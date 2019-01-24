// Copyright (C) 2018-2019 Fievus
//
// This software may be modified and distributed under the terms
// of the MIT license.  See the LICENSE file for details.
using Windows.UI.Xaml.Controls;

namespace Charites.Windows.Mvc.Wrappers
{
    /// <summary>
    /// Provides data of the <see cref="ScrollViewerViewChangedEventArgs"/>
    /// resolved by <see cref="IScrollViewerViewChangedEventArgsResolver"/>.
    /// </summary>
    public static class ScrollViewerViewChangedEventArgsWrapper
    {
        /// <summary>
        /// Gets or sets the <see cref="IScrollViewerViewChangedEventArgsResolver"/>
        /// that resolves data of the <see cref="ScrollViewerViewChangedEventArgs"/>.
        /// </summary>
        public static IScrollViewerViewChangedEventArgsResolver Resolver { get; set; } = new DefaultScrollViewerViewChangedEventArgsResolver();

        /// <summary>
        /// Gets a value that indicates whether the underlying manipulation that raised the event is complete.
        /// </summary>
        /// <param name="e">The requested <see cref="ScrollViewerViewChangedEventArgs"/>.</param>
        /// <returns>
        /// <c>true</c> if the manipulation is at an intermediate stage and not yet final;
        /// <c>false</c> if the manipulation is final.
        /// </returns>
        public static bool IsIntermediate(this ScrollViewerViewChangedEventArgs e) => Resolver.IsIntermediate(e);

        private sealed class DefaultScrollViewerViewChangedEventArgsResolver : IScrollViewerViewChangedEventArgsResolver
        {
            bool IScrollViewerViewChangedEventArgsResolver.IsIntermediate(ScrollViewerViewChangedEventArgs e) => e.IsIntermediate;
        }
    }

    /// <summary>
    /// Resolves data of the <see cref="ScrollViewerViewChangedEventArgs"/>.
    /// </summary>
    public interface IScrollViewerViewChangedEventArgsResolver
    {
        /// <summary>
        /// Gets a value that indicates whether the underlying manipulation that raised the event is complete.
        /// </summary>
        /// <param name="e">The requested <see cref="ScrollViewerViewChangedEventArgs"/>.</param>
        /// <returns>
        /// <c>true</c> if the manipulation is at an intermediate stage and not yet final;
        /// <c>false</c> if the manipulation is final.
        /// </returns>
        bool IsIntermediate(ScrollViewerViewChangedEventArgs e);
    }
}
