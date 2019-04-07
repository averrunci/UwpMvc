// Copyright (C) 2019 Fievus
//
// This software may be modified and distributed under the terms
// of the MIT license.  See the LICENSE file for details.
using System;
using System.Collections.Generic;
using System.Linq;
using Windows.UI.Xaml;

namespace Charites.Windows.Mvc
{
    /// <summary>
    /// Builds the event args resolver scope.
    /// </summary>
    /// <typeparam name="T">The type of the resolver.</typeparam>
    public sealed class EventArgsResolverScopeBuilder<T>
    {
        private readonly IList<IEventArgsResolver> eventArgsResolvers;

        private readonly T resolver;
        private readonly Type eventArgsWrapperType;
        private readonly string resolverPropertyName;

        /// <summary>
        /// Initializes a new instance of the <see cref="EventArgsResolverScopeBuilder{T}"/> class
        /// with the specified resolver to resolve the event data, type of the event args wrapper,
        /// and name of the Resolver property of the event args wrapper.
        /// </summary>
        /// <param name="resolver">The resolver to resolve the event data.</param>
        /// <param name="eventArgsWrapperType">The type of the event args wrapper.</param>
        /// <param name="resolverPropertyName">The name of the Resolver property of the event args wrapper.</param>
        /// <exception cref="ArgumentNullException">
        /// <paramref name="eventArgsWrapperType"/> is <c>null</c>.
        /// </exception>
        public EventArgsResolverScopeBuilder(T resolver, Type eventArgsWrapperType, string resolverPropertyName) : this(resolver, eventArgsWrapperType, resolverPropertyName, Enumerable.Empty<IEventArgsResolver>())
        {
        }

        private EventArgsResolverScopeBuilder(T resolver, Type eventArgsWrapperType, string resolverPropertyName, IEnumerable<IEventArgsResolver> eventArgsResolvers)
        {
            this.resolver = resolver;
            this.eventArgsWrapperType = eventArgsWrapperType.RequireNonNull(nameof(eventArgsWrapperType));
            this.resolverPropertyName = resolverPropertyName;
            this.eventArgsResolvers = new List<IEventArgsResolver>(eventArgsResolvers);
        }

        /// <summary>
        /// Specifies that the specified resolver is used to resolve the event data that is defined by the specified
        /// type of the event args wrapper.
        /// </summary>
        /// <typeparam name="TResolver">The type of the resolver.</typeparam>
        /// <param name="resolver">The resolver to resolve the event data.</param>
        /// <param name="eventArgsWrapperType">The type of the event args wrapper.</param>
        /// <param name="resolverPropertyName">The name of the Resolver property of the event args wrapper.</param>
        /// <returns>The builder to build the event handlers that are invoked in the event args resolver scope.</returns>
        /// <exception cref="ArgumentNullException">
        /// <paramref name="eventArgsWrapperType"/> is <c>null</c>.
        /// </exception>
        public EventArgsResolverScopeBuilder<TResolver> Using<TResolver>(TResolver resolver, Type eventArgsWrapperType, string resolverPropertyName = "Resolver")
        {
            return new EventArgsResolverScopeBuilder<TResolver>(resolver, eventArgsWrapperType, resolverPropertyName, eventArgsResolvers);
        }

        /// <summary>
        /// Applies the specified action that performs to resolve the event data with the resolver.
        /// </summary>
        /// <param name="action">The action that performs to resolve the event data with the resolver.</param>
        /// <returns>The instance of the <see cref="EventArgsResolverScopeBuilder{T}"/> class.</returns>
        public EventArgsResolverScopeBuilder<T> Apply(Action<T> action)
        {
            eventArgsResolvers.Add(new EventArgsResolverContext<T>(resolver, eventArgsWrapperType, resolverPropertyName, action));
            return this;
        }

        /// <summary>
        /// Gets event handlers that the specified controller has.
        /// </summary>
        /// <param name="controller">The controller that has event handlers.</param>
        /// <returns>The event handlers that the specified controller has.</returns>
        public EventArgsResolverScopeEventHandlerBase<T> EventHandlersOf(object controller)
            => new EventArgsResolverScopeEventHandlerBase<T>(
                eventArgsResolvers,
                UwpController.Retrieve<UwpEventHandlerExtension, EventHandlerBase<FrameworkElement, UwpEventHandlerItem>>(controller)
            );
    }
}