// Copyright (C) 2017 Fievus
//
// This software may be modified and distributed under the terms
// of the MIT license.  See the LICENSE file for details.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Windows.UI.Xaml;

namespace Fievus.Windows.Mvc
{
    /// <summary>
    /// Provides functions for the UWP controllers; a data context injection, elements injection,
    /// and event handlers injection.
    /// </summary>
    public class UwpController
    {
        private static readonly BindingFlags contextBindingFlags = BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static;

        private static readonly DependencyProperty ControllersProperty = DependencyProperty.RegisterAttached(
            "ShadowControllers", typeof(UwpControllerCollection), typeof(UwpController), new PropertyMetadata(null, OnControllersChanged)
        );

        /// <summary>
        /// Gets or sets the injector of UWP controllers.
        /// </summary>
        public static IUwpControllerInjector Injector { get; set; }

        /// <summary>
        /// Gets or sets the factory of UWP controller.
        /// </summary>
        public static IUwpControllerFactory Factory
        {
            get { return factory; }
            set { factory = value.RequireNonNull(nameof(value)); }
        }
        private static IUwpControllerFactory factory = new SimpleUwpControllerFactory();

        /// <summary>
        /// Gets or sets the type of UWP controller.
        /// </summary>
        public string ControllerType { get; set; }

        /// <summary>
        /// Creates a UWP controller of the specified controller type.
        /// </summary>
        /// <returns>The new instance of a UWP controller of the specified controller type.</returns>
        public object Create() => ControllerType == null ? null : Factory.Create(Type.GetType(ControllerType, true));

        private static IList<IUwpControllerExtension> Extensions { get; } = new List<IUwpControllerExtension>();

        static UwpController()
        {
            typeof(UwpController).GetTypeInfo().Assembly.GetTypes()
                .Where(t => typeof(IUwpControllerExtension).IsAssignableFrom(t))
                .Where(t => t.GetTypeInfo().IsClass && !t.GetTypeInfo().IsAbstract)
                .ForEach(t => Add(Activator.CreateInstance(t) as IUwpControllerExtension));
        }

        /// <summary>
        /// Adds an extension of a UWP controller.
        /// </summary>
        /// <param name="extensions">The extension of a UWP controller.</param>
        public static void Add(IUwpControllerExtension extensions)
        {
            Extensions.Add(extensions.RequireNonNull(nameof(extensions)));
        }

        /// <summary>
        /// Removes an extension of a UWP controller.
        /// </summary>
        /// <param name="extensions">The extension of a UWP controller.</param>
        public static void Remove(IUwpControllerExtension extensions)
        {
            Extensions.Remove(extensions.RequireNonNull(nameof(extensions)));
        }

        /// <summary>
        /// Gets UWP controllers attached to the specified depencency object.
        /// </summary>
        /// <param name="obj">The dependency object to which UWP controllers are attached.</param>
        /// <returns>
        /// UWP controllers attached to the specified dependency object.
        /// </returns>
        public static UwpControllerCollection GetControllers(DependencyObject obj)
        {
            var controllers = obj.RequireNonNull(nameof(obj)).GetValue(ControllersProperty) as UwpControllerCollection;
            controllers.IfAbsent(() =>
            {
                controllers = new UwpControllerCollection();
                obj.SetValue(ControllersProperty, controllers);
            });
            return controllers;
        }

        private static void OnControllersChanged(DependencyObject obj, DependencyPropertyChangedEventArgs args)
        {
            var oldControllers = args.OldValue as UwpControllerCollection;
            var newControllers = args.NewValue as UwpControllerCollection;
            if (oldControllers == newControllers) { return; }

            oldControllers.IfPresent(controllers =>
            {
                if (oldControllers.AssociatedElement == null) { throw new InvalidOperationException("Associated element must not be null."); }

                UnregisterEventHanders(oldControllers.AssociatedElement);
                controllers.Detach();
            });

            if (newControllers != null && obj != null)
            {
                if (newControllers.AssociatedElement != null) { throw new InvalidOperationException("Associated element must be null."); }

                var element = obj as FrameworkElement;
                if (element == null) { throw new InvalidOperationException("Dependency object must be FrameworkElement."); }

                newControllers.AttachTo(element);
                RegisterEventHandlers(element);
            }
        }

        private static void RegisterEventHandlers(FrameworkElement element)
        {
            element.Loaded += OnElementLoaded;
            element.Unloaded += OnElementUnloaded;
            element.DataContextChanged += OnElementDataContextChanged;
        }

        private static void UnregisterEventHanders(FrameworkElement element)
        {
            element.Loaded -= OnElementLoaded;
            element.Unloaded -= OnElementUnloaded;
            element.DataContextChanged -= OnElementDataContextChanged;
        }

        /// <summary>
        /// Attaches the specified UWP controller to the specified element.
        /// </summary>
        /// <param name="controller">The UWP controller attached to the element.</param>
        /// <param name="element">The element to which the UWP controllers is attached.</param>
        public static void Attach(object controller, FrameworkElement element)
        {
            if (controller == null || element == null) { return; }

            Injector.IfPresent(injector => injector.Inject(controller));

            SetDataContext(element.DataContext, controller);
        }

        /// <summary>
        /// Detaches the specified UWP controller from the specified element.
        /// </summary>
        /// <param name="controller">The UWP controller detached from the element.</param>
        /// <param name="element">The element from which the UWP controller is detached.</param>
        public static void Detach(object controller, FrameworkElement element)
        {
            if (controller == null || element == null) { return; }

            SetElement(null, controller);
            SetDataContext(null, controller);
            Extensions.ForEach(extension => extension.Detach(element, controller));
        }

        /// <summary>
        /// Gets an extension that the specified UWP controller has.
        /// </summary>
        /// <typeparam name="E">The type of the extension.</typeparam>
        /// <typeparam name="T">The type of the container of the extension.</typeparam>
        /// <param name="controller">The UWP controller that has the extension.</param>
        /// <returns>The container of the extension that the specified UWP controller has.</returns>
        public static T Retrieve<E, T>(object controller) where E : IUwpControllerExtension where T : class, new()
            => (Extensions.OfType<E>().FirstOrDefault()?.Retrieve(controller) as T) ?? new T();

        /// <summary>
        /// Gets event handlers that the specified UWP controller has.
        /// </summary>
        /// <param name="controller">The UWP controller that has event handlers.</param>
        /// <returns>
        /// The event handlers that the specified UWP controller has.
        /// </returns>
        public static EventHandlerBase RetrieveEventHandlers(object controller)
            => Retrieve<EventHandlerExtension, EventHandlerBase>(controller);

        /// <summary>
        /// Sets the specified data context to the specified UWP controller.
        /// </summary>
        /// <param name="dataContext">The data context that is set to the UWP controller.</param>
        /// <param name="controller">The UWP controller to which the data context is set.</param>
        public static void SetDataContext(object dataContext, object controller)
        {
            if (controller == null) { return; }

            controller.GetType()
                .GetFields(contextBindingFlags)
                .Where(field => field.GetCustomAttribute<DataContextAttribute>(true) != null)
                .ForEach(field => field.SetValue(controller, dataContext));
            controller.GetType()
                .GetProperties(contextBindingFlags)
                .Where(property => property.GetCustomAttribute<DataContextAttribute>(true) != null)
                .ForEach(property => property.SetValue(controller, dataContext, null));
            controller.GetType()
                .GetMethods(contextBindingFlags)
                .Where(method => method.GetCustomAttribute<DataContextAttribute>(true) != null)
                .ForEach(method => method.Invoke(controller, new object[] { dataContext }));
        }

        /// <summary>
        /// Sets the specified element to the specified UWP controller.
        /// </summary>
        /// <param name="rootElement">The element that is set to the UWP controller.</param>
        /// <param name="controller">The UWP controller to which the element is set.</param>
        /// <param name="foundElementOnly">
        /// If <c>true</c>, an element is not set to the UWP controller when it is not found in the specified element;
        /// otherwise, <c>null</c> is set.
        /// </param>
        public static void SetElement(FrameworkElement rootElement, object controller, bool foundElementOnly = false)
        {
            if (controller == null) { return; }

            controller.GetType()
                .GetFields(contextBindingFlags)
                .Select(Field => new { Field, Attribute = Field.GetCustomAttribute<ElementAttribute>(true) })
                .Where(t => t.Attribute != null)
                .ForEach(t =>
                {
                    var element = rootElement.FindElement<object>(t.Attribute.Name ?? t.Field.Name);
                    if (!foundElementOnly || element != null)
                    {
                        t.Field.SetValue(controller, element);
                    }
                });
            controller.GetType()
                .GetProperties(contextBindingFlags)
                .Select(Property => new { Property, Attribute = Property.GetCustomAttribute<ElementAttribute>(true) })
                .Where(t => t.Attribute != null)
                .ForEach(t =>
                {
                    var element = rootElement.FindElement<object>(t.Attribute.Name ?? t.Property.Name);
                    if (!foundElementOnly || element != null)
                    {
                        t.Property.SetValue(controller, element, null);
                    }
                });
            controller.GetType()
                .GetMethods(contextBindingFlags)
                .Select(Method => new { Method, Attribute = Method.GetCustomAttribute<ElementAttribute>(true) })
                .Where(t => t.Attribute != null)
                .ForEach(t =>
                {
                    var element = rootElement.FindElement<object>(ResolveElementMethodName(t.Method, t.Attribute));
                    if (!foundElementOnly || element != null)
                    {
                        t.Method.Invoke(controller, new object[] { element });
                    }
                });
        }

        private static string ResolveElementMethodName(MethodInfo m, ElementAttribute a)
            => a.Name ?? (m.Name.StartsWith("Set") ? m.Name.Substring(3) : m.Name);

        private static void OnElementLoaded(object sender, RoutedEventArgs e)
        {
            var element = sender as FrameworkElement;
            if (element == null) { return; }

            var controllers = element.GetValue(ControllersProperty) as UwpControllerCollection;
            if (controllers == null) { return; }

            controllers.ForEach(controller =>
            {
                SetElement(element, controller);
                Extensions.ForEach(Extension => Extension.Attach(element, controller));
            });
        }

        private static void OnElementUnloaded(object sender, RoutedEventArgs e)
        {
            var element = sender as FrameworkElement;
            if (element == null) { return; }

            var controllers = element.GetValue(ControllersProperty) as UwpControllerCollection;
            if (controllers == null) { return; }

            controllers.ForEach(controller =>
            {
                SetElement(null, controller);
                Extensions.ForEach(Extension => Extension.Detach(element, controller));
            });
        }

        private static void OnElementDataContextChanged(object sender, DataContextChangedEventArgs e)
        {
            var dependencyObject = sender as DependencyObject;
            if (dependencyObject == null) { return; }

            var controllers = dependencyObject.GetValue(ControllersProperty) as UwpControllerCollection;
            if (controllers == null) { return; }

            controllers.ForEach(controller => SetDataContext(e.NewValue, controller));
        }
    }
}
