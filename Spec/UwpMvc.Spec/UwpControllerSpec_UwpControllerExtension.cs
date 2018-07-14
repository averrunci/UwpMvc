// Copyright (C) 2018 Fievus
//
// This software may be modified and distributed under the terms
// of the MIT license.  See the LICENSE file for details.
using System;
using System.Threading.Tasks;
using Windows.UI.Xaml;
using Carna;
using NSubstitute;

namespace Charites.Windows.Mvc
{
    [Context("UwpControllerExtension")]
    class UwpControllerSpec_UwpControllerExtension : DispatcherContext, IDisposable
    {
        class TestExtension : IUwpControllerExtension
        {
            public static object TestExtensionContainer { get; } = new object();
            public void Attach(object controller, FrameworkElement element) { }
            public void Detach(object controller, FrameworkElement element) { }
            public object Retrieve(object controller) => TestExtensionContainer;
        }

        IUwpControllerExtension Extension { get; } = Substitute.For<IUwpControllerExtension>();

        TestUwpControllers.TestDataContext DataContext { get; } = new TestUwpControllers.TestDataContext();
        TestElement Element { get; set; }
        TestUwpControllers.TestUwpController Controller { get; set; }

        public void Dispose()
        {
            if (Extension == null) return;

            UwpController.RemoveExtension(Extension);
        }

        [Example("Attaches an extension when the element is loaded and detaches it when the element is unloaded")]
        async Task Ex01()
        {
            await RunAsync(() =>
            {
                Given("an element that contains a data context", () => Element = new TestElement { DataContext = DataContext });
                When("the UwpController is enabled for the element", () =>
                {
                    UwpController.SetIsEnabled(Element, true);
                    Controller = UwpController.GetControllers(Element)[0] as TestUwpControllers.TestUwpController;
                });
                When("the extension is added", () => UwpController.AddExtension(Extension));
            });
            When("the element is set for the content of the window", async () => await SetWindowContent(Element));
            Then("the extension should be attached", () => Extension.Received().Attach(Controller, Element));

            When("the content of the window is cleared in order to unload the element", async () => await ClearWindowContent());
            Then("the extension should be detached", () => Extension.Received().Detach(Controller, Element));
        }

        [Example("Retrieves a container of an extension")]
        void Ex02()
        {
            Given("a controller", () => Controller = new TestUwpControllers.TestUwpController());
            When("an extension is added", () => UwpController.AddExtension(new TestExtension()));
            Then("the container of the extension should be retrieved", () => UwpController.Retrieve<TestExtension, object>(Controller) == TestExtension.TestExtensionContainer);
        }
    }
}
