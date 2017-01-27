// Copyright (C) 2017 Fievus
//
// This software may be modified and distributed under the terms
// of the MIT license.  See the LICENSE file for details.
using Windows.UI.Xaml;
using Windows.UI.Xaml.Media;

namespace Fievus.Windows.Mvc
{
    /// <summary>
    /// Provides utility methods for an element.
    /// </summary>
    public static class ElementExtensions
    {
        /// <summary>
        /// Retrieves an element that has the specified identifier name.
        /// </summary>
        /// <typeparam name="E">The type of the requested element.</typeparam>
        /// <param name="element">The element that has the requested element.</param>
        /// <param name="name">The name of the requested element.</param>
        /// <returns>
        /// The requested element. This can be null if an element was not found.
        /// </returns>
        public static E FindElement<E>(this FrameworkElement element, string name) where E : FrameworkElement
        {
            if (element == null) { return null; }
            if (string.IsNullOrEmpty(name)) { return element as E; }
            if (element.Name == name) { return element as E; }

            return element.FindName(name) as E;
        }

        /// <summary>
        /// Retrieves an element that is an anscestor of the specified element.
        /// </summary>
        /// <typeparam name="E">The type of the requested element.</typeparam>
        /// <param name="element">The element that is descendant of the requested element.</param>
        /// <returns>
        /// The requested element. This can be null if an element was not found.
        /// </returns>
        public static E FindAnscestorElement<E>(this DependencyObject element) where E : UIElement
        {
            if (element == null) { return null; }

            var parent = VisualTreeHelper.GetParent(element);
            var targetElement = parent as E;
            if (targetElement != null) { return targetElement; }

            return parent.FindAnscestorElement<E>();
        }
    }
}
