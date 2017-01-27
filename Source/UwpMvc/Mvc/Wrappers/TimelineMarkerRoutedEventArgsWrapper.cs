// Copyright (C) 2017 Fievus
//
// This software may be modified and distributed under the terms
// of the MIT license.  See the LICENSE file for details.
using Windows.UI.Xaml.Media;

namespace Fievus.Windows.Mvc.Wrappers
{
    /// <summary>
    /// Provides data of the <see cref="TimelineMarkerRoutedEventArgs"/>
    /// resolved by <see cref="ITimelineMarkerRoutedEventArgsResolver"/>.
    /// </summary>
    public static class TimelineMarkerRoutedEventArgsWrapper
    {
        /// <summary>
        /// Gets or sets the <see cref="ITimelineMarkerRoutedEventArgsResolver"/>
        /// that resolves data of the <see cref="TimelineMarkerRoutedEventArgs"/>.
        /// </summary>
        public static ITimelineMarkerRoutedEventArgsResolver Resolver { get; set; } = new DefaultTimelineMarkerRoutedEventArgsResolver();

        /// <summary>
        /// Gets the <see cref="TimelineMarker"/> that triggered this event.
        /// </summary>
        /// <param name="e">The requested <see cref="TimelineMarkerRoutedEventArgs"/>.</param>
        /// <returns>The <see cref="TimelineMarker"/> that triggered this event.</returns>
        public static TimelineMarker Marker(this TimelineMarkerRoutedEventArgs e) => Resolver.Marker(e);

        /// <summary>
        /// Gets a reference to the object that raised the event.
        /// This is often a template part of a control rather than an element that was declared in your app UI.
        /// </summary>
        /// <param name="e">The requested <see cref="TimelineMarkerRoutedEventArgs"/>.</param>
        /// <returns>The object that raised the event.</returns>
        public static object OriginalSource(this TimelineMarkerRoutedEventArgs e) => Resolver.OriginalSource(e);

        private sealed class DefaultTimelineMarkerRoutedEventArgsResolver : ITimelineMarkerRoutedEventArgsResolver
        {
            TimelineMarker ITimelineMarkerRoutedEventArgsResolver.Marker(TimelineMarkerRoutedEventArgs e) => e.Marker;
            object ITimelineMarkerRoutedEventArgsResolver.OriginalSource(TimelineMarkerRoutedEventArgs e) => e.OriginalSource;
        }
    }

    /// <summary>
    /// Resolves data of the <see cref="TimelineMarkerRoutedEventArgs"/>.
    /// </summary>
    public interface ITimelineMarkerRoutedEventArgsResolver
    {
        /// <summary>
        /// Gets the <see cref="TimelineMarker"/> that triggered this event.
        /// </summary>
        /// <param name="e">The requested <see cref="TimelineMarkerRoutedEventArgs"/>.</param>
        /// <returns>The <see cref="TimelineMarker"/> that triggered this event.</returns>
        TimelineMarker Marker(TimelineMarkerRoutedEventArgs e);

        /// <summary>
        /// Gets a reference to the object that raised the event.
        /// This is often a template part of a control rather than an element that was declared in your app UI.
        /// </summary>
        /// <param name="e">The requested <see cref="TimelineMarkerRoutedEventArgs"/>.</param>
        /// <returns>The object that raised the event.</returns>
        object OriginalSource(TimelineMarkerRoutedEventArgs e);
    }
}
