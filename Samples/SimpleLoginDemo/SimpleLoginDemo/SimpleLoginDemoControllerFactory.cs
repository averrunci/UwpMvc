// Copyright (C) 2017 Fievus
//
// This software may be modified and distributed under the terms
// of the MIT license.  See the LICENSE file for details.
using System;
using Microsoft.Extensions.DependencyInjection;

using Fievus.Windows.Mvc;

using Fievus.Windows.Samples.SimpleLoginDemo.Adapter;
using Fievus.Windows.Samples.SimpleLoginDemo.Presentation;

namespace Fievus.Windows.Samples.SimpleLoginDemo
{
    public class SimpleLoginDemoControllerFactory : IUwpControllerFactory
    {
        private IServiceProvider Services { get; } = new ServiceCollection()
            .AddControllers()
            .AddPresentationAdapters()
            .BuildServiceProvider();

        protected virtual object Create(Type controllerType) => Services.GetRequiredService(controllerType);
        object IUwpControllerFactory.Create(Type controllerType) => Create(controllerType);
    }
}
