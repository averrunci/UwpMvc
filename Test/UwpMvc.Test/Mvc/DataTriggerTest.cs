// Copyright (C) 2017 Fievus
//
// This software may be modified and distributed under the terms
// of the MIT license.  See the LICENSE file for details.
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Windows.ApplicationModel.Core;
using Windows.UI.Core;
using Windows.UI.Xaml;
using Xunit;

namespace Fievus.Windows.Mvc
{
    public class DataTriggerTest
    {
        public static IEnumerable<object[]> TestData
        {
            get
            {
                yield return new object[] { true, "true", true };
                yield return new object[] { true, "false", false };
                yield return new object[] { (sbyte)1, "1", true };
                yield return new object[] { (sbyte)1, "2", false };
                yield return new object[] { (byte)1, "1", true };
                yield return new object[] { (byte)1, "2", false };
                yield return new object[] { 'a', "a", true };
                yield return new object[] { 'a', "A", false };
                yield return new object[] { (short)1, "1", true };
                yield return new object[] { (short)1, "2", false };
                yield return new object[] { (ushort)1, "1", true };
                yield return new object[] { (ushort)1, "2", false };
                yield return new object[] { 1, "1", true };
                yield return new object[] { 1, "2", false };
                yield return new object[] { 1u, "1", true };
                yield return new object[] { 1u, "2", false };
                yield return new object[] { 1L, "1", true };
                yield return new object[] { 1L, "2", false };
                yield return new object[] { 1ul, "1", true };
                yield return new object[] { 1ul, "2", false };
                yield return new object[] { 1f, "1", true };
                yield return new object[] { 1f, "2", false };
                yield return new object[] { 1d, "1", true };
                yield return new object[] { 1d, "2", false };
                yield return new object[] { 1m, "1", true };
                yield return new object[] { 1m, "2", false };
                yield return new object[] { new DateTime(2017, 1, 2), "2017-1-2", true };
                yield return new object[] { new DateTime(2017, 1, 2), "2017-1-3", false };
                yield return new object[] { Visibility.Collapsed, "Collapsed", true };
                yield return new object[] { Visibility.Collapsed, "Visible", false };
                var data = new object();
                yield return new object[] { data, data, true };
                yield return new object[] { data, new object(), false };
            }
        }

        [Theory]
        [MemberData("TestData")]
        public async Task UpdatesStateTriggerWithSpecifiedDataValueAndTriggerValue(object dataValue, object triggerValue, bool expected)
        {
            await CoreApplication.MainView.Dispatcher.RunAsync(CoreDispatcherPriority.Normal, () =>
            {
                var trigger = new DataTrigger
                {
                    DataValue = dataValue,
                    TriggerValue = triggerValue
                };

                Assert.Equal(expected, trigger.IsActive);
            });
        }
    }
}
