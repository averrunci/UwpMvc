// Copyright (C) 2017 Fievus
//
// This software may be modified and distributed under the terms
// of the MIT license.  See the LICENSE file for details.
using System;
using Windows.ApplicationModel.Resources;

namespace Fievus.Windows.Samples.SimpleLoginDemo.Presentation.Home
{
    public class HomeContent
    {
        public event EventHandler LogoutRequested;

        public string Id { get; }

        public string Message { get; }

        public HomeContent(string id)
        {
            Id = id;
            Message = string.Format(ResourceLoader.GetForCurrentView("SimpleLoginDemo.Presentation/Resources").GetString("UserMessageFormat"), Id);
        }

        public void Logout()
        {
            OnLogoutRequested(EventArgs.Empty);
        }

        protected virtual void OnLogoutRequested(EventArgs e) => LogoutRequested?.Invoke(this, e);
    }
}
