// Copyright (C) 2018 Fievus
//
// This software may be modified and distributed under the terms
// of the MIT license.  See the LICENSE file for details.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Windows.UI.Xaml;

namespace Charites.Windows.Mvc
{
    internal sealed class UwpControllerTypeFinder : ControllerTypeFinder<FrameworkElement>, IUwpControllerTypeFinder
    {
        public IUwpControllerTypeContainer ControllerTypeContainer { get; set; }

        public UwpControllerTypeFinder(IUwpElementKeyFinder elementKeyFinder, IUwpDataContextFinder dataContextFinder) : base(elementKeyFinder, dataContextFinder)
        {
        }

        protected override IEnumerable<Type> FindControllerTypeCandidates(FrameworkElement view)
            => GetControllerTypes()
                .Concat(GetType().Assembly.GetTypes().Where(type => type.GetCustomAttributes<ViewAttribute>(true).Any()))
                .Concat(view.DataContext?.GetType().Assembly.GetTypes() ?? Enumerable.Empty<Type>());

        private IEnumerable<Type> GetControllerTypes()
            => ControllerTypeContainer?.GetControllerTypes() ?? Enumerable.Empty<Type>();
    }
}
