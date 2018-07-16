// Copyright (C) 2018 Fievus
//
// This software may be modified and distributed under the terms
// of the MIT license.  See the LICENSE file for details.
using System;
using System.Reflection;
using System.Threading;

namespace Charites.Windows.Mvc.Wrappers
{
    internal sealed class EventArgsResolverScope<T> : IDisposable
    {
        public T Resolver { get; }

        private readonly SemaphoreSlim semaphore = new SemaphoreSlim(1, 1);
        private readonly PropertyInfo resolverProperty;
        private readonly object originalResolver;

        public EventArgsResolverScope(T resolver, Type eventArgsWrapperType, string resolverPropertyName)
        {
            eventArgsWrapperType.RequireNonNull(nameof(eventArgsWrapperType));

            semaphore.Wait();

            resolverProperty = eventArgsWrapperType.GetProperty(resolverPropertyName);
            originalResolver = resolverProperty.GetValue(null);
            resolverProperty.SetValue(null, resolver);
            Resolver = resolver;
        }

        public void Dispose()
        {
            resolverProperty.SetValue(null, originalResolver);

            semaphore.Release();
        }
    }
}
