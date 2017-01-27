// Copyright (C) 2017 Fievus
//
// This software may be modified and distributed under the terms
// of the MIT license.  See the LICENSE file for details.
using System;
using System.Threading;
using System.Threading.Tasks;
using Windows.ApplicationModel.Core;
using Windows.Foundation;
using Windows.UI.Core;
using Windows.UI.Xaml;

namespace Fievus.Windows.Mvc
{
    public class DispatcherHarness : IDisposable
    {
        protected CoreDispatcher Dispatcher { get; }

        private static AutoResetEvent working = new AutoResetEvent(true);

        protected DispatcherHarness()
        {
            working.WaitOne();
            Dispatcher = CoreApplication.CreateNewView().Dispatcher;
        }

        protected IAsyncAction RunAsync(DispatchedHandler agileCallback) =>
            Dispatcher.RunAsync(CoreDispatcherPriority.Normal, agileCallback);

        protected async Task SetWindowContent(UIElement element)
        {
            await RunAsync(() => Window.Current.Content = element);
            await Task.Delay(100);
        }

        protected async Task ClearWindowContent()
        {
            await RunAsync(() => Window.Current.Content = null);
            await Task.Delay(100);
        }

        protected virtual void Dispose()
        {
        }

        void IDisposable.Dispose()
        {
            Dispose();

            working.Set();
        }
    }
}
