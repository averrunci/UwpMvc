// Copyright (C) 2017-2018 Fievus
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
    /// Represents an extension to handle an event.
    /// </summary>
    internal sealed class EventHandlerExtension : IUwpControllerExtension
    {
        private static readonly BindingFlags eventHandlerBindingFlags = BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static;
        private static readonly BindingFlags routedEventBindingFlags = BindingFlags.Public | BindingFlags.Static | BindingFlags.FlattenHierarchy;

        private static readonly DependencyProperty EventHandlerBasesProperty = DependencyProperty.RegisterAttached(
            "ShadowEventHandlerBases", typeof(IDictionary<object, EventHandlerBase>), typeof(EventHandlerExtension), new PropertyMetadata(null)
        );

        void IUwpControllerExtension.Attach(FrameworkElement element, object controller)
        {
            if (element == null || controller == null) { return; }

            var eventHandlers = RetrieveEventHandlers(element, controller);
            eventHandlers.RegisterEventHandler();
            eventHandlers.GetBy(element.Name).From(element).Raise(nameof(FrameworkElement.DataContextChanged));
            eventHandlers.GetBy(element.Name).From(element).With(new RoutedEventArgs()).Raise(nameof(FrameworkElement.Loaded));
        }

        void IUwpControllerExtension.Detach(FrameworkElement element, object controller)
        {
            if (element == null || controller == null) { return; }

            RetrieveEventHandlers(element, controller).UnregisterEventHandler();
        }

        object IUwpControllerExtension.Retrieve(object controller)
        {
            return controller == null ? new EventHandlerBase() : RetrieveEventHandlers(null, controller);
        }

        private EventHandlerBase RetrieveEventHandlers(FrameworkElement rootElement, object controller)
        {
            var eventHandlerBases = EnsureEventHandlerBases(rootElement);
            if (eventHandlerBases.ContainsKey(controller)) { return eventHandlerBases[controller]; }

            var eventHandlers = new EventHandlerBase();
            eventHandlerBases[controller] = eventHandlers;

            controller.GetType().GetFields(eventHandlerBindingFlags)
                .Where(field => field.GetCustomAttributes<EventHandlerAttribute>().Any())
                .ForEach(field => AddEventHandlers(field, rootElement, e => CreateEventHandler(field.GetValue(controller) as Delegate, e), eventHandlers));
            controller.GetType().GetProperties(eventHandlerBindingFlags)
                .Where(property => property.GetCustomAttributes<EventHandlerAttribute>().Any())
                .ForEach(property => AddEventHandlers(property, rootElement, e => CreateEventHandler(property.GetValue(controller, null) as Delegate, e), eventHandlers));
            controller.GetType().GetMethods(eventHandlerBindingFlags)
                .Where(method => method.GetCustomAttributes<EventHandlerAttribute>().Any())
                .ForEach(method => AddEventHandlers(method, rootElement, e => CreateEventHandler(method, e, controller), eventHandlers));

            return eventHandlers;
        }

        private IDictionary<object, EventHandlerBase> EnsureEventHandlerBases(FrameworkElement rootElement)
        {
            if (rootElement == null) { return new Dictionary<object, EventHandlerBase>(); }

            var eventHandlerBases = rootElement.GetValue(EventHandlerBasesProperty) as IDictionary<object, EventHandlerBase>;
            if (eventHandlerBases != null) { return eventHandlerBases; }

            eventHandlerBases = new Dictionary<object, EventHandlerBase>();
            rootElement.SetValue(EventHandlerBasesProperty, eventHandlerBases);
            return eventHandlerBases;
        }

        private Delegate CreateEventHandler(Delegate @delegate, EventInfo eventInfo)
        {
            return @delegate == null ? null : CreateEventHandler(@delegate.GetMethodInfo(), eventInfo,  @delegate.Target);
        }

        private Delegate CreateEventHandler(MethodInfo method, EventInfo eventInfo, object target)
        {
            if (method == null) { return null; }

            var action = new EventHandlerAction(method, target);
            return action?.GetType()
                .GetMethod(nameof(EventHandlerAction.OnHandled))
                .CreateDelegate(eventInfo?.EventHandlerType ?? typeof(Handler), action);
        }

        private delegate void Handler(object sender, object e);

        private void AddEventHandlers(MemberInfo member, FrameworkElement rootElement, Func<EventInfo, Delegate> createHandler, EventHandlerBase eventHandlers)
        {
            if (eventHandlers == null) { return; }

            member.GetCustomAttributes<EventHandlerAttribute>(true)
                .ForEach(eventHandler =>
                {
                    var element = rootElement.FindElement<FrameworkElement>(eventHandler.ElementName);
                    var routedEvent = RetrieveRoutedEvent(element, eventHandler.Event);
                    var eventInfo = RetrieveEventInfo(element, eventHandler.Event);
                    eventHandlers.Add(
                        eventHandler.ElementName, element,
                        eventHandler.Event, routedEvent, eventInfo,
                        createHandler(eventInfo), eventHandler.HandledEventsToo
                    );
                });
        }

        private RoutedEvent RetrieveRoutedEvent(FrameworkElement element, string name)
        {
            if (element == null) { return null; }

            return element.GetType()
                .GetProperties(routedEventBindingFlags)
                .Where(field => field.Name == EnsureRoutedEventName(name))
                .Select(field => field.GetValue(element))
                .FirstOrDefault() as RoutedEvent;
        }

        private string EnsureRoutedEventName(string routedEventName)
        {
            return routedEventName != null && !routedEventName.EndsWith("Event") ? string.Format("{0}Event", routedEventName) : routedEventName;
        }

        private EventInfo RetrieveEventInfo(FrameworkElement element, string name)
        {
            if (element == null) { return null; }

            return element.GetType()
                .GetEvents()
                .Where(e => e.Name == name)
                .FirstOrDefault() as EventInfo;
        }
    }
}
