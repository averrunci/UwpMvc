// Copyright (C) 2018 Fievus
//
// This software may be modified and distributed under the terms
// of the MIT license.  See the LICENSE file for details.
using Windows.UI.Xaml;

namespace Charites.Windows.Mvc.Wrappers
{
    /// <summary>
    /// Provides data of the <see cref="DependencyPropertyChangedEventArgs"/>
    /// resolved by <see cref="IDependencyPropertyChangedEventArgsResolver"/>.
    /// </summary>
    public static class DependencyPropertyChangedEventArgsWrapper
    {
        /// <summary>
        /// Gets or sets the <see cref="IDependencyPropertyChangedEventArgsResolver"/>
        /// that resolves data of the <see cref="DependencyPropertyChangedEventArgs"/>.
        /// </summary>
        public static IDependencyPropertyChangedEventArgsResolver Resolver { get; set; } = new DefaultDependencyPropertyChangedEventArgsResolver();

        /// <summary>
        /// Gets the value of the dependency property after the reported change.
        /// </summary>
        /// <param name="e">The requested <see cref="DependencyPropertyChangedEventArgs"/>.</param>
        /// <returns>The dependency property value after the change.</returns>
        public static object NewValue(this DependencyPropertyChangedEventArgs e) => Resolver.NewValue(e);

        /// <summary>
        /// Gets the value of the dependency property before the reported change.
        /// </summary>
        /// <param name="e">The requested <see cref="DependencyPropertyChangedEventArgs"/>.</param>
        /// <returns>The dependency property value before the change.</returns>
        public static object OldValue(this DependencyPropertyChangedEventArgs e) => Resolver.OldValue(e);

        /// <summary>
        /// Gets the identifier for the dependency property where the value change occurred.
        /// </summary>
        /// <param name="e">The requested <see cref="DependencyPropertyChangedEventArgs"/>.</param>
        /// <returns>The identifier field of the dependency property where the value change occurred.</returns>
        public static DependencyProperty Property(this DependencyPropertyChangedEventArgs e) => Resolver.Property(e);

        private sealed class DefaultDependencyPropertyChangedEventArgsResolver : IDependencyPropertyChangedEventArgsResolver
        {
            object IDependencyPropertyChangedEventArgsResolver.NewValue(DependencyPropertyChangedEventArgs e) => e.NewValue;
            object IDependencyPropertyChangedEventArgsResolver.OldValue(DependencyPropertyChangedEventArgs e) => e.OldValue;
            DependencyProperty IDependencyPropertyChangedEventArgsResolver.Property(DependencyPropertyChangedEventArgs e) => e.Property;
        }
    }

    /// <summary>
    /// Resolves data of the <see cref="DependencyPropertyChangedEventArgs"/>.
    /// </summary>
    public interface IDependencyPropertyChangedEventArgsResolver
    {
        /// <summary>
        /// Gets the value of the dependency property after the reported change.
        /// </summary>
        /// <param name="e">The requested <see cref="DependencyPropertyChangedEventArgs"/>.</param>
        /// <returns>The dependency property value after the change.</returns>
        object NewValue(DependencyPropertyChangedEventArgs e);

        /// <summary>
        /// Gets the value of the dependency property before the reported change.
        /// </summary>
        /// <param name="e">The requested <see cref="DependencyPropertyChangedEventArgs"/>.</param>
        /// <returns>The dependency property value before the change.</returns>
        object OldValue(DependencyPropertyChangedEventArgs e);

        /// <summary>
        /// Gets the identifier for the dependency property where the value change occurred.
        /// </summary>
        /// <param name="e">The requested <see cref="DependencyPropertyChangedEventArgs"/>.</param>
        /// <returns>The identifier field of the dependency property where the value change occurred.</returns>
        DependencyProperty Property(DependencyPropertyChangedEventArgs e);
    }
}
