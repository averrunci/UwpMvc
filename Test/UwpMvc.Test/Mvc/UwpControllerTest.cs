// Copyright (C) 2017 Fievus
//
// This software may be modified and distributed under the terms
// of the MIT license.  See the LICENSE file for details.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Windows.UI.Core;
using Windows.UI.Xaml;
using Xunit;

namespace Fievus.Windows.Mvc.UwpControllerTest
{
    public class UwpController_EventHandlerAndDataContextAndElementInject : DispatcherHarness
    {
        private object Context { get; set; }
        private TestElement Element { get; set; }
        private TestElement ChildElement { get; set; }
        private UIElement CurrentContent { get; set; }

        private static bool EventHandled { get; set; }
        private static Action AssertionHandler { get { return () => EventHandled = true; } }
        private static Action<object> OneArgAssertionHandler { get { return e => EventHandled = true; } }
        private static Action<object, object> TwoArgsAssertionHandler { get { return (s, e) => EventHandled = true; } }

        private async Task InitializeController(TestUwpControllers.ITestUwpController controller)
        {
            await RunAsync(() =>
            {
                Context = new object();
                ChildElement = new TestElement { Name = "childElement" };
                Element = new TestElement { Name = "element", Content = ChildElement, DataContext = Context };

                UwpController.GetControllers(Element).Add(controller);

                Assert.Equal(Context, controller.Context);
                Assert.Null(controller.Element);
                Assert.Null(controller.ChildElement);
            });

            await SetWindowContent(Element);
        }

        private async Task AssertController(TestUwpControllers.ITestUwpController controller)
        {
            await RunAsync(() =>
            {
                Assert.Equal(Context, controller.Context);
                Assert.Equal(Element, controller.Element);
                Assert.Equal(ChildElement, controller.ChildElement);
                Assert.True(EventHandled);

                EventHandled = false;
                ChildElement.RaiseChanged();
                Assert.True(EventHandled);

                EventHandled = false;
                ChildElement.DataContext = new object();
                Assert.True(EventHandled);
            });
        }

        public static IEnumerable<object[]> TestUwpControllers
        {
            get
            {
                yield return new object[] { new TestUwpControllers.AttributedToField.NoArgumentHandlerController(AssertionHandler) };
                yield return new object[] { new TestUwpControllers.AttributedToField.OneArgumentHandlerController(OneArgAssertionHandler) };
                yield return new object[] { new TestUwpControllers.AttributedToField.TwoArgumentsEventHandlerController(TwoArgsAssertionHandler) };
                yield return new object[] { new TestUwpControllers.AttributedToProperty.NoArgumentHandlerController(AssertionHandler) };
                yield return new object[] { new TestUwpControllers.AttributedToProperty.OneArgumentHandlerController(OneArgAssertionHandler) };
                yield return new object[] { new TestUwpControllers.AttributedToProperty.TwoArgumentsEventHandlerController(TwoArgsAssertionHandler) };
                yield return new object[] { new TestUwpControllers.AttributedToMethod.NoArgumentHandlerController(AssertionHandler) };
                yield return new object[] { new TestUwpControllers.AttributedToMethod.OneArgumentHandlerController(OneArgAssertionHandler) };
                yield return new object[] { new TestUwpControllers.AttributedToMethod.TwoArgumentsEventHandlerController(TwoArgsAssertionHandler) };
            }
        }

        [Theory]
        [MemberData("TestUwpControllers")]
        public async Task AddsEventHandler(TestUwpControllers.ITestUwpController controller)
        {
            await InitializeController(controller);
            await AssertController(controller);
        }
    }

    public class UwpController_AttachingAndDetachingUwpController : DispatcherHarness
    {
        [Fact]
        public async Task InjectsInstanceWithUwpControllerInjector()
        {
            await RunAsync(() =>
            {
                var controller = new object();
                var element = new TestElement();
                var injected = false;

                UwpController.Injector = new StubIUwpControllerInjector().Inject(c => injected = c == controller);

                UwpController.GetControllers(element).Add(controller);

                Assert.True(injected);
            });
        }

        [Fact]
        public async Task SetsChangedDataContextWhenDataContextOfElementIsChanged()
        {
            await RunAsync(() =>
            {
                var context = new object();
                var element = new TestElement { DataContext = context };
                var controller = new TestUwpControllers.TestUwpController();

                UwpController.GetControllers(element).Add(controller);

                Assert.Equal(context, controller.Context);

                var anotherContext = new object();
                element.DataContext = anotherContext;

                Assert.Equal(anotherContext, controller.Context);
            });
        }

        [Fact]
        public async Task UnregistersEventHandlerAndSetNullToElementWhenUnloadedEventIsRaised()
        {
            TestElement element = null;
            var eventHandled = false;
            var controller = new TestUwpControllers.TestUwpController { AssertionHandler = () => eventHandled = true };
            await RunAsync(() =>
            {
                element = new TestElement { Name = "Element" };
                UwpController.GetControllers(element).Add(controller);
                Window.Current.Content = element;
            });

            await SetWindowContent(element);

            await RunAsync(() =>
            {
                Assert.True(eventHandled);
                Assert.Equal(element, controller.Element);

                eventHandled = false;
                element.RaiseChanged();
                Assert.True(eventHandled);
            });

            await ClearWindowContent();

            await RunAsync(() =>
            {
                Assert.Null(controller.Element);

                eventHandled = false;
                element.RaiseChanged();
                Assert.False(eventHandled);
            });
        }

        [Fact]
        public async Task UnregistersEventHandlerWhenUwpControllerIsDetached()
        {
            var context = new object();
            TestElement element = null;
            var eventHandled = false;
            var controller = new TestUwpControllers.TestUwpController { AssertionHandler = () => eventHandled = true };
            await RunAsync(() =>
            {
                element = new TestElement { Name = "Element", DataContext = context };
                UwpController.GetControllers(element).Add(controller);
            });

            await SetWindowContent(element);

            await RunAsync(() =>
            {
                Assert.True(eventHandled);
                Assert.Equal(context, controller.Context);
                Assert.Equal(element, controller.Element);

                UwpController.GetControllers(element).Remove(controller);

                Assert.Null(controller.Context);
                Assert.Null(controller.Element);

                eventHandled = false;
                element.RaiseChanged();
                Assert.False(eventHandled);
            });

            await ClearWindowContent();

            await RunAsync(() => eventHandled = false);

            await SetWindowContent(element);

            await RunAsync(() =>
            {
                Assert.False(eventHandled);
                Assert.Null(controller.Context);
                Assert.Null(controller.Element);
            });
        }

        [Fact]
        public async Task AttachesMultiUwpControllers()
        {
            var context = new object();
            TestElement element = null;
            var eventHandled = new[] { false, false, false };
            var controller1 = new TestUwpControllers.TestUwpController { AssertionHandler = () => eventHandled[0] = true };
            var controller2 = new TestUwpControllers.TestUwpController { AssertionHandler = () => eventHandled[1] = true };
            var controller3 = new TestUwpControllers.TestUwpController { AssertionHandler = () => eventHandled[2] = true };
            await RunAsync(() =>
            {
                element = new TestElement { Name = "Element", DataContext = context };
                UwpController.GetControllers(element).Add(controller1);
                UwpController.GetControllers(element).Add(controller2);
                UwpController.GetControllers(element).Add(controller3);

                Assert.Equal(context, controller1.Context);
                Assert.Equal(context, controller2.Context);
                Assert.Equal(context, controller3.Context);
            });

            await SetWindowContent(element);

            await RunAsync(() =>
            {
                Assert.True(eventHandled.All(h => h));
                Assert.Equal(element, controller1.Element);
                Assert.Equal(element, controller2.Element);
                Assert.Equal(element, controller3.Element);

                eventHandled = eventHandled.Select(h => false).ToArray();
                element.RaiseChanged();
                Assert.True(eventHandled.All(h => h));
            });

            await ClearWindowContent();

            await RunAsync(() =>
            {
                Assert.Null(controller1.Element);
                Assert.Null(controller2.Element);
                Assert.Null(controller3.Element);

                eventHandled = eventHandled.Select(h => false).ToArray();
                element.RaiseChanged();
                Assert.True(eventHandled.All(h => !h));
            });
        }

        [Fact]
        public void RetrievesEventHandlersAndExecutesThemWhenElementIsNotAttached()
        {
            var eventHandled = false;
            var controller = new TestUwpControllers.TestUwpController { AssertionHandler = () => eventHandled = true };

            UwpController.RetrieveEventHandlers(controller)
                .GetBy("Element")
                .Raise("Loaded");

            Assert.True(eventHandled);
        }
    }

    public class UwpController_UwpControllerExtension : DispatcherHarness
    {
        private IUwpControllerExtension Extension { get; set; }

        protected override void Dispose()
        {
            if (Extension != null)
            {
                UwpController.Remove(Extension);
            }
        }

        [Fact]
        public async Task AttachesExtensionWhenLoadedEventIsRaised()
        {
            TestElement element = null;
            var extensionAttached = false;
            await RunAsync(() =>
            {
                element = new TestElement { Name = "Element" };

                var controller = new TestUwpControllers.TestUwpController();
                UwpController.GetControllers(element).Add(controller);

                Extension = new StubIUwpControllerExtension().Attach((e, c) => extensionAttached = e == element && c == controller);
                UwpController.Add(Extension);
            });

            await SetWindowContent(element);

            await RunAsync(() => Assert.True(extensionAttached));
        }

        [Fact]
        public async Task DetachesExtensionWhenUnloadedEventIsRaised()
        {
            TestElement element = null;
            var extensionAttached = false;
            var extensionDetached = false;
            await Dispatcher.RunAsync(CoreDispatcherPriority.Normal, () =>
            {
                element = new TestElement { Name = "Element" };

                var controller = new TestUwpControllers.TestUwpController();
                UwpController.GetControllers(element).Add(controller);

                Extension = new StubIUwpControllerExtension()
                    .Attach((e, c) => extensionAttached = e == element && c == controller)
                    .Detach((e, c) => extensionDetached = e == element && c == controller);
                UwpController.Add(Extension);
            });

            await SetWindowContent(element);

            await RunAsync(() => Assert.True(extensionAttached));

            await ClearWindowContent();

            await RunAsync(() => Assert.True(extensionDetached));
        }

        [Fact]
        public void RetrievesExtensionWithSpecifiedExtensionType()
        {
            Extension = new StubIUwpControllerExtension().Retrieve(c => c);
            UwpController.Add(Extension);

            var controller = new TestUwpControllers.TestUwpController();

            var retrievedExtension = UwpController.Retrieve<StubIUwpControllerExtension, object>(controller);

            Assert.Equal(controller, retrievedExtension);
        }
    }

    public class UwpController_UwpControllerCreation
    {
        [Fact]
        public void CreatesControllerTheTypeOfWhichIsTheValueOfControllerTypeProperty()
        {
            var controllerType = typeof(TestUwpControllers.TestUwpController);

            var uwpController = new UwpController
            {
                ControllerType = controllerType.AssemblyQualifiedName
            };
            var controller = uwpController.Create();

            Assert.IsType(controllerType, controller);
        }

        [Fact]
        public void CreatesControllerWithSpecifiedIUwpControllerFactory()
        {
            var controllerType = typeof(TestUwpControllers.TestUwpController);
            var expectedController = new TestUwpControllers.TestUwpController();

            UwpController.Factory = new StubIUwpControllerFactory().Create(c => c == controllerType ? expectedController : null);

            var uwpController = new UwpController
            {
                ControllerType = controllerType.AssemblyQualifiedName
            };
            var controller = uwpController.Create();

            Assert.Equal(expectedController, controller);
        }

        [Fact]
        public void GetsNullWhenValueOfControllerTypePropertyIsNull()
        {
            var uwpController = new UwpController
            {
                ControllerType = null
            };
            var controller = uwpController.Create();

            Assert.Null(controller);
        }

        [Fact]
        public void ThrowsExceptionWhenIUwpControllerThatIsNullIsSpecified()
        {
            Assert.Throws<ArgumentNullException>(() => UwpController.Factory = null);
        }
    }
}
