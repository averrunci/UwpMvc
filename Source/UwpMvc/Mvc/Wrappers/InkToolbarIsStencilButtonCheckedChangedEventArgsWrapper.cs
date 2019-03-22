// Copyright (C) 2019 Fievus
//
// This software may be modified and distributed under the terms
// of the MIT license.  See the LICENSE file for details.
using Windows.UI.Xaml.Controls;

namespace Charites.Windows.Mvc.Wrappers
{
    /// <summary>
    /// Provides data of the <see cref="InkToolbarIsStencilButtonCheckedChangedEventArgs"/>
    /// resolved by <see cref="IInkToolbarIsStencilButtonCheckedChangedEventArgsResolver"/>.
    /// </summary>
    public static class InkToolbarIsStencilButtonCheckedChangedEventArgsWrapper
    {
        /// <summary>
        /// Gets or sets the <see cref="IInkToolbarIsStencilButtonCheckedChangedEventArgsResolver"/>
        /// that resolves data of the <see cref="InkToolbarIsStencilButtonCheckedChangedEventArgs"/>.
        /// </summary>
        public static IInkToolbarIsStencilButtonCheckedChangedEventArgsResolver Resolver { get; set; } = new DefaultInkToolbarIsStencilButtonCheckedChangedEventArgsResolver();

        /// <summary>
        /// Gets the button for the selected stencil.
        /// </summary>
        /// <param name="e">The requested <see cref="InkToolbarIsStencilButtonCheckedChangedEventArgs"/>.</param>
        /// <returns>The stencil button.</returns>
        public static InkToolbarStencilButton StencilButton(this InkToolbarIsStencilButtonCheckedChangedEventArgs e) => Resolver.StencilButton(e);

        /// <summary>
        /// Gets the type of stencil.
        /// </summary>
        /// <param name="e">The requested <see cref="InkToolbarIsStencilButtonCheckedChangedEventArgs"/>.</param>
        /// <returns>The type of stencil.</returns>
        public static InkToolbarStencilKind StencilKind(this InkToolbarIsStencilButtonCheckedChangedEventArgs e) => Resolver.StencilKind(e);

        private sealed class DefaultInkToolbarIsStencilButtonCheckedChangedEventArgsResolver : IInkToolbarIsStencilButtonCheckedChangedEventArgsResolver
        {
            InkToolbarStencilButton IInkToolbarIsStencilButtonCheckedChangedEventArgsResolver.StencilButton(InkToolbarIsStencilButtonCheckedChangedEventArgs e) => e.StencilButton;
            InkToolbarStencilKind IInkToolbarIsStencilButtonCheckedChangedEventArgsResolver.StencilKind(InkToolbarIsStencilButtonCheckedChangedEventArgs e) => e.StencilKind;
        }
    }

    /// <summary>
    /// Resolves data of the <see cref="InkToolbarIsStencilButtonCheckedChangedEventArgs"/>.
    /// </summary>
    public interface IInkToolbarIsStencilButtonCheckedChangedEventArgsResolver
    {
        /// <summary>
        /// Gets the button for the selected stencil.
        /// </summary>
        /// <param name="e">The requested <see cref="InkToolbarIsStencilButtonCheckedChangedEventArgs"/>.</param>
        /// <returns>The stencil button.</returns>
        InkToolbarStencilButton StencilButton(InkToolbarIsStencilButtonCheckedChangedEventArgs e);

        /// <summary>
        /// Gets the type of stencil.
        /// </summary>
        /// <param name="e">The requested <see cref="InkToolbarIsStencilButtonCheckedChangedEventArgs"/>.</param>
        /// <returns>The type of stencil.</returns>
        InkToolbarStencilKind StencilKind(InkToolbarIsStencilButtonCheckedChangedEventArgs e);
    }
}
