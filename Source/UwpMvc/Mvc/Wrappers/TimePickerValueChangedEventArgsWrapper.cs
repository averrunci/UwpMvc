// Copyright (C) 2018 Fievus
//
// This software may be modified and distributed under the terms
// of the MIT license.  See the LICENSE file for details.
using System;
using Windows.UI.Xaml.Controls;

namespace Charites.Windows.Mvc.Wrappers
{
    /// <summary>
    /// Provides data of the <see cref="TimePickerValueChangedEventArgs"/>
    /// resolved by <see cref="ITimePickerValueChangedEventArgsResolver"/>.
    /// </summary>
    public static class TimePickerValueChangedEventArgsWrapper
    {
        /// <summary>
        /// Gets or sets the <see cref="ITimePickerValueChangedEventArgsResolver"/>
        /// that resolves data of the <see cref="TimePickerValueChangedEventArgs"/>.
        /// </summary>
        public static ITimePickerValueChangedEventArgsResolver Resolver { get; set; } = new DefaultTimePickerValueChangedEventArgsResolver();

        /// <summary>
        /// Gets the new time selected in the picker.
        /// </summary>
        /// <param name="e">The requested <see cref="TimePickerValueChangedEventArgs"/>.</param>
        /// <returns>The new time selected in the picker.</returns>
        public static TimeSpan NewTime(this TimePickerValueChangedEventArgs e) => Resolver.NewTime(e);

        /// <summary>
        /// Gets the time previously selected in the picker.
        /// </summary>
        /// <param name="e">The requested <see cref="TimePickerValueChangedEventArgs"/>.</param>
        /// <returns>The time previously selected in the picker.</returns>
        public static TimeSpan OldTime(this TimePickerValueChangedEventArgs e) => Resolver.OldTime(e);

        private sealed class DefaultTimePickerValueChangedEventArgsResolver : ITimePickerValueChangedEventArgsResolver
        {
            TimeSpan ITimePickerValueChangedEventArgsResolver.NewTime(TimePickerValueChangedEventArgs e) => e.NewTime;
            TimeSpan ITimePickerValueChangedEventArgsResolver.OldTime(TimePickerValueChangedEventArgs e) => e.OldTime;
        }
    }

    /// <summary>
    /// Resolves data of the <see cref="TimePickerValueChangedEventArgs"/>.
    /// </summary>
    public interface ITimePickerValueChangedEventArgsResolver
    {
        /// <summary>
        /// Gets the new time selected in the picker.
        /// </summary>
        /// <param name="e">The requested <see cref="TimePickerValueChangedEventArgs"/>.</param>
        /// <returns>The new time selected in the picker.</returns>
        TimeSpan NewTime(TimePickerValueChangedEventArgs e);

        /// <summary>
        /// Gets the time previously selected in the picker.
        /// </summary>
        /// <param name="e">The requested <see cref="TimePickerValueChangedEventArgs"/>.</param>
        /// <returns>The time previously selected in the picker.</returns>
        TimeSpan OldTime(TimePickerValueChangedEventArgs e);
    }
}
