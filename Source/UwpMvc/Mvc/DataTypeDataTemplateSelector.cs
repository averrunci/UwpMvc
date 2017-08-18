// Copyright (C) 2017 Fievus
//
// This software may be modified and distributed under the terms
// of the MIT license.  See the LICENSE file for details.
using System;
using System.Reflection;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace Fievus.Windows.Mvc
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
            item == null ? base.SelectTemplateCore(item) : FindDataTemplate(item) ?? base.SelectTemplateCore(item);

        /// <summary>
        /// Returns a specific <see cref="DataTemplate"/> that has a key based on a given item type
        /// for a given item or container.
        /// </summary>
        /// <param name="item">The item to return a template for.</param>
        /// <param name="container">The parent container for the templated item.</param>
        /// <returns>The template to use for the given item and/or container.</returns>
        protected override DataTemplate SelectTemplateCore(object item, DependencyObject container) =>
            item == null ? base.SelectTemplateCore(item, container) : FindDataTemplate(item) ?? base.SelectTemplateCore(item, container);

        private DataTemplate FindDataTemplate(object item) => FindDataTemplate(item.GetType());

        private DataTemplate FindDataTemplate(Type dataType) =>
            dataType == null ? null : FindDataTemplate(dataType.Name) ?? FindDataTemplate(dataType.FullName) ?? FindDataTemplate(dataType.GetTypeInfo().BaseType);

        private DataTemplate FindDataTemplate(string dataTypeName) =>
            FindDataTemplateByResourceKey(dataTypeName) ?? FindDataTemplateByResourceKey($"{dataTypeName}Template");

        private DataTemplate FindDataTemplateByResourceKey(string key) =>
            Application.Current.Resources.ContainsKey(key) ? Application.Current.Resources[key] as DataTemplate : null;
    }
}
