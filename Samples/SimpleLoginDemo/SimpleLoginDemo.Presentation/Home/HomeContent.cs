// Copyright (C) 2018-2021 Fievus
//
// This software may be modified and distributed under the terms
// of the MIT license.  See the LICENSE file for details.
namespace Charites.Windows.Samples.SimpleLoginDemo.Presentation.Home
{
    public class HomeContent
    {
        public string Id { get; }

        public string Message { get; }

        public HomeContent(string id)
        {
            Id = id;
            Message = string.Format(Resources.UserMessageFormat, Id);
        }
    }
}
