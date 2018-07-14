// Copyright (C) 2018 Fievus
//
// This software may be modified and distributed under the terms
// of the MIT license.  See the LICENSE file for details.
using Windows.UI.Xaml.Controls;

namespace Charites.Windows.Mvc.Wrappers
{
    /// <summary>
    /// Provides data of the <see cref="SplitViewPaneClosingEventArgs"/>
    /// resolved by <see cref="ISplitViewPaneClosingEventArgsResolver"/>.
    /// </summary>
    public static class SplitViewPaneClosingEventArgsWrapper
    {
        /// <summary>
        /// Gets or sets the <see cref="ISplitViewPaneClosingEventArgsResolver"/>
        /// that resolves data of the <see cref="SplitViewPaneClosingEventArgs"/>.
        /// </summary>
        public static ISplitViewPaneClosingEventArgsResolver Resolver { get; set; } = new DefaultSplitViewPaneClosingEventArgsResolver();

        /// <summary>
        /// Gets a value that indicates whether the pane closing action should be canceled.
        /// </summary>
        /// <param name="e">The requested <see cref="SplitViewPaneClosingEventArgs"/>.</param>
        /// <returns>
        /// <c>true</c> to cancel the pane closing acction; otherwise, <c>false</c>.
        /// </returns>
        public static bool CancelWrapped(this SplitViewPaneClosingEventArgs e) => Resolver.Cancel(e);

        /// <summary>
        /// Sets a value that indicates whether the pane closing action should be canceled.
        /// </summary>
        /// <param name="e">The requested <see cref="SplitViewPaneClosingEventArgs"/>.</param>
        /// <param name="cancel">
        /// <c>true</c> to cancel the pane closing acction; otherwise, <c>false</c>.
        /// </param>
        public static void CancelWrapped(this SplitViewPaneClosingEventArgs e, bool cancel) => Resolver.Cancel(e, cancel);

        private sealed class DefaultSplitViewPaneClosingEventArgsResolver : ISplitViewPaneClosingEventArgsResolver
        {
            bool ISplitViewPaneClosingEventArgsResolver.Cancel(SplitViewPaneClosingEventArgs e) => e.Cancel;
            void ISplitViewPaneClosingEventArgsResolver.Cancel(SplitViewPaneClosingEventArgs e, bool cancel) => e.Cancel = cancel;
        }
    }

    /// <summary>
    /// Resolves data of the <see cref="SplitViewPaneClosingEventArgs"/>.
    /// </summary>
    public interface ISplitViewPaneClosingEventArgsResolver
    {
        /// <summary>
        /// Gets a value that indicates whether the pane closing action should be canceled.
        /// </summary>
        /// <param name="e">The requested <see cref="SplitViewPaneClosingEventArgs"/>.</param>
        /// <returns>
        /// <c>true</c> to cancel the pane closing acction; otherwise, <c>false</c>.
        /// </returns>
        bool Cancel(SplitViewPaneClosingEventArgs e);

        /// <summary>
        /// Sets a value that indicates whether the pane closing action should be canceled.
        /// </summary>
        /// <param name="e">The requested <see cref="SplitViewPaneClosingEventArgs"/>.</param>
        /// <param name="cancel">
        /// <c>true</c> to cancel the pane closing acction; otherwise, <c>false</c>.
        /// </param>
        void Cancel(SplitViewPaneClosingEventArgs e, bool cancel);
    }
}
