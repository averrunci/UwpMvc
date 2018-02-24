// Copyright (C) 2017-2018 Fievus
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
    public class DataTypeDataTemplateSelectorTest : DispatcherHarness
    {
        public DataTypeDataTemplateSelectorTest()
        {
        }

        protected override async void Dispose()
        {
            await CoreApplication.MainView.Dispatcher.RunAsync(CoreDispatcherPriority.Normal, () =>
            {
                Application.Current.Resources.Remove("TestData");
                Application.Current.Resources.Remove("TestDataTemplate");
                Application.Current.Resources.Remove("Fievus.Windows.Mvc.DataTypeDataTemplateSelectorTest+TestData");
                Application.Current.Resources.Remove("Fievus.Windows.Mvc.DataTypeDataTemplateSelectorTest+TestDataTemplate");
                Application.Current.Resources.Remove("GenericTestData'1");
                Application.Current.Resources.Remove("GenericTestData'1Template");
                Application.Current.Resources.Remove("GenericTestData");
                Application.Current.Resources.Remove("GenericTestDataTemplate");
                Application.Current.Resources.Remove("Fievus.Windows.Mvc.DataTypeDataTemplateSelectorTest+GenericTestData`1");
                Application.Current.Resources.Remove("Fievus.Windows.Mvc.DataTypeDataTemplateSelectorTest+GenericTestData`1Template");
                Application.Current.Resources.Remove("Fievus.Windows.Mvc.DataTypeDataTemplateSelectorTest+GenericTestData`1[System.String]");
                Application.Current.Resources.Remove("Fievus.Windows.Mvc.DataTypeDataTemplateSelectorTest+GenericTestData`1[System.String]Template");
                Application.Current.Resources.Remove("Fievus.Windows.Mvc.DataTypeDataTemplateSelectorTest+GenericTestData`1[Fievus.Windows.Mvc.DataTypeDataTemplateSelectorTest+TestData]");
                Application.Current.Resources.Remove("Fievus.Windows.Mvc.DataTypeDataTemplateSelectorTest+GenericTestData`1[Fievus.Windows.Mvc.DataTypeDataTemplateSelectorTest+TestData]Template");
                Application.Current.Resources.Remove("ITestData");
                Application.Current.Resources.Remove("ITestDataTemplate");
                Application.Current.Resources.Remove("Fievus.Windows.Mvc.DataTypeDataTemplateSelectorTest+ITestData");
                Application.Current.Resources.Remove("Fievus.Windows.Mvc.DataTypeDataTemplateSelectorTest+ITestDataTemplate");
            });
        }

        private interface ITestData { }
        private class TestData : ITestData { }
        private class TestContainer : DependencyObject { }
        private class DerivedTestData : TestData { }
        private class GenericTestData<T> { }

        [Fact]
        public async Task SelectsDataTemplateThatHasKeyOfSpecifiedDataTypeName()
        {
            await RunAsync(() =>
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
            await RunAsync(() =>
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
            await RunAsync(() =>
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
            await RunAsync(() =>
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
            await RunAsync(() =>
            {
                Application.Current.Resources["TestDataTemplate"] = new DataTemplate();

                var selector = new DataTypeDataTemplateSelector();

                var template = selector.SelectTemplate(new DerivedTestData());
                Assert.NotNull(template);

                template = selector.SelectTemplate(new DerivedTestData(), new TestContainer());
                Assert.NotNull(template);
            });
        }

        [Fact]
        public async Task SelectsDataTemplateThatHasKeyOfSpecifiedDataTypeFullName()
        {
            await RunAsync(() =>
            {
                Application.Current.Resources["Fievus.Windows.Mvc.DataTypeDataTemplateSelectorTest+TestData"] = new DataTemplate();

                var selector = new DataTypeDataTemplateSelector();

                var template = selector.SelectTemplate(new TestData());
                Assert.NotNull(template);

                template = selector.SelectTemplate(new TestData(), new TestContainer());
                Assert.NotNull(template);
            });
        }

        [Fact]
        public async Task SelectsDataTemplateThatHasKeyOfSpecifiedDataTypeFullNameTheSuffixOfWhichIsTemplate()
        {
            await RunAsync(() =>
            {
                Application.Current.Resources["Fievus.Windows.Mvc.DataTypeDataTemplateSelectorTest+TestDataTemplate"] = new DataTemplate();

                var selector = new DataTypeDataTemplateSelector();

                var template = selector.SelectTemplate(new TestData());
                Assert.NotNull(template);

                template = selector.SelectTemplate(new TestData(), new TestContainer());
                Assert.NotNull(template);
            });
        }

        [Fact]
        public async Task SelectsDataTemplateThatHasKeyOfSpecifiedBaseDataTypeFullName()
        {
            await RunAsync(() =>
            {
                Application.Current.Resources["Fievus.Windows.Mvc.DataTypeDataTemplateSelectorTest+TestData"] = new DataTemplate();

                var selector = new DataTypeDataTemplateSelector();

                var template = selector.SelectTemplate(new DerivedTestData());
                Assert.NotNull(template);

                template = selector.SelectTemplate(new DerivedTestData(), new TestContainer());
                Assert.NotNull(template);
            });
        }

        [Fact]
        public async Task SelectsDataTemplateThatHasKeyOfSpecifiedBaseDataTypeFullNameTheSuffixOfWhichIsTemplate()
        {
            await RunAsync(() =>
            {
                Application.Current.Resources["Fievus.Windows.Mvc.DataTypeDataTemplateSelectorTest+TestDataTemplate"] = new DataTemplate();

                var selector = new DataTypeDataTemplateSelector();

                var template = selector.SelectTemplate(new DerivedTestData());
                Assert.NotNull(template);

                template = selector.SelectTemplate(new DerivedTestData(), new TestContainer());
                Assert.NotNull(template);
            });
        }

        [Fact]
        public async Task SelectsDataTemplateThatHasKeyOfSpecifiedGenericDataTypeName()
        {
            await RunAsync(() =>
            {
                Application.Current.Resources["GenericTestData`1"] = new DataTemplate();

                var selector = new DataTypeDataTemplateSelector();

                var template = selector.SelectTemplate(new GenericTestData<string>());
                Assert.NotNull(template);

                template = selector.SelectTemplate(new GenericTestData<string>(), new TestContainer());
                Assert.NotNull(template);

                template = selector.SelectTemplate(new GenericTestData<TestData>());
                Assert.NotNull(template);

                template = selector.SelectTemplate(new GenericTestData<TestData>(), new TestContainer());
                Assert.NotNull(template);
            });
        }

        [Fact]
        public async Task SelectsDataTemplateThatHasKeyOfSpecifiedGenericDataTypeNameTheSuffixOfWhichIsTemplate()
        {
            await RunAsync(() =>
            {
                Application.Current.Resources["GenericTestData`1Template"] = new DataTemplate();

                var selector = new DataTypeDataTemplateSelector();

                var template = selector.SelectTemplate(new GenericTestData<string>());
                Assert.NotNull(template);

                template = selector.SelectTemplate(new GenericTestData<string>(), new TestContainer());
                Assert.NotNull(template);

                template = selector.SelectTemplate(new GenericTestData<TestData>());
                Assert.NotNull(template);

                template = selector.SelectTemplate(new GenericTestData<TestData>(), new TestContainer());
                Assert.NotNull(template);
            });
        }

        [Fact]
        public async Task GetsNullWhenDataTemplateThatHasKeyOfSpecifiedGenericDataTypeNameDoesNotExist()
        {
            await RunAsync(() =>
            {
                Application.Current.Resources["GenericTestData"] = new DataTemplate();
                Application.Current.Resources["GenericTestDataTemplate"] = new DataTemplate();

                var selector = new DataTypeDataTemplateSelector();

                var template = selector.SelectTemplate(new GenericTestData<string>());
                Assert.Null(template);

                template = selector.SelectTemplate(new GenericTestData<string>(), new TestContainer());
                Assert.Null(template);

                template = selector.SelectTemplate(new GenericTestData<TestData>());
                Assert.Null(template);

                template = selector.SelectTemplate(new GenericTestData<TestData>(), new TestContainer());
                Assert.Null(template);
            });
        }

        [Fact]
        public async Task SelectsDataTemplateThatHasKeyOfSpecifiedGenericDataTypeFullName()
        {
            await RunAsync(() =>
            {
                Application.Current.Resources["Fievus.Windows.Mvc.DataTypeDataTemplateSelectorTest+GenericTestData`1[System.String]"] = new DataTemplate();
                Application.Current.Resources["Fievus.Windows.Mvc.DataTypeDataTemplateSelectorTest+GenericTestData`1[Fievus.Windows.Mvc.DataTypeDataTemplateSelectorTest+TestData]"] = new DataTemplate();

                var selector = new DataTypeDataTemplateSelector();

                var template = selector.SelectTemplate(new GenericTestData<string>());
                Assert.NotNull(template);

                template = selector.SelectTemplate(new GenericTestData<string>(), new TestContainer());
                Assert.NotNull(template);

                template = selector.SelectTemplate(new GenericTestData<TestData>());
                Assert.NotNull(template);

                template = selector.SelectTemplate(new GenericTestData<TestData>(), new TestContainer());
                Assert.NotNull(template);
            });
        }

        [Fact]
        public async Task SelectsDataTemplateThatHasKeyOfSpecifiedGenericDataTypeFullNameTheSuffixOfWhichIsTemplate()
        {
            await RunAsync(() =>
            {
                Application.Current.Resources["Fievus.Windows.Mvc.DataTypeDataTemplateSelectorTest+GenericTestData`1[System.String]Template"] = new DataTemplate();
                Application.Current.Resources["Fievus.Windows.Mvc.DataTypeDataTemplateSelectorTest+GenericTestData`1[Fievus.Windows.Mvc.DataTypeDataTemplateSelectorTest+TestData]Template"] = new DataTemplate();

                var selector = new DataTypeDataTemplateSelector();

                var template = selector.SelectTemplate(new GenericTestData<string>());
                Assert.NotNull(template);

                template = selector.SelectTemplate(new GenericTestData<string>(), new TestContainer());
                Assert.NotNull(template);

                template = selector.SelectTemplate(new GenericTestData<TestData>());
                Assert.NotNull(template);

                template = selector.SelectTemplate(new GenericTestData<TestData>(), new TestContainer());
                Assert.NotNull(template);
            });
        }

        [Fact]
        public async Task SelectsDataTemplateThatHasKeyOfSpecifiedGenericDataTypeFullNameWithoutTypeOfGenericParameter()
        {
            await RunAsync(() =>
            {
                Application.Current.Resources["Fievus.Windows.Mvc.DataTypeDataTemplateSelectorTest+GenericTestData`1"] = new DataTemplate();

                var selector = new DataTypeDataTemplateSelector();

                var template = selector.SelectTemplate(new GenericTestData<string>());
                Assert.NotNull(template);

                template = selector.SelectTemplate(new GenericTestData<string>(), new TestContainer());
                Assert.NotNull(template);

                template = selector.SelectTemplate(new GenericTestData<TestData>());
                Assert.NotNull(template);

                template = selector.SelectTemplate(new GenericTestData<TestData>(), new TestContainer());
                Assert.NotNull(template);
            });
        }

        [Fact]
        public async Task SelectsDataTemplateThatHasKeyOfSpecifiedGenericDataTypeFullNameTheSuffixOfWhichIsTemplateWithoutTypeOfGenericParameter()
        {
            await RunAsync(() =>
            {
                Application.Current.Resources["Fievus.Windows.Mvc.DataTypeDataTemplateSelectorTest+GenericTestData`1Template"] = new DataTemplate();

                var selector = new DataTypeDataTemplateSelector();

                var template = selector.SelectTemplate(new GenericTestData<string>());
                Assert.NotNull(template);

                template = selector.SelectTemplate(new GenericTestData<string>(), new TestContainer());
                Assert.NotNull(template);

                template = selector.SelectTemplate(new GenericTestData<TestData>());
                Assert.NotNull(template);

                template = selector.SelectTemplate(new GenericTestData<TestData>(), new TestContainer());
                Assert.NotNull(template);
            });
        }

        [Fact]
        public async Task SelectsDataTemplateThatHasKeyOfSpecifiedNameOfInterfaceImplementedByDataType()
        {
            await RunAsync(() =>
            {
                Application.Current.Resources["ITestData"] = new DataTemplate();

                var selector = new DataTypeDataTemplateSelector();

                var template = selector.SelectTemplate(new TestData());
                Assert.NotNull(template);

                template = selector.SelectTemplate(new TestData(), new TestContainer());
                Assert.NotNull(template);
            });
        }

        [Fact]
        public async Task SelectsDataTemplateThatHasKeyOfSpecifiedNameTheSuffixOfWhichIsTemplateOfInterfaceImplementedByDataType()
        {
            await RunAsync(() =>
            {
                Application.Current.Resources["ITestDataTemplate"] = new DataTemplate();

                var selector = new DataTypeDataTemplateSelector();

                var template = selector.SelectTemplate(new TestData());
                Assert.NotNull(template);

                template = selector.SelectTemplate(new TestData(), new TestContainer());
                Assert.NotNull(template);
            });
        }

        [Fact]
        public async Task SelectsDataTemplateThatHasKeyOfSpecifiedFullNameOfInterfaceImplementedByDataType()
        {
            await RunAsync(() =>
            {
                Application.Current.Resources["Fievus.Windows.Mvc.DataTypeDataTemplateSelectorTest+ITestData"] = new DataTemplate();

                var selector = new DataTypeDataTemplateSelector();

                var template = selector.SelectTemplate(new TestData());
                Assert.NotNull(template);

                template = selector.SelectTemplate(new TestData(), new TestContainer());
                Assert.NotNull(template);
            });
        }

        [Fact]
        public async Task SelectsDataTemplateThatHasKeyOfSpecifiedFullNameTheSuffixOfWhichIsTemplateOfInterfaceImplementedByDataType()
        {
            await RunAsync(() =>
            {
                Application.Current.Resources["Fievus.Windows.Mvc.DataTypeDataTemplateSelectorTest+ITestDataTemplate"] = new DataTemplate();

                var selector = new DataTypeDataTemplateSelector();

                var template = selector.SelectTemplate(new TestData());
                Assert.NotNull(template);

                template = selector.SelectTemplate(new TestData(), new TestContainer());
                Assert.NotNull(template);
            });
        }
    }
}
