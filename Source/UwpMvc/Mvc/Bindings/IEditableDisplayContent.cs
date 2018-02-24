// Copyright (C) 2018 Fievus
//
// This software may be modified and distributed under the terms
// of the MIT license.  See the LICENSE file for details.
using System;

namespace Fievus.Windows.Mvc.Bindings
{
    /// <summary>
    /// Provides a display content of an editable content.
    /// </summary>
    public interface IEditableDisplayContent
    {
        /// <summary>
        /// Occurs when an edit is started.
        /// </summary>
        event EventHandler EditStarted;

        /// <summary>
        /// Gets the <see cref="ObservableProperty{T}"/> of a value that indicates whether the content is editable.
        /// </summary>
        ObservableProperty<bool> IsEditable { get; }

        /// <summary>
        /// Starts an edit of the content.
        /// </summary>
        void StartEdit();
    }

    /// <summary>
    /// Provides a display content of an editable content.
    /// </summary>
    /// <typeparam name="T">The type of the content.</typeparam>
    public interface IEditableDisplayContent<T> : IEditableDisplayContent, IEditableContent<T>
    {
    }
}