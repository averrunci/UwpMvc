// Copyright (C) 2018 Fievus
//
// This software may be modified and distributed under the terms
// of the MIT license.  See the LICENSE file for details.
using System;
using System.Collections;
using System.Threading.Tasks;
using Windows.UI.Xaml;
using Carna;

namespace Charites.Windows.Mvc
{
    [Specification("DataTrigger Spec")]
    class DataTriggerSpec : DispatcherContext
    {
        [Example("Updates States when a data value and a trigger value is set")]
        [Sample(Source = typeof(DataTriggerSpecSampleDataSource))]
        async Task Ex01(object dataValue, object triggerValue, bool expectedIsActive)
        {
            await RunAsync(() =>
            {
                DataTrigger trigger = null;
                Given($"a DataTrigger with a data value ({dataValue}) and a trigger value ({triggerValue})", () => trigger = new DataTrigger { DataValue = dataValue, TriggerValue = triggerValue });
                Expect($"the DataTrigger should be {(expectedIsActive ? "active" : "inactive")}", () => trigger.IsActive == expectedIsActive);
            });
        }

        class DataTriggerSpecSampleDataSource : ISampleDataSource
        {
            IEnumerable ISampleDataSource.GetData()
            {
                yield return new { Description = "When the value type is boolean and a data value is equal to a trigger value", DataValue = true, TriggerValue = "true", ExpectedIsActive = true };
                yield return new { Description = "When the value type is boolean and a data value is not equal to a trigger value", DataValue = true, TriggerValue = "false", ExpectedIsActive = false };
                yield return new { Description = "When the value type is signed byte and a data value is equal to a trigger value", DataValue = (sbyte)1, TriggerValue = "1", ExpectedIsActive = true };
                yield return new { Description = "When the value type is signed byte and a data value is not equal to a trigger value", DataValue = (sbyte)1, TriggerValue = "2", ExpectedIsActive = false };
                yield return new { Description = "When the value type is byte and a data value is equal to a trigger value", DataValue = (byte)1, TriggerValue = "1", ExpectedIsActive = true };
                yield return new { Description = "When the value type is byte and a data value is not equal to a trigger value", DataValue = (byte)1, TriggerValue = "2", ExpectedIsActive = false };
                yield return new { Description = "When the value type is char and a data value is equal to a trigger value", DataValue = 'a', TriggerValue = "a", ExpectedIsActive = true };
                yield return new { Description = "When the value type is char and a data value is not equal to a trigger value", DataValue = 'a', TriggerValue = "A", ExpectedIsActive = false };
                yield return new { Description = "When the value type is short and a data value is equal to a trigger value", DataValue = (short)1, TriggerValue = "1", ExpectedIsActive = true };
                yield return new { Description = "When the value type is short and a data value is not equal to a trigger value", DataValue = (short)1, TriggerValue = "2", ExpectedIsActive = false };
                yield return new { Description = "When the value type is unsigned short and a data value is equal to a trigger value", DataValue = (ushort)1, TriggerValue = "1", ExpectedIsActive = true };
                yield return new { Description = "When the value type is unsigned short and a data value is not equal to a trigger value", DataValue = (ushort)1, TriggerValue = "2", ExpectedIsActive = false };
                yield return new { Description = "When the value type is int and a data value is equal to a trigger value", DataValue = 1, TriggerValue = "1", ExpectedIsActive = true };
                yield return new { Description = "When the value type is int and a data value is not equal to a trigger value", DataValue = 1, TriggerValue = "2", ExpectedIsActive = false };
                yield return new { Description = "When the value type is unsigned int and a data value is equal to a trigger value", DataValue = 1u, TriggerValue = "1", ExpectedIsActive = true };
                yield return new { Description = "When the value type is unsigned int and a data value is not equal to a trigger value", DataValue = 1u, TriggerValue = "2", ExpectedIsActive = false };
                yield return new { Description = "When the value type is long and a data value is equal to a trigger value", DataValue = 1L, TriggerValue = "1", ExpectedIsActive = true };
                yield return new { Description = "When the value type is long and a data value is not equal to a trigger value", DataValue = 1L, TriggerValue = "2", ExpectedIsActive = false };
                yield return new { Description = "When the value type is unsigned long and a data value is equal to a trigger value", DataValue = 1uL, TriggerValue = "1", ExpectedIsActive = true };
                yield return new { Description = "When the value type is unsigned long and a data value is not equal to a trigger value", DataValue = 1uL, TriggerValue = "2", ExpectedIsActive = false };
                yield return new { Description = "When the value type is float and a data value is equal to a trigger value", DataValue = 1f, TriggerValue = "1", ExpectedIsActive = true };
                yield return new { Description = "When the value type is float and a data value is not equal to a trigger value", DataValue = 1f, TriggerValue = "2", ExpectedIsActive = false };
                yield return new { Description = "When the value type is double and a data value is equal to a trigger value", DataValue = 1d, TriggerValue = "1", ExpectedIsActive = true };
                yield return new { Description = "When the value type is double and a data value is not equal to a trigger value", DataValue = 1d, TriggerValue = "2", ExpectedIsActive = false };
                yield return new { Description = "When the value type is decimal and a data value is equal to a trigger value", DataValue = 1m, TriggerValue = "1", ExpectedIsActive = true };
                yield return new { Description = "When the value type is decimal and a data value is not equal to a trigger value", DataValue = 1m, TriggerValue = "2", ExpectedIsActive = false };
                yield return new { Description = "When the value type is DateTime and a data value is equal to a trigger value", DataValue = new DateTime(2018, 1, 2), TriggerValue = "2018-1-2", ExpectedIsActive = true };
                yield return new { Description = "When the value type is DateTime and a data value is not equal to a trigger value", DataValue = new DateTime(2018, 1, 2), TriggerValue = "2018-1-3", ExpectedIsActive = false };
                yield return new { Description = "When the value type is enum and a data value is equal to a trigger value", DataValue = Visibility.Collapsed, TriggerValue = "Collapsed", ExpectedIsActive = true };
                yield return new { Description = "When the value type is enum and a data value is not equal to a trigger value", DataValue = Visibility.Collapsed, TriggerValue = "Visible", ExpectedIsActive = false };
                var data = new object();
                yield return new { Description = "When the value type is object and a data value is equal to a trigger value", DataValue = data, TriggerValue = data, ExpectedIsActive = true };
                yield return new { Description = "When the value type is object and a data value is not equal to a trigger value", DataValue = data, TriggerValue = new object(), ExpectedIsActive = false };
            }
        }
    }
}
