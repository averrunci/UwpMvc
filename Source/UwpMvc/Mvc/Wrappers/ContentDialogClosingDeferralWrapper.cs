// Copyright (C) 2018 Fievus
//
// This software may be modified and distributed under the terms
// of the MIT license.  See the LICENSE file for details.
using Windows.UI.Xaml.Controls;

namespace Charites.Windows.Mvc.Wrappers
{
    /// <summary>
    /// Provides data of the <see cref="ContentDialogClosingDeferral"/>
    /// resolved by <see cref="IContentDialogClosingDeferralResolver"/>.
    /// </summary>
    public static class ContentDialogClosingDeferralWrapper
    {
        /// <summary>
        /// Gets or sets the <see cref="IContentDialogClosingDeferralResolver"/>
        /// that resolves data of the <see cref="ContentDialogClosingDeferral"/>.
        /// </summary>
        public static IContentDialogClosingDeferralResolver Resolver { get; set; } = new DefaultContentDialogClosingDeferralResolver();

        /// <summary>
        /// Notifies the system that the app has finished processing the closing event.
        /// </summary>
        /// <param name="deferral">The requested <see cref="ContentDialogClosingDeferral"/>.</param>
        public static void Complete(this ContentDialogClosingDeferral deferral) => Resolver.Complete(deferral);

        private sealed class DefaultContentDialogClosingDeferralResolver : IContentDialogClosingDeferralResolver
        {
            void IContentDialogClosingDeferralResolver.Complete(ContentDialogClosingDeferral deferral) => deferral.Complete();
        }
    }

    /// <summary>
    /// Resolves data of the <see cref="ContentDialogClosingDeferral"/>.
    /// </summary>
    public interface IContentDialogClosingDeferralResolver
    {
        /// <summary>
        /// Notifies the system that the app has finished processing the closing event.
        /// </summary>
        /// <param name="deferral">The requested <see cref="ContentDialogClosingDeferral"/>.</param>
        void Complete(ContentDialogClosingDeferral deferral);
    }
}
