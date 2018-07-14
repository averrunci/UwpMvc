// Copyright (C) 2018 Fievus
//
// This software may be modified and distributed under the terms
// of the MIT license.  See the LICENSE file for details.
using Windows.UI.Xaml.Controls;

namespace Charites.Windows.Mvc.Wrappers
{
    /// <summary>
    /// Provides data of the <see cref="ScrollViewerViewChangingEventArgs"/>
    /// resolved by <see cref="IScrollViewerViewChangingEventArgsResolver"/>.
    /// </summary>
    public static class ScrollViewerViewChangingEventArgsWrapper
    {
        /// <summary>
        /// Gets or sets the <see cref="IScrollViewerViewChangingEventArgsResolver"/>
        /// that resolves data of the <see cref="ScrollViewerViewChangingEventArgs"/>.
        /// </summary>
        public static IScrollViewerViewChangingEventArgsResolver Resolver { get; set; } = new DefaultScrollViewerViewChangingEventArgsResolver();

        /// <summary>
        /// Gets the view that the <see cref="ScrollViewer"/> will show when the view comes to rest after a pan/zoom manipulation.
        /// </summary>
        /// <param name="e">The requested <see cref="ScrollViewerViewChangingEventArgs"/>.</param>
        /// <returns>
        /// The view that the <see cref="ScrollViewer"/> will show when the view comes to rest after a pan/zoom manipulation.
        /// </returns>
        public static ScrollViewerView FinalView(this ScrollViewerViewChangingEventArgs e) => Resolver.FinalView(e);

        /// <summary>
        /// Gets a value that indicates whether the pan/zoom manipulation has an inertial component.
        /// </summary>
        /// <param name="e">The requested <see cref="ScrollViewerViewChangingEventArgs"/>.</param>
        /// <returns>
        /// <c>true</c> if the pan/zoom manipulation has an inertial component; otherwise, <c>false</c>.
        /// </returns>
        public static bool IsInertial(this ScrollViewerViewChangingEventArgs e) => Resolver.IsInertial(e);

        /// <summary>
        /// Gets the view that the <see cref="ScrollViewer"/> will show next.
        /// </summary>
        /// <param name="e">The requested <see cref="ScrollViewerViewChangingEventArgs"/>.</param>
        /// <returns>The view that the <see cref="ScrollViewer"/> will show next.</returns>
        public static ScrollViewerView NextView(this ScrollViewerViewChangingEventArgs e) => Resolver.NextView(e);

        private sealed class DefaultScrollViewerViewChangingEventArgsResolver : IScrollViewerViewChangingEventArgsResolver
        {
            ScrollViewerView IScrollViewerViewChangingEventArgsResolver.FinalView(ScrollViewerViewChangingEventArgs e) => e.FinalView;
            bool IScrollViewerViewChangingEventArgsResolver.IsInertial(ScrollViewerViewChangingEventArgs e) => e.IsInertial;
            ScrollViewerView IScrollViewerViewChangingEventArgsResolver.NextView(ScrollViewerViewChangingEventArgs e) => e.NextView;
        }
    }

    /// <summary>
    /// Resolves data of the <see cref="ScrollViewerViewChangingEventArgs"/>.
    /// </summary>
    public interface IScrollViewerViewChangingEventArgsResolver
    {
        /// <summary>
        /// Gets the view that the <see cref="ScrollViewer"/> will show when the view comes to rest after a pan/zoom manipulation.
        /// </summary>
        /// <param name="e">The requested <see cref="ScrollViewerViewChangingEventArgs"/>.</param>
        /// <returns>
        /// The view that the <see cref="ScrollViewer"/> will show when the view comes to rest after a pan/zoom manipulation.
        /// </returns>
        ScrollViewerView FinalView(ScrollViewerViewChangingEventArgs e);

        /// <summary>
        /// Gets a value that indicates whether the pan/zoom manipulation has an inertial component.
        /// </summary>
        /// <param name="e">The requested <see cref="ScrollViewerViewChangingEventArgs"/>.</param>
        /// <returns>
        /// <c>true</c> if the pan/zoom manipulation has an inertial component; otherwise, <c>false</c>.
        /// </returns>
        bool IsInertial(ScrollViewerViewChangingEventArgs e);

        /// <summary>
        /// Gets the view that the <see cref="ScrollViewer"/> will show next.
        /// </summary>
        /// <param name="e">The requested <see cref="ScrollViewerViewChangingEventArgs"/>.</param>
        /// <returns>The view that the <see cref="ScrollViewer"/> will show next.</returns>
        ScrollViewerView NextView(ScrollViewerViewChangingEventArgs e);
    }
}
