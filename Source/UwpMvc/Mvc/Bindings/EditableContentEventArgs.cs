// Copyright (C) 2018 Fievus
//
// This software may be modified and distributed under the terms
// of the MIT license.  See the LICENSE file for details.
using System;

namespace Fievus.Windows.Mvc.Bindings
{
    /// <summary>
    /// Represents the method that handles the <see cref="EditableContentProperty{T}.EditStarted"/>,
    /// the <see cref="EditableContentProperty{T}.EditCompleted"/>, and
    /// the <see cref="EditableContentProperty{T}.EditCanceled"/> events
    /// raised when an edit is started, completed, or canceled.
    /// </summary>
    /// <typeparam name="T">The type of the content.</typeparam>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">A <see cref="EditableContentEventArgs{T}"/> that contains the event data.</param>
    public delegate void EditableContentEventHandler<T>(object sender, EditableContentEventArgs<T> e);

    /// <summary>
    /// Provides the data of the <see cref="EditableContentProperty{T}.EditStarted"/>,
    /// the <see cref="EditableContentProperty{T}.EditCompleted"/>, and
    /// the <see cref="EditableContentProperty{T}.EditCanceled"/> events.
    /// </summary>
    /// <typeparam name="T">The type of the content.</typeparam>
    public class EditableContentEventArgs<T> : EventArgs
    {
        /// <summary>
        /// Gets the display content.
        /// </summary>
        public T DisplayContent { get; }

        /// <summary>
        /// Gets the edit content.
        /// </summary>
        public T EditContent { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="EditableContentEventArgs{T}"/> class
        /// with the specified display content and edit content.
        /// </summary>
        /// <param name="displayContent">The display content.</param>
        /// <param name="editContent">The edit content.</param>
        public EditableContentEventArgs(T displayContent, T editContent)
        {
            DisplayContent = displayContent;
            EditContent = editContent;
        }
    }
}
