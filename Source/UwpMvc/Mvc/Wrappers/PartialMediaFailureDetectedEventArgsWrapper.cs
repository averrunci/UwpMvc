// Copyright (C) 2017 Fievus
//
// This software may be modified and distributed under the terms
// of the MIT license.  See the LICENSE file for details.
using System;
using Windows.Media.Playback;
using Windows.UI.Xaml.Media;

namespace Fievus.Windows.Mvc.Wrappers
{
    /// <summary>
    /// Provides data of the <see cref="PartialMediaFailureDetectedEventArgs"/>
    /// resolved by <see cref="IPartialMediaFailureDetectedEventArgsResolver"/>.
    /// </summary>
    public static class PartialMediaFailureDetectedEventArgsWrapper
    {
        /// <summary>
        /// Gets or sets the <see cref="IPartialMediaFailureDetectedEventArgsResolver"/>
        /// that resolves data of the <see cref="PartialMediaFailureDetectedEventArgs"/>.
        /// </summary>
        public static IPartialMediaFailureDetectedEventArgsResolver Resolver { get; set; } = new DefaultPartialMediaFailureDetectedEventArgsResolver();

        /// <summary>
        /// Gets error information for the media failure.
        /// </summary>
        /// <param name="e">The requested <see cref="PartialMediaFailureDetectedEventArgs"/>.</param>
        /// <returns>The error information for the media failure.</returns>
        public static Exception ExtendedError(this PartialMediaFailureDetectedEventArgs e) => Resolver.ExtendedError(e);

        /// <summary>
        /// Gets a value indicating whether the stream that failed to decode contains audio or video.
        /// </summary>
        /// <param name="e">The requested <see cref="PartialMediaFailureDetectedEventArgs"/>.</param>
        /// <returns>A value indicating whether the stream that failed to decode contains audio or video.</returns>
        public static FailedMediaStreamKind StreamKind(this PartialMediaFailureDetectedEventArgs e) => Resolver.StreamKind(e);

        private sealed class DefaultPartialMediaFailureDetectedEventArgsResolver : IPartialMediaFailureDetectedEventArgsResolver
        {
            Exception IPartialMediaFailureDetectedEventArgsResolver.ExtendedError(PartialMediaFailureDetectedEventArgs e) => e.ExtendedError;
            FailedMediaStreamKind IPartialMediaFailureDetectedEventArgsResolver.StreamKind(PartialMediaFailureDetectedEventArgs e) => e.StreamKind;
        }
    }

    /// <summary>
    /// Resolves data of the <see cref="PartialMediaFailureDetectedEventArgs"/>.
    /// </summary>
    public interface IPartialMediaFailureDetectedEventArgsResolver
    {
        /// <summary>
        /// Gets error information for the media failure.
        /// </summary>
        /// <param name="e">The requested <see cref="PartialMediaFailureDetectedEventArgs"/>.</param>
        /// <returns>The error information for the media failure.</returns>
        Exception ExtendedError(PartialMediaFailureDetectedEventArgs e);

        /// <summary>
        /// Gets a value indicating whether the stream that failed to decode contains audio or video.
        /// </summary>
        /// <param name="e">The requested <see cref="PartialMediaFailureDetectedEventArgs"/>.</param>
        /// <returns>A value indicating whether the stream that failed to decode contains audio or video.</returns>
        FailedMediaStreamKind StreamKind(PartialMediaFailureDetectedEventArgs e);
    }
}
