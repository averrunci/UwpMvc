// Copyright (C) 2019 Fievus
//
// This software may be modified and distributed under the terms
// of the MIT license.  See the LICENSE file for details.
using Windows.UI;
using Windows.UI.Xaml.Controls;

namespace Charites.Windows.Mvc.Wrappers
{
    /// <summary>
    /// Provides data of the <see cref="ColorChangedEventArgs"/>
    /// resolved by <see cref="IColorChangedEventArgsResolver"/>.
    /// </summary>
    public static class ColorChangedEventArgsWrapper
    {
        /// <summary>
        /// Gets or sets the <see cref="IColorChangedEventArgsResolver"/>
        /// that resolves data of the <see cref="ColorChangedEventArgs"/>.
        /// </summary>
        public static IColorChangedEventArgsResolver Resolver { get; set; } = new DefaultColorChangedEventArgsResolver();

        /// <summary>
        /// Gets the color that is currently selected in the control.
        /// </summary>
        /// <param name="e">The requested <see cref="ColorChangedEventArgs"/>.</param>
        /// <returns>The color that is currently selected in the control.</returns>
        public static Color NewColor(this ColorChangedEventArgs e) => Resolver.NewColor(e);

        /// <summary>
        /// Gets the color that was previously selected in the control.
        /// </summary>
        /// <param name="e">The requested <see cref="ColorChangedEventArgs"/>.</param>
        /// <returns>The color that was previously selected in the control.</returns>
        public static Color OldColor(this ColorChangedEventArgs e) => Resolver.OldColor(e);

        private sealed class DefaultColorChangedEventArgsResolver : IColorChangedEventArgsResolver
        {
            Color IColorChangedEventArgsResolver.NewColor(ColorChangedEventArgs e) => e.NewColor;
            Color IColorChangedEventArgsResolver.OldColor(ColorChangedEventArgs e) => e.OldColor;
        }
    }

    /// <summary>
    /// Resolves data of the <see cref="ColorChangedEventArgs"/>.
    /// </summary>
    public interface IColorChangedEventArgsResolver
    {
        /// <summary>
        /// Gets the color that is currently selected in the control.
        /// </summary>
        /// <param name="e">The requested <see cref="ColorChangedEventArgs"/>.</param>
        /// <returns>The color that is currently selected in the control.</returns>
        Color NewColor(ColorChangedEventArgs e);

        /// <summary>
        /// Gets the color that was previously selected in the control.
        /// </summary>
        /// <param name="e">The requested <see cref="ColorChangedEventArgs"/>.</param>
        /// <returns>The color that was previously selected in the control.</returns>
        Color OldColor(ColorChangedEventArgs e);
    }
}
