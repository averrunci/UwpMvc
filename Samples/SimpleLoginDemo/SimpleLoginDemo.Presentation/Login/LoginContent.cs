// Copyright (C) 2018 Fievus
//
// This software may be modified and distributed under the terms
// of the MIT license.  See the LICENSE file for details.
using System;
using System.ComponentModel.DataAnnotations;
using Charites.Windows.Mvc.Bindings;

namespace Charites.Windows.Samples.SimpleLoginDemo.Presentation.Login
{
    public class LoginContent
    {
        public event EventHandler LoginRequested;

        [Display(Name = "User ID")]
        [Required]
        public ObservableProperty<string> UserId { get; } = string.Empty.ToObservableProperty();

        [Display(Name = "Password")]
        [Required]
        public ObservableProperty<string> Password { get; } = string.Empty.ToObservableProperty();

        public ObservableProperty<string> Message { get; } = string.Empty.ToObservableProperty();

        public ObservableProperty<bool> IsValid { get; } = false.ToObservableProperty();

        public LoginContent()
        {
            UserId.EnableValidation(() => UserId);
            Password.EnableValidation(() => Password);

            UserId.PropertyValueChanged += (s, e) => IsValid.Value = Validate();
            Password.PropertyValueChanged += (s, e) => IsValid.Value = Validate();
        }

        private bool Validate()
        {
            UserId.EnsureValidation();
            Password.EnsureValidation();
            return !UserId.HasErrors && !Password.HasErrors;
        }

        public void Login()
        {
            if (!IsValid.Value) { return; }

            OnLoginRequested(EventArgs.Empty);
        }

        protected virtual void OnLoginRequested(EventArgs e) => LoginRequested?.Invoke(this, e);
    }
}
