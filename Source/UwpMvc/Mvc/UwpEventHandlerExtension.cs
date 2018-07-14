// Copyright (C) 2018 Fievus
//
// This software may be modified and distributed under the terms
// of the MIT license.  See the LICENSE file for details.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Windows.UI.Xaml;

namespace Charites.Windows.Mvc
{
    internal sealed class UwpEventHandlerExtension : EventHandlerExtension<FrameworkElement, UwpEventHandlerItem>, IUwpControllerExtension
    {
        private const BindingFlags RoutedEventBindingFlags = BindingFlags.Public | BindingFlags.Static | BindingFlags.FlattenHierarchy;

        private static DependencyProperty EventHandlerBasesProperty { get; } = DependencyProperty.RegisterAttached(
            "ShadowEventHandlerBases", typeof(IDictionary<object, EventHandlerBase<FrameworkElement, UwpEventHandlerItem>>), typeof(UwpEventHandlerExtension), new PropertyMetadata(default(IDictionary<object, EventHandlerBase<FrameworkElement, UwpEventHandlerItem>>))
        );

        protected override IDictionary<object, EventHandlerBase<FrameworkElement, UwpEventHandlerItem>> EnsureEventHandlerBases(FrameworkElement element)
        {
            if (element == null) return new Dictionary<object, EventHandlerBase<FrameworkElement, UwpEventHandlerItem>>();

            if (element.GetValue(EventHandlerBasesProperty) is IDictionary<object, EventHandlerBase<FrameworkElement, UwpEventHandlerItem>> eventHandlerBases) return eventHandlerBases;

            eventHandlerBases = new Dictionary<object, EventHandlerBase<FrameworkElement, UwpEventHandlerItem>>();
            element.SetValue(EventHandlerBasesProperty, eventHandlerBases);
            return eventHandlerBases;
        }

        protected override void AddEventHandler(FrameworkElement element, EventHandlerAttribute eventHandlerAttribute, Func<Type, Delegate> handlerCreator, EventHandlerBase<FrameworkElement, UwpEventHandlerItem> eventHandlers)
        {
            var targetElement = element.FindElement<FrameworkElement>(eventHandlerAttribute.ElementName);
            var routedEvent = RetrieveRoutedEvent(targetElement, eventHandlerAttribute.Event);
            var eventInfo = RetrieveEventInfo(targetElement, eventHandlerAttribute.Event);
            eventHandlers.Add(new UwpEventHandlerItem(
                eventHandlerAttribute.ElementName, targetElement,
                eventHandlerAttribute.Event, routedEvent, eventInfo,
                handlerCreator(eventInfo?.EventHandlerType), eventHandlerAttribute.HandledEventsToo
            ));
        }

        protected override void OnEventHandlerAdded(EventHandlerBase<FrameworkElement, UwpEventHandlerItem> eventHandlers, FrameworkElement element)
        {
            base.OnEventHandlerAdded(eventHandlers, element);

            eventHandlers.GetBy(element.Name).From(element).Raise(nameof(FrameworkElement.DataContextChanged));
            eventHandlers.GetBy(element.Name).From(element).With(new RoutedEventArgs()).Raise(nameof(FrameworkElement.Loaded));
        }

        private RoutedEvent RetrieveRoutedEvent(FrameworkElement element, string name)
        {
            if (element == null || string.IsNullOrWhiteSpace(name)) return null;

            return element.GetType()
                .GetProperties(RoutedEventBindingFlags)
                .Where(property => property.Name == EnsureRoutedEventName(name))
                .Select(property => property.GetValue(null))
                .FirstOrDefault() as RoutedEvent;
        }

        private string EnsureRoutedEventName(string routedEventName)
            => routedEventName != null && !routedEventName.EndsWith("Event") ? $"{routedEventName}Event" : routedEventName;

        private EventInfo RetrieveEventInfo(FrameworkElement element, string name)
            => element?.GetType()
                .GetEvents()
                .FirstOrDefault(e => e.Name == name);
    }
}
