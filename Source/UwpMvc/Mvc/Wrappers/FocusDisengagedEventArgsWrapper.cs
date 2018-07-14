// Copyright (C) 2018 Fievus
//
// This software may be modified and distributed under the terms
// of the MIT license.  See the LICENSE file for details.
using Windows.UI.Xaml.Controls;

namespace Charites.Windows.Mvc.Wrappers
{
    /// <summary>
    /// Provides data of the <see cref="FocusDisengagedEventArgs"/>
    /// resolved by <see cref="IFocusDisengagedEventArgsResolver"/>.
    /// </summary>
    public static class FocusDisengagedEventArgsWrapper
    {
        /// <summary>
        /// Gets or sets the <see cref="IFocusDisengagedEventArgsResolver"/>
        /// that resolves data of the <see cref="FocusDisengagedEventArgs"/>.
        /// </summary>
        public static IFocusDisengagedEventArgsResolver Resolver { get; set; } = new DefaultFocusDisengagedEventArgsResolver();

        /// <summary>
        /// Gets a reference to the object that raised the event.
        /// This is often a template part of a control rather than an element that was declared in your app UI.
        /// </summary>
        /// <param name="e">The requested <see cref="FocusDisengagedEventArgs"/>.</param>
        /// <returns>The object that raised the event.</returns>
        public static object OriginalSource(this FocusDisengagedEventArgs e) => Resolver.OriginalSource(e);

        private sealed class DefaultFocusDisengagedEventArgsResolver : IFocusDisengagedEventArgsResolver
        {
            object IFocusDisengagedEventArgsResolver.OriginalSource(FocusDisengagedEventArgs e) => e.OriginalSource;
        }
    }

    /// <summary>
    /// Resolves data of the <see cref="FocusDisengagedEventArgs"/>.
    /// </summary>
    public interface IFocusDisengagedEventArgsResolver
    {
        /// <summary>
        /// Gets a reference to the object that raised the event.
        /// This is often a template part of a control rather than an element that was declared in your app UI.
        /// </summary>
        /// <param name="e">The requested <see cref="FocusDisengagedEventArgs"/>.</param>
        /// <returns>The object that raised the event.</returns>
        object OriginalSource(FocusDisengagedEventArgs e);
    }
}
