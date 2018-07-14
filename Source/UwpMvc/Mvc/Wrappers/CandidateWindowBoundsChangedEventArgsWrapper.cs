// Copyright (C) 2018 Fievus
//
// This software may be modified and distributed under the terms
// of the MIT license.  See the LICENSE file for details.
using Windows.Foundation;
using Windows.UI.Xaml.Controls;

namespace Charites.Windows.Mvc.Wrappers
{
    /// <summary>
    /// Provides data of the <see cref="CandidateWindowBoundsChangedEventArgs"/>
    /// resolved by <see cref="ICandidateWindowBoundsChangedEventArgsResolver"/>.
    /// </summary>
    public static class CandidateWindowBoundsChangedEventArgsWrapper
    {
        /// <summary>
        /// Gets or sets the <see cref="ICandidateWindowBoundsChangedEventArgsResolver"/>
        /// that resolves data of the <see cref="CandidateWindowBoundsChangedEventArgs"/>.
        /// </summary>
        public static ICandidateWindowBoundsChangedEventArgsResolver Resolver { get; set; } = new DefaultCandidateWindowBoundsChangedEventArgsResolver();

        /// <summary>
        /// Gets the Rect that defines the size and location of the Input Method Editor (IME)
        /// window, in the coordinate space of the text edit control.
        /// </summary>
        /// <param name="e">The requested <see cref="CandidateWindowBoundsChangedEventArgs"/>.</param>
        /// <returns>The Rect that defines the size and location of the IME window.</returns>
        public static Rect Bounds(this CandidateWindowBoundsChangedEventArgs e) => Resolver.Bounds(e);

        private sealed class DefaultCandidateWindowBoundsChangedEventArgsResolver : ICandidateWindowBoundsChangedEventArgsResolver
        {
            Rect ICandidateWindowBoundsChangedEventArgsResolver.Bounds(CandidateWindowBoundsChangedEventArgs e) => e.Bounds;
        }
    }

    /// <summary>
    /// Resolves data of the <see cref="CandidateWindowBoundsChangedEventArgs"/>.
    /// </summary>
    public interface ICandidateWindowBoundsChangedEventArgsResolver
    {
        /// <summary>
        /// Gets the Rect that defines the size and location of the Input Method Editor (IME)
        /// window, in the coordinate space of the text edit control.
        /// </summary>
        /// <param name="e">The requested <see cref="CandidateWindowBoundsChangedEventArgs"/>.</param>
        /// <returns>The Rect that defines the size and location of the IME window.</returns>
        Rect Bounds(CandidateWindowBoundsChangedEventArgs e);
    }
}
