// Copyright (C) 2018-2019 Fievus
//
// This software may be modified and distributed under the terms
// of the MIT license.  See the LICENSE file for details.
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using Windows.UI.Xaml;

namespace Charites.Windows.Mvc
{
    /// <summary>
    /// Provides functions for the controllers; a data context injection, elements injection,
    /// and event handlers injection.
    /// </summary>
    public class UwpController
    {
        /// <summary>
        /// Occurs when an exception is not handled in event handlers.
        /// </summary>
        public static event UnhandledExceptionEventHandler UnhandledException;

        /// <summary>
        /// Gets or sets the finder to find a data context in a view.
        /// </summary>
        public static IUwpDataContextFinder DataContextFinder
        {
            get => dataContextFinder;
            set
            {
                dataContextFinder = value;
                EnsureControllerTypeFinder();
            }
        }
        private static IUwpDataContextFinder dataContextFinder = new UwpDataContextFinder();

        /// <summary>
        /// Gets or sets the injector to inject a data context to a controller.
        /// </summary>
        public static IDataContextInjector DataContextInjector { get; set; } = new DataContextInjector();

        /// <summary>
        /// Gets or sets the finder to find a key of an element.
        /// </summary>
        public static IUwpElementKeyFinder ElementKeyFinder
        {
            get => elementKeyFinder;
            set
            {
                elementKeyFinder = value;
                EnsureControllerTypeFinder();
            }
        }
        private static IUwpElementKeyFinder elementKeyFinder = new UwpElementKeyFinder();

        /// <summary>
        /// Gets or sets the injector to inject elements in a view to a controller.
        /// </summary>
        public static IUwpElementInjector ElementInjector { get; set; } = new UwpElementInjector();

        /// <summary>
        /// Gets or sets the finder to find a type of a controller that controls a view.
        /// </summary>
        public static IUwpControllerTypeFinder ControllerTypeFinder { get; set; }

        /// <summary>
        /// Gets or sets the factory to create a controller.
        /// </summary>
        public static IUwpControllerFactory ControllerFactory
        {
            get => controllerFactory;
            set => controllerFactory = value ?? new SimpleUwpControllerFactory();
        }
        private static IUwpControllerFactory controllerFactory = new SimpleUwpControllerFactory();

        /// <summary>
        /// Gets or sets the container that contains all controllers defined in a project.
        /// </summary>
        public static IUwpControllerTypeContainer ControllerTypeContainer
        {
            get => ControllerTypeFinder?.ControllerTypeContainer;
            set
            {
                if (ControllerTypeFinder == null) return;

                ControllerTypeFinder.ControllerTypeContainer = value;
            }
        }

        /// <summary>
        /// Gets the extension.
        /// </summary>
        protected static ICollection<IUwpControllerExtension> Extensions { get; } = new Collection<IUwpControllerExtension>();

        /// <summary>
        /// Adds an extension of a controller.
        /// </summary>
        /// <param name="extension">The extension of a controller.</param>
        /// <exception cref="ArgumentNullException">
        /// <paramref name="extension"/> is <c>null</c>.
        /// </exception>
        public static void AddExtension(IUwpControllerExtension extension) => Extensions.Add(extension.RequireNonNull(nameof(extension)));

        /// <summary>
        /// Removes an extension of a controller.
        /// </summary>
        /// <param name="extension">The extension of a controller.</param>
        /// <exception cref="ArgumentNullException">
        /// <paramref name="extension"/> is <c>null</c>.
        /// </exception>
        public static void RemoveExtension(IUwpControllerExtension extension) => Extensions.Remove(extension.RequireNonNull(nameof(extension)));

        /// <summary>
        /// Identifies the <see cref="KeyProperty"/> XAML attached property.
        /// </summary>
        public static DependencyProperty KeyProperty { get; } = DependencyProperty.RegisterAttached(
            "Key", typeof(string), typeof(UwpController), new PropertyMetadata(default(string), OnKeyChanged)
        );

        /// <summary>
        /// Sets the value of the <see cref="KeyProperty"/> XAML attached property on the specified <see cref="DependencyObject"/>.
        /// </summary>
        /// <param name="element">The element on which to set the <see cref="KeyProperty"/> XAML attached property.</param>
        /// <param name="value">The property value to set.</param>
        public static void SetKey(DependencyObject element, string value) => element.SetValue(KeyProperty, value);

        /// <summary>
        /// Gets the value of the <see cref="KeyProperty"/> XAML attached property from the specified <see cref="DependencyObject"/>.
        /// </summary>
        /// <param name="element">The element from which to read the property value.</param>
        /// <returns>The value of the <see cref="KeyProperty"/> XAML attached property on the target dependency object.</returns>
        public static string GetKey(DependencyObject element) => (string)element.GetValue(KeyProperty);

        private static void OnKeyChanged(DependencyObject sender, DependencyPropertyChangedEventArgs e) => SetIsEnabled(sender, true);

        /// <summary>
        /// Identifies the <see cref="IsEnabledProperty"/> XAML attached property.
        /// </summary>
        public static DependencyProperty IsEnabledProperty { get; } = DependencyProperty.RegisterAttached(
            "IsEnabled", typeof(bool), typeof(UwpController), new PropertyMetadata(default(bool), OnIsEnabledChanged)
        );

        /// <summary>
        /// Sets the value of the <see cref="IsEnabledProperty"/> XAML attached property on the specified <see cref="DependencyObject"/>.
        /// </summary>
        /// <param name="element">The element on which to set the <see cref="IsEnabledProperty"/> XAML attached property.</param>
        /// <param name="value">The property value to set.</param>
        public static void SetIsEnabled(DependencyObject element, bool value) => element.SetValue(IsEnabledProperty, value);

        /// <summary>
        /// Gets the value of the <see cref="IsEnabledProperty"/> XAML attached property from the specified <see cref="DependencyObject"/>.
        /// </summary>
        /// <param name="element">The element from which to read the property value.</param>
        /// <returns>The value of the <see cref="IsEnabledProperty"/> XAML attached property on the target dependency object.</returns>
        public static bool GetIsEnabled(DependencyObject element) => (bool)element.GetValue(IsEnabledProperty);

        private static void OnIsEnabledChanged(DependencyObject sender, DependencyPropertyChangedEventArgs e)
        {
            if (!(sender is FrameworkElement element)) throw new InvalidOperationException("Dependency object must be FrameworkElement.");

            if ((bool)e.NewValue)
            {
                if (element.DataContext == null)
                {
                    element.DataContextChanged += OnElementDataContextChanged;
                }
                else
                {
                    AttachControllers(element);
                }
            }
            else
            {
                element.DataContextChanged -= OnElementDataContextChanged;

                DetachControllers(element);
            }
        }

        private static DependencyProperty ControllersProperty { get; } = DependencyProperty.RegisterAttached(
            "ShadowControllers", typeof(UwpControllerCollection), typeof(UwpController), new PropertyMetadata(default(UwpControllerCollection)));

        private static void OnElementDataContextChanged(object sender, DataContextChangedEventArgs e)
        {
            if (!(sender is FrameworkElement element)) return;
            if (element.DataContext == null) return;

            element.DataContextChanged -= OnElementDataContextChanged;

            AttachControllers(element);
        }

        private static void AttachControllers(FrameworkElement element)
        {
            if (element.GetValue(ControllersProperty) != null) return;

            var controllers = new UwpControllerCollection(DataContextFinder, DataContextInjector, ElementInjector, Extensions);
            controllers.AddRange(ControllerTypeFinder?.Find(element).Select(ControllerFactory.Create));
            controllers.AttachTo(element);
            element.SetValue(ControllersProperty, controllers);
        }

        private static void DetachControllers(FrameworkElement element)
        {
            var controllers = element.GetValue(ControllersProperty) as UwpControllerCollection;
            controllers?.Detach();
            element.SetValue(ControllersProperty, null);
        }

        internal static void ClearControllers(FrameworkElement element)
        {
            element.DataContextChanged += OnElementDataContextChanged;
            element.SetValue(ControllersProperty, null);
        }

        static UwpController()
        {
            EnsureControllerTypeFinder();

            typeof(UwpController).Assembly.GetTypes()
                .Where(t => typeof(IUwpControllerExtension).IsAssignableFrom(t))
                .Where(t => t.GetTypeInfo().IsClass && !t.GetTypeInfo().IsAbstract)
                .ForEach(t => AddExtension(Activator.CreateInstance(t) as IUwpControllerExtension));
        }

        private static void EnsureControllerTypeFinder()
        {
            ControllerTypeFinder = new UwpControllerTypeFinder(ElementKeyFinder, DataContextFinder);
        }

        /// <summary>
        /// Gets the collection of the controller associated with the specified <see cref="DependencyObject"/>.
        /// </summary>
        /// <param name="element">The element with which the collection of the controller is associated.</param>
        /// <returns>The collection of the controller associated with the specified <see cref="DependencyObject"/>.</returns>
        /// <exception cref="ArgumentNullException">
        /// <paramref name="element"/> is <c>null</c>.
        /// </exception>
        public static UwpControllerCollection GetControllers(DependencyObject element)
        {
            var controllers = element.RequireNonNull(nameof(element)).GetValue(ControllersProperty) as UwpControllerCollection;
            controllers.IfAbsent(() =>
            {
                controllers = new UwpControllerCollection(DataContextFinder, DataContextInjector, ElementInjector, Extensions);
                element.SetValue(ControllersProperty, controllers);
            });
            return controllers;
        }

        /// <summary>
        /// Sets the specified data context to the specified controller.
        /// </summary>
        /// <param name="dataContext">The data context that is set to the controller.</param>
        /// <param name="controller">The controller to which the data context is set.</param>
        public static void SetDataContext(object dataContext, object controller) => DataContextInjector?.Inject(dataContext, controller);

        /// <summary>
        /// Sets the specified element to the specified controller.
        /// </summary>
        /// <param name="rootElement">The element that is set to the controller.</param>
        /// <param name="controller">The controller to which the element is set.</param>
        /// <param name="foundElementOnly">
        /// If <c>true</c>, an element is not set to the controller when it is not found in the specified element;
        /// otherwise, <c>null</c> is set.
        /// </param>
        public static void SetElement(FrameworkElement rootElement, object controller, bool foundElementOnly = false)
            => ElementInjector?.Inject(rootElement, controller, foundElementOnly);

        /// <summary>
        /// Gets a container of an extension that the specified controller has.
        /// </summary>
        /// <typeparam name="TExtension">The type of the extension.</typeparam>
        /// <typeparam name="T">The type of the container of the extension.</typeparam>
        /// <param name="controller">The controller that has the extension.</param>
        /// <returns>The container of the extension that the specified controller has.</returns>
        public static T Retrieve<TExtension, T>(object controller) where TExtension : IUwpControllerExtension where T : class, new()
            => Extensions.OfType<TExtension>().FirstOrDefault()?.Retrieve(controller) as T ?? new T();

        /// <summary>
        /// Gets event handlers that the specified controller has.
        /// </summary>
        /// <param name="controller">The controller that has event handlers.</param>
        /// <returns>The event handlers that the specified controller has.</returns>
        public static EventHandlerBase<FrameworkElement, UwpEventHandlerItem> EventHandlersOf(object controller)
            => Retrieve<UwpEventHandlerExtension, EventHandlerBase<FrameworkElement, UwpEventHandlerItem>>(controller);

        /// <summary>
        /// Specifies that the specified resolver is used to resolve the event data that is defined by the specified
        /// type of the event args wrapper.
        /// </summary>
        /// <typeparam name="T">The type of the resolver.</typeparam>
        /// <param name="resolver">The resolver to resolve the event data.</param>
        /// <param name="eventArgsWrapperType">The type of the event args wrapper.</param>
        /// <param name="resolverPropertyName">The name of the Resolver property of the event args wrapper.</param>
        /// <returns>The builder to build the event handlers that are invoked in the event args resolver scope.</returns>
        /// <exception cref="ArgumentNullException">
        /// <paramref name="eventArgsWrapperType"/> is <c>null</c>.
        /// </exception>
        public static EventArgsResolverScopeBuilder<T> Using<T>(T resolver, Type eventArgsWrapperType, string resolverPropertyName = "Resolver")
            => new EventArgsResolverScopeBuilder<T>(resolver, eventArgsWrapperType, resolverPropertyName);

        internal static bool HandleUnhandledException(Exception exc)
        {
            var e = new UnhandledExceptionEventArgs(exc);
            OnUnhandledException(e);
            return e.Handled;
        }

        private static void OnUnhandledException(UnhandledExceptionEventArgs e) => UnhandledException?.Invoke(null, e);
    }
}
