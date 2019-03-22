// Copyright (C) 2019 Fievus
//
// This software may be modified and distributed under the terms
// of the MIT license.  See the LICENSE file for details.
using System;
using Windows.UI.Xaml.Controls;

namespace Charites.Windows.Mvc.Wrappers
{
    /// <summary>
    /// Provides data of the <see cref="TimePickerSelectedValueChangedEventArgs"/>
    /// resolved by <see cref="ITimePickerSelectedValueChangedEventArgsResolver"/>.
    /// </summary>
    public static class TimePickerSelectedValueChangedEventArgsWrapper
    {
        /// <summary>
        /// Gets or sets the <see cref="ITimePickerSelectedValueChangedEventArgsResolver"/>
        /// that resolves data of the <see cref="TimePickerSelectedValueChangedEventArgs"/>.
        /// </summary>
        public static ITimePickerSelectedValueChangedEventArgsResolver Resolver { get; set; } = new DefaultTimePickerSelectedValueChangedEventArgsResolver();

        /// <summary>
        /// Gets the new time selected in the picker.
        /// </summary>
        /// <param name="e">The requested <see cref="TimePickerSelectedValueChangedEventArgs"/>.</param>
        /// <returns>The new time selected in the picker.</returns>
        public static TimeSpan? NewTime(this TimePickerSelectedValueChangedEventArgs e) => e.NewTime;

        /// <summary>
        /// Gets the time previously selected in the picker.
        /// </summary>
        /// <param name="e">The requested <see cref="TimePickerSelectedValueChangedEventArgs"/>.</param>
        /// <returns>The time previously selected in the picker.</returns>
        public static TimeSpan? OldTime(this TimePickerSelectedValueChangedEventArgs e) => e.OldTime;

        private sealed class DefaultTimePickerSelectedValueChangedEventArgsResolver : ITimePickerSelectedValueChangedEventArgsResolver
        {
            TimeSpan? ITimePickerSelectedValueChangedEventArgsResolver.NewTime(TimePickerSelectedValueChangedEventArgs e) => e.NewTime;
            TimeSpan? ITimePickerSelectedValueChangedEventArgsResolver.OldTime(TimePickerSelectedValueChangedEventArgs e) => e.OldTime;
        }
    }

    /// <summary>
    /// Resolves data of the <see cref="TimePickerSelectedValueChangedEventArgs"/>.
    /// </summary>
    public interface ITimePickerSelectedValueChangedEventArgsResolver
    {
        /// <summary>
        /// Gets the new time selected in the picker.
        /// </summary>
        /// <param name="e">The requested <see cref="TimePickerSelectedValueChangedEventArgs"/>.</param>
        /// <returns>The new time selected in the picker.</returns>
        TimeSpan? NewTime(TimePickerSelectedValueChangedEventArgs e);

        /// <summary>
        /// Gets the time previously selected in the picker.
        /// </summary>
        /// <param name="e">The requested <see cref="TimePickerSelectedValueChangedEventArgs"/>.</param>
        /// <returns>The time previously selected in the picker.</returns>
        TimeSpan? OldTime(TimePickerSelectedValueChangedEventArgs e);
    }
}
