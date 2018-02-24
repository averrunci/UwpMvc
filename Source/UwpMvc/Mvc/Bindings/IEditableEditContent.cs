// Copyright (C) 2018 Fievus
//
// This software may be modified and distributed under the terms
// of the MIT license.  See the LICENSE file for details.
using System;

namespace Fievus.Windows.Mvc.Bindings
{
    /// <summary>
    /// Provides an edit content of an editable content.
    /// </summary>
    public interface IEditableEditContent
    {
        /// <summary>
        /// Occurs when an edit is completed.
        /// </summary>
        event EventHandler EditCompleted;

        /// <summary>
        /// Occurs when an edit is canceled.
        /// </summary>
        event EventHandler EditCanceled;

        /// <summary>
        /// Completes an edit of the content.
        /// </summary>
        void CompleteEdit();

        /// <summary>
        /// Cancels an edit of the content.
        /// </summary>
        void CancelEdit();
    }

    /// <summary>
    /// Provides an edit content of an editable content.
    /// </summary>
    /// <typeparam name="T">The type of the content.</typeparam>
    public interface IEditableEditContent<T> : IEditableEditContent, IEditableContent<T>
    {
    }
}
