// Copyright (C) 2018-2019 Fievus
//
// This software may be modified and distributed under the terms
// of the MIT license.  See the LICENSE file for details.
using System;
using System.Threading.Tasks;
using Windows.Devices.Input;
using Windows.Foundation;
using Windows.System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Input;
using Charites.Windows.Mvc.Wrappers;

namespace Charites.Windows.Mvc
{
    public class TestUwpControllers
    {
        public class TestDataContext { }
        public class MultiTestDataContext { }

        public interface ITestUwpController
        {
            object DataContext { get; }
            FrameworkElement Element { get; }
            FrameworkElement ChildElement { get; }
        }

        public class TestUwpControllerBase
        {
            [DataContext]
            public object DataContext { get; set; }

            [Element]
            public FrameworkElement Element { get; set; }

            [EventHandler(ElementName = "Element", Event = "Tapped")]
            protected void OnElementTapped()
            {
                TappedAssertionHandler?.Invoke();
            }

            [EventHandler(ElementName = "Element", Event = "Loaded")]
            protected void OnElementLoaded()
            {
                LoadedAssertionHandler?.Invoke();
            }

            [EventHandler(ElementName = "Element", Event = "Changed")]
            protected void OnElementChanged()
            {
                ChangedAssertionHandler?.Invoke();
            }

            [EventHandler(ElementName = "Element", Event = "DataContextChanged")]
            protected void OnElementDataContextChanged()
            {
                DataContextChangedAssertionHandler?.Invoke();
            }

            [EventHandler(ElementName = "Element", Event = "KeyDown")]
            protected void OnElementKeyDown(KeyRoutedEventArgs e)
            {
                KeyDownAssertionHandler?.Invoke(e.Key());
            }

            [EventHandler(ElementName = "Element", Event = "PointerPressed")]
            protected void OnElementPointerPressed(PointerRoutedEventArgs e)
            {
                PointerPressedHandler?.Invoke(e.Pointer().PointerDeviceType());
            }

            public Action TappedAssertionHandler { get; set; }
            public Action LoadedAssertionHandler { get; set; }
            public Action ChangedAssertionHandler { get; set; }
            public Action DataContextChangedAssertionHandler { get; set; }
            public Action<VirtualKey> KeyDownAssertionHandler { get; set; }
            public Action<PointerDeviceType> PointerPressedHandler { get; set; }
        }

        [View(Key = "Charites.Windows.Mvc.TestUwpControllers+TestDataContext")]
        public class TestUwpController : TestUwpControllerBase { }

        [View(Key = "Charites.Windows.Mvc.TestUwpControllers+MultiTestDataContext")]
        public class MultiTestUwpControllerA : TestUwpControllerBase { }

        [View(Key = "Charites.Windows.Mvc.TestUwpControllers+MultiTestDataContext")]
        public class MultiTestUwpControllerB : TestUwpControllerBase { }

        [View(Key = "Charites.Windows.Mvc.TestUwpControllers+MultiTestDataContext")]
        public class MultiTestUwpControllerC : TestUwpControllerBase { }
    
        public class TestUwpControllerAsync
        {
            [DataContext]
            public object DataContext { get; set; }

            [Element]
            public FrameworkElement Element { get; set; }

            [EventHandler(ElementName = "Element", Event = "Tapped")]
            private async Task OnElementTapped()
            {
                await Task.Run(() => TappedAssertionHandler?.Invoke());
            }

            [EventHandler(ElementName = "Element", Event = "Loaded")]
            private async Task OnElementLoaded()
            {
                await Task.Run(() => LoadedAssertionHandler?.Invoke());
            }

            [EventHandler(ElementName = "Element", Event = "Changed")]
            private async Task OnElementChanged()
            {
                await Task.Run(() => ChangedAssertionHandler?.Invoke());
            }

            [EventHandler(ElementName = "Element", Event = "DataContextChanged")]
            private async Task OnElementDataContextChanged()
            {
                await Task.Run(() => DataContextChangedAssertionHandler?.Invoke());
            }

            [EventHandler(ElementName = "Element", Event = "KeyDown")]
            private async Task OnElementKeyDown(KeyRoutedEventArgs e)
            {
                await Task.Run(() => KeyDownAssertionHandler?.Invoke(e.Key()));
            }

            public Action TappedAssertionHandler { get; set; }
            public Action LoadedAssertionHandler { get; set; }
            public Action ChangedAssertionHandler { get; set; }
            public Action DataContextChangedAssertionHandler { get; set; }
            public Action<VirtualKey> KeyDownAssertionHandler { get; set; }
        }

        public class ExceptionTestUwpController
        {
            [EventHandler(Event = "Changed")]
            private void OnChanged()
            {
                throw new Exception();
            }
        }

        public class AttributedToField
        {
            public class NoArgumentHandlerController : ITestUwpController
            {
                [DataContext]
                private object dataContext;

                [Element]
                private FrameworkElement element;

                [Element]
                private FrameworkElement childElement;

                [EventHandler(ElementName = "childElement", Event = "Tapped")]
                private Action tappedHandler;

                [EventHandler(ElementName = "childElement", Event = "Loaded")]
                private Action loadedHandler;

                [EventHandler(ElementName = "childElement", Event = "Changed")]
                private Action changedHandler;

                [EventHandler(ElementName = "childElement", Event = "DataContextChanged")]
                private Action dataContextChangedHandler;

                public NoArgumentHandlerController(Action assertionHandler)
                {
                    tappedHandler = assertionHandler;
                    loadedHandler = assertionHandler;
                    changedHandler = assertionHandler;
                    dataContextChangedHandler = assertionHandler;
                }

                public object DataContext => dataContext;
                public FrameworkElement Element => element;
                public FrameworkElement ChildElement => childElement;
            }

            public class OneArgumentHandlerController : ITestUwpController
            {
                [DataContext]
                private object dataContext;

                [Element]
                private FrameworkElement element;

                [Element]
                private FrameworkElement childElement;

                [EventHandler(ElementName = "childElement", Event = "Tapped")]
                private Action<RoutedEventArgs> tappedHandler;

                [EventHandler(ElementName = "childElement", Event = "Loaded")]
                private Action<RoutedEventArgs> loadedHandler;

                [EventHandler(ElementName = "childElement", Event = "Changed")]
                private Action<RoutedEventArgs> changedHandler;

                [EventHandler(ElementName = "childElement", Event = "DataContextChanged")]
                private Action<DataContextChangedEventArgs> dataContextChangedHandler;

                public OneArgumentHandlerController(Action<object> assertionHandler)
                {
                    tappedHandler = assertionHandler;
                    loadedHandler = assertionHandler;
                    changedHandler = assertionHandler;
                    dataContextChangedHandler = assertionHandler;
                }

                public object DataContext => dataContext;
                public FrameworkElement Element => element;
                public FrameworkElement ChildElement => childElement;
            }

            public class TwoArgumentsEventHandlerController : ITestUwpController
            {
                [DataContext]
                private object dataContext;

                [Element]
                private FrameworkElement element;

                [Element]
                private FrameworkElement childElement;

                [EventHandler(ElementName = "childElement", Event = "Tapped")]
                private TappedEventHandler tappedHandler;

                [EventHandler(ElementName = "childElement", Event = "Loaded")]
                private RoutedEventHandler loadedHandler;

                [EventHandler(ElementName = "childElement", Event = "Changed")]
                private RoutedEventHandler changedHandler;

                [EventHandler(ElementName = "childElement", Event = "DataContextChanged")]
                private TypedEventHandler<FrameworkElement, DataContextChangedEventArgs> dataContextChangedHandler;

                public TwoArgumentsEventHandlerController(Action<object, object> assertionHandler)
                {
                    tappedHandler = (s, e) => assertionHandler(s, e);
                    loadedHandler = (s, e) => assertionHandler(s, e);
                    changedHandler = (s, e) => assertionHandler(s, e);
                    dataContextChangedHandler = (s, e) => assertionHandler(s, e);
                }

                public object DataContext => dataContext;
                public FrameworkElement Element => element;
                public FrameworkElement ChildElement => childElement;
            }
        }

        public class AttributedToProperty
        {
            public class NoArgumentHandlerController : ITestUwpController
            {
                [DataContext]
                public object DataContext { get; private set; }

                [Element(Name = "element")]
                public FrameworkElement Element { get; private set; }

                [Element(Name = "childElement")]
                public FrameworkElement ChildElement { get; private set; }

                [EventHandler(ElementName = "childElement", Event = "Tapped")]
                private Action TappedHandler { get; set; }

                [EventHandler(ElementName = "childElement", Event = "Loaded")]
                private Action LoadedHandler { get; set; }

                [EventHandler(ElementName = "childElement", Event = "Changed")]
                private Action ChangedHandler { get; set; }

                [EventHandler(ElementName = "childElement", Event = "DataContextChanged")]
                private Action DataContextChangedHandler { get; set; }

                public NoArgumentHandlerController(Action assertionHandler)
                {
                    TappedHandler = assertionHandler;
                    LoadedHandler = assertionHandler;
                    ChangedHandler = assertionHandler;
                    DataContextChangedHandler = assertionHandler;
                }
            }

            public class OneArgumentHandlerController : ITestUwpController
            {
                [DataContext]
                public object DataContext { get; private set; }

                [Element(Name = "element")]
                public FrameworkElement Element { get; private set; }

                [Element(Name = "childElement")]
                public FrameworkElement ChildElement { get; private set; }

                [EventHandler(ElementName = "childElement", Event = "Tapped")]
                private Action<TappedRoutedEventArgs> TappedHandler { get; set; }

                [EventHandler(ElementName = "childElement", Event = "Loaded")]
                private Action<RoutedEventArgs> LoadedHandler { get; set; }

                [EventHandler(ElementName = "childElement", Event = "Changed")]
                private Action<RoutedEventArgs> ChangedHandler { get; set; }

                [EventHandler(ElementName = "childElement", Event = "DataContextChanged")]
                private Action<DataContextChangedEventArgs> DataContextChangedHandler { get; set; }

                public OneArgumentHandlerController(Action<object> assertionHandler)
                {
                    TappedHandler = assertionHandler;
                    LoadedHandler = assertionHandler;
                    ChangedHandler = assertionHandler;
                    DataContextChangedHandler = assertionHandler;
                }
            }

            public class TwoArgumentsEventHandlerController : ITestUwpController
            {
                [DataContext]
                public object DataContext { get; private set; }

                [Element(Name = "element")]
                public FrameworkElement Element { get; private set; }

                [Element(Name = "childElement")]
                public FrameworkElement ChildElement { get; private set; }

                [EventHandler(ElementName = "childElement", Event = "Tapped")]
                private TappedEventHandler TappedHandler { get; set; }

                [EventHandler(ElementName = "childElement", Event = "Loaded")]
                private RoutedEventHandler LoadedHandler { get; set; }

                [EventHandler(ElementName = "childElement", Event = "Changed")]
                private RoutedEventHandler ChangedHandler { get; set; }

                [EventHandler(ElementName = "childElement", Event = "DataContextChanged")]
                private TypedEventHandler<FrameworkElement, DataContextChangedEventArgs> DataContextChangedHandler { get; set; }

                public TwoArgumentsEventHandlerController(Action<object, object> assertionHandler)
                {
                    TappedHandler = (s, e) => assertionHandler(s, e);
                    LoadedHandler = (s, e) => assertionHandler(s, e);
                    ChangedHandler = (s, e) => assertionHandler(s, e);
                    DataContextChangedHandler = (s, e) => assertionHandler(s, e);
                }
            }
        }

        public class AttributedToMethod
        {
            public class NoArgumentHandlerController : ITestUwpController
            {
                [DataContext]
                public void SetDataContext(object dataContext) => DataContext = dataContext;
                public object DataContext { get; private set; }

                [Element(Name = "element")]
                public void SetElement(FrameworkElement element) => Element = element;
                public FrameworkElement Element { get; private set; }

                [Element(Name = "childElement")]
                public void SetChildElement(FrameworkElement childElement) => ChildElement = childElement;
                public FrameworkElement ChildElement { get; private set; }

                [EventHandler(ElementName = "childElement", Event = "Tapped")]
                public void OnChildElementTapped()
                {
                    tappedHandler();
                }
                private readonly Action tappedHandler;

                [EventHandler(ElementName = "childElement", Event = "Loaded")]
                public void OnChildElementLoaded()
                {
                    loadedHandler();
                }
                private readonly Action loadedHandler;

                [EventHandler(ElementName = "childElement", Event = "Changed")]
                public void OnChildElementChanged()
                {
                    changedHandler();
                }
                private readonly Action changedHandler;

                [EventHandler(ElementName = "childElement", Event = "DataContextChanged")]
                public void OnChildElementDataContextChanged()
                {
                    dataContextChangedHandler();
                }
                private readonly Action dataContextChangedHandler;

                public NoArgumentHandlerController(Action assertionHandler)
                {
                    tappedHandler = assertionHandler;
                    loadedHandler = assertionHandler;
                    changedHandler = assertionHandler;
                    dataContextChangedHandler = assertionHandler;
                }
            }

            public class OneArgumentHandlerController : ITestUwpController
            {
                [DataContext]
                public void SetDataContext(object dataContext) => DataContext = dataContext;
                public object DataContext { get; private set; }

                [Element(Name = "element")]
                public void SetElement(FrameworkElement element) => Element = element;
                public FrameworkElement Element { get; private set; }

                [Element(Name = "childElement")]
                public void SetChildElement(FrameworkElement childElement) => ChildElement = childElement;
                public FrameworkElement ChildElement { get; private set; }

                [EventHandler(ElementName = "childElement", Event = "Tapped")]
                public void OnChildElementTapped(TappedRoutedEventArgs e)
                {
                    tappedHandler(e);
                }
                private readonly Action<TappedRoutedEventArgs> tappedHandler;

                [EventHandler(ElementName = "childElement", Event = "Loaded")]
                public void OnChildElementLoaded(RoutedEventArgs e)
                {
                    loadedHandler(e);
                }
                private readonly Action<RoutedEventArgs> loadedHandler;

                [EventHandler(ElementName = "childElement", Event = "Changed")]
                public void OnChildElementChanged(RoutedEventArgs e)
                {
                    changedHandler(e);
                }
                private readonly Action<RoutedEventArgs> changedHandler;

                [EventHandler(ElementName = "childElement", Event = "DataContextChanged")]
                public void OnChildElementDataContextChanged(DataContextChangedEventArgs e)
                {
                    dataContextChangedHandler(e);
                }
                private readonly Action<DataContextChangedEventArgs> dataContextChangedHandler;

                public OneArgumentHandlerController(Action<object> assertionHandler)
                {
                    tappedHandler = assertionHandler;
                    loadedHandler = assertionHandler;
                    changedHandler = assertionHandler;
                    dataContextChangedHandler = assertionHandler;
                }
            }

            public class TwoArgumentsEventHandlerController : ITestUwpController
            {
                [DataContext]
                public void SetDataContext(object dataContext) => DataContext = dataContext;
                public object DataContext { get; private set; }

                [Element(Name = "element")]
                public void SetElement(FrameworkElement element) => Element = element;
                public FrameworkElement Element { get; private set; }

                [Element(Name = "childElement")]
                public void SetChildElement(FrameworkElement childElement) => ChildElement = childElement;
                public FrameworkElement ChildElement { get; private set; }

                [EventHandler(ElementName = "childElement", Event = "Tapped")]
                public void OnChildElementTapped(object sender, TappedRoutedEventArgs e)
                {
                    tappedHandler(sender, e);
                }
                private readonly TappedEventHandler tappedHandler;

                [EventHandler(ElementName = "childElement", Event = "Loaded")]
                public void OnChildElementLoaded(object sender, RoutedEventArgs e)
                {
                    loadedHandler(sender, e);
                }
                private readonly RoutedEventHandler loadedHandler;

                [EventHandler(ElementName = "childElement", Event = "Changed")]
                public void OnChildElementChanged(object sender, RoutedEventArgs e)
                {
                    changedHandler(sender, e);
                }
                private readonly RoutedEventHandler changedHandler;

                [EventHandler(ElementName = "childElement", Event = "DataContextChanged")]
                public void OnChildElementDataContextChanged(FrameworkElement sender, DataContextChangedEventArgs e)
                {
                    dataContextChangedHandler(sender, e);
                }
                private readonly TypedEventHandler<FrameworkElement, DataContextChangedEventArgs> dataContextChangedHandler;

                public TwoArgumentsEventHandlerController(Action<object, object> assertionHandler)
                {
                    tappedHandler = (s, e) => assertionHandler(s, e);
                    loadedHandler = (s, e) => assertionHandler(s, e);
                    changedHandler = (s, e) => assertionHandler(s, e);
                    dataContextChangedHandler = (s, e) => assertionHandler(s, e);
                }
            }
        }

        public class AttributedToMethodUsingNamingConvention
        {
            public class NoArgumentHandlerController : ITestUwpController
            {
                public void SetDataContext(object dataContext) => DataContext = dataContext;
                public object DataContext { get; private set; }

                [Element(Name = "element")]
                public void SetElement(FrameworkElement element) => Element = element;
                public FrameworkElement Element { get; private set; }

                [Element(Name = "childElement")]
                public void SetChildElement(FrameworkElement childElement) => ChildElement = childElement;
                public FrameworkElement ChildElement { get; private set; }

                public void childElement_Tapped()
                {
                    tappedHandler();
                }
                private readonly Action tappedHandler;

                public void childElement_Loaded()
                {
                    loadedHandler();
                }
                private readonly Action loadedHandler;

                public void childElement_Changed()
                {
                    changedHandler();
                }
                private readonly Action changedHandler;

                public void childElement_DataContextChanged()
                {
                    dataContextChangedHandler();
                }
                private readonly Action dataContextChangedHandler;

                public NoArgumentHandlerController(Action assertionHandler)
                {
                    tappedHandler = assertionHandler;
                    loadedHandler = assertionHandler;
                    changedHandler = assertionHandler;
                    dataContextChangedHandler = assertionHandler;
                }
            }

            public class OneArgumentHandlerController : ITestUwpController
            {
                public void SetDataContext(object dataContext) => DataContext = dataContext;
                public object DataContext { get; private set; }

                [Element(Name = "element")]
                public void SetElement(FrameworkElement element) => Element = element;
                public FrameworkElement Element { get; private set; }

                [Element(Name = "childElement")]
                public void SetChildElement(FrameworkElement childElement) => ChildElement = childElement;
                public FrameworkElement ChildElement { get; private set; }

                public void childElement_Tapped(TappedRoutedEventArgs e)
                {
                    tappedHandler(e);
                }
                private readonly Action<TappedRoutedEventArgs> tappedHandler;

                public void childElement_Loaded(RoutedEventArgs e)
                {
                    loadedHandler(e);
                }
                private readonly Action<RoutedEventArgs> loadedHandler;

                public void childElement_Changed(RoutedEventArgs e)
                {
                    changedHandler(e);
                }
                private readonly Action<RoutedEventArgs> changedHandler;

                public void childElement_DataContextChanged(DataContextChangedEventArgs e)
                {
                    dataContextChangedHandler(e);
                }
                private readonly Action<DataContextChangedEventArgs> dataContextChangedHandler;

                public OneArgumentHandlerController(Action<object> assertionHandler)
                {
                    tappedHandler = assertionHandler;
                    loadedHandler = assertionHandler;
                    changedHandler = assertionHandler;
                    dataContextChangedHandler = assertionHandler;
                }
            }

            public class TwoArgumentsEventHandlerController : ITestUwpController
            {
                public void SetDataContext(object dataContext) => DataContext = dataContext;
                public object DataContext { get; private set; }

                [Element(Name = "element")]
                public void SetElement(FrameworkElement element) => Element = element;
                public FrameworkElement Element { get; private set; }

                [Element(Name = "childElement")]
                public void SetChildElement(FrameworkElement childElement) => ChildElement = childElement;
                public FrameworkElement ChildElement { get; private set; }

                public void childElement_Tapped(object sender, TappedRoutedEventArgs e)
                {
                    tappedHandler(sender, e);
                }
                private readonly TappedEventHandler tappedHandler;

                public void childElement_Loaded(object sender, RoutedEventArgs e)
                {
                    loadedHandler(sender, e);
                }
                private readonly RoutedEventHandler loadedHandler;

                public void childElement_Changed(object sender, RoutedEventArgs e)
                {
                    changedHandler(sender, e);
                }
                private readonly RoutedEventHandler changedHandler;

                public void childElement_DataContextChanged(FrameworkElement sender, DataContextChangedEventArgs e)
                {
                    dataContextChangedHandler(sender, e);
                }
                private readonly TypedEventHandler<FrameworkElement, DataContextChangedEventArgs> dataContextChangedHandler;

                public TwoArgumentsEventHandlerController(Action<object, object> assertionHandler)
                {
                    tappedHandler = (s, e) => assertionHandler(s, e);
                    loadedHandler = (s, e) => assertionHandler(s, e);
                    changedHandler = (s, e) => assertionHandler(s, e);
                    dataContextChangedHandler = (s, e) => assertionHandler(s, e);
                }
            }
        }
    }
}
