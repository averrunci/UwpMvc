// Copyright (C) 2019 Fievus
//
// This software may be modified and distributed under the terms
// of the MIT license.  See the LICENSE file for details.
using Windows.UI.Xaml.Controls;

namespace Charites.Windows.Mvc.Wrappers
{
    /// <summary>
    /// Provides data of the <see cref="ContentDialogButtonClickEventArgs"/>
    /// resolved by <see cref="IContentDialogButtonClickEventArgsResolver"/>.
    /// </summary>
    public static class ContentDialogButtonClickEventArgsWrapper
    {
        /// <summary>
        /// Gets or sets the <see cref="IContentDialogButtonClickEventArgsResolver"/>
        /// that resolves data of the <see cref="ContentDialogButtonClickEventArgs"/>.
        /// </summary>
        public static IContentDialogButtonClickEventArgsResolver Resolver { get; set; } = new DefaultContentDialogButtonClickEventArgsResolver();

        /// <summary>
        /// Gets a value that can cancel the button click. A <c>true</c> value for Cancel cancels the default behavior.
        /// </summary>
        /// <param name="e">The requested <see cref="ContentDialogButtonClickEventArgs"/>.</param>
        /// <returns><c>true</c> to cancel the button click; Otherwise, <c>false</c>.</returns>
        public static bool Cancel(this ContentDialogButtonClickEventArgs e) => Resolver.Cancel(e);

        /// <summary>
        /// Sets a value that can cancel the button click. A <c>true</c> value for Cancel cancels the default behavior.
        /// </summary>
        /// <param name="e">The requested <see cref="ContentDialogButtonClickEventArgs"/>.</param>
        /// <param name="cancel"><c>true</c> to cancel the button click; Otherwise, <c>false</c>.</param>
        public static void Cancel(this ContentDialogButtonClickEventArgs e, bool cancel) => Resolver.Cancel(e, cancel);

        /// <summary>
        /// Gets a ContentDialogButtonClickDeferral that the app can use to respond asynchronously to a button click event.
        /// </summary>
        /// <param name="e">The requested <see cref="ContentDialogButtonClickEventArgs"/>.</param>
        /// <returns>A ContentDialogButtonClickDeferral that the app can use to respond asynchronously to a button click event.</returns>
        public static ContentDialogButtonClickDeferral GetDeferralWrapped(this ContentDialogButtonClickEventArgs e) => Resolver.GetDeferral(e);

        private sealed class DefaultContentDialogButtonClickEventArgsResolver : IContentDialogButtonClickEventArgsResolver
        {
            bool IContentDialogButtonClickEventArgsResolver.Cancel(ContentDialogButtonClickEventArgs e) => e.Cancel;
            void IContentDialogButtonClickEventArgsResolver.Cancel(ContentDialogButtonClickEventArgs e, bool cancel) => e.Cancel = cancel;
            ContentDialogButtonClickDeferral IContentDialogButtonClickEventArgsResolver.GetDeferral(ContentDialogButtonClickEventArgs e) => e.GetDeferral();
        }
    }

    /// <summary>
    /// Resolves data of the <see cref="ContentDialogButtonClickEventArgs"/>.
    /// </summary>
    public interface IContentDialogButtonClickEventArgsResolver
    {
        /// <summary>
        /// Gets a value that can cancel the button click. A <c>true</c> value for Cancel cancels the default behavior.
        /// </summary>
        /// <param name="e">The requested <see cref="ContentDialogButtonClickEventArgs"/>.</param>
        /// <returns><c>true</c> to cancel the button click; Otherwise, <c>false</c>.</returns>
        bool Cancel(ContentDialogButtonClickEventArgs e);

        /// <summary>
        /// Sets a value that can cancel the button click. A <c>true</c> value for Cancel cancels the default behavior.
        /// </summary>
        /// <param name="e">The requested <see cref="ContentDialogButtonClickEventArgs"/>.</param>
        /// <param name="cancel"><c>true</c> to cancel the button click; Otherwise, <c>false</c>.</param>
        void Cancel(ContentDialogButtonClickEventArgs e, bool cancel);

        /// <summary>
        /// Gets a ContentDialogButtonClickDeferral that the app can use to respond asynchronously to a button click event.
        /// </summary>
        /// <param name="e">The requested <see cref="ContentDialogButtonClickEventArgs"/>.</param>
        /// <returns>A ContentDialogButtonClickDeferral that the app can use to respond asynchronously to a button click event.</returns>
        ContentDialogButtonClickDeferral GetDeferral(ContentDialogButtonClickEventArgs e);
    }
}
