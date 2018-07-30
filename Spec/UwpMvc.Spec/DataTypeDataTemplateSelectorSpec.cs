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
    [Specification("DataTypeDataTemplateSelector Spec")]
    class DataTypeDataTemplateSelectorSpec : DispatcherContext
    {
        interface ITestData { }
        class TestData : ITestData { }
        class TestContainer : DependencyObject { }
        class DerivedTestData : TestData { }
        class GenericTestData<T> { }

        DataTemplate ExpectedTemplate { get; set; }
        DataTemplate ActualTemplate { get; set; }

        [Example("Selects the DataTemplate using a naming convention")]
        [Sample(Source = typeof(DataTemplateSelectionSampleDataSource))]
        async Task Ex01(string key, object item)
        {
            await RunAsync(() =>
            {
                Given("a data template in an application resource", () => Application.Current.Resources[key] = ExpectedTemplate = new DataTemplate());
                When("to select a template by specifying the data", () => ActualTemplate = new DataTypeDataTemplateSelector().SelectTemplate(item));
                Then("the template should be selected", () => ActualTemplate == ExpectedTemplate);
                
                When("to select a template by specifying the data and the container", () => ActualTemplate = new DataTypeDataTemplateSelector().SelectTemplate(item, new TestContainer()));
                Then("the template should be selected", () => ActualTemplate == ExpectedTemplate);
            });
        }

        class DataTemplateSelectionSampleDataSource : ISampleDataSource
        {
            IEnumerable ISampleDataSource.GetData()
            {
                yield return new { Description = "When the key is the name of the data type", Key = "TestData", Item = new TestData() };
                yield return new { Description = "When the key is the name of the data type and has a suffix 'Template'", Key = "TestData", Item = new TestData() };
                yield return new { Description = "When the key is the name of the base data type", Key = "TestData", Item = new DerivedTestData() };
                yield return new { Description = "When the key is the name of the base data type and has a suffix 'Template'", Key = "TestDataTemplate", Item = new DerivedTestData() };
                yield return new { Description = "When the key is the full name of the data type", Key = "Charites.Windows.Mvc.DataTypeDataTemplateSelectorSpec+TestData", Item = new TestData() };
                yield return new { Description = "When the key is the full name of the data type and has a suffix 'Template'", Key = "Charites.Windows.Mvc.DataTypeDataTemplateSelectorSpec+TestData", Item = new TestData() };
                yield return new { Description = "When the key is the full name of the base data type", Key = "Charites.Windows.Mvc.DataTypeDataTemplateSelectorSpec+TestData", Item = new DerivedTestData() };
                yield return new { Description = "When the key is the full name of the base data type and has a suffix 'Template'", Key = "Charites.Windows.Mvc.DataTypeDataTemplateSelectorSpec+TestDataTemplate", Item = new DerivedTestData() };
                yield return new { Description = "When the key is the name of the generic data type", Key = "GenericTestData`1", Item = new GenericTestData<string>() };
                yield return new { Description = "When the key is the name of the generic data type and has a suffix 'Template'", Key = "GenericTestData`1Template", Item = new GenericTestData<string>() };
                yield return new { Description = "When the key is the full name of the generic data type whose parameter type is string", Key = "Charites.Windows.Mvc.DataTypeDataTemplateSelectorSpec+GenericTestData`1[System.String]", Item = new GenericTestData<string>() };
                yield return new { Description = "When the key is the full name of the generic data type whose parameter type is string and has a suffix 'Template'", Key = "Charites.Windows.Mvc.DataTypeDataTemplateSelectorSpec+GenericTestData`1[System.String]Template", Item = new GenericTestData<string>() };
                yield return new { Description = "When the key is the full name of the generic data type whose parameter type is TestData", Key = "Charites.Windows.Mvc.DataTypeDataTemplateSelectorSpec+GenericTestData`1[Charites.Windows.Mvc.DataTypeDataTemplateSelectorSpec+TestData]", Item = new GenericTestData<TestData>() };
                yield return new { Description = "When the key is the full name of the generic data type whose parameter type is TestData and has a suffix 'Template'", Key = "Charites.Windows.Mvc.DataTypeDataTemplateSelectorSpec+GenericTestData`1[Charites.Windows.Mvc.DataTypeDataTemplateSelectorSpec+TestData]Template", Item = new GenericTestData<TestData>() };
                yield return new { Description = "When the key is the full name of the generic data type whose parameter type is string, but excluding type names", Key = "Charites.Windows.Mvc.DataTypeDataTemplateSelectorSpec+GenericTestData`1", Item = new GenericTestData<string>() };
                yield return new { Description = "When the key is the full name of the generic data type whose parameter type is string, but excluding type names and has a suffix 'Template'", Key = "Charites.Windows.Mvc.DataTypeDataTemplateSelectorSpec+GenericTestData`1Template", Item = new GenericTestData<string>() };
                yield return new { Description = "When the key is the full name of the generic data type whose parameter type is TestData, but excluding type names", Key = "Charites.Windows.Mvc.DataTypeDataTemplateSelectorSpec+GenericTestData`1", Item = new GenericTestData<TestData>() };
                yield return new { Description = "When the key is the full name of the generic data type whose parameter type is TestData, but excluding type names and has a suffix 'Template'", Key = "Charites.Windows.Mvc.DataTypeDataTemplateSelectorSpec+GenericTestData`1Template", Item = new GenericTestData<TestData>() };
                yield return new { Description = "When the key is the name of the implemented interface", Key = "ITestData", Item = new TestData() };
                yield return new { Description = "When the key is the name of the implemented interface and has a suffix 'Template'", Key = "ITestDataTemplate", Item = new TestData() };
                yield return new { Description = "When the key is the full name of the implemented interface", Key = "Charites.Windows.Mvc.DataTypeDataTemplateSelectorSpec+ITestData", Item = new TestData() };
                yield return new { Description = "When the key is the full name of the implemented interface and has a suffix 'Template'", Key = "Charites.Windows.Mvc.DataTypeDataTemplateSelectorSpec+ITestDataTemplate", Item = new TestData() };
            }
        }

        [Example("Not select the DataTemplate that does not exist")]
        async Task Ex02()
        {
            await RunAsync(() =>
            {
                When("to select a template by specifying the data", () => ActualTemplate = new DataTypeDataTemplateSelector().SelectTemplate(new TestData()));
                Then("the template should not be selected", () => ActualTemplate == null);

                When("to select a template by specifying the data and the container", () => ActualTemplate = new DataTypeDataTemplateSelector().SelectTemplate(new TestData(), new TestContainer()));
                Then("the template should not be selected", () => ActualTemplate == null);
            });
        }

        [Example("Not select the DataTemplate whose key does not contain generic parameters")]
        [Sample(Source = typeof(DataTemplateNoSelectionSampleDataSource))]
        async Task Ex03(string key, object item)
        {
            await RunAsync(() =>
            {
                Given("a data template whose key does not contain generic parameters in an application resource", () => Application.Current.Resources[key] = new DataTemplate());
                When("to select a template by specifying the data", () => ActualTemplate = new DataTypeDataTemplateSelector().SelectTemplate(item));
                Then("the template should not be selected", () => ActualTemplate == null);

                When("to select a template by specifying the data and the container", () => ActualTemplate = new DataTypeDataTemplateSelector().SelectTemplate(item, new TestContainer()));
                Then("the template should not be selected", () => ActualTemplate == null);
            });
        }

        class DataTemplateNoSelectionSampleDataSource : ISampleDataSource
        {
            IEnumerable ISampleDataSource.GetData()
            {
                yield return new { Description = "When the key is the data type and does not contain generic parameters", Key = "GenericTestData", Item = new GenericTestData<string>() };
                yield return new { Description = "When the key is the data type, does not contain generic parameters, and has a suffix 'Template'", Key = "GenericTestDataTemplate", Item = new GenericTestData<string>() };
            }
        }

        [Example("Selects the DataTemplate from resources of the container using a naming convention")]
        [Sample(Source = typeof(DataTemplateSelectionSampleDataSource))]
        async Task Ex04(string key, object item)
        {
            TestElement element = null;
            TestElement container = null;

            await RunAsync(() =>
            {
                element = new TestElement();
                container = new TestElement { Content = element };

                Given("a data template in a container resource", () => container.Resources[key] = ExpectedTemplate = new DataTemplate());
            });

            await SetWindowContent(container);

            await RunAsync(() =>
            {
                When("to select a template by specifying the data and the container", () => ActualTemplate = new DataTypeDataTemplateSelector().SelectTemplate(item, container));
                Then("the template should be selected", () => ActualTemplate == ExpectedTemplate);
            });

            await RunAsync(() =>
            {
                When("to select a template by specifying the data and the element whose parent is the container", () => ActualTemplate = new DataTypeDataTemplateSelector().SelectTemplate(item, element));
                Then("the template should be selected", () => ActualTemplate == ExpectedTemplate);
            });

        }
    }
}
