// Copyright (C) 2018 Fievus
//
// This software may be modified and distributed under the terms
// of the MIT license.  See the LICENSE file for details.
using System;
using System.Collections;
using System.Threading.Tasks;
using Carna;

namespace Charites.Windows.Mvc
{
    [Context("Event handler, data context, and element injection")]
    class UwpControllerSpec_EventHandlerDataContextElementInjection : DispatcherContext
    {
        object DataContext { get; set; }
        TestElement Element { get; set; }
        TestElement ChildElement { get; set; }

        static bool EventHandled { get; set; }
        static Action NoArgumentAssertionHandler { get; } = () => EventHandled = true;
        static Action<object> OneArgumentAssertionHandler { get; } = e => EventHandled = true;
        static Action<object, object> TwoArgumentsAssertionHandler { get; } = (s, e) => EventHandled = true;

        [Example("Adds event handlers")]
        [Sample(Source = typeof(UwpControllerSampleDataSource))]
        async Task Ex01(TestUwpControllers.ITestUwpController controller)
        {
            await RunAsync(() =>
            {
                Given("a data context", () => DataContext = new object());
                Given("a child element", () => ChildElement = new TestElement { Name = "childElement" });
                Given("an element that has the child element", () => Element = new TestElement { Name = "element", Content = ChildElement, DataContext = DataContext });

                When("the controller is added", () => UwpController.GetControllers(Element).Add(controller));
                When("the controller is attached to the element", () => UwpController.GetControllers(Element).AttachTo(Element));

                Then("the data context of the controller should be set", () => controller.DataContext == DataContext);
                Then("the element of the controller should be null", () => controller.Element == null);
                Then("the child element of the controller should be null", () => controller.ChildElement == null);
            });

            EventHandled = false;
            When("the element is set to the content of the window", async () => await SetWindowContent(Element));

            Then("the data context of the controller should be set", () => controller.DataContext == DataContext);
            Then("the element of the controller should be set", () => controller.Element == Element);
            Then("the child element of the controller should be set", () => controller.ChildElement == ChildElement);
            Then("the event should be handled", () => EventHandled);

            await RunAsync(() =>
            {
                EventHandled = false;
                When("the Changed event of the child element is raised", () => ChildElement.RaiseChanged());
                Then("the Changed event should be handled", () => EventHandled);

                EventHandled = false;
                When("the data context of the child element should be set", () => ChildElement.DataContext = new object());
                Then("the DataContextChanged event should be handled", () => EventHandled);
            });
        }

        [Example("Sets elements")]
        [Sample(Source = typeof(UwpControllerSampleDataSource))]
        async Task Ex02(TestUwpControllers.ITestUwpController controller)
        {
            await RunAsync(() =>
            {
                Given("a child element", () => ChildElement = new TestElement { Name = "childElement" });
                Given("an element", () => Element = new TestElement { Name = "element" });
                When("the child element is set to the controller using the UwpController", () => UwpController.SetElement(ChildElement, controller, true));
                When("the element is set to the controller using the UwpController", () => UwpController.SetElement(Element, controller, true));
                Then("the element should be set to the controller", () => controller.Element == Element);
                Then("the child element should be set to the controller", () => controller.ChildElement == ChildElement);
            });
        }

        [Example("Sets a data context")]
        [Sample(Source = typeof(UwpControllerSampleDataSource))]
        async Task Ex03(TestUwpControllers.ITestUwpController controller)
        {
            await RunAsync(() =>
            {
                Given("a data context", () => DataContext = new object());
                When("the data context is set to the controller using the UwpController", () => UwpController.SetDataContext(DataContext, controller));
                Then("the data context should be set to the controller", () => controller.DataContext == DataContext);
            });
        }

        class UwpControllerSampleDataSource : ISampleDataSource
        {
            IEnumerable ISampleDataSource.GetData()
            {
                yield return new { Description = "When the contents are attributed to fields and the event handler has no argument.", Controller = new TestUwpControllers.AttributedToField.NoArgumentHandlerController(NoArgumentAssertionHandler) };
                yield return new { Description = "When the contents are attributed to fields and the event handler has one argument.", Controller = new TestUwpControllers.AttributedToField.OneArgumentHandlerController(OneArgumentAssertionHandler) };
                yield return new { Description = "When the contents are attributed to fields and the event handler has two arguments.", Controller = new TestUwpControllers.AttributedToField.TwoArgumentsEventHandlerController(TwoArgumentsAssertionHandler) };
                yield return new { Description = "When the contents are attributed to properties and the event handler has no argument.", Controller = new TestUwpControllers.AttributedToProperty.NoArgumentHandlerController(NoArgumentAssertionHandler) };
                yield return new { Description = "When the contents are attributed to properties and the event handler has one argument.", Controller = new TestUwpControllers.AttributedToProperty.OneArgumentHandlerController(OneArgumentAssertionHandler) };
                yield return new { Description = "When the contents are attributed to properties and the event handler has two arguments.", Controller = new TestUwpControllers.AttributedToProperty.TwoArgumentsEventHandlerController(TwoArgumentsAssertionHandler) };
                yield return new { Description = "When the contents are attributed to methods and the event handler has no argument.", Controller = new TestUwpControllers.AttributedToMethod.NoArgumentHandlerController(NoArgumentAssertionHandler) };
                yield return new { Description = "When the contents are attributed to methods and the event handler has one argument.", Controller = new TestUwpControllers.AttributedToMethod.OneArgumentHandlerController(OneArgumentAssertionHandler) };
                yield return new { Description = "When the contents are attributed to methods and the event handler has two arguments.", Controller = new TestUwpControllers.AttributedToMethod.TwoArgumentsEventHandlerController(TwoArgumentsAssertionHandler) };
            }
        }
    }
}
