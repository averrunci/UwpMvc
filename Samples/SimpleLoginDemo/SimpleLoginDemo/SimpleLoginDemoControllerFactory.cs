﻿// Copyright (C) 2018-2021 Fievus
//
// This software may be modified and distributed under the terms
// of the MIT license.  See the LICENSE file for details.
using System;
using Charites.Windows.Mvc;
using Charites.Windows.Samples.SimpleLoginDemo.Presentation;
using Charites.Windows.SamplesSimpleLoginDemo.Adapter;
using Microsoft.Extensions.DependencyInjection;

namespace Charites.Windows.Samples.SimpleLoginDemo
{
    public class SimpleLoginDemoControllerFactory : IUwpControllerFactory
    {
        private IServiceProvider Services { get; } = new ServiceCollection()
            .AddSingleton<IContentNavigator, ContentNavigator>(p =>
            {
                IContentNavigator navigator = new ContentNavigator();
                navigator.IsNavigationStackEnabled = false;
                return (ContentNavigator)navigator;
            })
            .AddControllers()
            .AddPresentationAdapters()
            .BuildServiceProvider();

        protected virtual object Create(Type controllerType) => Services.GetRequiredService(controllerType);
        object IUwpControllerFactory.Create(Type controllerType) => Create(controllerType);
    }
}
