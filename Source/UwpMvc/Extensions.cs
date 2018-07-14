// Copyright (C) 2018 Fievus
//
// This software may be modified and distributed under the terms
// of the MIT license.  See the LICENSE file for details.
using System;
using System.Collections.Generic;

namespace Charites.Windows
{
    internal static class Extensions
    {
        public static void IfPresent<T>(this T @this, Action<T> action)
        {
            if (@this == null) return;

            action(@this);
        }

        public static void IfAbsent<T>(this T @this, Action action)
        {
            if (@this != null) return;

            action();
        }

        public static void IfTypeOf<T>(this object @this, Action<T> action)
        {
            if (@this == null) return;
            if (!(@this is T)) return;

            action((T)@this);
        }

        public static T RequireNonNull<T>(this T @this, string name)
        {
            if (@this == null) throw new ArgumentNullException(name);
            return @this;
        }

        public static void ForEach<T>(this IEnumerable<T> @this, Action<T> action)
        {
            if (@this == null) return;

            foreach (var item in @this)
            {
                action(item);
            }
        }
    }
}
