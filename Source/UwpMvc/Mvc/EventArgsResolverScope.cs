// Copyright (C) 2018-2019 Fievus
//
// This software may be modified and distributed under the terms
// of the MIT license.  See the LICENSE file for details.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace Charites.Windows.Mvc
{
    internal sealed class EventArgsResolverScope : IDisposable
    {
        private readonly SemaphoreSlim semaphore = new SemaphoreSlim(1, 1);
        private readonly IEnumerable<IEventArgsResolver> eventArgsResolvers;

        public EventArgsResolverScope(IEnumerable<IEventArgsResolver> eventArgsResolvers)
        {
            this.eventArgsResolvers = eventArgsResolvers ?? Enumerable.Empty<IEventArgsResolver>();

            semaphore.Wait();

            this.eventArgsResolvers.ForEach(context => context.Configure());
        }

        public void ApplyResolver()
        {
            eventArgsResolvers.ForEach(context => context.Apply());
        }

        public void Dispose()
        {
            eventArgsResolvers.ForEach(context => context.Dispose());

            semaphore.Release();
        }
    }
}
