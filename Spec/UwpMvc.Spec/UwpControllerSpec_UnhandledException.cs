// Copyright (C) 2018 Fievus
//
// This software may be modified and distributed under the terms
// of the MIT license.  See the LICENSE file for details.
using System;
using System.Reflection;
using System.Threading.Tasks;
using Carna;

namespace Charites.Windows.Mvc
{
    [Context("Unhandled exception")]
    class UwpControllerSpec_UnhandledException : DispatcherContext, IDisposable
    {
        object Controller { get; set; }
        TestElement Element { get; set; }

        Exception UnhandledException { get; set; }
        bool HandledException { get; set; }

        public UwpControllerSpec_UnhandledException()
        {
            UwpController.UnhandledException += OnUwpControllerUnhandledException;
        }

        public void Dispose()
        {
            UwpController.UnhandledException -= OnUwpControllerUnhandledException;
        }

        private void OnUwpControllerUnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            UnhandledException = e.Exception;
            e.Handled = HandledException;
        }

        [Example("Handles an unhandled exception as it is handled")]
        async Task Ex01()
        {
            HandledException = true;

            await RunAsync(() =>
            {
                Given("a controller that has an event handler that throws an exception", () => Controller = new TestUwpControllers.ExceptionTestUwpController());
                Given("an element", () => Element = new TestElement());

                When("the controller is added", () => UwpController.GetControllers(Element).Add(Controller));
                When("the controller is attached to the element", () => UwpController.GetControllers(Element).AttachTo(Element));
            });

            When("the element is set to the content of the window", async () => await SetWindowContent(Element));

            await RunAsync(() =>
            {
                When("the Changed event of the element is raised", () => Element.RaiseChanged());
                Then("the unhandled exception should be handled", () => UnhandledException != null);
            });
        }

        [Example("Handles an unhandled exception as it is not handled")]
        async Task Ex02()
        {
            HandledException = false;

            await RunAsync(() =>
            {
                Given("a controller that has an event handler that throws an exception", () => Controller = new TestUwpControllers.ExceptionTestUwpController());
                Given("an element", () => Element = new TestElement());

                When("the controller is added", () => UwpController.GetControllers(Element).Add(Controller));
                When("the controller is attached to the element", () => UwpController.GetControllers(Element).AttachTo(Element));
            });

            When("the element is set to the content of the window", async () => await SetWindowContent(Element));

            await RunAsync(() =>
            {
                When("the Changed event of the element is raised", () => Element.RaiseChanged());
                Then<TargetInvocationException>("the exception should be thrown");
                Then("the unhandled exception should be handled", () => UnhandledException != null);
            });
        }
    }
}
