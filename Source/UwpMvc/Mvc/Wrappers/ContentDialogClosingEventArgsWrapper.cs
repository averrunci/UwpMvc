// Copyright (C) 2017 Fievus
//
// This software may be modified and distributed under the terms
// of the MIT license.  See the LICENSE file for details.
using Windows.UI.Xaml.Controls;

namespace Fievus.Windows.Mvc.Wrappers
{
    /// <summary>
    /// Provides data of the <see cref="ContentDialogClosingEventArgs"/>
    /// resolved by <see cref="IContentDialogClosingEventArgsResolver"/>.
    /// </summary>
    public static class ContentDialogClosingEventArgsWrapper
    {
        /// <summary>
        /// Gets or sets the <see cref="IContentDialogClosingEventArgsResolver"/>
        /// that resolves data of the <see cref="ContentDialogClosingEventArgs"/>.
        /// </summary>
        public static IContentDialogClosingEventArgsResolver Resolver { get; set; } = new DefaultContentDialogClosingEventArgsResolver();

        /// <summary>
        /// Gets a value that can cancel the closing of the dialog.
        /// A <c>true</c> value for <see cref="ContentDialogClosingEventArgs.Cancel"/> cancels the default behavior.
        /// </summary>
        /// <param name="e">The requested <see cref="ContentDialogClosingEventArgs"/>.</param>
        /// <returns>
        /// <c>true</c> to cancel the closing of the dialog; otherwise, <c>false</c>.
        /// </returns>
        public static bool Cancel(this ContentDialogClosingEventArgs e) => Resolver.Cancel(e);

        /// <summary>
        /// Sets a value that can cancel the closing of the dialog.
        /// A <c>true</c> value for <see cref="ContentDialogClosingEventArgs.Cancel"/> cancels the default behavior.
        /// </summary>
        /// <param name="e">The requested <see cref="ContentDialogClosingEventArgs"/>.</param>
        /// <param name="cancel">
        /// <c>true</c> to cancel the closing of the dialog; otherwise, <c>false</c>.
        /// </param>
        public static void Cancel(this ContentDialogClosingEventArgs e, bool cancel) => Resolver.Cancel(e, cancel);

        /// <summary>
        /// Gets the <see cref="ContentDialogResult"/> of the closing event.
        /// </summary>
        /// <param name="e">The requested <see cref="ContentDialogClosingEventArgs"/>.</param>
        /// <returns>The <see cref="ContentDialogResult"/> of the closing event.</returns>
        public static ContentDialogResult Result(this ContentDialogClosingEventArgs e) => Resolver.Result(e);

        /// <summary>
        /// Gets a <see cref="ContentDialogClosingDeferral"/> that the app can use to respond
        /// asynchronously to the closing event.
        /// </summary>
        /// <param name="e">The requested <see cref="ContentDialogClosingEventArgs"/>.</param>
        /// <returns>
        /// A <see cref="ContentDialogClosingDeferral"/> that the app can use to respond asynchronously
        /// to the the closing event.
        /// </returns>
        public static ContentDialogClosingDeferral GetDeferral(this ContentDialogClosingEventArgs e) => Resolver.GetDeferral(e);

        private sealed class DefaultContentDialogClosingEventArgsResolver : IContentDialogClosingEventArgsResolver
        {
            bool IContentDialogClosingEventArgsResolver.Cancel(ContentDialogClosingEventArgs e) => e.Cancel;
            void IContentDialogClosingEventArgsResolver.Cancel(ContentDialogClosingEventArgs e, bool cancel) => e.Cancel = cancel;
            ContentDialogResult IContentDialogClosingEventArgsResolver.Result(ContentDialogClosingEventArgs e) => e.Result;
            ContentDialogClosingDeferral IContentDialogClosingEventArgsResolver.GetDeferral(ContentDialogClosingEventArgs e) => e.GetDeferral();
        }
    }

    /// <summary>
    /// Resolves data of the <see cref="ContentDialogClosingEventArgs"/>.
    /// </summary>
    public interface IContentDialogClosingEventArgsResolver
    {
        /// <summary>
        /// Gets a value that can cancel the closing of the dialog.
        /// A <c>true</c> value for <see cref="ContentDialogClosingEventArgs.Cancel"/> cancels the default behavior.
        /// </summary>
        /// <param name="e">The requested <see cref="ContentDialogClosingEventArgs"/>.</param>
        /// <returns>
        /// <c>true</c> to cancel the closing of the dialog; otherwise, <c>false</c>.
        /// </returns>
        bool Cancel(ContentDialogClosingEventArgs e);

        /// <summary>
        /// Sets a value that can cancel the closing of the dialog.
        /// A <c>true</c> value for <see cref="ContentDialogClosingEventArgs.Cancel"/> cancels the default behavior.
        /// </summary>
        /// <param name="e">The requested <see cref="ContentDialogClosingEventArgs"/>.</param>
        /// <param name="cancel">
        /// <c>true</c> to cancel the closing of the dialog; otherwise, <c>false</c>.
        /// </param>
        void Cancel(ContentDialogClosingEventArgs e, bool cancel);

        /// <summary>
        /// Gets the <see cref="ContentDialogResult"/> of the closing event.
        /// </summary>
        /// <param name="e">The requested <see cref="ContentDialogClosingEventArgs"/>.</param>
        /// <returns>The <see cref="ContentDialogResult"/> of the closing event.</returns>
        ContentDialogResult Result(ContentDialogClosingEventArgs e);

        /// <summary>
        /// Gets a <see cref="ContentDialogClosingDeferral"/> that the app can use to respond
        /// asynchronously to the closing event.
        /// </summary>
        /// <param name="e">The requested <see cref="ContentDialogClosingEventArgs"/>.</param>
        /// <returns>
        /// A <see cref="ContentDialogClosingDeferral"/> that the app can use to respond asynchronously
        /// to the the closing event.
        /// </returns>
        ContentDialogClosingDeferral GetDeferral(ContentDialogClosingEventArgs e);
    }
}
