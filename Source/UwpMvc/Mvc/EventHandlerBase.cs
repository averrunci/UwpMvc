// Copyright (C) 2017-2018 Fievus
//
// This software may be modified and distributed under the terms
// of the MIT license.  See the LICENSE file for details.
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using Windows.UI.Xaml;

namespace Fievus.Windows.Mvc
{
    /// <summary>
    /// Represents the base of event handlers.
    /// </summary>
    public class EventHandlerBase
    {
        private readonly ICollection<Item> items = new Collection<Item>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EventHandlerBase"/> class.
        /// </summary>
        public EventHandlerBase()
        {
        }

        /// <summary>
        /// Adds an event handler to the <see cref="EventHandlerBase"/>.
        /// </summary>
        /// <param name="elementName">The name of the element.</param>
        /// <param name="element">The element that raises the event.</param>
        /// <param name="eventName">The name of the event.</param>
        /// <param name="routedEvent"><see cref="RoutedEvent"/> that is handled.</param>
        /// <param name="eventInfo"><see cref="EventInfo"/> of the event that is handled.</param>
        /// <param name="handler">The event handler.</param>
        /// <param name="handledEventsToo">
        /// The value that indicates whether to register the handler such that
        /// it is invoked even when the routed event is marked handled in its event data.
        /// </param>
        public void Add(string elementName, FrameworkElement element, string eventName, RoutedEvent routedEvent, EventInfo eventInfo, Delegate handler, bool handledEventsToo)
        {
            items.Add(new Item(elementName, element, eventName, routedEvent, eventInfo, handler, handledEventsToo));
        }

        /// <summary>
        /// Removes all event handlers from the <see cref="EventHandlerBase"/>.
        /// </summary>
        public void Clear()
        {
            items.Clear();
        }

        /// <summary>
        /// Gets an executor that raises an event for the specified name of the element.
        /// </summary>
        /// <param name="elementName">The name of the element that has event handlers.</param>
        /// <returns>
        /// <see cref="Executor"/> that raises an event.
        /// </returns>
        public Executor GetBy(string elementName) => new Executor(items.Where(i => i.Has(elementName)));

        /// <summary>
        /// Registers event handlers to the element.
        /// </summary>
        public void RegisterEventHandler() => items.ForEach(i => i.RegisterEventHandler());

        /// <summary>
        /// Unregisters event handlers from the element.
        /// </summary>
        public void UnregisterEventHandler() => items.ForEach(i => i.UnregisterEventHandler());

        /// <summary>
        /// Provides an event execution.
        /// </summary>
        public sealed class Executor
        {
            private readonly IEnumerable<Item> items;
            private object sender;
            private object e;

            /// <summary>
            /// Initializes a new instance of the <see cref="Executor"/> class,
            /// using the supplied items.
            /// </summary>
            /// <param name="items">The event handler items.</param>
            /// <exception cref="ArgumentNullException">
            /// <paramref name="items"/> is <c>null</c>.
            /// </exception>
            public Executor(IEnumerable<Item> items)
            {
                this.items = items.RequireNonNull(nameof(items));
            }

            /// <summary>
            /// Sets the object where the event handler is attached.
            /// </summary>
            /// <param name="sender">The object where the event handler is attached.</param>
            /// <returns>
            /// The instance of the <see cref="Executor"/> class.
            /// </returns>
            public Executor From(object sender)
            {
                this.sender = sender;
                return this;
            }

            /// <summary>
            /// Sets the event data.
            /// </summary>
            /// <param name="e">The event data.</param>
            /// <returns>
            /// The instance of the <see cref="Executor"/> class.
            /// </returns>
            public Executor With(object e)
            {
                this.e = e;
                return this;
            }

            /// <summary>
            /// Raises the event of the specified name.
            /// </summary>
            /// <param name="eventName">The name of the event.</param>
            public void Raise(string eventName) => items.ForEach(i => i.Raise(eventName, sender, e));

            /// <summary>
            /// Raises the event of the specified name asynchronously.
            /// </summary>
            /// <param name="eventName">The name of the event.</param>
            /// <returns>A task that represents the asynchronous raise operation.</returns>
            public async Task RaiseAsync(string eventName)
            {
                foreach (var item in items)
                {
                    await item.RaiseAsync(eventName, sender, e);
                }
            }
        }

        /// <summary>
        /// Represents an item of an event handler.
        /// </summary>
        public sealed class Item
        {
            private string ElementName { get; }
            private FrameworkElement Element { get; }
            private string EventName { get; }
            private RoutedEvent RoutedEvent { get; }
            private EventInfo EventInfo { get; }
            private Delegate Handler { get; }
            private bool HandledEventsToo { get; }

            private EventRegistrationToken? Token { get; set; }
            private bool IsEventHandlerRegistered { get; set; }

            internal Item(string elementName, FrameworkElement element, string eventName, RoutedEvent routedEvent, EventInfo eventInfo, Delegate handler, bool handledEventsToo)
            {
                ElementName = elementName;
                Element = element;
                EventName = eventName;
                RoutedEvent = routedEvent;
                EventInfo = eventInfo;
                Handler = handler;
                HandledEventsToo = handledEventsToo;
            }

            /// <summary>
            /// Gets a value that indicates whether <see cref="Item"/> has the specified element name.
            /// </summary>
            /// <param name="elementName">An element name.</param>
            /// <returns>
            /// <c>true</c> if <see cref="Item"/> has the specified element name; otherwise, <c>false</c>.
            /// </returns>
            public bool Has(string elementName) => ElementName == (elementName ?? string.Empty);

            /// <summary>
            /// Registers the event handler to the element.
            /// </summary>
            public void RegisterEventHandler()
            {
                if (Element == null || Handler == null) { return; }

                if (RoutedEvent != null)
                {
                    Element.AddHandler(RoutedEvent, Handler, HandledEventsToo);
                } 
                else if (EventInfo != null)
                {
                    Token = (EventRegistrationToken?)(EventInfo.AddMethod.Invoke(Element, new[] { Handler }));
                }
                IsEventHandlerRegistered = true;
            }

            /// <summary>
            /// Unregisters the event handler from the element.
            /// </summary>
            public void UnregisterEventHandler()
            {
                if (Element == null || Handler == null || !IsEventHandlerRegistered) { return; }

                if (RoutedEvent != null)
                {
                    Element.RemoveHandler(RoutedEvent, Handler);
                }
                else if (EventInfo != null)
                {
                    if (Token.HasValue)
                    {
                        EventInfo.RemoveMethod.Invoke(Element, new object[] { Token.Value });
                    }
                    else
                    {
                        EventInfo.RemoveMethod.Invoke(Element, new object[] { Handler });
                    }
                }
                IsEventHandlerRegistered = false;
            }

            /// <summary>
            /// Raises the event of the specified name.
            /// </summary>
            /// <param name="eventName">The name of the event.</param>
            /// <param name="sender">The object where the event handler is attached.</param>
            /// <param name="e">The event data.</param>
            public void Raise(string eventName, object sender, object e)
            {
                if (EventName != eventName || Handler == null) { return; }

                switch (Handler.GetMethodInfo().GetParameters().Length)
                {
                    case 0:
                        Handler.DynamicInvoke();
                        break;
                    case 1:
                        Handler.DynamicInvoke(new object[] { e });
                        break;
                    case 2:
                        Handler.DynamicInvoke(new object[] { sender, e });
                        break;
                }
            }

            /// <summary>
            /// Raises the event of the specified name asynchronously.
            /// </summary>
            /// <param name="eventName">The name of the event.</param>
            /// <param name="sender">The object where the event handler is attached.</param>
            /// <param name="e">The event data.</param>
            /// <returns>A task that represents the asynchronous raise operation.</returns>
            public async Task RaiseAsync(string eventName, object sender, object e)
            {
                if (EventName != eventName || Handler == null) { return; }

                var action = Handler.Target as EventHandlerAction;
                if (action == null) { return; }

                var task = action.Handle(sender, e) as Task;
                if (task != null)
                {
                    await task;
                }
            }
        }
    }
}
