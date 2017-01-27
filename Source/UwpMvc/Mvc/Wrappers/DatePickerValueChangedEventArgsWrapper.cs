// Copyright (C) 2017 Fievus
//
// This software may be modified and distributed under the terms
// of the MIT license.  See the LICENSE file for details.
using System;
using Windows.UI.Xaml.Controls;

namespace Fievus.Windows.Mvc.Wrappers
{
    /// <summary>
    /// Provides data of the <see cref="DatePickerValueChangedEventArgs"/>
    /// resolved by <see cref="IDatePickerValueChangedEventArgsResolver"/>.
    /// </summary>
    public static class DatePickerValueChangedEventArgsWrapper
    {
        /// <summary>
        /// Gets or sets the <see cref="IDatePickerValueChangedEventArgsResolver"/>
        /// that resolves data of the <see cref="DatePickerValueChangedEventArgs"/>.
        /// </summary>
        public static IDatePickerValueChangedEventArgsResolver Resolver { get; set; } = new DefaultDatePickerValueChangedEventArgsResolver();

        /// <summary>
        /// Gets the new date selected in the picker.
        /// </summary>
        /// <param name="e">The requested <see cref="DatePickerValueChangedEventArgs"/>.</param>
        /// <returns>The new date selected in the picker.</returns>
        public static DateTimeOffset NewDate(this DatePickerValueChangedEventArgs e) => Resolver.NewDate(e);

        /// <summary>
        /// Gets the date previously selected in the picker.
        /// </summary>
        /// <param name="e">The requested <see cref="DatePickerValueChangedEventArgs"/>.</param>
        /// <returns>The date previously selected in the picker.</returns>
        public static DateTimeOffset OldDate(this DatePickerValueChangedEventArgs e) => Resolver.OldDate(e);

        private sealed class DefaultDatePickerValueChangedEventArgsResolver : IDatePickerValueChangedEventArgsResolver
        {
            DateTimeOffset IDatePickerValueChangedEventArgsResolver.NewDate(DatePickerValueChangedEventArgs e) => e.NewDate;
            DateTimeOffset IDatePickerValueChangedEventArgsResolver.OldDate(DatePickerValueChangedEventArgs e) => e.OldDate;
        }
    }

    /// <summary>
    /// Resolves data of the <see cref="DatePickerValueChangedEventArgs"/>.
    /// </summary>
    public interface IDatePickerValueChangedEventArgsResolver
    {
        /// <summary>
        /// Gets the new date selected in the picker.
        /// </summary>
        /// <param name="e">The requested <see cref="DatePickerValueChangedEventArgs"/>.</param>
        /// <returns>The new date selected in the picker.</returns>
        DateTimeOffset NewDate(DatePickerValueChangedEventArgs e);

        /// <summary>
        /// Gets the date previously selected in the picker.
        /// </summary>
        /// <param name="e">The requested <see cref="DatePickerValueChangedEventArgs"/>.</param>
        /// <returns>The date previously selected in the picker.</returns>
        DateTimeOffset OldDate(DatePickerValueChangedEventArgs e);
    }
}
