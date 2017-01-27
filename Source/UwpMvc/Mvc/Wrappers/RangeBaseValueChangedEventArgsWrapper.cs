// Copyright (C) 2017 Fievus
//
// This software may be modified and distributed under the terms
// of the MIT license.  See the LICENSE file for details.
using Windows.UI.Xaml.Controls.Primitives;

namespace Fievus.Windows.Mvc.Wrappers
{
    /// <summary>
    /// Provides data of the <see cref="RangeBaseValueChangedEventArgs"/>
    /// resolved by <see cref="IRangeBaseValueChangedEventArgsResolver"/>.
    /// </summary>
    public static class RangeBaseValueChangedEventArgsWrapper
    {
        /// <summary>
        /// Gets or sets the <see cref="IRangeBaseValueChangedEventArgsResolver"/>
        /// that resolves data of the <see cref="RangeBaseValueChangedEventArgs"/>.
        /// </summary>
        public static IRangeBaseValueChangedEventArgsResolver Resolver { get; set; } = new DefaultRangeBaseValueChangedEventArgsResolver();

        /// <summary>
        /// Gets the new value of a range value property.
        /// </summary>
        /// <param name="e">The requested <see cref="RangeBaseValueChangedEventArgs"/>.</param>
        /// <returns>The new value.</returns>
        public static double NewValue(this RangeBaseValueChangedEventArgs e) => Resolver.NewValue(e);

        /// <summary>
        /// Gets the previous value of a range value property.
        /// </summary>
        /// <param name="e">The requested <see cref="RangeBaseValueChangedEventArgs"/>.</param>
        /// <returns>The previous value.</returns>
        public static double OldValue(this RangeBaseValueChangedEventArgs e) => Resolver.OldValue(e);

        /// <summary>
        /// Gets a reference to the object that raised the event.
        /// This is often a template part of a control rather than an element that was declared in your app UI.
        /// </summary>
        /// <param name="e">The requested <see cref="RangeBaseValueChangedEventArgs"/>.</param>
        /// <returns>The object that raised the event.</returns>
        public static object OriginalSource(this RangeBaseValueChangedEventArgs e) => Resolver.OriginalSource(e);

        private sealed class DefaultRangeBaseValueChangedEventArgsResolver : IRangeBaseValueChangedEventArgsResolver
        {
            double IRangeBaseValueChangedEventArgsResolver.NewValue(RangeBaseValueChangedEventArgs e) => e.NewValue;
            double IRangeBaseValueChangedEventArgsResolver.OldValue(RangeBaseValueChangedEventArgs e) => e.OldValue;
            object IRangeBaseValueChangedEventArgsResolver.OriginalSource(RangeBaseValueChangedEventArgs e) => e.OriginalSource;
        }
    }

    /// <summary>
    /// Resolves data of the <see cref="RangeBaseValueChangedEventArgs"/>.
    /// </summary>
    public interface IRangeBaseValueChangedEventArgsResolver
    {
        /// <summary>
        /// Gets the new value of a range value property.
        /// </summary>
        /// <param name="e">The requested <see cref="RangeBaseValueChangedEventArgs"/>.</param>
        /// <returns>The new value.</returns>
        double NewValue(RangeBaseValueChangedEventArgs e);

        /// <summary>
        /// Gets the previous value of a range value property.
        /// </summary>
        /// <param name="e">The requested <see cref="RangeBaseValueChangedEventArgs"/>.</param>
        /// <returns>The previous value.</returns>
        double OldValue(RangeBaseValueChangedEventArgs e);

        /// <summary>
        /// Gets a reference to the object that raised the event.
        /// This is often a template part of a control rather than an element that was declared in your app UI.
        /// </summary>
        /// <param name="e">The requested <see cref="RangeBaseValueChangedEventArgs"/>.</param>
        /// <returns>The object that raised the event.</returns>
        object OriginalSource(RangeBaseValueChangedEventArgs e);
    }
}
