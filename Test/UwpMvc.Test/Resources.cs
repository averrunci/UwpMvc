// Copyright (C) 2017 Fievus
//
// This software may be modified and distributed under the terms
// of the MIT license.  See the LICENSE file for details.

using Windows.ApplicationModel.Resources;

namespace Fievus.Windows
{
    public static class Resources
    {
        //private static ResourceLoader Loader { get; } = ResourceLoader.GetForCurrentView();

        public static string LocalizablePropertyName => ResourceLoader.GetForCurrentView().GetString("LocalizablePropertyName");
        public static string StringLengthErrorMessage => ResourceLoader.GetForCurrentView().GetString("StringLengthErrorMessage");
    }
}
