// Copyright (C) 2018 Fievus
//
// This software may be modified and distributed under the terms
// of the MIT license.  See the LICENSE file for details.
using System;
using System.Collections;
using System.Linq;
using System.Threading.Tasks;
using Windows.System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Input;
using Carna;
using Charites.Windows.Mvc.Wrappers;
using NSubstitute;

namespace Charites.Windows.Mvc
{
    [Context("Attaching and detaching a controller")]
    class UwpControllerSpec_AttachingAndDetachingController : DispatcherContext
    {
        interface IAttachingTestDataContext { }
        interface IAttachingTestDataContextFullName { }
        class AttachingTestDataContext { }
        class AttachingTestDataContextFullName { }
        class BaseAttachingTestDataContext { }
        class DerivedBaseAttachingTestDataContext : BaseAttachingTestDataContext { }
        class BaseAttachingTestDataContextFullName { }
        class DerivedBaseAttachingTestDataContextFullName : BaseAttachingTestDataContextFullName { }
        class GenericAttachingTestDataContext<T> { }
        class GenericAttachingTestDataContextFullName<T> { }
        class InterfaceImplementedAttachingTestDataContext : IAttachingTestDataContext { }
        class InterfaceImplementedAttachingTestDataContextFullName : IAttachingTestDataContextFullName { }
        class KeyAttachingTestDataContext { }

        class TestController { [DataContext] public object DataContext { get; set; } }

        [View(Key = "AttachingTestDataContext")]
        class TestDataContextController : TestController { }

        [View(Key = "BaseAttachingTestDataContext")]
        class BaseTestDataContextController : TestController { }

        [View(Key = "Charites.Windows.Mvc.UwpControllerSpec_AttachingAndDetachingController+AttachingTestDataContextFullName")]
        class TestDataContextFullNameController : TestController { }

        [View(Key = "Charites.Windows.Mvc.UwpControllerSpec_AttachingAndDetachingController+BaseAttachingTestDataContextFullName")]
        class BaseTestDataContextFullNameController : TestController { }

        [View(Key = "GenericAttachingTestDataContext`1")]
        class GenericTestDataContextController : TestController { }

        [View(Key = "Charites.Windows.Mvc.UwpControllerSpec_AttachingAndDetachingController+GenericAttachingTestDataContextFullName`1[System.String]")]
        class GenericTestDataContextFullNameController : TestController { }

        [View(Key = "Charites.Windows.Mvc.UwpControllerSpec_AttachingAndDetachingController+GenericAttachingTestDataContextFullName`1")]
        class GenericTestDataContextFullNameWithoutParametersController : TestController { }

        [View(Key = "IAttachingTestDataContext")]
        class InterfaceImplementedTestDataContextController : TestController { }

        [View(Key = "Charites.Windows.Mvc.UwpControllerSpec_AttachingAndDetachingController+IAttachingTestDataContextFullName")]
        class InterfaceImplementedTestDataContextFullNameController : TestController { }

        [View(Key = "TestElement")]
        class KeyTestDataContextController : TestController { }

        object DataContext { get; set; }
        object AnotherDataContext { get; set; }
        TestElement Element { get; set; }

        T GetController<T>(FrameworkElement element) => UwpController.GetControllers(element).OfType<T>().FirstOrDefault();

        [Example("Attaches a controller when the IsEnabled property of the UwpController is set to true")]
        [Sample(Source = typeof(AttachingControllerSampleDataSource))]
        async Task Ex01(object dataContext, Type[] expectedControllerTypes)
        {
            await RunAsync(() =>
            {
                Given("an element that contains the data context", () => Element = new TestElement { DataContext = dataContext });
                When("the UwpController is enabled for the element", () => UwpController.SetIsEnabled(Element, true));
                Then("the controller should be attached to the element", () =>
                    UwpController.GetControllers(Element).Select(controller => controller.GetType()).SequenceEqual(expectedControllerTypes) &&
                    UwpController.GetControllers(Element).Cast<TestController>().All(controller => controller.DataContext == dataContext)
                );
            });
        }

        class AttachingControllerSampleDataSource : ISampleDataSource
        {
            IEnumerable ISampleDataSource.GetData()
            {
                yield return new
                {
                    Description = "When the key is the name of the data context type",
                    DataContext = new AttachingTestDataContext(),
                    ExpectedControllerTypes = new[] { typeof(TestDataContextController) }
                };
                yield return new
                {
                    Description = "When the key is the name of the data context base type",
                    DataContext = new DerivedBaseAttachingTestDataContext(),
                    ExpectedControllerTypes = new[] { typeof(BaseTestDataContextController) }
                };
                yield return new
                {
                    Description = "When the key is the full name of the data context type",
                    DataContext = new AttachingTestDataContextFullName(),
                    ExpectedControllerTypes = new[] { typeof(TestDataContextFullNameController) }
                };
                yield return new
                {
                    Description = "When the key is the full name of the data context base type",
                    DataContext = new DerivedBaseAttachingTestDataContextFullName(),
                    ExpectedControllerTypes = new[] { typeof(BaseTestDataContextFullNameController) }
                };
                yield return new
                {
                    Description = "When the key is the name of the data context type that is generic",
                    DataContext = new GenericAttachingTestDataContext<string>(),
                    ExpectedControllerTypes = new[] { typeof(GenericTestDataContextController) }
                };
                yield return new
                {
                    Description = "When the key is the full name of the data context type that is generic",
                    DataContext = new GenericAttachingTestDataContextFullName<string>(),
                    ExpectedControllerTypes = new[] { typeof(GenericTestDataContextFullNameController), typeof(GenericTestDataContextFullNameWithoutParametersController) }
                };
                yield return new
                {
                    Description = "When the key is the name of the interface implemented by the data context",
                    DataContext = new InterfaceImplementedAttachingTestDataContext(),
                    ExpectedControllerTypes = new[] { typeof(InterfaceImplementedTestDataContextController) }
                };
                yield return new
                {
                    Description = "When the key is the full name of hte interface implemented by the data context",
                    DataContext = new InterfaceImplementedAttachingTestDataContextFullName(),
                    ExpectedControllerTypes = new[] { typeof(InterfaceImplementedTestDataContextFullNameController) }
                };
            }
        }

        [Example("Attaches a controller when the IsEnabled property of the UwpController is set to true before the data context of the element is set")]
        [Sample(Source = typeof(AttachingControllerSampleDataSource))]
        async Task Ex02(object dataContext, Type[] expectedControllerTypes)
        {
            await RunAsync(() =>
            {
                Given("an element that does not contain the data context", () => Element = new TestElement());
                When("the UwpController is enabled for the element", () => UwpController.SetIsEnabled(Element, true));
                When("a data context of the element is set", () => Element.DataContext = dataContext);
                Then("the controller should be attached to the element", () =>
                    UwpController.GetControllers(Element).Select(controller => controller.GetType()).SequenceEqual(expectedControllerTypes) &&
                    UwpController.GetControllers(Element).Cast<TestController>().All(controller => controller.DataContext == dataContext)
                );
            });
        }

        [Example("Attaches a controller when the Key property of the UwpController is set")]
        async Task Ex03()
        {
            await RunAsync(() =>
            {
                Given("a data context", () => DataContext = new KeyAttachingTestDataContext());
                Given("an element that contains the data context", () => Element = new TestElement { DataContext = DataContext });
                When("the key of the element is set using the UwpController", () => UwpController.SetKey(Element, "TestElement"));
                Then("the UwpController should be enabled for the element", () => UwpController.GetIsEnabled(Element));
                Then("the controller should be attached to the element", () =>
                    UwpController.GetControllers(Element).Count == 1 &&
                    UwpController.GetControllers(Element)[0].GetType() == typeof(KeyTestDataContextController) &&
                    (UwpController.GetControllers(Element)[0] as KeyTestDataContextController).DataContext == DataContext
                );
            });
        }

        [Example("Sets the changed data context when the UwpController is enabled and the data context of an element is changed")]
        async Task Ex04()
        {
            await RunAsync(() =>
            {
                Given("a data context", () => DataContext = new AttachingTestDataContext());
                Given("an element that contains the data context", () => Element = new TestElement { DataContext = DataContext });
                When("the UwpController is enabled for the element", () => UwpController.SetIsEnabled(Element, true));
                Then("the data context of the controller should be set", () => GetController<TestController>(Element).DataContext == DataContext);
                When("another data context is set for the element", () => Element.DataContext = AnotherDataContext = new object());
                Then("the data context of the controller should be changed", () => GetController<TestController>(Element).DataContext == AnotherDataContext);
            });
        }

        [Example("Removes event handlers and sets null to elements and a data context when the Unloaded event of the root element is raised")]
        async Task Ex05()
        {
            var dataContextChangedHandled = false;
            var loadedEventHandled = false;
            var changedEventHandled = false;

            await RunAsync(() =>
            {
                Given("an element that contains the data context", () => Element = new TestElement { Name = "Element", DataContext = new TestUwpControllers.TestDataContext() });
                When("the UwpController is enabled for the element", () =>
                {
                    UwpController.SetIsEnabled(Element, true);
                    GetController<TestUwpControllers.TestUwpController>(Element).DataContextChangedAssertionHandler = () => dataContextChangedHandled = true;
                    GetController<TestUwpControllers.TestUwpController>(Element).LoadedAssertionHandler = () => loadedEventHandled = true;
                    GetController<TestUwpControllers.TestUwpController>(Element).ChangedAssertionHandler = () => changedEventHandled = true;
                });
                Then("the data context of the controller should be set", () => GetController<TestUwpControllers.TestUwpController>(Element).DataContext == Element.DataContext);
            });

            When("the element is set for the content of the window", async () => await SetWindowContent(Element));

            await RunAsync(() =>
            {
                Then("the element of the controller should be set", () => GetController<TestUwpControllers.TestUwpController>(Element).Element == Element);

                Then("the DataContextChanged event should be handled", () => dataContextChangedHandled);
                Then("the Loaded event should be handled", () => loadedEventHandled);
                
                When("the Changed event of the element is raised", () => Element.RaiseChanged());
                Then("the Changed event should be handled", () => changedEventHandled);
            });

            When("the content of the window is cleared in order to unload the element", async () => await ClearWindowContent());

            await RunAsync(() =>
            {
                Then("the data context of the controller should be null", () => GetController<TestUwpControllers.TestUwpController>(Element).DataContext == null);
                Then("the element of the controller should be null", () => GetController<TestUwpControllers.TestUwpController>(Element).Element == null);

                changedEventHandled = false;
                When("the Changed event of the element is raised", () => Element.RaiseChanged());
                Then("the Changed event should not be handled", () => !changedEventHandled);
            });
        }

        [Example("Removes event handlers and sets null to elements and a data context when the UwpController is disabled")]
        async Task Ex06()
        {
            var dataContextChangedHandled = false;
            var loadedEventHandled = false;
            var changedEventHandled = false;
            TestUwpControllers.TestUwpController controller = null;

            await RunAsync(() =>
            {
                Given("an element that contains the data context", () => Element = new TestElement { Name = "Element", DataContext = new TestUwpControllers.TestDataContext() });
                When("the UwpController is enabled for the element", () =>
                {
                    UwpController.SetIsEnabled(Element, true);
                    controller = GetController<TestUwpControllers.TestUwpController>(Element);
                    controller.DataContextChangedAssertionHandler = () => dataContextChangedHandled = true;
                    controller.LoadedAssertionHandler = () => loadedEventHandled = true;
                    controller.ChangedAssertionHandler = () => changedEventHandled = true;
                });
                Then("the data context of the controller should be set", () => GetController<TestUwpControllers.TestUwpController>(Element).DataContext == Element.DataContext);
            });

            When("the element is set for the content of the window", async () => await SetWindowContent(Element));

            await RunAsync(() =>
            {
                Then("the element of the controller should be set", () => GetController<TestUwpControllers.TestUwpController>(Element).Element == Element);

                Then("the DataContextChanged event should be handled", () => dataContextChangedHandled);
                Then("the Loaded event should be handled", () => loadedEventHandled);

                When("the UwpController is disabled for the element", () => UwpController.SetIsEnabled(Element, false));
                Then("the controller should be detached", () => !UwpController.GetControllers(Element).Any());
                Then("the data context of the controller should be null", () => controller.DataContext == null);
                Then("the element of the controller should be null", () => controller.Element == null);

                When("the Changed event of the element is raised", () => Element.RaiseChanged());
                Then("the Changed event should not be handled", () => !changedEventHandled);
            });

            When("the content of the window is cleared in order to unload the element", async () => await ClearWindowContent());

            When("the element is set for the content of the window", async () => await SetWindowContent(Element));

            await RunAsync(() =>
            {
                Then("the controller should not be attached", () => !UwpController.GetControllers(Element).Any());
            });
        }

        [Example("Attaches multi controllers")]
        async Task Ex07()
        {
            var dataContextChangedHandled = new[] { false, false, false };
            var loadedEventHandled = new[] { false, false, false };
            var changedEventHandled = new[] { false, false, false };

            await RunAsync(() =>
            {
                Given("an element that contains the data context", () => Element = new TestElement { Name = "Element", DataContext = new TestUwpControllers.MultiTestDataContext() });
                When("the UwpController is enabled for the element", () =>
                {
                    UwpController.SetIsEnabled(Element, true);
                    GetController<TestUwpControllers.MultiTestUwpControllerA>(Element).DataContextChangedAssertionHandler = () => dataContextChangedHandled[0] = true;
                    GetController<TestUwpControllers.MultiTestUwpControllerA>(Element).LoadedAssertionHandler = () => loadedEventHandled[0] = true;
                    GetController<TestUwpControllers.MultiTestUwpControllerA>(Element).ChangedAssertionHandler = () => changedEventHandled[0] = true;

                    GetController<TestUwpControllers.MultiTestUwpControllerB>(Element).DataContextChangedAssertionHandler = () => dataContextChangedHandled[1] = true;
                    GetController<TestUwpControllers.MultiTestUwpControllerB>(Element).LoadedAssertionHandler = () => loadedEventHandled[1] = true;
                    GetController<TestUwpControllers.MultiTestUwpControllerB>(Element).ChangedAssertionHandler = () => changedEventHandled[1] = true;

                    GetController<TestUwpControllers.MultiTestUwpControllerC>(Element).DataContextChangedAssertionHandler = () => dataContextChangedHandled[2] = true;
                    GetController<TestUwpControllers.MultiTestUwpControllerC>(Element).LoadedAssertionHandler = () => loadedEventHandled[2] = true;
                    GetController<TestUwpControllers.MultiTestUwpControllerC>(Element).ChangedAssertionHandler = () => changedEventHandled[2] = true;
                });
                Then("the data context of the controller should be set", () => UwpController.GetControllers(Element).Cast<TestUwpControllers.TestUwpControllerBase>().All(controller => controller.DataContext == Element.DataContext));
            });

            When("the element is set for the content of the window", async () => await SetWindowContent(Element));

            await RunAsync(() =>
            {
                Then("the element of the controller should be set", () => UwpController.GetControllers(Element).Cast<TestUwpControllers.TestUwpControllerBase>().All(controller => controller.Element == Element));

                Then("the DataContextChanged event should be handled", () => dataContextChangedHandled.All(h => h));
                Then("the Loaded event should be handled", () => loadedEventHandled.All(h => h));

                When("the Changed event of the element is raised", () => Element.RaiseChanged());
                Then("the Changed event should be handled", () => changedEventHandled.All(h => h));
            });

            When("the content of the window is cleared in order to unload the element", async () => await ClearWindowContent());

            await RunAsync(() =>
            {
                Then("the data context of the controller should be null", () => UwpController.GetControllers(Element).Cast<TestUwpControllers.TestUwpControllerBase>().All(controller => controller.DataContext == null));
                Then("the element of the controller should be null", () => UwpController.GetControllers(Element).Cast<TestUwpControllers.TestUwpControllerBase>().All(controller => controller.Element == null));

                for (int index = 0; index < changedEventHandled.Length; index++)
                {
                    changedEventHandled[index] = false;
                }
                When("the Changed event of the element is raised", () => Element.RaiseChanged());
                Then("the Changed event should not be handled", () => changedEventHandled.All(h => !h));
            });
        }

        [Example("Retrieves event handlers and executes them when an element is not attached")]
        void Ex08()
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
        void Ex09()
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
        void Ex10()
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
        void Ex11()
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
    }
}
