// Copyright (C) 2018 Fievus
//
// This software may be modified and distributed under the terms
// of the MIT license.  See the LICENSE file for details.
using Windows.UI.Xaml;

namespace Charites.Windows.Mvc.Wrappers
{
    /// <summary>
    /// Provides data of the <see cref="ExceptionRoutedEventArgs"/>
    /// resolved by <see cref="IExceptionRoutedEventArgsResolver"/>.
    /// </summary>
    public static class ExceptionRoutedEventArgsWrapper
    {
        /// <summary>
        /// Gets or sets the <see cref="IExceptionRoutedEventArgsResolver"/>
        /// that resolves data of the <see cref="ExceptionRoutedEventArgs"/>.
        /// </summary>
        public static IExceptionRoutedEventArgsResolver Resolver { get; set; } = new DefaultExceptionRoutedEventArgsResolver();

        /// <summary>
        /// Gets the message component of the exception, as a string.
        /// </summary>
        /// <param name="e">The requested <see cref="ExceptionRoutedEventArgs"/>.</param>
        /// <returns>The message component of the exception.</returns>
        public static string ErrorMessage(this ExceptionRoutedEventArgs e) => Resolver.ErrorMessage(e);

        /// <summary>
        /// Gets a reference to the object that raised the event.
        /// This is often a template part of a control rather than an element that was declared in your app UI.
        /// </summary>
        /// <param name="e">The requested <see cref="ExceptionRoutedEventArgs"/>.</param>
        /// <returns>The object that raised the event.</returns>
        public static object OriginalSource(this ExceptionRoutedEventArgs e) => Resolver.OriginalSource(e);

        private sealed class DefaultExceptionRoutedEventArgsResolver : IExceptionRoutedEventArgsResolver
        {
            string IExceptionRoutedEventArgsResolver.ErrorMessage(ExceptionRoutedEventArgs e) => e.ErrorMessage;
            object IExceptionRoutedEventArgsResolver.OriginalSource(ExceptionRoutedEventArgs e) => e.OriginalSource;
        }
    }

    /// <summary>
    /// Resolves data of the <see cref="ExceptionRoutedEventArgs"/>.
    /// </summary>
    public interface IExceptionRoutedEventArgsResolver
    {
        /// <summary>
        /// Gets the message component of the exception, as a string.
        /// </summary>
        /// <param name="e">The requested <see cref="ExceptionRoutedEventArgs"/>.</param>
        /// <returns>The message component of the exception.</returns>
        string ErrorMessage(ExceptionRoutedEventArgs e);

        /// <summary>
        /// Gets a reference to the object that raised the event.
        /// This is often a template part of a control rather than an element that was declared in your app UI.
        /// </summary>
        /// <param name="e">The requested <see cref="ExceptionRoutedEventArgs"/>.</param>
        /// <returns>The object that raised the event.</returns>
        object OriginalSource(ExceptionRoutedEventArgs e);
    }
}
