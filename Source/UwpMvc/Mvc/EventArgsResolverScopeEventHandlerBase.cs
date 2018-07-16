// Copyright (C) 2018 Fievus
//
// This software may be modified and distributed under the terms
// of the MIT license.  See the LICENSE file for details.
using System;
using System.Threading.Tasks;
using Windows.UI.Xaml;
using Charites.Windows.Mvc.Wrappers;

namespace Charites.Windows.Mvc
{
    /// <summary>
    /// Represents the base of event handler that are invoked in the event args resolver scope.
    /// </summary>
    /// <typeparam name="T">The type of the resolver.</typeparam>
    public sealed class EventArgsResolverScopeEventHandlerBase<T>
    {
        private readonly T resolver;
        private readonly Type eventArgsWrapperType;
        private readonly string resolverPropertyName;
        private readonly Action<T> applyResolver;
        private readonly EventHandlerBase<FrameworkElement, UwpEventHandlerItem> eventHandlerBase;

        /// <summary>
        /// Initializes a new instance of the <see cref="EventArgsResolverScopeEventHandlerBase{T}"/> class
        /// with the specified resolver to resolve the event data, type of the event args wrapper,
        /// name of the Resolver property of the event args wrapper, action that performs to resolve the
        /// event data with the resolver, and event handlers.
        /// </summary>
        /// <param name="resolver">The resolver to resolve the event data.</param>
        /// <param name="eventArgsWrapperType">The type of the event args wrapper.</param>
        /// <param name="resolverPropertyName">The name of the Resolver property of the event args wrapper.</param>
        /// <param name="applyResolver">The action that performs to resolve the event data with the resolver.</param>
        /// <param name="eventHandlerBase">The event handlers that handle an event.</param>
        /// <exception cref="ArgumentNullException">
        /// <paramref name="eventArgsWrapperType"/> is <c>null</c>.
        /// </exception>
        /// <exception cref="ArgumentNullException">
        /// <paramref name="eventHandlerBase"/> is <c>null</c>.
        /// </exception>
        public EventArgsResolverScopeEventHandlerBase(T resolver, Type eventArgsWrapperType, string resolverPropertyName, Action<T> applyResolver, EventHandlerBase<FrameworkElement, UwpEventHandlerItem> eventHandlerBase)
        {
            this.resolver = resolver;
            this.eventArgsWrapperType = eventArgsWrapperType.RequireNonNull(nameof(eventArgsWrapperType));
            this.resolverPropertyName = resolverPropertyName;
            this.applyResolver = applyResolver;
            this.eventHandlerBase = eventHandlerBase.RequireNonNull(nameof(eventHandlerBase));
        }

        /// <summary>
        /// Gets an executor that raises an event for the specified name of the element.
        /// </summary>
        /// <param name="elementName">The name of the element that has event handlers.</param>
        /// <returns><see cref="Executor"/> that raises an event.</returns>
        public Executor GetBy(string elementName) => new Executor(resolver, eventArgsWrapperType, resolverPropertyName, applyResolver, eventHandlerBase.GetBy(elementName));

        /// <summary>
        /// Provides an event execution.
        /// </summary>
        public sealed class Executor
        {
            private readonly T resolver;
            private readonly Type eventArgsWrapperType;
            private readonly string resolverPropertyName;
            private readonly Action<T> applyResolver;
            private readonly EventHandlerBase<FrameworkElement, UwpEventHandlerItem>.Executor executor;

            /// <summary>
            /// Initializes a new instance of the <see cref="Executor"/> class
            /// with the specified resolver to resolve the event data, type of the event args wrapper,
            /// name of the Resolver property of the event args wrapper, action that performs to resolve the
            /// event data with the resolver, and executor to .
            /// </summary>
            /// <param name="resolver">The resolver to resolve the event data.</param>
            /// <param name="eventArgsWrapperType">The type of the event args wrapper.</param>
            /// <param name="resolverPropertyName">The name of the Resolver property of the event args wrapper.</param>
            /// <param name="applyResolver">The action that performs to resolve the event data with the resolver.</param>
            /// <param name="executor">The executor to raise an event.</param>
            /// <exception cref="ArgumentNullException">
            /// <paramref name="eventArgsWrapperType"/> is <c>null</c>.
            /// </exception>
            /// <exception cref="ArgumentNullException">
            /// <paramref name="executor"/> is <c>null</c>.
            /// </exception>
            public Executor(T resolver, Type eventArgsWrapperType, string resolverPropertyName, Action<T> applyResolver, EventHandlerBase<FrameworkElement, UwpEventHandlerItem>.Executor executor)
            {
                this.resolver = resolver;
                this.eventArgsWrapperType = eventArgsWrapperType.RequireNonNull(nameof(eventArgsWrapperType));
                this.resolverPropertyName = resolverPropertyName;
                this.applyResolver = applyResolver;
                this.executor = executor.RequireNonNull(nameof(executor));
            }

            /// <summary>Sets the object where the event handler is attached.</summary>
            /// <param name="sender">The object where the event handler is attached.</param>
            /// <returns>The instance of the <see cref="Executor" /> class.</returns>
            public Executor From(object sender)
            {
                executor.From(sender);
                return this;
            }

            /// <summary>Sets the event data.</summary>
            /// <param name="args">The event data.</param>
            /// <returns>The instance of the <see cref="Executor" /> class.</returns>
            public Executor With(object args)
            {
                executor.With(args);
                return this;
            }

            /// <summary>Raises the event of the specified name.</summary>
            /// <param name="eventName">The name of the event to raise.</param>
            public void Raise(string eventName)
            {
                using (var scope = new EventArgsResolverScope<T>(resolver, eventArgsWrapperType, resolverPropertyName))
                {
                    applyResolver?.Invoke(scope.Resolver);
                    executor.Raise(eventName);
                }
            }

            /// <summary>
            /// Raises the event of the specified name asynchronously.
            /// </summary>
            /// <param name="eventName">The name of the event to raise.</param>
            /// <returns>A task that represents the asynchronous raise operation.</returns>
            public async Task RaiseAsync(string eventName)
            {
                using (var scope = new EventArgsResolverScope<T>(resolver, eventArgsWrapperType, resolverPropertyName))
                {
                    applyResolver?.Invoke(scope.Resolver);
                    await executor.RaiseAsync(eventName);
                }
            }
        }
    }
}
