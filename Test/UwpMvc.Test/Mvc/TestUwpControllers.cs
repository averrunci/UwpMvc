// Copyright (C) 2017 Fievus
//
// This software may be modified and distributed under the terms
// of the MIT license.  See the LICENSE file for details.
using System;
using Windows.Foundation;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Input;

namespace Fievus.Windows.Mvc
{
    public class TestUwpControllers
    {
        public interface ITestUwpController
        {
            object Context { get; }
            FrameworkElement Element { get; }
            FrameworkElement ChildElement { get; }
        }

        public class TestUwpController
        {
            [DataContext]
            public object Context { get; set; }

            [Element]
            public FrameworkElement Element { get; set; }

            [EventHandler(ElementName = "Element", Event = "Tapped")]
            private void OnElementTapped()
            {
                AssertionHandler?.Invoke();
            }

            [EventHandler(ElementName = "Element", Event = "Loaded")]
            private void OnElementLoaded()
            {
                AssertionHandler?.Invoke();
            }

            [EventHandler(ElementName = "Element", Event = "Changed")]
            private void OnElementChanged()
            {
                AssertionHandler?.Invoke();
            }

            [EventHandler(ElementName = "Element", Event = "DataContextChanged")]
            private void OnElementDataContextChanged()
            {
                AssertionHandler?.Invoke();
            }

            public Action AssertionHandler { get; set; }

            public TestUwpController() { }
        }

        public class AttributedToField
        {
            public class NoArgumentHandlerController : ITestUwpController
            {
                [DataContext]
                private object context;

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
                    tappedHandler = () => assertionHandler();
                    loadedHandler = () => assertionHandler();
                    changedHandler = () => assertionHandler();
                    dataContextChangedHandler = () => assertionHandler();
                }

                public object Context { get { return context; } }
                public FrameworkElement Element { get { return element; } }
                public FrameworkElement ChildElement { get { return childElement; } }
            }

            public class OneArgumentHandlerController : ITestUwpController
            {
                [DataContext]
                private object context;

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
                    tappedHandler = e => assertionHandler(e);
                    loadedHandler = e => assertionHandler(e);
                    changedHandler = e => assertionHandler(e);
                    dataContextChangedHandler = e => assertionHandler(e);
                }

                public object Context { get { return context; } }
                public FrameworkElement Element { get { return element; } }
                public FrameworkElement ChildElement { get { return childElement; } }
            }

            public class TwoArgumentsEventHandlerController : ITestUwpController
            {
                [DataContext]
                private object context;

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

                public object Context { get { return context; } }
                public FrameworkElement Element { get { return element; } }
                public FrameworkElement ChildElement { get { return childElement; } }
            }
        }

        public class AttributedToProperty
        {
            public class NoArgumentHandlerController : ITestUwpController
            {
                [DataContext]
                public object Context { get; private set; }

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
                    TappedHandler = () => assertionHandler();
                    LoadedHandler = () => assertionHandler();
                    ChangedHandler = () => assertionHandler();
                    DataContextChangedHandler = () => assertionHandler();
                }
            }

            public class OneArgumentHandlerController : ITestUwpController
            {
                [DataContext]
                public object Context { get; private set; }

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
                    TappedHandler = e => assertionHandler(e);
                    LoadedHandler = e => assertionHandler(e);
                    ChangedHandler = e => assertionHandler(e);
                    DataContextChangedHandler = e => assertionHandler(e);
                }
            }

            public class TwoArgumentsEventHandlerController : ITestUwpController
            {
                [DataContext]
                public object Context { get; private set; }

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
                public void SetDataContext(object context) => Context = context;
                public object Context { get; private set; }

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
                private Action tappedHandler;

                [EventHandler(ElementName = "childElement", Event = "Loaded")]
                public void OnChildElementLoaded()
                {
                    loadedHandler();
                }
                private Action loadedHandler;

                [EventHandler(ElementName = "childElement", Event = "Changed")]
                public void OnChildElementChanged()
                {
                    changedHandler();
                }
                private Action changedHandler;

                [EventHandler(ElementName = "childElement", Event = "DataContextChanged")]
                public void OnChildElementDataContextChanged()
                {
                    dataContextChangedHandler();
                }
                private Action dataContextChangedHandler;

                public NoArgumentHandlerController(Action assertionHandler)
                {
                    tappedHandler = () => assertionHandler();
                    loadedHandler = () => assertionHandler();
                    changedHandler = () => assertionHandler();
                    dataContextChangedHandler = () => assertionHandler();
                }
            }

            public class OneArgumentHandlerController : ITestUwpController
            {
                [DataContext]
                public void SetDataContext(object context) => Context = context;
                public object Context { get; private set; }

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
                private Action<TappedRoutedEventArgs> tappedHandler;

                [EventHandler(ElementName = "childElement", Event = "Loaded")]
                public void OnChildElementLoaded(RoutedEventArgs e)
                {
                    loadedHandler(e);
                }
                private Action<RoutedEventArgs> loadedHandler;

                [EventHandler(ElementName = "childElement", Event = "Changed")]
                public void OnChildElementChanged(RoutedEventArgs e)
                {
                    changedHandler(e);
                }
                private Action<RoutedEventArgs> changedHandler;

                [EventHandler(ElementName = "childElement", Event = "DataContextChanged")]
                public void OnChildElementDataContextChanged(DataContextChangedEventArgs e)
                {
                    dataContextChangedHandler(e);
                }
                private Action<DataContextChangedEventArgs> dataContextChangedHandler;

                public OneArgumentHandlerController(Action<object> assertionHandler)
                {
                    tappedHandler = e => assertionHandler(e);
                    loadedHandler = e => assertionHandler(e);
                    changedHandler = e => assertionHandler(e);
                    dataContextChangedHandler = e => assertionHandler(e);
                }
            }

            public class TwoArgumentsEventHandlerController : ITestUwpController
            {
                [DataContext]
                public void SetDataContext(object context) => Context = context;
                public object Context { get; private set; }

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
                private TappedEventHandler tappedHandler;

                [EventHandler(ElementName = "childElement", Event = "Loaded")]
                public void OnChildElementLoaded(object sender, RoutedEventArgs e)
                {
                    loadedHandler(sender, e);
                }
                private RoutedEventHandler loadedHandler;

                [EventHandler(ElementName = "childElement", Event = "Changed")]
                public void OnChildElementChanged(object sender, RoutedEventArgs e)
                {
                    changedHandler(sender, e);
                }
                private RoutedEventHandler changedHandler;

                [EventHandler(ElementName = "childElement", Event = "DataContextChanged")]
                public void OnChildElementDataContextChanged(FrameworkElement sender, DataContextChangedEventArgs e)
                {
                    dataContextChangedHandler(sender, e);
                }
                private TypedEventHandler<FrameworkElement, DataContextChangedEventArgs> dataContextChangedHandler;

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
