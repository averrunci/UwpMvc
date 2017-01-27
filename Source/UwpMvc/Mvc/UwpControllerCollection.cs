// Copyright (C) 2017 Fievus
//
// This software may be modified and distributed under the terms
// of the MIT license.  See the LICENSE file for details.
using System;
using System.Collections.ObjectModel;
using Windows.UI.Xaml;

namespace Fievus.Windows.Mvc
{
    /// <summary>
    /// Represents a collection of UWP controller objects.
    /// </summary>
    public sealed class UwpControllerCollection : Collection<object>
    {
        /// <summary>
        /// Gets the element to which UWP controllers are attached.
        /// </summary>
        public FrameworkElement AssociatedElement { get; private set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="UwpControllerCollection"/> class.
        /// </summary>
        public UwpControllerCollection()
        {
        }

        /// <summary>
        /// Attaches UWP controllers to the specified element.
        /// </summary>
        /// <param name="element">The element to which UWP controllers are attached.</param>
        public void AttachTo(FrameworkElement element)
        {
            if (element == AssociatedElement) { return; }
            if (AssociatedElement != null) { throw new InvalidOperationException("Assosiated element must be null."); }

            AssociatedElement = element;
            this.ForEach(controller => UwpController.Attach(controller, element));
        }

        /// <summary>
        /// Detaches UWP controllers from the element to which UWP controllers are attached.
        /// </summary>
        public void Detach()
        {
            this.ForEach(controller => UwpController.Detach(controller, AssociatedElement));
            AssociatedElement = null;
        }

        /// <summary>
        /// Removes all elements of the <see cref="UwpControllerCollection"/>.
        /// </summary>
        protected override void ClearItems()
        {
            Detach();

            base.ClearItems();
        }

        /// <summary>
        /// Inserts an element into the <see cref="UwpControllerCollection"/> at the specified index.
        /// </summary>
        /// <param name="index">
        /// The zero-based index at which <paramref name="item"/> should be inserted.
        /// </param>
        /// <param name="item">
        /// The object to insert. The value can be <c>null</c> for reference types.
        /// </param>
        protected override void InsertItem(int index, object item)
        {
            var controller = item;
            (controller as IUwpControllerFactory).IfPresent(factory => controller = factory.Create(null));
            (controller as UwpController).IfPresent(uwpController => controller = uwpController.Create());

            base.InsertItem(index, controller);

            if (AssociatedElement == null) { return; }
            UwpController.Attach(controller, AssociatedElement);
        }

        /// <summary>
        /// Removes the element at the specified index of the <see cref="UwpControllerCollection"/>.
        /// </summary>
        /// <param name="index">The zero-based index of the element to remove.</param>
        protected override void RemoveItem(int index)
        {
            UwpController.Detach(this[index], AssociatedElement);

            base.RemoveItem(index);
        }
    }
}
