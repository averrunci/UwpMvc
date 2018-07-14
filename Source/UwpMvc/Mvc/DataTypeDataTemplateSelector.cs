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
            item == null ? base.SelectTemplateCore(null, container) : FindDataTemplate(item) ?? base.SelectTemplateCore(item, container);

        private DataTemplate FindDataTemplate(object item) => FindDataTemplate(item.GetType());

        private DataTemplate FindDataTemplate(Type dataType) =>
            dataType == null ? null : FindDataTemplate(dataType.Name) ??
                FindDataTemplate(dataType.ToString()) ??
                (dataType.IsConstructedGenericType ? FindDataTemplate(GetFullNameWithoutParameters(dataType)) : null) ??
                FindDataTemplate(dataType.BaseType) ??
                dataType.GetInterfaces()
                    .Select(FindDataTemplate)
                    .FirstOrDefault(type => type != null);

        private DataTemplate FindDataTemplate(string dataTypeName) =>
            FindDataTemplateByResourceKey(dataTypeName) ?? FindDataTemplateByResourceKey($"{dataTypeName}Template");

        private DataTemplate FindDataTemplateByResourceKey(string key) =>
            Application.Current.Resources.ContainsKey(key) ? Application.Current.Resources[key] as DataTemplate : null;

        private static string GetFullNameWithoutParameters(Type type)
        {
            var dataTypeFullName = type.ToString();
            var parameterStartIndex = dataTypeFullName.IndexOf('[');
            return parameterStartIndex < 0 ? null : dataTypeFullName.Substring(0, parameterStartIndex);
        }

    }
}
