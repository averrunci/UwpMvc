// Copyright (C) 2018 Fievus
//
// This software may be modified and distributed under the terms
// of the MIT license.  See the LICENSE file for details.
using System;
using System.Collections.Generic;
using Windows.UI.Xaml.Controls;

namespace Charites.Windows.Mvc.Wrappers
{
    /// <summary>
    /// Provides data of the <see cref="CalendarViewSelectedDatesChangedEventArgs"/>
    /// resolved by <see cref="ICalendarViewSelectedDatesChangedEventArgsResolver"/>.
    /// </summary>
    public static class CalendarViewSelectedDatesChangedEventArgsWrapper
    {
        /// <summary>
        /// Gets or sets the <see cref="ICalendarViewSelectedDatesChangedEventArgsResolver"/>
        /// that resolves data of the <see cref="CalendarViewSelectedDatesChangedEventArgs"/>.
        /// </summary>
        public static ICalendarViewSelectedDatesChangedEventArgsResolver Resolver { get; set; } = new DefaultCalendarViewSelectedDatesChangedEventArgsResolver();

        /// <summary>
        /// Gets a collection that contains the items that were selected.
        /// </summary>
        /// <param name="e">The requested <see cref="CalendarViewSelectedDatesChangedEventArgs"/>.</param>
        /// <returns>
        /// The items that were selected since the last time the <see cref="CalendarView.SelectedDatesChanged"/> event occurred.
        /// </returns>
        public static IReadOnlyList<DateTimeOffset> AddedDates(this CalendarViewSelectedDatesChangedEventArgs e) => Resolver.AddedDates(e);

        /// <summary>
        /// Gets a collection that contains the items that were unselected.
        /// </summary>
        /// <param name="e">The requested <see cref="CalendarViewSelectedDatesChangedEventArgs"/>.</param>
        /// <returns>
        /// The items that were unselected since the last time the <see cref="CalendarView.SelectedDatesChanged"/> event occurred.
        /// </returns>
        public static IReadOnlyList<DateTimeOffset> RemovedDates(this CalendarViewSelectedDatesChangedEventArgs e) => Resolver.RemovedDates(e);

        private sealed class DefaultCalendarViewSelectedDatesChangedEventArgsResolver : ICalendarViewSelectedDatesChangedEventArgsResolver
        {
            IReadOnlyList<DateTimeOffset> ICalendarViewSelectedDatesChangedEventArgsResolver.AddedDates(CalendarViewSelectedDatesChangedEventArgs e) => e.AddedDates;
            IReadOnlyList<DateTimeOffset> ICalendarViewSelectedDatesChangedEventArgsResolver.RemovedDates(CalendarViewSelectedDatesChangedEventArgs e) => e.RemovedDates;
        }
    }

    /// <summary>
    /// Resolves data of the <see cref="CalendarViewSelectedDatesChangedEventArgs"/>.
    /// </summary>
    public interface ICalendarViewSelectedDatesChangedEventArgsResolver
    {
        /// <summary>
        /// Gets a collection that contains the items that were selected.
        /// </summary>
        /// <param name="e">The requested <see cref="CalendarViewSelectedDatesChangedEventArgs"/>.</param>
        /// <returns>
        /// The items that were selected since the last time the <see cref="CalendarView.SelectedDatesChanged"/> event occurred.
        /// </returns>
        IReadOnlyList<DateTimeOffset> AddedDates(CalendarViewSelectedDatesChangedEventArgs e);

        /// <summary>
        /// Gets a collection that contains the items that were unselected.
        /// </summary>
        /// <param name="e">The requested <see cref="CalendarViewSelectedDatesChangedEventArgs"/>.</param>
        /// <returns>
        /// The items that were unselected since the last time the <see cref="CalendarView.SelectedDatesChanged"/> event occurred.
        /// </returns>
        IReadOnlyList<DateTimeOffset> RemovedDates(CalendarViewSelectedDatesChangedEventArgs e);
    }
}
