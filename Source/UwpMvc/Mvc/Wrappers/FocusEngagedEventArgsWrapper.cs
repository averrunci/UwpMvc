// Copyright (C) 2017 Fievus
//
// This software may be modified and distributed under the terms
// of the MIT license.  See the LICENSE file for details.
using Windows.UI.Xaml.Controls;

namespace Fievus.Windows.Mvc.Wrappers
{
    /// <summary>
    /// Provides data of the <see cref="FocusEngagedEventArgs"/>
    /// resolved by <see cref="IFocusEngagedEventArgsResolver"/>.
    /// </summary>
    public static class FocusEngagedEventArgsWrapper
    {
        /// <summary>
        /// Gets or sets the <see cref="IFocusEngagedEventArgsResolver"/>
        /// that resolves data of the <see cref="FocusEngagedEventArgs"/>.
        /// </summary>
        public static IFocusEngagedEventArgsResolver Resolver { get; set; } = new DefaultFocusEngagedEventArgsResolver();

        /// <summary>
        /// Gets a reference to the object that raised the event.
        /// This is often a template part of a control rather than an element that was declared in your app UI.
        /// </summary>
        /// <param name="e">The requested <see cref="FocusEngagedEventArgs"/>.</param>
        /// <returns>The object that raised the event.</returns>
        public static object OriginalSource(this FocusEngagedEventArgs e) => Resolver.OriginalSource(e);

        private sealed class DefaultFocusEngagedEventArgsResolver : IFocusEngagedEventArgsResolver
        {
            object IFocusEngagedEventArgsResolver.OriginalSource(FocusEngagedEventArgs e) => e.OriginalSource;
        }
    }

    /// <summary>
    /// Resolves data of the <see cref="FocusEngagedEventArgs"/>.
    /// </summary>
    public interface IFocusEngagedEventArgsResolver
    {
        /// <summary>
        /// Gets a reference to the object that raised the event.
        /// This is often a template part of a control rather than an element that was declared in your app UI.
        /// </summary>
        /// <param name="e">The requested <see cref="FocusEngagedEventArgs"/>.</param>
        /// <returns>The object that raised the event.</returns>
        object OriginalSource(FocusEngagedEventArgs e);
    }
}
