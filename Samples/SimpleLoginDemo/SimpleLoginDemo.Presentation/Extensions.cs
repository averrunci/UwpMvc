// Copyright (C) 2017 Fievus
//
// This software may be modified and distributed under the terms
// of the MIT license.  See the LICENSE file for details.
using System;

namespace Fievus.Windows.Samples.SimpleLoginDemo.Presentation
{
    internal static class Extensions
    {
        public static T RequireNonNull<T>(this T @this) => RequireNonNull(@this, null);

        public static T RequireNonNull<T>(this T @this, string name)
        {
            if (@this == null) { throw new ArgumentNullException(name); }
            return @this;
        }

        public static void IfPresent<T>(this T @this, Action<T> action)
        {
            if (@this != null) { action(@this); }
        }

        public static void IfAbsent<T>(this T @this, Action action)
        {
            if (@this == null) { action(); }
        }
    }
}
