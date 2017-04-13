// Copyright (C) 2017 Fievus
//
// This software may be modified and distributed under the terms
// of the MIT license.  See the LICENSE file for details.
using Windows.ApplicationModel.DataTransfer;
using Windows.UI.Xaml;

namespace Fievus.Windows.Mvc.Wrappers
{
    /// <summary>
    /// Provides data of the <see cref="DropCompletedEventArgs"/>
    /// resolved by <see cref="IDropCompletedEventArgsResolver"/>.
    /// </summary>
    public static class DropCompletedEventArgsWrapper
    {
        /// <summary>
        /// Gets or sets the <see cref="IDropCompletedEventArgsResolver"/>
        /// that resolves data of the <see cref="DropCompletedEventArgs"/>.
        /// </summary>
        public static IDropCompletedEventArgsResolver Resolver { get; set; } = new DefaultDropCompletedEventArgsResolver();

        /// <summary>
        /// Gets a value that indicates the type of drag-and-drop operation, and whether the operation was successful.
        /// </summary>
        /// <param name="e">The requested <see cref="DropCompletedEventArgs"/>.</param>
        /// <returns>
        /// An enumeration value that indicates the type of drag-and-drop operation, and whether the operation was successful.
        /// </returns>
        public static DataPackageOperation DropResult(this DropCompletedEventArgs e) => Resolver.DropResult(e);

        /// <summary>
        /// Gets a reference to the object that raised the event.
        /// This is often a template part of a control rather than an element that was declared in your app UI.
        /// </summary>
        /// <param name="e">The requested <see cref="DropCompletedEventArgs"/>.</param>
        /// <returns>The object that raised the event.</returns>
        public static object OriginalSource(this DropCompletedEventArgs e) => Resolver.OriginalSource(e);

        private sealed class DefaultDropCompletedEventArgsResolver : IDropCompletedEventArgsResolver
        {
            DataPackageOperation IDropCompletedEventArgsResolver.DropResult(DropCompletedEventArgs e) => e.DropResult;
            object IDropCompletedEventArgsResolver.OriginalSource(DropCompletedEventArgs e) => e.OriginalSource;
        }
    }

    /// <summary>
    /// Resolves data of the <see cref="DropCompletedEventArgsWrapper"/>.
    /// </summary>
    public interface IDropCompletedEventArgsResolver
    {
        /// <summary>
        /// Gets a value that indicates the type of drag-and-drop operation, and whether the operation was successful.
        /// </summary>
        /// <param name="e">The requested <see cref="DropCompletedEventArgs"/>.</param>
        /// <returns>
        /// An enumeration value that indicates the type of drag-and-drop operation, and whether the operation was successful.
        /// </returns>
        DataPackageOperation DropResult(DropCompletedEventArgs e);

        /// <summary>
        /// Gets a reference to the object that raised the event.
        /// This is often a template part of a control rather than an element that was declared in your app UI.
        /// </summary>
        /// <param name="e">The requested <see cref="DropCompletedEventArgs"/>.</param>
        /// <returns>The object that raised the event.</returns>
        object OriginalSource(DropCompletedEventArgs e);
    }
}
