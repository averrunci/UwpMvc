// Copyright (C) 2018 Fievus
//
// This software may be modified and distributed under the terms
// of the MIT license.  See the LICENSE file for details.
using Windows.UI.Xaml;
using Windows.UI.Xaml.Media;

namespace Charites.Windows.Mvc
{
    /// <summary>
    /// Provides utility methods for an element.
    /// </summary>
    public static class ElementExtensions
    {
        /// <summary>
        /// Retrieves an element that has the specified identifier name.
        /// </summary>
        /// <typeparam name="TElement">The type of the requested element.</typeparam>
        /// <param name="element">The element that has the requested element.</param>
        /// <param name="name">The name of the requested element.</param>
        /// <returns>
        /// The requested element. This can be null if an element was not found.
        /// </returns>
        public static TElement FindElement<TElement>(this FrameworkElement element, string name) where TElement : class
        {
            if (element == null) return null;
            if (string.IsNullOrEmpty(name)) return element as TElement;
            if (element.Name == name) return element as TElement;

            return element.FindName(name) as TElement;
        }

        /// <summary>
        /// Retrieves an element that is an ancestor of the specified element.
        /// </summary>
        /// <typeparam name="TElement">The type of the requested element.</typeparam>
        /// <param name="element">The element that is descendant of the requested element.</param>
        /// <returns>
        /// The requested element. This can be null if an element was not found.
        /// </returns>
        public static TElement FindAncestorElement<TElement>(this DependencyObject element) where TElement : UIElement
        {
            if (element == null) return null;

            var parent = VisualTreeHelper.GetParent(element);
            if (parent is TElement targetElement) return targetElement;

            return parent.FindAncestorElement<TElement>();
        }
    }
}
