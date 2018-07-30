// Copyright (C) 2018 Fievus
//
// This software may be modified and distributed under the terms
// of the MIT license.  See the LICENSE file for details.
using System;
using System.Linq;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace Charites.Windows.Mvc
{
    /// <summary>
    /// Enables template selection logic by a data type at the application level.
    /// </summary>
    /// <remarks>
    /// <see cref="DataTypeDataTemplateSelector"/> selects a DataTemplate that has a key
    /// that is a data type name or a data type name + 'Template'.
    /// </remarks>
    public class DataTypeDataTemplateSelector : DataTemplateSelector
    {
        /// <summary>
        /// Returns a specific <see cref="DataTemplate"/> that has a key based on a given item type
        /// for a given item.
        /// </summary>
        /// <param name="item">The item to return a template for.</param>
        /// <returns>The template to use for the given item.</returns>
        protected override DataTemplate SelectTemplateCore(object item) =>
            item == null ? base.SelectTemplateCore(null) : FindDataTemplate(item) ?? base.SelectTemplateCore(item);

        /// <summary>
        /// Returns a specific <see cref="DataTemplate"/> that has a key based on a given item type
        /// for a given item or container.
        /// </summary>
        /// <param name="item">The item to return a template for.</param>
        /// <param name="container">The parent container for the template item.</param>
        /// <returns>The template to use for the given item and/or container.</returns>
        protected override DataTemplate SelectTemplateCore(object item, DependencyObject container) =>
            item == null ? base.SelectTemplateCore(null, container) : FindDataTemplate(item, container as FrameworkElement) ?? base.SelectTemplateCore(item, container);

        private DataTemplate FindDataTemplate(object item, FrameworkElement container = null)
        {
            var targetContainer = container;

            while (targetContainer != null)
            {
                var dataTemplate = FindDataTemplate(item, targetContainer.Resources);
                if (dataTemplate != null) return dataTemplate;
                targetContainer = targetContainer.Parent as FrameworkElement;
            }

            return FindDataTemplate(item, Application.Current.Resources);
        }

        private DataTemplate FindDataTemplate(object item, ResourceDictionary resources) =>
            resources == null ? null : FindDataTemplate(item.GetType(), resources);

        private DataTemplate FindDataTemplate(Type dataType, ResourceDictionary resources) =>
            dataType == null ? null : FindDataTemplate(dataType.Name, resources) ??
                FindDataTemplate(dataType.ToString(), resources) ??
                (dataType.IsConstructedGenericType ? FindDataTemplate(GetFullNameWithoutParameters(dataType), resources) : null) ??
                FindDataTemplate(dataType.BaseType, resources) ??
                dataType.GetInterfaces()
                    .Select(type => FindDataTemplate(type, resources))
                    .FirstOrDefault(type => type != null);

        private DataTemplate FindDataTemplate(string dataTypeName, ResourceDictionary resources) =>
            FindDataTemplateByResourceKey(dataTypeName, resources) ?? FindDataTemplateByResourceKey($"{dataTypeName}Template", resources);

        private DataTemplate FindDataTemplateByResourceKey(string key, ResourceDictionary resources) =>
            resources.ContainsKey(key) ? resources[key] as DataTemplate : null;

        private static string GetFullNameWithoutParameters(Type type)
        {
            var dataTypeFullName = type.ToString();
            var parameterStartIndex = dataTypeFullName.IndexOf('[');
            return parameterStartIndex < 0 ? null : dataTypeFullName.Substring(0, parameterStartIndex);
        }

    }
}
