// Copyright (C) 2018 Fievus
//
// This software may be modified and distributed under the terms
// of the MIT license.  See the LICENSE file for details.
using System;

namespace Fievus.Windows.Mvc.Bindings
{
    /// <summary>
    /// Represents an edit content of an editable content.
    /// </summary>
    /// <typeparam name="T">The type of the content.</typeparam>
    public class EditableEditContent<T> : IEditableEditContent<T>
    {
        /// <summary>
        /// Occurs when an edit is completed.
        /// </summary>
        public event EventHandler EditCompleted;

        /// <summary>
        /// Occurs when an edit is canceled.
        /// </summary>
        public event EventHandler EditCanceled;

        /// <summary>
        /// Gets the <see cref="ObservableProperty{T}"/> of a value of the content.
        /// </summary>
        public ObservableProperty<T> Value { get; } = new ObservableProperty<T>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EditableEditContent{T}"/> class.
        /// </summary>
        public EditableEditContent()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EditableEditContent{T}"/> class
        /// with the specified content value.
        /// </summary>
        /// <param name="value">The value of the edit content.</param>
        public EditableEditContent(T value)
        {
            Value.Value = value;
        }

        /// <summary>
        /// Completes an edit of the content.
        /// </summary>
        public void CompleteEdit() => OnEditCompleted(EventArgs.Empty);

        /// <summary>
        /// Cancels an edit of the content.
        /// </summary>
        public void CancelEdit() => OnEditCanceled(EventArgs.Empty);

        /// <summary>
        /// Raises the <see cref="EditCompleted"/> event with the specified event data.
        /// </summary>
        /// <param name="e">The event data.</param>
        protected virtual void OnEditCompleted(EventArgs e) => EditCompleted?.Invoke(this, e);

        /// <summary>
        /// Raises the <see cref="EditCanceled"/> event with the specified event data.
        /// </summary>
        /// <param name="e">The event data.</param>
        protected virtual void OnEditCanceled(EventArgs e) => EditCanceled?.Invoke(this, e);
    }
}
