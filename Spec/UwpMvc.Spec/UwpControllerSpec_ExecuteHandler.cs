// Copyright (C) 2021 Fievus
//
// This software may be modified and distributed under the terms
// of the MIT license.  See the LICENSE file for details.
using System;
using Windows.Devices.Input;
using Windows.System;
using Windows.UI.Xaml.Input;
using Carna;
using Charites.Windows.Mvc.Wrappers;
using NSubstitute;

namespace Charites.Windows.Mvc
{
    [Context("Executes handlers")]
    class UwpControllerSpec_ExecuteHandler : FixtureSteppable
    {
        [Example("Retrieves event handlers and executes them when an element is not attached")]
        void Ex01()
        {
            var loadedEventHandled = false;
            TestUwpControllers.TestUwpController controller = null;
            Given("a controller", () => controller = new TestUwpControllers.TestUwpController { LoadedAssertionHandler = () => loadedEventHandled = true });
            When("the Loaded event is raised using the EventHandlerBase", () =>
                UwpController.EventHandlersOf(controller)
                    .GetBy("Element")
                    .Raise("Loaded")
            );
            Then("the Loaded event should be handled", () => loadedEventHandled);
        }

        [Example("Retrieves event handlers and executes them asynchronously when an element is not attached")]
        void Ex02()
        {
            var loadedEventHandled = false;
            TestUwpControllers.TestUwpControllerAsync controller = null;
            Given("a controller", () => controller = new TestUwpControllers.TestUwpControllerAsync { LoadedAssertionHandler = () => loadedEventHandled = true });
            When("the Loaded event is raised asynchronously using the EventHandlerBase", async () =>
                await UwpController.EventHandlersOf(controller)
                    .GetBy("Element")
                    .RaiseAsync("Loaded")
            );
            Then("the Loaded event should be handled", () => loadedEventHandled);
        }

        [Example("Retrieves event handlers and executes them with the event args resolver scope when an element is not attached")]
        void Ex03()
        {
            var keyDownHandler = Substitute.For<Action<VirtualKey>>();
            TestUwpControllers.TestUwpController controller = null;
            Given("a controller", () => controller = new TestUwpControllers.TestUwpController { KeyDownAssertionHandler = keyDownHandler });
            When("the KeyDown event is raised using the EventHandlerBase", () =>
                UwpController.Using(Substitute.For<IKeyRoutedEventArgsResolver>(), typeof(KeyRoutedEventArgsWrapper))
                    .Apply(resolver => resolver.Key(Arg.Any<KeyRoutedEventArgs>()).Returns(VirtualKey.Enter))
                    .EventHandlersOf(controller)
                    .GetBy("Element")
                    .Raise("KeyDown")
            );
            Then("the KeyDown event should be handled", () => keyDownHandler.Received(1).Invoke(VirtualKey.Enter));
        }

        [Example("Retrieves event handlers and executes them with the event args resolver scope asynchronously when an element is not attached")]
        void Ex04()
        {
            var keyDownHandler = Substitute.For<Action<VirtualKey>>();
            TestUwpControllers.TestUwpControllerAsync controller = null;
            Given("a controller", () => controller = new TestUwpControllers.TestUwpControllerAsync { KeyDownAssertionHandler = keyDownHandler });
            When("the KeyDown event is raised asynchronously using the EventHandlerBase", async () =>
                await UwpController.Using(Substitute.For<IKeyRoutedEventArgsResolver>(), typeof(KeyRoutedEventArgsWrapper))
                    .Apply(resolver => resolver.Key(Arg.Any<KeyRoutedEventArgs>()).Returns(VirtualKey.Enter))
                    .EventHandlersOf(controller)
                    .GetBy("Element")
                    .RaiseAsync("KeyDown")
            );
            Then("the KeyDown event should be handled", () => keyDownHandler.Received(1).Invoke(VirtualKey.Enter));
        }

        [Example("Retrieves event handlers and executes them with the event args resolver scope that has multiple event args resolver when an element is not attached")]
        void Ex05()
        {
            var pointerPressedHandler = Substitute.For<Action<PointerDeviceType>>();
            TestUwpControllers.TestUwpController controller = null;
            Given("a controller", () => controller = new TestUwpControllers.TestUwpController { PointerPressedHandler = pointerPressedHandler });
            When("the PointerPressed event is raised using the EventHandlerBase", () =>
                UwpController.Using(Substitute.For<IPointerRoutedEventArgsResolver>(), typeof(PointerRoutedEventArgsWrapper))
                    .Apply(resolver => resolver.Pointer(Arg.Any<PointerRoutedEventArgs>()).Returns((Pointer)null))
                    .Using(Substitute.For<IPointerResolver>(), typeof(PointerWrapper))
                    .Apply(resolver => resolver.PointerDeviceType(Arg.Any<Pointer>()).Returns(PointerDeviceType.Mouse))
                    .EventHandlersOf(controller)
                    .GetBy("Element")
                    .Raise("PointerPressed")
            );
            Then("the PointerPressed event should be handled", () => pointerPressedHandler.Received(1).Invoke(PointerDeviceType.Mouse));
        }

        [Example("Retrieves event handlers and executes them with the event args resolver scope that has multiple event args resolver asynchronously when an element is not attached")]
        void Ex06()
        {
            var pointerPressedHandler = Substitute.For<Action<PointerDeviceType>>();
            TestUwpControllers.TestUwpController controller = null;
            Given("a controller", () => controller = new TestUwpControllers.TestUwpController { PointerPressedHandler = pointerPressedHandler });
            When("the PointerPressed event is raised asynchronously using the EventHandlerBase", async () =>
                await UwpController.Using(Substitute.For<IPointerRoutedEventArgsResolver>(), typeof(PointerRoutedEventArgsWrapper))
                    .Apply(resolver => resolver.Pointer(Arg.Any<PointerRoutedEventArgs>()).Returns((Pointer)null))
                    .Using(Substitute.For<IPointerResolver>(), typeof(PointerWrapper))
                    .Apply(resolver => resolver.PointerDeviceType(Arg.Any<Pointer>()).Returns(PointerDeviceType.Mouse))
                    .EventHandlersOf(controller)
                    .GetBy("Element")
                    .RaiseAsync("PointerPressed")
            );
            Then("the PointerPressed event should be handled", () => pointerPressedHandler.Received(1).Invoke(PointerDeviceType.Mouse));
        }
    }
}