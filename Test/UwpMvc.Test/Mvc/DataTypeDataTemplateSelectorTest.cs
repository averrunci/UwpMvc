// Copyright (C) 2017 Fievus
//
// This software may be modified and distributed under the terms
// of the MIT license.  See the LICENSE file for details.
using System;
using System.Threading.Tasks;
using Windows.ApplicationModel.Core;
using Windows.UI.Core;
using Windows.UI.Xaml;
using Xunit;

namespace Fievus.Windows.Mvc
{
    public class DataTypeDataTemplateSelectorTest : IDisposable
    {
        public DataTypeDataTemplateSelectorTest()
        {
        }

        public async void Dispose()
        {
            await CoreApplication.MainView.Dispatcher.RunAsync(CoreDispatcherPriority.Normal, () =>
            {
                Application.Current.Resources.Remove("TestData");
                Application.Current.Resources.Remove("TestDataTemplate");
            });
        }

        private class TestData { }
        private class TestContainer : DependencyObject { }
        private class DerivedTestData : TestData { }

        [Fact]
        public async Task SelectsDataTemplateThatHasKeyOfSpecifiedDataTypeName()
        {
            await CoreApplication.MainView.Dispatcher.RunAsync(CoreDispatcherPriority.Normal, () =>
            {
                Application.Current.Resources["TestData"] = new DataTemplate();

                var selector = new DataTypeDataTemplateSelector();

                var template = selector.SelectTemplate(new TestData());
                Assert.NotNull(template);

                template = selector.SelectTemplate(new TestData(), new TestContainer());
                Assert.NotNull(template);
            });
        }

        [Fact]
        public async Task SelectsDataTemplateThatHasKeyOfSpecifiedDataTypeNameTheSuffixOfWhichIsTemplate()
        {
            await CoreApplication.MainView.Dispatcher.RunAsync(CoreDispatcherPriority.Normal, () =>
            {
                Application.Current.Resources["TestDataTemplate"] = new DataTemplate();

                var selector = new DataTypeDataTemplateSelector();

                var template = selector.SelectTemplate(new TestData());
                Assert.NotNull(template);

                template = selector.SelectTemplate(new TestData(), new TestContainer());
                Assert.NotNull(template);
            });
        }

        [Fact]
        public async Task GetsNullWhenDataTemplateThatHasKeyOfSpecifiedDataTypeNameDoesNotExist()
        {
            await CoreApplication.MainView.Dispatcher.RunAsync(CoreDispatcherPriority.Normal, () =>
            {
                var selector = new DataTypeDataTemplateSelector();

                var template = selector.SelectTemplate(new TestData());
                Assert.Null(template);

                template = selector.SelectTemplate(new TestData(), new TestContainer());
                Assert.Null(template);
            });
        }

        [Fact]
        public async Task SelectsDataTemplateThatHasKeyOfSpecifiedBaseDataTypeName()
        {
            await CoreApplication.MainView.Dispatcher.RunAsync(CoreDispatcherPriority.Normal, () =>
            {
                Application.Current.Resources["TestData"] = new DataTemplate();

                var selector = new DataTypeDataTemplateSelector();

                var template = selector.SelectTemplate(new DerivedTestData());
                Assert.NotNull(template);

                template = selector.SelectTemplate(new DerivedTestData(), new TestContainer());
                Assert.NotNull(template);
            });
        }

        [Fact]
        public async Task SelectsDataTemplateThatHasKeyOfSpecifiedBaseDataTypeNameTheSuffixOfWhichIsTemplate()
        {
            await CoreApplication.MainView.Dispatcher.RunAsync(CoreDispatcherPriority.Normal, () =>
            {
                Application.Current.Resources["TestDataTemplate"] = new DataTemplate();

                var selector = new DataTypeDataTemplateSelector();

                var template = selector.SelectTemplate(new DerivedTestData());
                Assert.NotNull(template);

                template = selector.SelectTemplate(new DerivedTestData(), new TestContainer());
                Assert.NotNull(template);
            });
        }
    }
}
