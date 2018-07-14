// Copyright (C) 2018 Fievus
//
// This software may be modified and distributed under the terms
// of the MIT license.  See the LICENSE file for details.
using System;
using System.Collections.Generic;
using System.Reflection;
using Windows.UI.Xaml;

namespace Charites.Windows.Mvc
{
    /// <summary>
    /// Represents a state trigger that is active when a specified data value
    /// is equals to a specified trigger value.
    /// </summary>
    public sealed class DataTrigger : StateTriggerBase
    {
        /// <summary>
        /// Identifies for the <see cref="DataValue"/> dependency property.
        /// </summary>
        public static DependencyProperty DataValueProperty { get; } =
            DependencyProperty.Register(nameof(DataValue), typeof(object), typeof(DataTrigger), new PropertyMetadata(null, OnDataValueChanged));

        /// <summary>
        /// Gets or sets a data value that is compared to a trigger value to determine whether the state trigger is active.
        /// </summary>
        public object DataValue
        {
            get => GetValue(DataValueProperty);
            set => SetValue(DataValueProperty, value);
        }
        private static void OnDataValueChanged(DependencyObject sender, DependencyPropertyChangedEventArgs e) =>
            UpdateState(sender, e.NewValue, sender.GetValue(TriggerValueProperty));

        /// <summary>
        /// Identifies for the <see cref="TriggerValue"/> dependency property.
        /// </summary>
        public static DependencyProperty TriggerValueProperty { get; } =
            DependencyProperty.Register(nameof(TriggerValue), typeof(object), typeof(DataTrigger), new PropertyMetadata(null, OnTriggerValueChanged));

        /// <summary>
        /// Gets of sets a value that determines whether the state trigger is active.
        /// </summary>
        public object TriggerValue
        {
            get => GetValue(TriggerValueProperty);
            set => SetValue(TriggerValueProperty, value);
        }
        private static void OnTriggerValueChanged(DependencyObject sender, DependencyPropertyChangedEventArgs e) =>
            UpdateState(sender, sender.GetValue(DataValueProperty), e.NewValue);

        /// <summary>
        /// Gets a value that indicates whether the state trigger is active.
        /// </summary>
        public bool IsActive { get; private set; }

        private static readonly IDictionary<Type, Func<object, object, bool>> StateTriggerPredicates = new Dictionary<Type, Func<object, object, bool>>
        {
            [typeof(bool)] = (dataValue, triggerValue) => Equals(dataValue, bool.Parse(triggerValue.ToString())),
            [typeof(sbyte)] = (dataValue, triggerValue) => Equals(dataValue, sbyte.Parse(triggerValue.ToString())),
            [typeof(byte)] = (dataValue, triggerValue) => Equals(dataValue, byte.Parse(triggerValue.ToString())),
            [typeof(char)] = (dataValue, triggerValue) => Equals(dataValue, char.Parse(triggerValue.ToString())),
            [typeof(short)] = (dataValue, triggerValue) => Equals(dataValue, short.Parse(triggerValue.ToString())),
            [typeof(ushort)] = (dataValue, triggerValue) => Equals(dataValue, ushort.Parse(triggerValue.ToString())),
            [typeof(int)] = (dataValue, triggerValue) => Equals(dataValue, int.Parse(triggerValue.ToString())),
            [typeof(uint)] = (dataValue, triggerValue) => Equals(dataValue, uint.Parse(triggerValue.ToString())),
            [typeof(long)] = (dataValue, triggerValue) => Equals(dataValue, long.Parse(triggerValue.ToString())),
            [typeof(ulong)] = (dataValue, triggerValue) => Equals(dataValue, ulong.Parse(triggerValue.ToString())),
            [typeof(float)] = (dataValue, triggerValue) => Equals(dataValue, float.Parse(triggerValue.ToString())),
            [typeof(double)] = (dataValue, triggerValue) => Equals(dataValue, double.Parse(triggerValue.ToString())),
            [typeof(decimal)] = (dataValue, triggerValue) => Equals(dataValue, decimal.Parse(triggerValue.ToString())),
            [typeof(DateTime)] = (dataValue, triggerValue) => Equals(dataValue, DateTime.Parse(triggerValue.ToString()))
        };

        private static void UpdateState(DependencyObject target, object dataValue, object triggerValue) =>
            (target as DataTrigger).IfPresent(trigger =>
            {
                trigger.IsActive = CanActivateStateTrigger(dataValue, triggerValue);
                trigger.SetActive(trigger.IsActive);
            });

        private static bool CanActivateStateTrigger(object dataValue, object triggerValue)
        {
            if (dataValue == null) return triggerValue == null;
            if (triggerValue == null) return false;

            var dataValueType = dataValue.GetType();
            try
            {
                return dataValueType.GetTypeInfo().IsEnum ?
                    Equals(dataValue, Enum.Parse(dataValueType, triggerValue.ToString(), true)) :
                    StateTriggerPredicates.ContainsKey(dataValueType) ?
                        StateTriggerPredicates[dataValueType](dataValue, triggerValue) : Equals(dataValue, triggerValue);
            }
            catch
            {
                return false;
            }
        }
    }
}
