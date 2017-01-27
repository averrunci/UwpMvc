// Copyright (C) 2017 Fievus
//
// This software may be modified and distributed under the terms
// of the MIT license.  See the LICENSE file for details.
using Windows.Foundation;
using Windows.UI.Xaml.Controls;

namespace Fievus.Windows.Mvc.Wrappers
{
    /// <summary>
    /// Provides data of the <see cref="CalendarViewDayItemChangingEventArgs"/>
    /// resolved by <see cref="ICalendarViewDayItemChangingEventArgsResolver"/>.
    /// </summary>
    public static class CalendarViewDayItemChangingEventArgsWrapper
    {
        /// <summary>
        /// Gets or sets the <see cref="ICalendarViewDayItemChangingEventArgsResolver"/>
        /// that resolves data of the <see cref="CalendarViewDayItemChangingEventArgs"/>.
        /// </summary>
        public static ICalendarViewDayItemChangingEventArgsResolver Resolver { get; set; } = new DefaultCalendarViewDayItemChangingEventArgsResolver();

        /// <summary>
        /// Gets a value that indicates whether this container is in the recycle queue of the <see cref="CalendarView"/>
        /// and is not being used to visualize a calendar item.
        /// </summary>
        /// <param name="e">The requested <see cref="CalendarViewDayItemChangingEventArgs"/>.</param>
        /// <returns>
        /// <c>true</c> if the container is in the recycle queue of the <see cref="CalendarView"/>; otherwise, <c>false</c>.
        /// </returns>
        public static bool InRecycleQueue(this CalendarViewDayItemChangingEventArgs e) => Resolver.InRecycleQueue(e);

        /// <summary>
        /// Gets the calendar day item associated with this container.
        /// </summary>
        /// <param name="e">The requested <see cref="CalendarViewDayItemChangingEventArgs"/>.</param>
        /// <returns>
        /// The <see cref="CalendarViewDayItem"/> associated with this container, or
        /// <c>null</c> if no item is associated with this container.
        /// </returns>
        public static CalendarViewDayItem Item(this CalendarViewDayItemChangingEventArgs e) => Resolver.Item(e);

        /// <summary>
        /// Gets the number of times this container and day item pair has been called.
        /// </summary>
        /// <param name="e">The requested <see cref="CalendarViewDayItemChangingEventArgs"/>.</param>
        /// <returns>The number of times this container and day item pair has been called.</returns>
        public static uint Phase(this CalendarViewDayItemChangingEventArgs e) => Resolver.Phase(e);

        /// <summary>
        /// Registers the event handler to be called again during the next phase.
        /// </summary>
        /// <param name="e">The requested <see cref="CalendarViewDayItemChangingEventArgs"/>.</param>
        /// <param name="callback">The event handler function.</param>
        public static void RegisterUpdateCallbackWrapped(this CalendarViewDayItemChangingEventArgs e, TypedEventHandler<CalendarView, CalendarViewDayItemChangingEventArgs> callback) => Resolver.RegisterUpdateCallback(e, callback);

        /// <summary>
        /// Registers the event handler to be called again during the specified phase.
        /// </summary>
        /// <param name="e">The requested <see cref="CalendarViewDayItemChangingEventArgs"/>.</param>
        /// <param name="callbackPhase">The phase during which the callback should occur.</param>
        /// <param name="callback">The event handler function.</param>
        public static void RegisterUpdateCallback(this CalendarViewDayItemChangingEventArgs e, uint callbackPhase, TypedEventHandler<CalendarView, CalendarViewDayItemChangingEventArgs> callback) => Resolver.RegisterUpdateCallback(e, callbackPhase, callback);

        private sealed class DefaultCalendarViewDayItemChangingEventArgsResolver : ICalendarViewDayItemChangingEventArgsResolver
        {
            bool ICalendarViewDayItemChangingEventArgsResolver.InRecycleQueue(CalendarViewDayItemChangingEventArgs e) => e.InRecycleQueue;
            CalendarViewDayItem ICalendarViewDayItemChangingEventArgsResolver.Item(CalendarViewDayItemChangingEventArgs e) => e.Item;
            uint ICalendarViewDayItemChangingEventArgsResolver.Phase(CalendarViewDayItemChangingEventArgs e) => e.Phase;
            void ICalendarViewDayItemChangingEventArgsResolver.RegisterUpdateCallback(CalendarViewDayItemChangingEventArgs e, TypedEventHandler<CalendarView, CalendarViewDayItemChangingEventArgs> callback) => e.RegisterUpdateCallback(callback);
            void ICalendarViewDayItemChangingEventArgsResolver.RegisterUpdateCallback(CalendarViewDayItemChangingEventArgs e, uint callbackPhase, TypedEventHandler<CalendarView, CalendarViewDayItemChangingEventArgs> callback) => e.RegisterUpdateCallback(callbackPhase, callback);
        }
    }

    /// <summary>
    /// Resolves data of the <see cref="CalendarViewDayItemChangingEventArgs"/>.
    /// </summary>
    public interface ICalendarViewDayItemChangingEventArgsResolver
    {
        /// <summary>
        /// Gets a value that indicates whether this container is in the recycle queue of the <see cref="CalendarView"/>
        /// and is not being used to visualize a calendar item.
        /// </summary>
        /// <param name="e">The requested <see cref="CalendarViewDayItemChangingEventArgs"/>.</param>
        /// <returns>
        /// <c>true</c> if the container is in the recycle queue of the <see cref="CalendarView"/>; otherwise, <c>false</c>.
        /// </returns>
        bool InRecycleQueue(CalendarViewDayItemChangingEventArgs e);

        /// <summary>
        /// Gets the calendar day item associated with this container.
        /// </summary>
        /// <param name="e">The requested <see cref="CalendarViewDayItemChangingEventArgs"/>.</param>
        /// <returns>
        /// The <see cref="CalendarViewDayItem"/> associated with this container, or
        /// <c>null</c> if no item is associated with this container.
        /// </returns>
        CalendarViewDayItem Item(CalendarViewDayItemChangingEventArgs e);

        /// <summary>
        /// Gets the number of times this container and day item pair has been called.
        /// </summary>
        /// <param name="e">The requested <see cref="CalendarViewDayItemChangingEventArgs"/>.</param>
        /// <returns>The number of times this container and day item pair has been called.</returns>
        uint Phase(CalendarViewDayItemChangingEventArgs e);

        /// <summary>
        /// Registers the event handler to be called again during the next phase.
        /// </summary>
        /// <param name="e">The requested <see cref="CalendarViewDayItemChangingEventArgs"/>.</param>
        /// <param name="callback">The event handler function.</param>
        void RegisterUpdateCallback(CalendarViewDayItemChangingEventArgs e, TypedEventHandler<CalendarView, CalendarViewDayItemChangingEventArgs> callback);

        /// <summary>
        /// Registers the event handler to be called again during the specified phase.
        /// </summary>
        /// <param name="e">The requested <see cref="CalendarViewDayItemChangingEventArgs"/>.</param>
        /// <param name="callbackPhase">The phase during which the callback should occur.</param>
        /// <param name="callback">The event handler function.</param>
        void RegisterUpdateCallback(CalendarViewDayItemChangingEventArgs e, uint callbackPhase, TypedEventHandler<CalendarView, CalendarViewDayItemChangingEventArgs> callback);
    }
}
