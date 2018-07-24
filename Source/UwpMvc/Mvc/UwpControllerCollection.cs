// Copyright (C) 2018 Fievus
//
// This software may be modified and distributed under the terms
// of the MIT license.  See the LICENSE file for details.
using System.Collections.Generic;
using Windows.UI.Xaml;

namespace Charites.Windows.Mvc
{
    /// <summary>
    /// Represents a collection of controller objects.
    /// </summary>
    public sealed class UwpControllerCollection : ControllerCollection<FrameworkElement>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UwpControllerCollection"/> class
        /// with the specified <see cref="IUwpDataContextFinder"/>, <see cref="IDataContextInjector"/>,
        /// <see cref="IUwpElementInjector"/>, and the enumerable of the <see cref="IUwpControllerExtension"/>.
        /// </summary>
        /// <param name="dataContextFinder">The finder to find a data context.</param>
        /// <param name="dataContextInjector">The injector to inject a data context.</param>
        /// <param name="elementInjector">The injector to inject elements.</param>
        /// <param name="extensions">The extensions for a controller.</param>
        public UwpControllerCollection(IUwpDataContextFinder dataContextFinder, IDataContextInjector dataContextInjector, IUwpElementInjector elementInjector, IEnumerable<IUwpControllerExtension> extensions) : base(dataContextFinder, dataContextInjector, elementInjector, extensions)
        {
        }

        /// <summary>
        /// Adds the controllers of the specified collection to the end of the <see cref="UwpControllerCollection"/>.
        /// </summary>
        /// <param name="controllers">
        /// The controllers to add to the end of the<see cref="UwpControllerCollection"/>.
        /// If the specified collection is <c>null</c>, nothing is added without throwing an exception.
        /// </param>
        public void AddRange(IEnumerable<object> controllers) => controllers.ForEach(Add);

        /// <summary>
        /// Gets the value that indicates whether the element to which controllers are attached is loaded.
        /// </summary>
        /// <param name="associatedElement">The element to which controllers are attached.</param>
        /// <returns>
        /// <c>true</c> if the element to which controllers are attached is loaded;
        /// otherwise, <c>false</c> is returned.
        /// </returns>
        protected override bool IsAssociatedElementLoaded(FrameworkElement associatedElement) => false;

        /// <summary>
        /// Subscribes events of the element to which controllers are attached.
        /// </summary>
        /// <param name="associatedElement">The element to which controllers are attached.</param>
        protected override void SubscribeAssociatedElementEvents(FrameworkElement associatedElement)
        {
            associatedElement.Loaded += OnElementLoaded;
            associatedElement.Unloaded += OnElementUnloaded;
            associatedElement.DataContextChanged += OnElementDataContextChanged;
        }

        /// <summary>
        /// Unsubscribes events of the element to which controllers are attached.
        /// </summary>
        /// <param name="associatedElement">The element to which controllers are attached.</param>
        protected override void UnsubscribeAssociatedElementEvents(FrameworkElement associatedElement)
        {
            associatedElement.Loaded -= OnElementLoaded;
            associatedElement.Unloaded -= OnElementUnloaded;
            associatedElement.DataContextChanged -= OnElementDataContextChanged;
        }

        private void OnElementLoaded(object sender, RoutedEventArgs e)
        {
            if (!(sender is FrameworkElement element)) return;

            SetElement(element);
            AttachExtensions();
        }

        private void OnElementUnloaded(object sender, RoutedEventArgs e)
        {
            Detach();

            if (!(sender is FrameworkElement element)) return;
            UwpController.ClearControllers(element);
        }

        private void OnElementDataContextChanged(object sender, DataContextChangedEventArgs e)
        {
            SetDataContext(e.NewValue);
        }
    }
}
