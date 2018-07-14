// Copyright (C) 2018 Fievus
//
// This software may be modified and distributed under the terms
// of the MIT license.  See the LICENSE file for details.
using System;
using System.Threading.Tasks;
using Windows.ApplicationModel.Core;
using Windows.Foundation;
using Windows.UI.Core;
using Windows.UI.Xaml;
using Carna;

namespace Charites.Windows.Mvc
{
    internal class DispatcherContext : FixtureSteppable
    {
        protected CoreDispatcher Dispatcher { get; }

        protected DispatcherContext()
        {
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
    }
}
