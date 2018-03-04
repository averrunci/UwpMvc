// Copyright (C) 2018 Fievus
//
// This software may be modified and distributed under the terms
// of the MIT license.  See the LICENSE file for details.
using System;

namespace Fievus.Windows.Mvc.Bindings
{
    /// <summary>
    /// Represents a property of a text that can be edited with a dedicated content.
    /// </summary>
    public class EditableTextProperty : EditableContentProperty<string>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EditableTextProperty"/> class.
        /// </summary>
        public EditableTextProperty() : this(string.Empty, null, false)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EditableTextProperty"/> class
        /// with the specified initial text value.
        /// </summary>
        /// <param name="initialValue">The initial text value.</param>
        public EditableTextProperty(string initialValue) : this(initialValue, null, false)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EditableTextProperty"/> class
        /// with the specified validator that validates the text.
        /// </summary>
        /// <param name="validator">The function to validate the text.</param>
        public EditableTextProperty(Func<string, bool> validator) : this(string.Empty, validator, false)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EditableTextProperty"/> class
        /// with the specified value that indicates whether the text is multiline.
        /// </summary>
        /// <param name="multiline">
        /// <c>true</c> if the text is multiline; otherwise, <c>false</c>.
        /// </param>
        public EditableTextProperty(bool multiline) : this(string.Empty, null, multiline)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EditableTextProperty"/> class
        /// with the specified initial text value and validator that validates the text.
        /// </summary>
        /// <param name="initialValue">The initial text value.</param>
        /// <param name="validator">The function to validate the text.</param>
        public EditableTextProperty(string initialValue, Func<string, bool> validator) : this(initialValue, validator, false)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EditableTextProperty"/> class
        /// with the specified initial text value and value that indicates whether the text is multiline.
        /// </summary>
        /// <param name="initialValue">The initial text value.</param>
        /// <param name="multiline">
        /// <c>true</c> if the text is multiline; otherwise, <c>false</c>.
        /// </param>
        public EditableTextProperty(string initialValue, bool multiline) : this(initialValue, null, multiline)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EditableTextProperty"/> class
        /// with the specified validator that validates the text and value
        /// that indicates whether the text is multiline.
        /// </summary>
        /// <param name="validator">The function to validate the text.</param>
        /// <param name="multiline">
        /// <c>true</c> if the text is multiline; otherwise, <c>false</c>.
        /// </param>
        public EditableTextProperty(Func<string, bool> validator, bool multiline) : this(string.Empty, validator, multiline)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EditableTextProperty"/> class
        /// with the specified initial text value, validator that validates the text, and
        /// value that indicates whether the text is multiline.
        /// </summary>
        /// <param name="initialValue">The initial text value.</param>
        /// <param name="validator">The function to validate the text.</param>
        /// <param name="multiline">
        /// <c>true</c> if the text is multiline; otherwise, <c>false</c>.
        /// </param>
        public EditableTextProperty(string initialValue, Func<string, bool> validator, bool multiline) : base(new EditableDisplayContent<string>(initialValue), new EditableEditText(validator, multiline))
        {
        }

        /// <summary>
        /// Sets the value from the display content to the edit content and
        /// raises the <see cref="EditableContentProperty{T}.EditStarted"/> event with the specified event data.
        /// </summary>
        /// <param name="e">The event data.</param>
        protected override void OnEditStarted(EditableContentEventArgs<string> e)
        {
            EditContent.Value.Value = DisplayContent.Value.Value;

            base.OnEditStarted(e);
        }

        /// <summary>
        /// Sets the value from the edit content to the display content and
        /// raises the <see cref="EditableContentProperty{T}.EditCompleted"/> event with the specified event data.
        /// </summary>
        /// <param name="e">The event data.</param>
        protected override void OnEditCompleted(EditableContentEventArgs<string> e)
        {
            DisplayContent.Value.Value = EditContent.Value.Value;

            base.OnEditCompleted(e);
        }
    }

    /// <summary>
    /// Provides extension methods of <see cref="EditableTextProperty"/>.
    /// </summary>
    public static class EditableTextPropertyExtensions
    {
        /// <summary>
        /// Converts the text value to the editable text property.
        /// </summary>
        /// <param name="value">The text value that is converted to the editable text property.</param>
        /// <returns>The instance of the <see cref="EditableTextProperty"/> class.</returns>
        public static EditableTextProperty ToEditableTextProperty(this string value)
            => new EditableTextProperty(value);

        /// <summary>
        /// Converts the text value to the editable text property with the specified validator
        /// that validates the text.
        /// </summary>
        /// <param name="value">The text value that is converted to the editable text property.</param>
        /// <param name="validator">The function to validate the text.</param>
        /// <returns>The instance of the <see cref="EditableTextProperty"/> class.</returns>
        public static EditableTextProperty ToEditableTextProperty(this string value, Func<string, bool> validator)
            => new EditableTextProperty(value, validator);

        /// <summary>
        /// Converts the text value to the editable text property with the specified value that
        /// indicates whether the text is multiline.
        /// </summary>
        /// <param name="value">The text value that is converted to the editable text property.</param>
        /// <param name="multiline">
        /// <c>true</c> if the text is multiline; otherwise, <c>false</c>.
        /// </param>
        /// <returns>The instance of the <see cref="EditableTextProperty"/> class.</returns>
        public static EditableTextProperty ToEditableTextProperty(this string value, bool multiline)
            => new EditableTextProperty(value, multiline);

        /// <summary>
        /// Converts the text value to the editable text property with the specified validator
        /// that validates the text and value that indicates whether the text is multiline.
        /// </summary>
        /// <param name="value">The text value that is converted to the editable text property.</param>
        /// <param name="validator">The function to validate the text.</param>
        /// <param name="multiline">
        /// <c>true</c> if the text is multiline; otherwise, <c>false</c>.
        /// </param>
        /// <returns>The instance of the <see cref="EditableTextProperty"/> class.</returns>
        public static EditableTextProperty ToEditableTextProperty(this string value, Func<string, bool> validator, bool multiline)
            => new EditableTextProperty(value, validator, multiline);
    }
}
