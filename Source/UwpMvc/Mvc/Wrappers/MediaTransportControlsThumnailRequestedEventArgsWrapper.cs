// Copyright (C) 2017 Fievus
//
// This software may be modified and distributed under the terms
// of the MIT license.  See the LICENSE file for details.
using Windows.Foundation;
using Windows.Storage.Streams;
using Windows.UI.Xaml.Media;

namespace Fievus.Windows.Mvc.Wrappers
{
    /// <summary>
    /// Provides data of the <see cref="MediaTransportControlsThumbnailRequestedEventArgs"/>
    /// resolved by <see cref="IMediaTransportControlsThumbnailRequestedEventArgsResolver"/>.
    /// </summary>
    public static class MediaTransportControlsThumbnailRequestedEventArgsWrapper
    {
        /// <summary>
        /// Gets or sets the <see cref="IMediaTransportControlsThumbnailRequestedEventArgsResolver"/>
        /// that resolves data of the <see cref="MediaTransportControlsThumbnailRequestedEventArgs"/>.
        /// </summary>
        public static IMediaTransportControlsThumbnailRequestedEventArgsResolver Resolver { get; set; } = new DefaultMediaTransportControlsThumbnailRequestedEventArgsResolver();

        /// <summary>
        /// Returns a deferral that can be used to defer the completion of the ThumbnailRequested event
        /// while the thumbnail is generated.
        /// </summary>
        /// <param name="e">The requested <see cref="MediaTransportControlsThumbnailRequestedEventArgs"/>.</param>
        /// <returns>A deferral object that you can use to identify when the thumbnail request is complete.</returns>
        public static Deferral GetDeferralWrapped(this MediaTransportControlsThumbnailRequestedEventArgs e) => Resolver.GetDeferral(e);

        /// <summary>
        /// Sets the source of the thumbnail image.
        /// </summary>
        /// <param name="e">The requested <see cref="MediaTransportControlsThumbnailRequestedEventArgs"/>.</param>
        /// <param name="source">The source of the thumbnail image.</param>
        public static void SetThumbnailImageWrapped(this MediaTransportControlsThumbnailRequestedEventArgs e, IInputStream source) => Resolver.SetThumbnailImage(e, source);

        private sealed class DefaultMediaTransportControlsThumbnailRequestedEventArgsResolver : IMediaTransportControlsThumbnailRequestedEventArgsResolver
        {
            Deferral IMediaTransportControlsThumbnailRequestedEventArgsResolver.GetDeferral(MediaTransportControlsThumbnailRequestedEventArgs e) => e.GetDeferral();
            void IMediaTransportControlsThumbnailRequestedEventArgsResolver.SetThumbnailImage(MediaTransportControlsThumbnailRequestedEventArgs e, IInputStream source) => e.SetThumbnailImage(source);
        }
    }

    /// <summary>
    /// Resolves data of the <see cref="MediaTransportControlsThumbnailRequestedEventArgs"/>.
    /// </summary>
    public interface IMediaTransportControlsThumbnailRequestedEventArgsResolver
    {
        /// <summary>
        /// Returns a deferral that can be used to defer the completion of the ThumbnailRequested event
        /// while the thumbnail is generated.
        /// </summary>
        /// <param name="e">The requested <see cref="MediaTransportControlsThumbnailRequestedEventArgs"/>.</param>
        /// <returns>A deferral object that you can use to identify when the thumbnail request is complete.</returns>
        Deferral GetDeferral(MediaTransportControlsThumbnailRequestedEventArgs e);

        /// <summary>
        /// Sets the source of the thumbnail image.
        /// </summary>
        /// <param name="e">The requested <see cref="MediaTransportControlsThumbnailRequestedEventArgs"/>.</param>
        /// <param name="source">The source of the thumbnail image.</param>
        void SetThumbnailImage(MediaTransportControlsThumbnailRequestedEventArgs e, IInputStream source);
    }
}
