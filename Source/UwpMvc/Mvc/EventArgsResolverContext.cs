// Copyright (C) 2019 Fievus
//
// This software may be modified and distributed under the terms
// of the MIT license.  See the LICENSE file for details.
using System;
using System.Reflection;

namespace Charites.Windows.Mvc
{
    /// <summary>
    /// Encapsulates information about the event args resolver.
    /// </summary>
    /// <typeparam name="T">The type of the resolver.</typeparam>
    public sealed class EventArgsResolverContext<T> : IEventArgsResolver
    {
        private readonly T resolver;
        private readonly Type eventArgsWrapperType;
        private readonly string resolverPropertyName;
        private readonly Action<T> applyResolver;

        private PropertyInfo resolverProperty;
        private object originalResolver;

        /// <summary>
        /// Initializes a new instance of the <see cref="EventArgsResolverContext{T}"/> class
        /// with the specified resolver to resolve the event data, type of the event args wrapper,
        /// name of the Resolver property of the event args wrapper,
        /// and the action that performs to resolver the event data with the resolver.
        /// </summary>
        /// <param name="resolver">The resolver to resolve the event data.</param>
        /// <param name="eventArgsWrapperType">The type of the event args wrapper.</param>
        /// <param name="resolverPropertyName">The name of the Resolver property of the event args wrapper.</param>
        /// <param name="applyResolver">The action that performs to resolve the event data with the resolver.</param>
        /// <exception cref="ArgumentNullException">
        /// <paramref name="eventArgsWrapperType"/> is <c>null</c>.
        /// </exception>
        public EventArgsResolverContext(T resolver, Type eventArgsWrapperType, string resolverPropertyName, Action<T> applyResolver)
        {
            this.resolver = resolver;
            this.eventArgsWrapperType = eventArgsWrapperType.RequireNonNull(nameof(eventArgsWrapperType));
            this.resolverPropertyName = resolverPropertyName;
            this.applyResolver = applyResolver;
        }

        /// <summary>
        /// Configures the resolver.
        /// </summary>
        public void Configure()
        {
            resolverProperty = eventArgsWrapperType.GetProperty(resolverPropertyName);
            originalResolver = resolverProperty.GetValue(null);
            resolverProperty.SetValue(null, resolver);
        }

        /// <summary>
        /// Applies the resolver action.
        /// </summary>
        public void Apply() => applyResolver?.Invoke(resolver);

        /// <summary>
        /// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
        /// </summary>
        /// <remarks>
        /// Sets the resolver to the original resolver.
        /// </remarks>
        public void Dispose()
        {
            resolverProperty?.SetValue(null, originalResolver);
        }
    }
}
