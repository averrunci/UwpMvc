// Copyright (C) 2017 Fievus
//
// This software may be modified and distributed under the terms
// of the MIT license.  See the LICENSE file for details.
using Windows.Foundation;

namespace Fievus.Windows.Mvc.Wrappers
{
    /// <summary>
    /// Provides the <see cref="Deferral"/> operation
    /// resolved by <see cref="IDeferralResolver"/>.
    /// </summary>
    public static class DeferralWrapper
    {
        /// <summary>
        /// Gets or sets the <see cref="IDeferralResolver"/>
        /// that resolves the <see cref="Deferral"/> operation.
        /// </summary>
        public static IDeferralResolver Resolver { get; set; } = new DefaultDeferralResolver();

        /// <summary>
        /// If the <see cref="DeferralCompletedHandler"/> has not yet been invoked,
        /// this will call it and drop the reference to the delegate.
        /// </summary>
        /// <param name="deferral">The requested <see cref="Deferral"/>.</param>
        public static void DisposeWrapped(this Deferral deferral) => Resolver.Dispose(deferral);

        /// <summary>
        /// If the <see cref="DeferralCompletedHandler"/> has not yet been invoked,
        /// this will call it and drop the reference to the delegate.
        /// </summary>
        /// <param name="deferral">The requested <see cref="Deferral"/>.</param>
        public static void CompleteWrapped(this Deferral deferral) => Resolver.Complete(deferral);

        private sealed class DefaultDeferralResolver : IDeferralResolver
        {
            void IDeferralResolver.Dispose(Deferral deferral) => deferral.Dispose();
            void IDeferralResolver.Complete(Deferral deferral) => deferral.Complete();
        }
    }

    /// <summary>
    /// Resolves the <see cref="Deferral"/> operation.
    /// </summary>
    public interface IDeferralResolver
    {
        /// <summary>
        /// If the <see cref="DeferralCompletedHandler"/> has not yet been invoked,
        /// this will call it and drop the reference to the delegate.
        /// </summary>
        /// <param name="deferral">The requested <see cref="Deferral"/>.</param>
        void Dispose(Deferral deferral);

        /// <summary>
        /// If the <see cref="DeferralCompletedHandler"/> has not yet been invoked,
        /// this will call it and drop the reference to the delegate.
        /// </summary>
        /// <param name="deferral">The requested <see cref="Deferral"/>.</param>
        void Complete(Deferral deferral);
    }
}
