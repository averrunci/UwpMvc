using System;
using System.Runtime.CompilerServices;
using Etg.SimpleStubs;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Controls;
using Windows.Foundation;
using System.Collections.Generic;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.Devices.Input;
using Windows.ApplicationModel.DataTransfer;
using Windows.Graphics.Imaging;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Input;
using Windows.System;
using Windows.UI.Core;
using Windows.UI.Xaml.Controls.Maps;
using Windows.Devices.Geolocation;
using Windows.Storage.Streams;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Animation;
using Windows.UI.Xaml.Navigation;
using Windows.Media.Playback;
using Windows.ApplicationModel.Search;
using Windows.Web;

namespace Fievus.Windows.Mvc
{
    [CompilerGenerated]
    public class StubIUwpControllerExtension : IUwpControllerExtension
    {
        private readonly StubContainer<StubIUwpControllerExtension> _stubs = new StubContainer<StubIUwpControllerExtension>();

        void global::Fievus.Windows.Mvc.IUwpControllerExtension.Attach(global::Windows.UI.Xaml.FrameworkElement element, object controller)
        {
            _stubs.GetMethodStub<Attach_FrameworkElement_Object_Delegate>("Attach").Invoke(element, controller);
        }

        public delegate void Attach_FrameworkElement_Object_Delegate(global::Windows.UI.Xaml.FrameworkElement element, object controller);

        public StubIUwpControllerExtension Attach(Attach_FrameworkElement_Object_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        void global::Fievus.Windows.Mvc.IUwpControllerExtension.Detach(global::Windows.UI.Xaml.FrameworkElement element, object controller)
        {
            _stubs.GetMethodStub<Detach_FrameworkElement_Object_Delegate>("Detach").Invoke(element, controller);
        }

        public delegate void Detach_FrameworkElement_Object_Delegate(global::Windows.UI.Xaml.FrameworkElement element, object controller);

        public StubIUwpControllerExtension Detach(Detach_FrameworkElement_Object_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        object global::Fievus.Windows.Mvc.IUwpControllerExtension.Retrieve(object controller)
        {
            return _stubs.GetMethodStub<Retrieve_Object_Delegate>("Retrieve").Invoke(controller);
        }

        public delegate object Retrieve_Object_Delegate(object controller);

        public StubIUwpControllerExtension Retrieve(Retrieve_Object_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }
    }
}

namespace Fievus.Windows.Mvc
{
    [CompilerGenerated]
    public class StubIUwpControllerFactory : IUwpControllerFactory
    {
        private readonly StubContainer<StubIUwpControllerFactory> _stubs = new StubContainer<StubIUwpControllerFactory>();

        object global::Fievus.Windows.Mvc.IUwpControllerFactory.Create(global::System.Type controllerType)
        {
            return _stubs.GetMethodStub<Create_Type_Delegate>("Create").Invoke(controllerType);
        }

        public delegate object Create_Type_Delegate(global::System.Type controllerType);

        public StubIUwpControllerFactory Create(Create_Type_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }
    }
}

namespace Fievus.Windows.Mvc
{
    [CompilerGenerated]
    public class StubIUwpControllerInjector : IUwpControllerInjector
    {
        private readonly StubContainer<StubIUwpControllerInjector> _stubs = new StubContainer<StubIUwpControllerInjector>();

        void global::Fievus.Windows.Mvc.IUwpControllerInjector.Inject(object controller)
        {
            _stubs.GetMethodStub<Inject_Object_Delegate>("Inject").Invoke(controller);
        }

        public delegate void Inject_Object_Delegate(object controller);

        public StubIUwpControllerInjector Inject(Inject_Object_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }
    }
}

namespace Fievus.Windows.Mvc.Wrappers
{
    [CompilerGenerated]
    public class StubIAccessKeyDisplayRequestedEventArgsResolver : IAccessKeyDisplayRequestedEventArgsResolver
    {
        private readonly StubContainer<StubIAccessKeyDisplayRequestedEventArgsResolver> _stubs = new StubContainer<StubIAccessKeyDisplayRequestedEventArgsResolver>();

        string global::Fievus.Windows.Mvc.Wrappers.IAccessKeyDisplayRequestedEventArgsResolver.PressedKeys(global::Windows.UI.Xaml.Input.AccessKeyDisplayRequestedEventArgs e)
        {
            return _stubs.GetMethodStub<PressedKeys_AccessKeyDisplayRequestedEventArgs_Delegate>("PressedKeys").Invoke(e);
        }

        public delegate string PressedKeys_AccessKeyDisplayRequestedEventArgs_Delegate(global::Windows.UI.Xaml.Input.AccessKeyDisplayRequestedEventArgs e);

        public StubIAccessKeyDisplayRequestedEventArgsResolver PressedKeys(PressedKeys_AccessKeyDisplayRequestedEventArgs_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }
    }
}

namespace Fievus.Windows.Mvc.Wrappers
{
    [CompilerGenerated]
    public class StubIAutoSuggestBoxQuerySubmittedEventArgsResolver : IAutoSuggestBoxQuerySubmittedEventArgsResolver
    {
        private readonly StubContainer<StubIAutoSuggestBoxQuerySubmittedEventArgsResolver> _stubs = new StubContainer<StubIAutoSuggestBoxQuerySubmittedEventArgsResolver>();

        object global::Fievus.Windows.Mvc.Wrappers.IAutoSuggestBoxQuerySubmittedEventArgsResolver.ChosenSuggestion(global::Windows.UI.Xaml.Controls.AutoSuggestBoxQuerySubmittedEventArgs e)
        {
            return _stubs.GetMethodStub<ChosenSuggestion_AutoSuggestBoxQuerySubmittedEventArgs_Delegate>("ChosenSuggestion").Invoke(e);
        }

        public delegate object ChosenSuggestion_AutoSuggestBoxQuerySubmittedEventArgs_Delegate(global::Windows.UI.Xaml.Controls.AutoSuggestBoxQuerySubmittedEventArgs e);

        public StubIAutoSuggestBoxQuerySubmittedEventArgsResolver ChosenSuggestion(ChosenSuggestion_AutoSuggestBoxQuerySubmittedEventArgs_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        string global::Fievus.Windows.Mvc.Wrappers.IAutoSuggestBoxQuerySubmittedEventArgsResolver.QueryText(global::Windows.UI.Xaml.Controls.AutoSuggestBoxQuerySubmittedEventArgs e)
        {
            return _stubs.GetMethodStub<QueryText_AutoSuggestBoxQuerySubmittedEventArgs_Delegate>("QueryText").Invoke(e);
        }

        public delegate string QueryText_AutoSuggestBoxQuerySubmittedEventArgs_Delegate(global::Windows.UI.Xaml.Controls.AutoSuggestBoxQuerySubmittedEventArgs e);

        public StubIAutoSuggestBoxQuerySubmittedEventArgsResolver QueryText(QueryText_AutoSuggestBoxQuerySubmittedEventArgs_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }
    }
}

namespace Fievus.Windows.Mvc.Wrappers
{
    [CompilerGenerated]
    public class StubIAutoSuggestBoxSuggestionChosenEventArgsResolver : IAutoSuggestBoxSuggestionChosenEventArgsResolver
    {
        private readonly StubContainer<StubIAutoSuggestBoxSuggestionChosenEventArgsResolver> _stubs = new StubContainer<StubIAutoSuggestBoxSuggestionChosenEventArgsResolver>();

        object global::Fievus.Windows.Mvc.Wrappers.IAutoSuggestBoxSuggestionChosenEventArgsResolver.SelectedItem(global::Windows.UI.Xaml.Controls.AutoSuggestBoxSuggestionChosenEventArgs e)
        {
            return _stubs.GetMethodStub<SelectedItem_AutoSuggestBoxSuggestionChosenEventArgs_Delegate>("SelectedItem").Invoke(e);
        }

        public delegate object SelectedItem_AutoSuggestBoxSuggestionChosenEventArgs_Delegate(global::Windows.UI.Xaml.Controls.AutoSuggestBoxSuggestionChosenEventArgs e);

        public StubIAutoSuggestBoxSuggestionChosenEventArgsResolver SelectedItem(SelectedItem_AutoSuggestBoxSuggestionChosenEventArgs_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }
    }
}

namespace Fievus.Windows.Mvc.Wrappers
{
    [CompilerGenerated]
    public class StubICalendarDatePickerDateChangedEventArgsResolver : ICalendarDatePickerDateChangedEventArgsResolver
    {
        private readonly StubContainer<StubICalendarDatePickerDateChangedEventArgsResolver> _stubs = new StubContainer<StubICalendarDatePickerDateChangedEventArgsResolver>();

        global::System.DateTimeOffset? global::Fievus.Windows.Mvc.Wrappers.ICalendarDatePickerDateChangedEventArgsResolver.NewDate(global::Windows.UI.Xaml.Controls.CalendarDatePickerDateChangedEventArgs e)
        {
            return _stubs.GetMethodStub<NewDate_CalendarDatePickerDateChangedEventArgs_Delegate>("NewDate").Invoke(e);
        }

        public delegate global::System.DateTimeOffset? NewDate_CalendarDatePickerDateChangedEventArgs_Delegate(global::Windows.UI.Xaml.Controls.CalendarDatePickerDateChangedEventArgs e);

        public StubICalendarDatePickerDateChangedEventArgsResolver NewDate(NewDate_CalendarDatePickerDateChangedEventArgs_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        global::System.DateTimeOffset? global::Fievus.Windows.Mvc.Wrappers.ICalendarDatePickerDateChangedEventArgsResolver.OldData(global::Windows.UI.Xaml.Controls.CalendarDatePickerDateChangedEventArgs e)
        {
            return _stubs.GetMethodStub<OldData_CalendarDatePickerDateChangedEventArgs_Delegate>("OldData").Invoke(e);
        }

        public delegate global::System.DateTimeOffset? OldData_CalendarDatePickerDateChangedEventArgs_Delegate(global::Windows.UI.Xaml.Controls.CalendarDatePickerDateChangedEventArgs e);

        public StubICalendarDatePickerDateChangedEventArgsResolver OldData(OldData_CalendarDatePickerDateChangedEventArgs_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }
    }
}

namespace Fievus.Windows.Mvc.Wrappers
{
    [CompilerGenerated]
    public class StubICalendarViewDayItemChangingEventArgsResolver : ICalendarViewDayItemChangingEventArgsResolver
    {
        private readonly StubContainer<StubICalendarViewDayItemChangingEventArgsResolver> _stubs = new StubContainer<StubICalendarViewDayItemChangingEventArgsResolver>();

        bool global::Fievus.Windows.Mvc.Wrappers.ICalendarViewDayItemChangingEventArgsResolver.InRecycleQueue(global::Windows.UI.Xaml.Controls.CalendarViewDayItemChangingEventArgs e)
        {
            return _stubs.GetMethodStub<InRecycleQueue_CalendarViewDayItemChangingEventArgs_Delegate>("InRecycleQueue").Invoke(e);
        }

        public delegate bool InRecycleQueue_CalendarViewDayItemChangingEventArgs_Delegate(global::Windows.UI.Xaml.Controls.CalendarViewDayItemChangingEventArgs e);

        public StubICalendarViewDayItemChangingEventArgsResolver InRecycleQueue(InRecycleQueue_CalendarViewDayItemChangingEventArgs_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        global::Windows.UI.Xaml.Controls.CalendarViewDayItem global::Fievus.Windows.Mvc.Wrappers.ICalendarViewDayItemChangingEventArgsResolver.Item(global::Windows.UI.Xaml.Controls.CalendarViewDayItemChangingEventArgs e)
        {
            return _stubs.GetMethodStub<Item_CalendarViewDayItemChangingEventArgs_Delegate>("Item").Invoke(e);
        }

        public delegate global::Windows.UI.Xaml.Controls.CalendarViewDayItem Item_CalendarViewDayItemChangingEventArgs_Delegate(global::Windows.UI.Xaml.Controls.CalendarViewDayItemChangingEventArgs e);

        public StubICalendarViewDayItemChangingEventArgsResolver Item(Item_CalendarViewDayItemChangingEventArgs_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        uint global::Fievus.Windows.Mvc.Wrappers.ICalendarViewDayItemChangingEventArgsResolver.Phase(global::Windows.UI.Xaml.Controls.CalendarViewDayItemChangingEventArgs e)
        {
            return _stubs.GetMethodStub<Phase_CalendarViewDayItemChangingEventArgs_Delegate>("Phase").Invoke(e);
        }

        public delegate uint Phase_CalendarViewDayItemChangingEventArgs_Delegate(global::Windows.UI.Xaml.Controls.CalendarViewDayItemChangingEventArgs e);

        public StubICalendarViewDayItemChangingEventArgsResolver Phase(Phase_CalendarViewDayItemChangingEventArgs_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        void global::Fievus.Windows.Mvc.Wrappers.ICalendarViewDayItemChangingEventArgsResolver.RegisterUpdateCallback(global::Windows.UI.Xaml.Controls.CalendarViewDayItemChangingEventArgs e, global::Windows.Foundation.TypedEventHandler<global::Windows.UI.Xaml.Controls.CalendarView, global::Windows.UI.Xaml.Controls.CalendarViewDayItemChangingEventArgs> callback)
        {
            _stubs.GetMethodStub<RegisterUpdateCallback_CalendarViewDayItemChangingEventArgs_TypedEventHandlerOfCalendarViewCalendarViewDayItemChangingEventArgs_Delegate>("RegisterUpdateCallback").Invoke(e, callback);
        }

        public delegate void RegisterUpdateCallback_CalendarViewDayItemChangingEventArgs_TypedEventHandlerOfCalendarViewCalendarViewDayItemChangingEventArgs_Delegate(global::Windows.UI.Xaml.Controls.CalendarViewDayItemChangingEventArgs e, global::Windows.Foundation.TypedEventHandler<global::Windows.UI.Xaml.Controls.CalendarView, global::Windows.UI.Xaml.Controls.CalendarViewDayItemChangingEventArgs> callback);

        public StubICalendarViewDayItemChangingEventArgsResolver RegisterUpdateCallback(RegisterUpdateCallback_CalendarViewDayItemChangingEventArgs_TypedEventHandlerOfCalendarViewCalendarViewDayItemChangingEventArgs_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        void global::Fievus.Windows.Mvc.Wrappers.ICalendarViewDayItemChangingEventArgsResolver.RegisterUpdateCallback(global::Windows.UI.Xaml.Controls.CalendarViewDayItemChangingEventArgs e, uint callbackPhase, global::Windows.Foundation.TypedEventHandler<global::Windows.UI.Xaml.Controls.CalendarView, global::Windows.UI.Xaml.Controls.CalendarViewDayItemChangingEventArgs> callback)
        {
            _stubs.GetMethodStub<RegisterUpdateCallback_CalendarViewDayItemChangingEventArgs_UInt32_TypedEventHandlerOfCalendarViewCalendarViewDayItemChangingEventArgs_Delegate>("RegisterUpdateCallback").Invoke(e, callbackPhase, callback);
        }

        public delegate void RegisterUpdateCallback_CalendarViewDayItemChangingEventArgs_UInt32_TypedEventHandlerOfCalendarViewCalendarViewDayItemChangingEventArgs_Delegate(global::Windows.UI.Xaml.Controls.CalendarViewDayItemChangingEventArgs e, uint callbackPhase, global::Windows.Foundation.TypedEventHandler<global::Windows.UI.Xaml.Controls.CalendarView, global::Windows.UI.Xaml.Controls.CalendarViewDayItemChangingEventArgs> callback);

        public StubICalendarViewDayItemChangingEventArgsResolver RegisterUpdateCallback(RegisterUpdateCallback_CalendarViewDayItemChangingEventArgs_UInt32_TypedEventHandlerOfCalendarViewCalendarViewDayItemChangingEventArgs_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }
    }
}

namespace Fievus.Windows.Mvc.Wrappers
{
    [CompilerGenerated]
    public class StubICalendarViewSelectedDatesChangedEventArgsResolver : ICalendarViewSelectedDatesChangedEventArgsResolver
    {
        private readonly StubContainer<StubICalendarViewSelectedDatesChangedEventArgsResolver> _stubs = new StubContainer<StubICalendarViewSelectedDatesChangedEventArgsResolver>();

        global::System.Collections.Generic.IReadOnlyList<global::System.DateTimeOffset> global::Fievus.Windows.Mvc.Wrappers.ICalendarViewSelectedDatesChangedEventArgsResolver.AddedDates(global::Windows.UI.Xaml.Controls.CalendarViewSelectedDatesChangedEventArgs e)
        {
            return _stubs.GetMethodStub<AddedDates_CalendarViewSelectedDatesChangedEventArgs_Delegate>("AddedDates").Invoke(e);
        }

        public delegate global::System.Collections.Generic.IReadOnlyList<global::System.DateTimeOffset> AddedDates_CalendarViewSelectedDatesChangedEventArgs_Delegate(global::Windows.UI.Xaml.Controls.CalendarViewSelectedDatesChangedEventArgs e);

        public StubICalendarViewSelectedDatesChangedEventArgsResolver AddedDates(AddedDates_CalendarViewSelectedDatesChangedEventArgs_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        global::System.Collections.Generic.IReadOnlyList<global::System.DateTimeOffset> global::Fievus.Windows.Mvc.Wrappers.ICalendarViewSelectedDatesChangedEventArgsResolver.RemovedDates(global::Windows.UI.Xaml.Controls.CalendarViewSelectedDatesChangedEventArgs e)
        {
            return _stubs.GetMethodStub<RemovedDates_CalendarViewSelectedDatesChangedEventArgs_Delegate>("RemovedDates").Invoke(e);
        }

        public delegate global::System.Collections.Generic.IReadOnlyList<global::System.DateTimeOffset> RemovedDates_CalendarViewSelectedDatesChangedEventArgs_Delegate(global::Windows.UI.Xaml.Controls.CalendarViewSelectedDatesChangedEventArgs e);

        public StubICalendarViewSelectedDatesChangedEventArgsResolver RemovedDates(RemovedDates_CalendarViewSelectedDatesChangedEventArgs_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }
    }
}

namespace Fievus.Windows.Mvc.Wrappers
{
    [CompilerGenerated]
    public class StubICandidateWindowBoundsChangedEventArgsResolver : ICandidateWindowBoundsChangedEventArgsResolver
    {
        private readonly StubContainer<StubICandidateWindowBoundsChangedEventArgsResolver> _stubs = new StubContainer<StubICandidateWindowBoundsChangedEventArgsResolver>();

        global::Windows.Foundation.Rect global::Fievus.Windows.Mvc.Wrappers.ICandidateWindowBoundsChangedEventArgsResolver.Bounds(global::Windows.UI.Xaml.Controls.CandidateWindowBoundsChangedEventArgs e)
        {
            return _stubs.GetMethodStub<Bounds_CandidateWindowBoundsChangedEventArgs_Delegate>("Bounds").Invoke(e);
        }

        public delegate global::Windows.Foundation.Rect Bounds_CandidateWindowBoundsChangedEventArgs_Delegate(global::Windows.UI.Xaml.Controls.CandidateWindowBoundsChangedEventArgs e);

        public StubICandidateWindowBoundsChangedEventArgsResolver Bounds(Bounds_CandidateWindowBoundsChangedEventArgs_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }
    }
}

namespace Fievus.Windows.Mvc.Wrappers
{
    [CompilerGenerated]
    public class StubIChoosingGroupHeaderContainerEventArgsResolver : IChoosingGroupHeaderContainerEventArgsResolver
    {
        private readonly StubContainer<StubIChoosingGroupHeaderContainerEventArgsResolver> _stubs = new StubContainer<StubIChoosingGroupHeaderContainerEventArgsResolver>();

        object global::Fievus.Windows.Mvc.Wrappers.IChoosingGroupHeaderContainerEventArgsResolver.Group(global::Windows.UI.Xaml.Controls.ChoosingGroupHeaderContainerEventArgs e)
        {
            return _stubs.GetMethodStub<Group_ChoosingGroupHeaderContainerEventArgs_Delegate>("Group").Invoke(e);
        }

        public delegate object Group_ChoosingGroupHeaderContainerEventArgs_Delegate(global::Windows.UI.Xaml.Controls.ChoosingGroupHeaderContainerEventArgs e);

        public StubIChoosingGroupHeaderContainerEventArgsResolver Group(Group_ChoosingGroupHeaderContainerEventArgs_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        global::Windows.UI.Xaml.Controls.ListViewBaseHeaderItem global::Fievus.Windows.Mvc.Wrappers.IChoosingGroupHeaderContainerEventArgsResolver.GroupHeaderContainer(global::Windows.UI.Xaml.Controls.ChoosingGroupHeaderContainerEventArgs e)
        {
            return _stubs.GetMethodStub<GroupHeaderContainer_ChoosingGroupHeaderContainerEventArgs_Delegate>("GroupHeaderContainer").Invoke(e);
        }

        public delegate global::Windows.UI.Xaml.Controls.ListViewBaseHeaderItem GroupHeaderContainer_ChoosingGroupHeaderContainerEventArgs_Delegate(global::Windows.UI.Xaml.Controls.ChoosingGroupHeaderContainerEventArgs e);

        public StubIChoosingGroupHeaderContainerEventArgsResolver GroupHeaderContainer(GroupHeaderContainer_ChoosingGroupHeaderContainerEventArgs_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        void global::Fievus.Windows.Mvc.Wrappers.IChoosingGroupHeaderContainerEventArgsResolver.GroupHeaderContainer(global::Windows.UI.Xaml.Controls.ChoosingGroupHeaderContainerEventArgs e, global::Windows.UI.Xaml.Controls.ListViewBaseHeaderItem groupHeaderContainer)
        {
            _stubs.GetMethodStub<GroupHeaderContainer_ChoosingGroupHeaderContainerEventArgs_ListViewBaseHeaderItem_Delegate>("GroupHeaderContainer").Invoke(e, groupHeaderContainer);
        }

        public delegate void GroupHeaderContainer_ChoosingGroupHeaderContainerEventArgs_ListViewBaseHeaderItem_Delegate(global::Windows.UI.Xaml.Controls.ChoosingGroupHeaderContainerEventArgs e, global::Windows.UI.Xaml.Controls.ListViewBaseHeaderItem groupHeaderContainer);

        public StubIChoosingGroupHeaderContainerEventArgsResolver GroupHeaderContainer(GroupHeaderContainer_ChoosingGroupHeaderContainerEventArgs_ListViewBaseHeaderItem_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        int global::Fievus.Windows.Mvc.Wrappers.IChoosingGroupHeaderContainerEventArgsResolver.GroupIndex(global::Windows.UI.Xaml.Controls.ChoosingGroupHeaderContainerEventArgs e)
        {
            return _stubs.GetMethodStub<GroupIndex_ChoosingGroupHeaderContainerEventArgs_Delegate>("GroupIndex").Invoke(e);
        }

        public delegate int GroupIndex_ChoosingGroupHeaderContainerEventArgs_Delegate(global::Windows.UI.Xaml.Controls.ChoosingGroupHeaderContainerEventArgs e);

        public StubIChoosingGroupHeaderContainerEventArgsResolver GroupIndex(GroupIndex_ChoosingGroupHeaderContainerEventArgs_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }
    }
}

namespace Fievus.Windows.Mvc.Wrappers
{
    [CompilerGenerated]
    public class StubIChoosingItemContainerEventArgsResolver : IChoosingItemContainerEventArgsResolver
    {
        private readonly StubContainer<StubIChoosingItemContainerEventArgsResolver> _stubs = new StubContainer<StubIChoosingItemContainerEventArgsResolver>();

        bool global::Fievus.Windows.Mvc.Wrappers.IChoosingItemContainerEventArgsResolver.IsContainerPrepared(global::Windows.UI.Xaml.Controls.ChoosingItemContainerEventArgs e)
        {
            return _stubs.GetMethodStub<IsContainerPrepared_ChoosingItemContainerEventArgs_Delegate>("IsContainerPrepared").Invoke(e);
        }

        public delegate bool IsContainerPrepared_ChoosingItemContainerEventArgs_Delegate(global::Windows.UI.Xaml.Controls.ChoosingItemContainerEventArgs e);

        public StubIChoosingItemContainerEventArgsResolver IsContainerPrepared(IsContainerPrepared_ChoosingItemContainerEventArgs_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        void global::Fievus.Windows.Mvc.Wrappers.IChoosingItemContainerEventArgsResolver.IsContainerPrepared(global::Windows.UI.Xaml.Controls.ChoosingItemContainerEventArgs e, bool isContainerPrepared)
        {
            _stubs.GetMethodStub<IsContainerPrepared_ChoosingItemContainerEventArgs_Boolean_Delegate>("IsContainerPrepared").Invoke(e, isContainerPrepared);
        }

        public delegate void IsContainerPrepared_ChoosingItemContainerEventArgs_Boolean_Delegate(global::Windows.UI.Xaml.Controls.ChoosingItemContainerEventArgs e, bool isContainerPrepared);

        public StubIChoosingItemContainerEventArgsResolver IsContainerPrepared(IsContainerPrepared_ChoosingItemContainerEventArgs_Boolean_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        object global::Fievus.Windows.Mvc.Wrappers.IChoosingItemContainerEventArgsResolver.Item(global::Windows.UI.Xaml.Controls.ChoosingItemContainerEventArgs e)
        {
            return _stubs.GetMethodStub<Item_ChoosingItemContainerEventArgs_Delegate>("Item").Invoke(e);
        }

        public delegate object Item_ChoosingItemContainerEventArgs_Delegate(global::Windows.UI.Xaml.Controls.ChoosingItemContainerEventArgs e);

        public StubIChoosingItemContainerEventArgsResolver Item(Item_ChoosingItemContainerEventArgs_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        global::Windows.UI.Xaml.Controls.Primitives.SelectorItem global::Fievus.Windows.Mvc.Wrappers.IChoosingItemContainerEventArgsResolver.ItemContainer(global::Windows.UI.Xaml.Controls.ChoosingItemContainerEventArgs e)
        {
            return _stubs.GetMethodStub<ItemContainer_ChoosingItemContainerEventArgs_Delegate>("ItemContainer").Invoke(e);
        }

        public delegate global::Windows.UI.Xaml.Controls.Primitives.SelectorItem ItemContainer_ChoosingItemContainerEventArgs_Delegate(global::Windows.UI.Xaml.Controls.ChoosingItemContainerEventArgs e);

        public StubIChoosingItemContainerEventArgsResolver ItemContainer(ItemContainer_ChoosingItemContainerEventArgs_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        void global::Fievus.Windows.Mvc.Wrappers.IChoosingItemContainerEventArgsResolver.ItemContainer(global::Windows.UI.Xaml.Controls.ChoosingItemContainerEventArgs e, global::Windows.UI.Xaml.Controls.Primitives.SelectorItem itemContainer)
        {
            _stubs.GetMethodStub<ItemContainer_ChoosingItemContainerEventArgs_SelectorItem_Delegate>("ItemContainer").Invoke(e, itemContainer);
        }

        public delegate void ItemContainer_ChoosingItemContainerEventArgs_SelectorItem_Delegate(global::Windows.UI.Xaml.Controls.ChoosingItemContainerEventArgs e, global::Windows.UI.Xaml.Controls.Primitives.SelectorItem itemContainer);

        public StubIChoosingItemContainerEventArgsResolver ItemContainer(ItemContainer_ChoosingItemContainerEventArgs_SelectorItem_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        int global::Fievus.Windows.Mvc.Wrappers.IChoosingItemContainerEventArgsResolver.ItemIndex(global::Windows.UI.Xaml.Controls.ChoosingItemContainerEventArgs e)
        {
            return _stubs.GetMethodStub<ItemIndex_ChoosingItemContainerEventArgs_Delegate>("ItemIndex").Invoke(e);
        }

        public delegate int ItemIndex_ChoosingItemContainerEventArgs_Delegate(global::Windows.UI.Xaml.Controls.ChoosingItemContainerEventArgs e);

        public StubIChoosingItemContainerEventArgsResolver ItemIndex(ItemIndex_ChoosingItemContainerEventArgs_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }
    }
}

namespace Fievus.Windows.Mvc.Wrappers
{
    [CompilerGenerated]
    public class StubIContainerContentChangingEventArgsResolver : IContainerContentChangingEventArgsResolver
    {
        private readonly StubContainer<StubIContainerContentChangingEventArgsResolver> _stubs = new StubContainer<StubIContainerContentChangingEventArgsResolver>();

        bool global::Fievus.Windows.Mvc.Wrappers.IContainerContentChangingEventArgsResolver.Handled(global::Windows.UI.Xaml.Controls.ContainerContentChangingEventArgs e)
        {
            return _stubs.GetMethodStub<Handled_ContainerContentChangingEventArgs_Delegate>("Handled").Invoke(e);
        }

        public delegate bool Handled_ContainerContentChangingEventArgs_Delegate(global::Windows.UI.Xaml.Controls.ContainerContentChangingEventArgs e);

        public StubIContainerContentChangingEventArgsResolver Handled(Handled_ContainerContentChangingEventArgs_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        void global::Fievus.Windows.Mvc.Wrappers.IContainerContentChangingEventArgsResolver.Handled(global::Windows.UI.Xaml.Controls.ContainerContentChangingEventArgs e, bool handled)
        {
            _stubs.GetMethodStub<Handled_ContainerContentChangingEventArgs_Boolean_Delegate>("Handled").Invoke(e, handled);
        }

        public delegate void Handled_ContainerContentChangingEventArgs_Boolean_Delegate(global::Windows.UI.Xaml.Controls.ContainerContentChangingEventArgs e, bool handled);

        public StubIContainerContentChangingEventArgsResolver Handled(Handled_ContainerContentChangingEventArgs_Boolean_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        bool global::Fievus.Windows.Mvc.Wrappers.IContainerContentChangingEventArgsResolver.InRecycleQueue(global::Windows.UI.Xaml.Controls.ContainerContentChangingEventArgs e)
        {
            return _stubs.GetMethodStub<InRecycleQueue_ContainerContentChangingEventArgs_Delegate>("InRecycleQueue").Invoke(e);
        }

        public delegate bool InRecycleQueue_ContainerContentChangingEventArgs_Delegate(global::Windows.UI.Xaml.Controls.ContainerContentChangingEventArgs e);

        public StubIContainerContentChangingEventArgsResolver InRecycleQueue(InRecycleQueue_ContainerContentChangingEventArgs_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        object global::Fievus.Windows.Mvc.Wrappers.IContainerContentChangingEventArgsResolver.Item(global::Windows.UI.Xaml.Controls.ContainerContentChangingEventArgs e)
        {
            return _stubs.GetMethodStub<Item_ContainerContentChangingEventArgs_Delegate>("Item").Invoke(e);
        }

        public delegate object Item_ContainerContentChangingEventArgs_Delegate(global::Windows.UI.Xaml.Controls.ContainerContentChangingEventArgs e);

        public StubIContainerContentChangingEventArgsResolver Item(Item_ContainerContentChangingEventArgs_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        global::Windows.UI.Xaml.Controls.Primitives.SelectorItem global::Fievus.Windows.Mvc.Wrappers.IContainerContentChangingEventArgsResolver.ItemContainer(global::Windows.UI.Xaml.Controls.ContainerContentChangingEventArgs e)
        {
            return _stubs.GetMethodStub<ItemContainer_ContainerContentChangingEventArgs_Delegate>("ItemContainer").Invoke(e);
        }

        public delegate global::Windows.UI.Xaml.Controls.Primitives.SelectorItem ItemContainer_ContainerContentChangingEventArgs_Delegate(global::Windows.UI.Xaml.Controls.ContainerContentChangingEventArgs e);

        public StubIContainerContentChangingEventArgsResolver ItemContainer(ItemContainer_ContainerContentChangingEventArgs_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        int global::Fievus.Windows.Mvc.Wrappers.IContainerContentChangingEventArgsResolver.ItemIndex(global::Windows.UI.Xaml.Controls.ContainerContentChangingEventArgs e)
        {
            return _stubs.GetMethodStub<ItemIndex_ContainerContentChangingEventArgs_Delegate>("ItemIndex").Invoke(e);
        }

        public delegate int ItemIndex_ContainerContentChangingEventArgs_Delegate(global::Windows.UI.Xaml.Controls.ContainerContentChangingEventArgs e);

        public StubIContainerContentChangingEventArgsResolver ItemIndex(ItemIndex_ContainerContentChangingEventArgs_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        uint global::Fievus.Windows.Mvc.Wrappers.IContainerContentChangingEventArgsResolver.Phase(global::Windows.UI.Xaml.Controls.ContainerContentChangingEventArgs e)
        {
            return _stubs.GetMethodStub<Phase_ContainerContentChangingEventArgs_Delegate>("Phase").Invoke(e);
        }

        public delegate uint Phase_ContainerContentChangingEventArgs_Delegate(global::Windows.UI.Xaml.Controls.ContainerContentChangingEventArgs e);

        public StubIContainerContentChangingEventArgsResolver Phase(Phase_ContainerContentChangingEventArgs_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        void global::Fievus.Windows.Mvc.Wrappers.IContainerContentChangingEventArgsResolver.RegisterUpdateCallback(global::Windows.UI.Xaml.Controls.ContainerContentChangingEventArgs e, global::Windows.Foundation.TypedEventHandler<global::Windows.UI.Xaml.Controls.ListViewBase, global::Windows.UI.Xaml.Controls.ContainerContentChangingEventArgs> callback)
        {
            _stubs.GetMethodStub<RegisterUpdateCallback_ContainerContentChangingEventArgs_TypedEventHandlerOfListViewBaseContainerContentChangingEventArgs_Delegate>("RegisterUpdateCallback").Invoke(e, callback);
        }

        public delegate void RegisterUpdateCallback_ContainerContentChangingEventArgs_TypedEventHandlerOfListViewBaseContainerContentChangingEventArgs_Delegate(global::Windows.UI.Xaml.Controls.ContainerContentChangingEventArgs e, global::Windows.Foundation.TypedEventHandler<global::Windows.UI.Xaml.Controls.ListViewBase, global::Windows.UI.Xaml.Controls.ContainerContentChangingEventArgs> callback);

        public StubIContainerContentChangingEventArgsResolver RegisterUpdateCallback(RegisterUpdateCallback_ContainerContentChangingEventArgs_TypedEventHandlerOfListViewBaseContainerContentChangingEventArgs_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        void global::Fievus.Windows.Mvc.Wrappers.IContainerContentChangingEventArgsResolver.RegisterUpdateCallback(global::Windows.UI.Xaml.Controls.ContainerContentChangingEventArgs e, uint callbackPhase, global::Windows.Foundation.TypedEventHandler<global::Windows.UI.Xaml.Controls.ListViewBase, global::Windows.UI.Xaml.Controls.ContainerContentChangingEventArgs> callback)
        {
            _stubs.GetMethodStub<RegisterUpdateCallback_ContainerContentChangingEventArgs_UInt32_TypedEventHandlerOfListViewBaseContainerContentChangingEventArgs_Delegate>("RegisterUpdateCallback").Invoke(e, callbackPhase, callback);
        }

        public delegate void RegisterUpdateCallback_ContainerContentChangingEventArgs_UInt32_TypedEventHandlerOfListViewBaseContainerContentChangingEventArgs_Delegate(global::Windows.UI.Xaml.Controls.ContainerContentChangingEventArgs e, uint callbackPhase, global::Windows.Foundation.TypedEventHandler<global::Windows.UI.Xaml.Controls.ListViewBase, global::Windows.UI.Xaml.Controls.ContainerContentChangingEventArgs> callback);

        public StubIContainerContentChangingEventArgsResolver RegisterUpdateCallback(RegisterUpdateCallback_ContainerContentChangingEventArgs_UInt32_TypedEventHandlerOfListViewBaseContainerContentChangingEventArgs_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }
    }
}

namespace Fievus.Windows.Mvc.Wrappers
{
    [CompilerGenerated]
    public class StubIContentDialogClosingDeferralResolver : IContentDialogClosingDeferralResolver
    {
        private readonly StubContainer<StubIContentDialogClosingDeferralResolver> _stubs = new StubContainer<StubIContentDialogClosingDeferralResolver>();

        void global::Fievus.Windows.Mvc.Wrappers.IContentDialogClosingDeferralResolver.Complete(global::Windows.UI.Xaml.Controls.ContentDialogClosingDeferral deferral)
        {
            _stubs.GetMethodStub<Complete_ContentDialogClosingDeferral_Delegate>("Complete").Invoke(deferral);
        }

        public delegate void Complete_ContentDialogClosingDeferral_Delegate(global::Windows.UI.Xaml.Controls.ContentDialogClosingDeferral deferral);

        public StubIContentDialogClosingDeferralResolver Complete(Complete_ContentDialogClosingDeferral_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }
    }
}

namespace Fievus.Windows.Mvc.Wrappers
{
    [CompilerGenerated]
    public class StubIContentDialogClosingEventArgsResolver : IContentDialogClosingEventArgsResolver
    {
        private readonly StubContainer<StubIContentDialogClosingEventArgsResolver> _stubs = new StubContainer<StubIContentDialogClosingEventArgsResolver>();

        bool global::Fievus.Windows.Mvc.Wrappers.IContentDialogClosingEventArgsResolver.Cancel(global::Windows.UI.Xaml.Controls.ContentDialogClosingEventArgs e)
        {
            return _stubs.GetMethodStub<Cancel_ContentDialogClosingEventArgs_Delegate>("Cancel").Invoke(e);
        }

        public delegate bool Cancel_ContentDialogClosingEventArgs_Delegate(global::Windows.UI.Xaml.Controls.ContentDialogClosingEventArgs e);

        public StubIContentDialogClosingEventArgsResolver Cancel(Cancel_ContentDialogClosingEventArgs_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        void global::Fievus.Windows.Mvc.Wrappers.IContentDialogClosingEventArgsResolver.Cancel(global::Windows.UI.Xaml.Controls.ContentDialogClosingEventArgs e, bool cancel)
        {
            _stubs.GetMethodStub<Cancel_ContentDialogClosingEventArgs_Boolean_Delegate>("Cancel").Invoke(e, cancel);
        }

        public delegate void Cancel_ContentDialogClosingEventArgs_Boolean_Delegate(global::Windows.UI.Xaml.Controls.ContentDialogClosingEventArgs e, bool cancel);

        public StubIContentDialogClosingEventArgsResolver Cancel(Cancel_ContentDialogClosingEventArgs_Boolean_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        global::Windows.UI.Xaml.Controls.ContentDialogResult global::Fievus.Windows.Mvc.Wrappers.IContentDialogClosingEventArgsResolver.Result(global::Windows.UI.Xaml.Controls.ContentDialogClosingEventArgs e)
        {
            return _stubs.GetMethodStub<Result_ContentDialogClosingEventArgs_Delegate>("Result").Invoke(e);
        }

        public delegate global::Windows.UI.Xaml.Controls.ContentDialogResult Result_ContentDialogClosingEventArgs_Delegate(global::Windows.UI.Xaml.Controls.ContentDialogClosingEventArgs e);

        public StubIContentDialogClosingEventArgsResolver Result(Result_ContentDialogClosingEventArgs_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        global::Windows.UI.Xaml.Controls.ContentDialogClosingDeferral global::Fievus.Windows.Mvc.Wrappers.IContentDialogClosingEventArgsResolver.GetDeferral(global::Windows.UI.Xaml.Controls.ContentDialogClosingEventArgs e)
        {
            return _stubs.GetMethodStub<GetDeferral_ContentDialogClosingEventArgs_Delegate>("GetDeferral").Invoke(e);
        }

        public delegate global::Windows.UI.Xaml.Controls.ContentDialogClosingDeferral GetDeferral_ContentDialogClosingEventArgs_Delegate(global::Windows.UI.Xaml.Controls.ContentDialogClosingEventArgs e);

        public StubIContentDialogClosingEventArgsResolver GetDeferral(GetDeferral_ContentDialogClosingEventArgs_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }
    }
}

namespace Fievus.Windows.Mvc.Wrappers
{
    [CompilerGenerated]
    public class StubIContextMenuEventArgsResolver : IContextMenuEventArgsResolver
    {
        private readonly StubContainer<StubIContextMenuEventArgsResolver> _stubs = new StubContainer<StubIContextMenuEventArgsResolver>();

        double global::Fievus.Windows.Mvc.Wrappers.IContextMenuEventArgsResolver.CursorLeft(global::Windows.UI.Xaml.Controls.ContextMenuEventArgs e)
        {
            return _stubs.GetMethodStub<CursorLeft_ContextMenuEventArgs_Delegate>("CursorLeft").Invoke(e);
        }

        public delegate double CursorLeft_ContextMenuEventArgs_Delegate(global::Windows.UI.Xaml.Controls.ContextMenuEventArgs e);

        public StubIContextMenuEventArgsResolver CursorLeft(CursorLeft_ContextMenuEventArgs_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        double global::Fievus.Windows.Mvc.Wrappers.IContextMenuEventArgsResolver.CursorTop(global::Windows.UI.Xaml.Controls.ContextMenuEventArgs e)
        {
            return _stubs.GetMethodStub<CursorTop_ContextMenuEventArgs_Delegate>("CursorTop").Invoke(e);
        }

        public delegate double CursorTop_ContextMenuEventArgs_Delegate(global::Windows.UI.Xaml.Controls.ContextMenuEventArgs e);

        public StubIContextMenuEventArgsResolver CursorTop(CursorTop_ContextMenuEventArgs_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        bool global::Fievus.Windows.Mvc.Wrappers.IContextMenuEventArgsResolver.Handled(global::Windows.UI.Xaml.Controls.ContextMenuEventArgs e)
        {
            return _stubs.GetMethodStub<Handled_ContextMenuEventArgs_Delegate>("Handled").Invoke(e);
        }

        public delegate bool Handled_ContextMenuEventArgs_Delegate(global::Windows.UI.Xaml.Controls.ContextMenuEventArgs e);

        public StubIContextMenuEventArgsResolver Handled(Handled_ContextMenuEventArgs_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        void global::Fievus.Windows.Mvc.Wrappers.IContextMenuEventArgsResolver.Handled(global::Windows.UI.Xaml.Controls.ContextMenuEventArgs e, bool handled)
        {
            _stubs.GetMethodStub<Handled_ContextMenuEventArgs_Boolean_Delegate>("Handled").Invoke(e, handled);
        }

        public delegate void Handled_ContextMenuEventArgs_Boolean_Delegate(global::Windows.UI.Xaml.Controls.ContextMenuEventArgs e, bool handled);

        public StubIContextMenuEventArgsResolver Handled(Handled_ContextMenuEventArgs_Boolean_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        object global::Fievus.Windows.Mvc.Wrappers.IContextMenuEventArgsResolver.OriginalSource(global::Windows.UI.Xaml.Controls.ContextMenuEventArgs e)
        {
            return _stubs.GetMethodStub<OriginalSource_ContextMenuEventArgs_Delegate>("OriginalSource").Invoke(e);
        }

        public delegate object OriginalSource_ContextMenuEventArgs_Delegate(global::Windows.UI.Xaml.Controls.ContextMenuEventArgs e);

        public StubIContextMenuEventArgsResolver OriginalSource(OriginalSource_ContextMenuEventArgs_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }
    }
}

namespace Fievus.Windows.Mvc.Wrappers
{
    [CompilerGenerated]
    public class StubIContextRequestedEventArgsResolver : IContextRequestedEventArgsResolver
    {
        private readonly StubContainer<StubIContextRequestedEventArgsResolver> _stubs = new StubContainer<StubIContextRequestedEventArgsResolver>();

        bool global::Fievus.Windows.Mvc.Wrappers.IContextRequestedEventArgsResolver.Handled(global::Windows.UI.Xaml.Input.ContextRequestedEventArgs e)
        {
            return _stubs.GetMethodStub<Handled_ContextRequestedEventArgs_Delegate>("Handled").Invoke(e);
        }

        public delegate bool Handled_ContextRequestedEventArgs_Delegate(global::Windows.UI.Xaml.Input.ContextRequestedEventArgs e);

        public StubIContextRequestedEventArgsResolver Handled(Handled_ContextRequestedEventArgs_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        void global::Fievus.Windows.Mvc.Wrappers.IContextRequestedEventArgsResolver.Handled(global::Windows.UI.Xaml.Input.ContextRequestedEventArgs e, bool handled)
        {
            _stubs.GetMethodStub<Handled_ContextRequestedEventArgs_Boolean_Delegate>("Handled").Invoke(e, handled);
        }

        public delegate void Handled_ContextRequestedEventArgs_Boolean_Delegate(global::Windows.UI.Xaml.Input.ContextRequestedEventArgs e, bool handled);

        public StubIContextRequestedEventArgsResolver Handled(Handled_ContextRequestedEventArgs_Boolean_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        bool global::Fievus.Windows.Mvc.Wrappers.IContextRequestedEventArgsResolver.TryGetPosition(global::Windows.UI.Xaml.Input.ContextRequestedEventArgs e, global::Windows.UI.Xaml.UIElement relativeTo, out global::Windows.Foundation.Point point)
        {
            return _stubs.GetMethodStub<TryGetPosition_ContextRequestedEventArgs_UIElement_Point_Delegate>("TryGetPosition").Invoke(e, relativeTo, out point);
        }

        public delegate bool TryGetPosition_ContextRequestedEventArgs_UIElement_Point_Delegate(global::Windows.UI.Xaml.Input.ContextRequestedEventArgs e, global::Windows.UI.Xaml.UIElement relativeTo, out global::Windows.Foundation.Point point);

        public StubIContextRequestedEventArgsResolver TryGetPosition(TryGetPosition_ContextRequestedEventArgs_UIElement_Point_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }
    }
}

namespace Fievus.Windows.Mvc.Wrappers
{
    [CompilerGenerated]
    public class StubIDataContextChangedEventArgsResolver : IDataContextChangedEventArgsResolver
    {
        private readonly StubContainer<StubIDataContextChangedEventArgsResolver> _stubs = new StubContainer<StubIDataContextChangedEventArgsResolver>();

        bool global::Fievus.Windows.Mvc.Wrappers.IDataContextChangedEventArgsResolver.Handled(global::Windows.UI.Xaml.DataContextChangedEventArgs e)
        {
            return _stubs.GetMethodStub<Handled_DataContextChangedEventArgs_Delegate>("Handled").Invoke(e);
        }

        public delegate bool Handled_DataContextChangedEventArgs_Delegate(global::Windows.UI.Xaml.DataContextChangedEventArgs e);

        public StubIDataContextChangedEventArgsResolver Handled(Handled_DataContextChangedEventArgs_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        void global::Fievus.Windows.Mvc.Wrappers.IDataContextChangedEventArgsResolver.Handled(global::Windows.UI.Xaml.DataContextChangedEventArgs e, bool handled)
        {
            _stubs.GetMethodStub<Handled_DataContextChangedEventArgs_Boolean_Delegate>("Handled").Invoke(e, handled);
        }

        public delegate void Handled_DataContextChangedEventArgs_Boolean_Delegate(global::Windows.UI.Xaml.DataContextChangedEventArgs e, bool handled);

        public StubIDataContextChangedEventArgsResolver Handled(Handled_DataContextChangedEventArgs_Boolean_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        object global::Fievus.Windows.Mvc.Wrappers.IDataContextChangedEventArgsResolver.NewValue(global::Windows.UI.Xaml.DataContextChangedEventArgs e)
        {
            return _stubs.GetMethodStub<NewValue_DataContextChangedEventArgs_Delegate>("NewValue").Invoke(e);
        }

        public delegate object NewValue_DataContextChangedEventArgs_Delegate(global::Windows.UI.Xaml.DataContextChangedEventArgs e);

        public StubIDataContextChangedEventArgsResolver NewValue(NewValue_DataContextChangedEventArgs_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }
    }
}

namespace Fievus.Windows.Mvc.Wrappers
{
    [CompilerGenerated]
    public class StubIDatePickerValueChangedEventArgsResolver : IDatePickerValueChangedEventArgsResolver
    {
        private readonly StubContainer<StubIDatePickerValueChangedEventArgsResolver> _stubs = new StubContainer<StubIDatePickerValueChangedEventArgsResolver>();

        global::System.DateTimeOffset global::Fievus.Windows.Mvc.Wrappers.IDatePickerValueChangedEventArgsResolver.NewDate(global::Windows.UI.Xaml.Controls.DatePickerValueChangedEventArgs e)
        {
            return _stubs.GetMethodStub<NewDate_DatePickerValueChangedEventArgs_Delegate>("NewDate").Invoke(e);
        }

        public delegate global::System.DateTimeOffset NewDate_DatePickerValueChangedEventArgs_Delegate(global::Windows.UI.Xaml.Controls.DatePickerValueChangedEventArgs e);

        public StubIDatePickerValueChangedEventArgsResolver NewDate(NewDate_DatePickerValueChangedEventArgs_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        global::System.DateTimeOffset global::Fievus.Windows.Mvc.Wrappers.IDatePickerValueChangedEventArgsResolver.OldDate(global::Windows.UI.Xaml.Controls.DatePickerValueChangedEventArgs e)
        {
            return _stubs.GetMethodStub<OldDate_DatePickerValueChangedEventArgs_Delegate>("OldDate").Invoke(e);
        }

        public delegate global::System.DateTimeOffset OldDate_DatePickerValueChangedEventArgs_Delegate(global::Windows.UI.Xaml.Controls.DatePickerValueChangedEventArgs e);

        public StubIDatePickerValueChangedEventArgsResolver OldDate(OldDate_DatePickerValueChangedEventArgs_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }
    }
}

namespace Fievus.Windows.Mvc.Wrappers
{
    [CompilerGenerated]
    public class StubIDeferralResolver : IDeferralResolver
    {
        private readonly StubContainer<StubIDeferralResolver> _stubs = new StubContainer<StubIDeferralResolver>();

        void global::Fievus.Windows.Mvc.Wrappers.IDeferralResolver.Dispose(global::Windows.Foundation.Deferral deferral)
        {
            _stubs.GetMethodStub<Dispose_Deferral_Delegate>("Dispose").Invoke(deferral);
        }

        public delegate void Dispose_Deferral_Delegate(global::Windows.Foundation.Deferral deferral);

        public StubIDeferralResolver Dispose(Dispose_Deferral_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        void global::Fievus.Windows.Mvc.Wrappers.IDeferralResolver.Complete(global::Windows.Foundation.Deferral deferral)
        {
            _stubs.GetMethodStub<Complete_Deferral_Delegate>("Complete").Invoke(deferral);
        }

        public delegate void Complete_Deferral_Delegate(global::Windows.Foundation.Deferral deferral);

        public StubIDeferralResolver Complete(Complete_Deferral_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }
    }
}

namespace Fievus.Windows.Mvc.Wrappers
{
    [CompilerGenerated]
    public class StubIDependencyPropertyChangedEventArgsResolver : IDependencyPropertyChangedEventArgsResolver
    {
        private readonly StubContainer<StubIDependencyPropertyChangedEventArgsResolver> _stubs = new StubContainer<StubIDependencyPropertyChangedEventArgsResolver>();

        object global::Fievus.Windows.Mvc.Wrappers.IDependencyPropertyChangedEventArgsResolver.NewValue(global::Windows.UI.Xaml.DependencyPropertyChangedEventArgs e)
        {
            return _stubs.GetMethodStub<NewValue_DependencyPropertyChangedEventArgs_Delegate>("NewValue").Invoke(e);
        }

        public delegate object NewValue_DependencyPropertyChangedEventArgs_Delegate(global::Windows.UI.Xaml.DependencyPropertyChangedEventArgs e);

        public StubIDependencyPropertyChangedEventArgsResolver NewValue(NewValue_DependencyPropertyChangedEventArgs_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        object global::Fievus.Windows.Mvc.Wrappers.IDependencyPropertyChangedEventArgsResolver.OldValue(global::Windows.UI.Xaml.DependencyPropertyChangedEventArgs e)
        {
            return _stubs.GetMethodStub<OldValue_DependencyPropertyChangedEventArgs_Delegate>("OldValue").Invoke(e);
        }

        public delegate object OldValue_DependencyPropertyChangedEventArgs_Delegate(global::Windows.UI.Xaml.DependencyPropertyChangedEventArgs e);

        public StubIDependencyPropertyChangedEventArgsResolver OldValue(OldValue_DependencyPropertyChangedEventArgs_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        global::Windows.UI.Xaml.DependencyProperty global::Fievus.Windows.Mvc.Wrappers.IDependencyPropertyChangedEventArgsResolver.Property(global::Windows.UI.Xaml.DependencyPropertyChangedEventArgs e)
        {
            return _stubs.GetMethodStub<Property_DependencyPropertyChangedEventArgs_Delegate>("Property").Invoke(e);
        }

        public delegate global::Windows.UI.Xaml.DependencyProperty Property_DependencyPropertyChangedEventArgs_Delegate(global::Windows.UI.Xaml.DependencyPropertyChangedEventArgs e);

        public StubIDependencyPropertyChangedEventArgsResolver Property(Property_DependencyPropertyChangedEventArgs_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }
    }
}

namespace Fievus.Windows.Mvc.Wrappers
{
    [CompilerGenerated]
    public class StubIDoubleTappedRoutedEventArgsResolver : IDoubleTappedRoutedEventArgsResolver
    {
        private readonly StubContainer<StubIDoubleTappedRoutedEventArgsResolver> _stubs = new StubContainer<StubIDoubleTappedRoutedEventArgsResolver>();

        bool global::Fievus.Windows.Mvc.Wrappers.IDoubleTappedRoutedEventArgsResolver.Handled(global::Windows.UI.Xaml.Input.DoubleTappedRoutedEventArgs e)
        {
            return _stubs.GetMethodStub<Handled_DoubleTappedRoutedEventArgs_Delegate>("Handled").Invoke(e);
        }

        public delegate bool Handled_DoubleTappedRoutedEventArgs_Delegate(global::Windows.UI.Xaml.Input.DoubleTappedRoutedEventArgs e);

        public StubIDoubleTappedRoutedEventArgsResolver Handled(Handled_DoubleTappedRoutedEventArgs_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        void global::Fievus.Windows.Mvc.Wrappers.IDoubleTappedRoutedEventArgsResolver.Handled(global::Windows.UI.Xaml.Input.DoubleTappedRoutedEventArgs e, bool handled)
        {
            _stubs.GetMethodStub<Handled_DoubleTappedRoutedEventArgs_Boolean_Delegate>("Handled").Invoke(e, handled);
        }

        public delegate void Handled_DoubleTappedRoutedEventArgs_Boolean_Delegate(global::Windows.UI.Xaml.Input.DoubleTappedRoutedEventArgs e, bool handled);

        public StubIDoubleTappedRoutedEventArgsResolver Handled(Handled_DoubleTappedRoutedEventArgs_Boolean_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        object global::Fievus.Windows.Mvc.Wrappers.IDoubleTappedRoutedEventArgsResolver.OriginalSource(global::Windows.UI.Xaml.Input.DoubleTappedRoutedEventArgs e)
        {
            return _stubs.GetMethodStub<OriginalSource_DoubleTappedRoutedEventArgs_Delegate>("OriginalSource").Invoke(e);
        }

        public delegate object OriginalSource_DoubleTappedRoutedEventArgs_Delegate(global::Windows.UI.Xaml.Input.DoubleTappedRoutedEventArgs e);

        public StubIDoubleTappedRoutedEventArgsResolver OriginalSource(OriginalSource_DoubleTappedRoutedEventArgs_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        global::Windows.Devices.Input.PointerDeviceType global::Fievus.Windows.Mvc.Wrappers.IDoubleTappedRoutedEventArgsResolver.PointerDeviceType(global::Windows.UI.Xaml.Input.DoubleTappedRoutedEventArgs e)
        {
            return _stubs.GetMethodStub<PointerDeviceType_DoubleTappedRoutedEventArgs_Delegate>("PointerDeviceType").Invoke(e);
        }

        public delegate global::Windows.Devices.Input.PointerDeviceType PointerDeviceType_DoubleTappedRoutedEventArgs_Delegate(global::Windows.UI.Xaml.Input.DoubleTappedRoutedEventArgs e);

        public StubIDoubleTappedRoutedEventArgsResolver PointerDeviceType(PointerDeviceType_DoubleTappedRoutedEventArgs_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        global::Windows.Foundation.Point global::Fievus.Windows.Mvc.Wrappers.IDoubleTappedRoutedEventArgsResolver.GetPosition(global::Windows.UI.Xaml.Input.DoubleTappedRoutedEventArgs e, global::Windows.UI.Xaml.UIElement relativeTo)
        {
            return _stubs.GetMethodStub<GetPosition_DoubleTappedRoutedEventArgs_UIElement_Delegate>("GetPosition").Invoke(e, relativeTo);
        }

        public delegate global::Windows.Foundation.Point GetPosition_DoubleTappedRoutedEventArgs_UIElement_Delegate(global::Windows.UI.Xaml.Input.DoubleTappedRoutedEventArgs e, global::Windows.UI.Xaml.UIElement relativeTo);

        public StubIDoubleTappedRoutedEventArgsResolver GetPosition(GetPosition_DoubleTappedRoutedEventArgs_UIElement_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }
    }
}

namespace Fievus.Windows.Mvc.Wrappers
{
    [CompilerGenerated]
    public class StubIDragCompletedEventArgsResolver : IDragCompletedEventArgsResolver
    {
        private readonly StubContainer<StubIDragCompletedEventArgsResolver> _stubs = new StubContainer<StubIDragCompletedEventArgsResolver>();

        bool global::Fievus.Windows.Mvc.Wrappers.IDragCompletedEventArgsResolver.Canceled(global::Windows.UI.Xaml.Controls.Primitives.DragCompletedEventArgs e)
        {
            return _stubs.GetMethodStub<Canceled_DragCompletedEventArgs_Delegate>("Canceled").Invoke(e);
        }

        public delegate bool Canceled_DragCompletedEventArgs_Delegate(global::Windows.UI.Xaml.Controls.Primitives.DragCompletedEventArgs e);

        public StubIDragCompletedEventArgsResolver Canceled(Canceled_DragCompletedEventArgs_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        double global::Fievus.Windows.Mvc.Wrappers.IDragCompletedEventArgsResolver.HorizontalChange(global::Windows.UI.Xaml.Controls.Primitives.DragCompletedEventArgs e)
        {
            return _stubs.GetMethodStub<HorizontalChange_DragCompletedEventArgs_Delegate>("HorizontalChange").Invoke(e);
        }

        public delegate double HorizontalChange_DragCompletedEventArgs_Delegate(global::Windows.UI.Xaml.Controls.Primitives.DragCompletedEventArgs e);

        public StubIDragCompletedEventArgsResolver HorizontalChange(HorizontalChange_DragCompletedEventArgs_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        object global::Fievus.Windows.Mvc.Wrappers.IDragCompletedEventArgsResolver.OriginalSource(global::Windows.UI.Xaml.Controls.Primitives.DragCompletedEventArgs e)
        {
            return _stubs.GetMethodStub<OriginalSource_DragCompletedEventArgs_Delegate>("OriginalSource").Invoke(e);
        }

        public delegate object OriginalSource_DragCompletedEventArgs_Delegate(global::Windows.UI.Xaml.Controls.Primitives.DragCompletedEventArgs e);

        public StubIDragCompletedEventArgsResolver OriginalSource(OriginalSource_DragCompletedEventArgs_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        double global::Fievus.Windows.Mvc.Wrappers.IDragCompletedEventArgsResolver.VerticalChange(global::Windows.UI.Xaml.Controls.Primitives.DragCompletedEventArgs e)
        {
            return _stubs.GetMethodStub<VerticalChange_DragCompletedEventArgs_Delegate>("VerticalChange").Invoke(e);
        }

        public delegate double VerticalChange_DragCompletedEventArgs_Delegate(global::Windows.UI.Xaml.Controls.Primitives.DragCompletedEventArgs e);

        public StubIDragCompletedEventArgsResolver VerticalChange(VerticalChange_DragCompletedEventArgs_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }
    }
}

namespace Fievus.Windows.Mvc.Wrappers
{
    [CompilerGenerated]
    public class StubIDragDeltaEventArgsResolver : IDragDeltaEventArgsResolver
    {
        private readonly StubContainer<StubIDragDeltaEventArgsResolver> _stubs = new StubContainer<StubIDragDeltaEventArgsResolver>();

        double global::Fievus.Windows.Mvc.Wrappers.IDragDeltaEventArgsResolver.HorizontalChange(global::Windows.UI.Xaml.Controls.Primitives.DragDeltaEventArgs e)
        {
            return _stubs.GetMethodStub<HorizontalChange_DragDeltaEventArgs_Delegate>("HorizontalChange").Invoke(e);
        }

        public delegate double HorizontalChange_DragDeltaEventArgs_Delegate(global::Windows.UI.Xaml.Controls.Primitives.DragDeltaEventArgs e);

        public StubIDragDeltaEventArgsResolver HorizontalChange(HorizontalChange_DragDeltaEventArgs_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        object global::Fievus.Windows.Mvc.Wrappers.IDragDeltaEventArgsResolver.OriginalSource(global::Windows.UI.Xaml.Controls.Primitives.DragDeltaEventArgs e)
        {
            return _stubs.GetMethodStub<OriginalSource_DragDeltaEventArgs_Delegate>("OriginalSource").Invoke(e);
        }

        public delegate object OriginalSource_DragDeltaEventArgs_Delegate(global::Windows.UI.Xaml.Controls.Primitives.DragDeltaEventArgs e);

        public StubIDragDeltaEventArgsResolver OriginalSource(OriginalSource_DragDeltaEventArgs_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        double global::Fievus.Windows.Mvc.Wrappers.IDragDeltaEventArgsResolver.VerticalChange(global::Windows.UI.Xaml.Controls.Primitives.DragDeltaEventArgs e)
        {
            return _stubs.GetMethodStub<VerticalChange_DragDeltaEventArgs_Delegate>("VerticalChange").Invoke(e);
        }

        public delegate double VerticalChange_DragDeltaEventArgs_Delegate(global::Windows.UI.Xaml.Controls.Primitives.DragDeltaEventArgs e);

        public StubIDragDeltaEventArgsResolver VerticalChange(VerticalChange_DragDeltaEventArgs_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }
    }
}

namespace Fievus.Windows.Mvc.Wrappers
{
    [CompilerGenerated]
    public class StubIDragEventArgsResolver : IDragEventArgsResolver
    {
        private readonly StubContainer<StubIDragEventArgsResolver> _stubs = new StubContainer<StubIDragEventArgsResolver>();

        global::Windows.ApplicationModel.DataTransfer.DataPackage global::Fievus.Windows.Mvc.Wrappers.IDragEventArgsResolver.Data(global::Windows.UI.Xaml.DragEventArgs e)
        {
            return _stubs.GetMethodStub<Data_DragEventArgs_Delegate>("Data").Invoke(e);
        }

        public delegate global::Windows.ApplicationModel.DataTransfer.DataPackage Data_DragEventArgs_Delegate(global::Windows.UI.Xaml.DragEventArgs e);

        public StubIDragEventArgsResolver Data(Data_DragEventArgs_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        void global::Fievus.Windows.Mvc.Wrappers.IDragEventArgsResolver.Data(global::Windows.UI.Xaml.DragEventArgs e, global::Windows.ApplicationModel.DataTransfer.DataPackage data)
        {
            _stubs.GetMethodStub<Data_DragEventArgs_DataPackage_Delegate>("Data").Invoke(e, data);
        }

        public delegate void Data_DragEventArgs_DataPackage_Delegate(global::Windows.UI.Xaml.DragEventArgs e, global::Windows.ApplicationModel.DataTransfer.DataPackage data);

        public StubIDragEventArgsResolver Data(Data_DragEventArgs_DataPackage_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        bool global::Fievus.Windows.Mvc.Wrappers.IDragEventArgsResolver.Handled(global::Windows.UI.Xaml.DragEventArgs e)
        {
            return _stubs.GetMethodStub<Handled_DragEventArgs_Delegate>("Handled").Invoke(e);
        }

        public delegate bool Handled_DragEventArgs_Delegate(global::Windows.UI.Xaml.DragEventArgs e);

        public StubIDragEventArgsResolver Handled(Handled_DragEventArgs_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        void global::Fievus.Windows.Mvc.Wrappers.IDragEventArgsResolver.Handled(global::Windows.UI.Xaml.DragEventArgs e, bool handled)
        {
            _stubs.GetMethodStub<Handled_DragEventArgs_Boolean_Delegate>("Handled").Invoke(e, handled);
        }

        public delegate void Handled_DragEventArgs_Boolean_Delegate(global::Windows.UI.Xaml.DragEventArgs e, bool handled);

        public StubIDragEventArgsResolver Handled(Handled_DragEventArgs_Boolean_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        object global::Fievus.Windows.Mvc.Wrappers.IDragEventArgsResolver.OriginalSource(global::Windows.UI.Xaml.DragEventArgs e)
        {
            return _stubs.GetMethodStub<OriginalSource_DragEventArgs_Delegate>("OriginalSource").Invoke(e);
        }

        public delegate object OriginalSource_DragEventArgs_Delegate(global::Windows.UI.Xaml.DragEventArgs e);

        public StubIDragEventArgsResolver OriginalSource(OriginalSource_DragEventArgs_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        global::Windows.Foundation.Point global::Fievus.Windows.Mvc.Wrappers.IDragEventArgsResolver.GetPosition(global::Windows.UI.Xaml.DragEventArgs e, global::Windows.UI.Xaml.UIElement relativeTo)
        {
            return _stubs.GetMethodStub<GetPosition_DragEventArgs_UIElement_Delegate>("GetPosition").Invoke(e, relativeTo);
        }

        public delegate global::Windows.Foundation.Point GetPosition_DragEventArgs_UIElement_Delegate(global::Windows.UI.Xaml.DragEventArgs e, global::Windows.UI.Xaml.UIElement relativeTo);

        public StubIDragEventArgsResolver GetPosition(GetPosition_DragEventArgs_UIElement_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }
    }
}

namespace Fievus.Windows.Mvc.Wrappers
{
    [CompilerGenerated]
    public class StubIDragItemsCompletedEventArgsResolver : IDragItemsCompletedEventArgsResolver
    {
        private readonly StubContainer<StubIDragItemsCompletedEventArgsResolver> _stubs = new StubContainer<StubIDragItemsCompletedEventArgsResolver>();

        global::Windows.ApplicationModel.DataTransfer.DataPackageOperation global::Fievus.Windows.Mvc.Wrappers.IDragItemsCompletedEventArgsResolver.DropResult(global::Windows.UI.Xaml.Controls.DragItemsCompletedEventArgs e)
        {
            return _stubs.GetMethodStub<DropResult_DragItemsCompletedEventArgs_Delegate>("DropResult").Invoke(e);
        }

        public delegate global::Windows.ApplicationModel.DataTransfer.DataPackageOperation DropResult_DragItemsCompletedEventArgs_Delegate(global::Windows.UI.Xaml.Controls.DragItemsCompletedEventArgs e);

        public StubIDragItemsCompletedEventArgsResolver DropResult(DropResult_DragItemsCompletedEventArgs_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        global::System.Collections.Generic.IReadOnlyList<object> global::Fievus.Windows.Mvc.Wrappers.IDragItemsCompletedEventArgsResolver.Items(global::Windows.UI.Xaml.Controls.DragItemsCompletedEventArgs e)
        {
            return _stubs.GetMethodStub<Items_DragItemsCompletedEventArgs_Delegate>("Items").Invoke(e);
        }

        public delegate global::System.Collections.Generic.IReadOnlyList<object> Items_DragItemsCompletedEventArgs_Delegate(global::Windows.UI.Xaml.Controls.DragItemsCompletedEventArgs e);

        public StubIDragItemsCompletedEventArgsResolver Items(Items_DragItemsCompletedEventArgs_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }
    }
}

namespace Fievus.Windows.Mvc.Wrappers
{
    [CompilerGenerated]
    public class StubIDragItemsStartingEventArgsResolver : IDragItemsStartingEventArgsResolver
    {
        private readonly StubContainer<StubIDragItemsStartingEventArgsResolver> _stubs = new StubContainer<StubIDragItemsStartingEventArgsResolver>();

        bool global::Fievus.Windows.Mvc.Wrappers.IDragItemsStartingEventArgsResolver.Cancel(global::Windows.UI.Xaml.Controls.DragItemsStartingEventArgs e)
        {
            return _stubs.GetMethodStub<Cancel_DragItemsStartingEventArgs_Delegate>("Cancel").Invoke(e);
        }

        public delegate bool Cancel_DragItemsStartingEventArgs_Delegate(global::Windows.UI.Xaml.Controls.DragItemsStartingEventArgs e);

        public StubIDragItemsStartingEventArgsResolver Cancel(Cancel_DragItemsStartingEventArgs_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        void global::Fievus.Windows.Mvc.Wrappers.IDragItemsStartingEventArgsResolver.Cancel(global::Windows.UI.Xaml.Controls.DragItemsStartingEventArgs e, bool cancel)
        {
            _stubs.GetMethodStub<Cancel_DragItemsStartingEventArgs_Boolean_Delegate>("Cancel").Invoke(e, cancel);
        }

        public delegate void Cancel_DragItemsStartingEventArgs_Boolean_Delegate(global::Windows.UI.Xaml.Controls.DragItemsStartingEventArgs e, bool cancel);

        public StubIDragItemsStartingEventArgsResolver Cancel(Cancel_DragItemsStartingEventArgs_Boolean_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        global::Windows.ApplicationModel.DataTransfer.DataPackage global::Fievus.Windows.Mvc.Wrappers.IDragItemsStartingEventArgsResolver.Data(global::Windows.UI.Xaml.Controls.DragItemsStartingEventArgs e)
        {
            return _stubs.GetMethodStub<Data_DragItemsStartingEventArgs_Delegate>("Data").Invoke(e);
        }

        public delegate global::Windows.ApplicationModel.DataTransfer.DataPackage Data_DragItemsStartingEventArgs_Delegate(global::Windows.UI.Xaml.Controls.DragItemsStartingEventArgs e);

        public StubIDragItemsStartingEventArgsResolver Data(Data_DragItemsStartingEventArgs_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        global::System.Collections.Generic.IList<object> global::Fievus.Windows.Mvc.Wrappers.IDragItemsStartingEventArgsResolver.Items(global::Windows.UI.Xaml.Controls.DragItemsStartingEventArgs e)
        {
            return _stubs.GetMethodStub<Items_DragItemsStartingEventArgs_Delegate>("Items").Invoke(e);
        }

        public delegate global::System.Collections.Generic.IList<object> Items_DragItemsStartingEventArgs_Delegate(global::Windows.UI.Xaml.Controls.DragItemsStartingEventArgs e);

        public StubIDragItemsStartingEventArgsResolver Items(Items_DragItemsStartingEventArgs_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }
    }
}

namespace Fievus.Windows.Mvc.Wrappers
{
    [CompilerGenerated]
    public class StubIDragStartedEventArgsResolver : IDragStartedEventArgsResolver
    {
        private readonly StubContainer<StubIDragStartedEventArgsResolver> _stubs = new StubContainer<StubIDragStartedEventArgsResolver>();

        double global::Fievus.Windows.Mvc.Wrappers.IDragStartedEventArgsResolver.HorizontalOffset(global::Windows.UI.Xaml.Controls.Primitives.DragStartedEventArgs e)
        {
            return _stubs.GetMethodStub<HorizontalOffset_DragStartedEventArgs_Delegate>("HorizontalOffset").Invoke(e);
        }

        public delegate double HorizontalOffset_DragStartedEventArgs_Delegate(global::Windows.UI.Xaml.Controls.Primitives.DragStartedEventArgs e);

        public StubIDragStartedEventArgsResolver HorizontalOffset(HorizontalOffset_DragStartedEventArgs_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        object global::Fievus.Windows.Mvc.Wrappers.IDragStartedEventArgsResolver.OriginalSource(global::Windows.UI.Xaml.Controls.Primitives.DragStartedEventArgs e)
        {
            return _stubs.GetMethodStub<OriginalSource_DragStartedEventArgs_Delegate>("OriginalSource").Invoke(e);
        }

        public delegate object OriginalSource_DragStartedEventArgs_Delegate(global::Windows.UI.Xaml.Controls.Primitives.DragStartedEventArgs e);

        public StubIDragStartedEventArgsResolver OriginalSource(OriginalSource_DragStartedEventArgs_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        double global::Fievus.Windows.Mvc.Wrappers.IDragStartedEventArgsResolver.VerticalOffset(global::Windows.UI.Xaml.Controls.Primitives.DragStartedEventArgs e)
        {
            return _stubs.GetMethodStub<VerticalOffset_DragStartedEventArgs_Delegate>("VerticalOffset").Invoke(e);
        }

        public delegate double VerticalOffset_DragStartedEventArgs_Delegate(global::Windows.UI.Xaml.Controls.Primitives.DragStartedEventArgs e);

        public StubIDragStartedEventArgsResolver VerticalOffset(VerticalOffset_DragStartedEventArgs_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }
    }
}

namespace Fievus.Windows.Mvc.Wrappers
{
    [CompilerGenerated]
    public class StubIDragStartingEventArgsResolver : IDragStartingEventArgsResolver
    {
        private readonly StubContainer<StubIDragStartingEventArgsResolver> _stubs = new StubContainer<StubIDragStartingEventArgsResolver>();

        global::Windows.ApplicationModel.DataTransfer.DataPackageOperation global::Fievus.Windows.Mvc.Wrappers.IDragStartingEventArgsResolver.AllowedOperations(global::Windows.UI.Xaml.DragStartingEventArgs e)
        {
            return _stubs.GetMethodStub<AllowedOperations_DragStartingEventArgs_Delegate>("AllowedOperations").Invoke(e);
        }

        public delegate global::Windows.ApplicationModel.DataTransfer.DataPackageOperation AllowedOperations_DragStartingEventArgs_Delegate(global::Windows.UI.Xaml.DragStartingEventArgs e);

        public StubIDragStartingEventArgsResolver AllowedOperations(AllowedOperations_DragStartingEventArgs_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        void global::Fievus.Windows.Mvc.Wrappers.IDragStartingEventArgsResolver.AllowedOperations(global::Windows.UI.Xaml.DragStartingEventArgs e, global::Windows.ApplicationModel.DataTransfer.DataPackageOperation dataPackageOperation)
        {
            _stubs.GetMethodStub<AllowedOperations_DragStartingEventArgs_DataPackageOperation_Delegate>("AllowedOperations").Invoke(e, dataPackageOperation);
        }

        public delegate void AllowedOperations_DragStartingEventArgs_DataPackageOperation_Delegate(global::Windows.UI.Xaml.DragStartingEventArgs e, global::Windows.ApplicationModel.DataTransfer.DataPackageOperation dataPackageOperation);

        public StubIDragStartingEventArgsResolver AllowedOperations(AllowedOperations_DragStartingEventArgs_DataPackageOperation_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        bool global::Fievus.Windows.Mvc.Wrappers.IDragStartingEventArgsResolver.Cancel(global::Windows.UI.Xaml.DragStartingEventArgs e)
        {
            return _stubs.GetMethodStub<Cancel_DragStartingEventArgs_Delegate>("Cancel").Invoke(e);
        }

        public delegate bool Cancel_DragStartingEventArgs_Delegate(global::Windows.UI.Xaml.DragStartingEventArgs e);

        public StubIDragStartingEventArgsResolver Cancel(Cancel_DragStartingEventArgs_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        void global::Fievus.Windows.Mvc.Wrappers.IDragStartingEventArgsResolver.Cancel(global::Windows.UI.Xaml.DragStartingEventArgs e, bool cancel)
        {
            _stubs.GetMethodStub<Cancel_DragStartingEventArgs_Boolean_Delegate>("Cancel").Invoke(e, cancel);
        }

        public delegate void Cancel_DragStartingEventArgs_Boolean_Delegate(global::Windows.UI.Xaml.DragStartingEventArgs e, bool cancel);

        public StubIDragStartingEventArgsResolver Cancel(Cancel_DragStartingEventArgs_Boolean_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        global::Windows.ApplicationModel.DataTransfer.DataPackage global::Fievus.Windows.Mvc.Wrappers.IDragStartingEventArgsResolver.Data(global::Windows.UI.Xaml.DragStartingEventArgs e)
        {
            return _stubs.GetMethodStub<Data_DragStartingEventArgs_Delegate>("Data").Invoke(e);
        }

        public delegate global::Windows.ApplicationModel.DataTransfer.DataPackage Data_DragStartingEventArgs_Delegate(global::Windows.UI.Xaml.DragStartingEventArgs e);

        public StubIDragStartingEventArgsResolver Data(Data_DragStartingEventArgs_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        global::Windows.UI.Xaml.DragUI global::Fievus.Windows.Mvc.Wrappers.IDragStartingEventArgsResolver.DragUI(global::Windows.UI.Xaml.DragStartingEventArgs e)
        {
            return _stubs.GetMethodStub<DragUI_DragStartingEventArgs_Delegate>("DragUI").Invoke(e);
        }

        public delegate global::Windows.UI.Xaml.DragUI DragUI_DragStartingEventArgs_Delegate(global::Windows.UI.Xaml.DragStartingEventArgs e);

        public StubIDragStartingEventArgsResolver DragUI(DragUI_DragStartingEventArgs_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        object global::Fievus.Windows.Mvc.Wrappers.IDragStartingEventArgsResolver.OriginalSource(global::Windows.UI.Xaml.DragStartingEventArgs e)
        {
            return _stubs.GetMethodStub<OriginalSource_DragStartingEventArgs_Delegate>("OriginalSource").Invoke(e);
        }

        public delegate object OriginalSource_DragStartingEventArgs_Delegate(global::Windows.UI.Xaml.DragStartingEventArgs e);

        public StubIDragStartingEventArgsResolver OriginalSource(OriginalSource_DragStartingEventArgs_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        global::Windows.UI.Xaml.DragOperationDeferral global::Fievus.Windows.Mvc.Wrappers.IDragStartingEventArgsResolver.GetDeferral(global::Windows.UI.Xaml.DragStartingEventArgs e)
        {
            return _stubs.GetMethodStub<GetDeferral_DragStartingEventArgs_Delegate>("GetDeferral").Invoke(e);
        }

        public delegate global::Windows.UI.Xaml.DragOperationDeferral GetDeferral_DragStartingEventArgs_Delegate(global::Windows.UI.Xaml.DragStartingEventArgs e);

        public StubIDragStartingEventArgsResolver GetDeferral(GetDeferral_DragStartingEventArgs_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        global::Windows.Foundation.Point global::Fievus.Windows.Mvc.Wrappers.IDragStartingEventArgsResolver.GetPosition(global::Windows.UI.Xaml.DragStartingEventArgs e, global::Windows.UI.Xaml.UIElement relativeTo)
        {
            return _stubs.GetMethodStub<GetPosition_DragStartingEventArgs_UIElement_Delegate>("GetPosition").Invoke(e, relativeTo);
        }

        public delegate global::Windows.Foundation.Point GetPosition_DragStartingEventArgs_UIElement_Delegate(global::Windows.UI.Xaml.DragStartingEventArgs e, global::Windows.UI.Xaml.UIElement relativeTo);

        public StubIDragStartingEventArgsResolver GetPosition(GetPosition_DragStartingEventArgs_UIElement_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }
    }
}

namespace Fievus.Windows.Mvc.Wrappers
{
    [CompilerGenerated]
    public class StubIDragUIResolver : IDragUIResolver
    {
        private readonly StubContainer<StubIDragUIResolver> _stubs = new StubContainer<StubIDragUIResolver>();

        void global::Fievus.Windows.Mvc.Wrappers.IDragUIResolver.SetContentFromBitmapImage(global::Windows.UI.Xaml.DragUI dragUI, global::Windows.UI.Xaml.Media.Imaging.BitmapImage bitmapImage)
        {
            _stubs.GetMethodStub<SetContentFromBitmapImage_DragUI_BitmapImage_Delegate>("SetContentFromBitmapImage").Invoke(dragUI, bitmapImage);
        }

        public delegate void SetContentFromBitmapImage_DragUI_BitmapImage_Delegate(global::Windows.UI.Xaml.DragUI dragUI, global::Windows.UI.Xaml.Media.Imaging.BitmapImage bitmapImage);

        public StubIDragUIResolver SetContentFromBitmapImage(SetContentFromBitmapImage_DragUI_BitmapImage_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        void global::Fievus.Windows.Mvc.Wrappers.IDragUIResolver.SetContentFromBitmapImage(global::Windows.UI.Xaml.DragUI dragUI, global::Windows.UI.Xaml.Media.Imaging.BitmapImage bitmapImage, global::Windows.Foundation.Point anchorPoint)
        {
            _stubs.GetMethodStub<SetContentFromBitmapImage_DragUI_BitmapImage_Point_Delegate>("SetContentFromBitmapImage").Invoke(dragUI, bitmapImage, anchorPoint);
        }

        public delegate void SetContentFromBitmapImage_DragUI_BitmapImage_Point_Delegate(global::Windows.UI.Xaml.DragUI dragUI, global::Windows.UI.Xaml.Media.Imaging.BitmapImage bitmapImage, global::Windows.Foundation.Point anchorPoint);

        public StubIDragUIResolver SetContentFromBitmapImage(SetContentFromBitmapImage_DragUI_BitmapImage_Point_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        void global::Fievus.Windows.Mvc.Wrappers.IDragUIResolver.SetContentFromDataPackage(global::Windows.UI.Xaml.DragUI dragUI)
        {
            _stubs.GetMethodStub<SetContentFromDataPackage_DragUI_Delegate>("SetContentFromDataPackage").Invoke(dragUI);
        }

        public delegate void SetContentFromDataPackage_DragUI_Delegate(global::Windows.UI.Xaml.DragUI dragUI);

        public StubIDragUIResolver SetContentFromDataPackage(SetContentFromDataPackage_DragUI_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        void global::Fievus.Windows.Mvc.Wrappers.IDragUIResolver.SetContentFromSoftwareBitmap(global::Windows.UI.Xaml.DragUI dragUI, global::Windows.Graphics.Imaging.SoftwareBitmap softwareBitmap)
        {
            _stubs.GetMethodStub<SetContentFromSoftwareBitmap_DragUI_SoftwareBitmap_Delegate>("SetContentFromSoftwareBitmap").Invoke(dragUI, softwareBitmap);
        }

        public delegate void SetContentFromSoftwareBitmap_DragUI_SoftwareBitmap_Delegate(global::Windows.UI.Xaml.DragUI dragUI, global::Windows.Graphics.Imaging.SoftwareBitmap softwareBitmap);

        public StubIDragUIResolver SetContentFromSoftwareBitmap(SetContentFromSoftwareBitmap_DragUI_SoftwareBitmap_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        void global::Fievus.Windows.Mvc.Wrappers.IDragUIResolver.SetContentFromSoftwareBitmap(global::Windows.UI.Xaml.DragUI dragUI, global::Windows.Graphics.Imaging.SoftwareBitmap softwareBitmap, global::Windows.Foundation.Point anchorPoint)
        {
            _stubs.GetMethodStub<SetContentFromSoftwareBitmap_DragUI_SoftwareBitmap_Point_Delegate>("SetContentFromSoftwareBitmap").Invoke(dragUI, softwareBitmap, anchorPoint);
        }

        public delegate void SetContentFromSoftwareBitmap_DragUI_SoftwareBitmap_Point_Delegate(global::Windows.UI.Xaml.DragUI dragUI, global::Windows.Graphics.Imaging.SoftwareBitmap softwareBitmap, global::Windows.Foundation.Point anchorPoint);

        public StubIDragUIResolver SetContentFromSoftwareBitmap(SetContentFromSoftwareBitmap_DragUI_SoftwareBitmap_Point_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }
    }
}

namespace Fievus.Windows.Mvc.Wrappers
{
    [CompilerGenerated]
    public class StubIDropCompletedEventArgsResolver : IDropCompletedEventArgsResolver
    {
        private readonly StubContainer<StubIDropCompletedEventArgsResolver> _stubs = new StubContainer<StubIDropCompletedEventArgsResolver>();

        global::Windows.ApplicationModel.DataTransfer.DataPackageOperation global::Fievus.Windows.Mvc.Wrappers.IDropCompletedEventArgsResolver.DropResult(global::Windows.UI.Xaml.DropCompletedEventArgs e)
        {
            return _stubs.GetMethodStub<DropResult_DropCompletedEventArgs_Delegate>("DropResult").Invoke(e);
        }

        public delegate global::Windows.ApplicationModel.DataTransfer.DataPackageOperation DropResult_DropCompletedEventArgs_Delegate(global::Windows.UI.Xaml.DropCompletedEventArgs e);

        public StubIDropCompletedEventArgsResolver DropResult(DropResult_DropCompletedEventArgs_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        object global::Fievus.Windows.Mvc.Wrappers.IDropCompletedEventArgsResolver.OriginalSource(global::Windows.UI.Xaml.DropCompletedEventArgs e)
        {
            return _stubs.GetMethodStub<OriginalSource_DropCompletedEventArgs_Delegate>("OriginalSource").Invoke(e);
        }

        public delegate object OriginalSource_DropCompletedEventArgs_Delegate(global::Windows.UI.Xaml.DropCompletedEventArgs e);

        public StubIDropCompletedEventArgsResolver OriginalSource(OriginalSource_DropCompletedEventArgs_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }
    }
}

namespace Fievus.Windows.Mvc.Wrappers
{
    [CompilerGenerated]
    public class StubIDynamicOverflowItemsChangingEventArgsResolver : IDynamicOverflowItemsChangingEventArgsResolver
    {
        private readonly StubContainer<StubIDynamicOverflowItemsChangingEventArgsResolver> _stubs = new StubContainer<StubIDynamicOverflowItemsChangingEventArgsResolver>();

        global::Windows.UI.Xaml.Controls.CommandBarDynamicOverflowAction global::Fievus.Windows.Mvc.Wrappers.IDynamicOverflowItemsChangingEventArgsResolver.Action(global::Windows.UI.Xaml.Controls.DynamicOverflowItemsChangingEventArgs e)
        {
            return _stubs.GetMethodStub<Action_DynamicOverflowItemsChangingEventArgs_Delegate>("Action").Invoke(e);
        }

        public delegate global::Windows.UI.Xaml.Controls.CommandBarDynamicOverflowAction Action_DynamicOverflowItemsChangingEventArgs_Delegate(global::Windows.UI.Xaml.Controls.DynamicOverflowItemsChangingEventArgs e);

        public StubIDynamicOverflowItemsChangingEventArgsResolver Action(Action_DynamicOverflowItemsChangingEventArgs_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }
    }
}

namespace Fievus.Windows.Mvc.Wrappers
{
    [CompilerGenerated]
    public class StubIExceptionRoutedEventArgsResolver : IExceptionRoutedEventArgsResolver
    {
        private readonly StubContainer<StubIExceptionRoutedEventArgsResolver> _stubs = new StubContainer<StubIExceptionRoutedEventArgsResolver>();

        string global::Fievus.Windows.Mvc.Wrappers.IExceptionRoutedEventArgsResolver.ErrorMessage(global::Windows.UI.Xaml.ExceptionRoutedEventArgs e)
        {
            return _stubs.GetMethodStub<ErrorMessage_ExceptionRoutedEventArgs_Delegate>("ErrorMessage").Invoke(e);
        }

        public delegate string ErrorMessage_ExceptionRoutedEventArgs_Delegate(global::Windows.UI.Xaml.ExceptionRoutedEventArgs e);

        public StubIExceptionRoutedEventArgsResolver ErrorMessage(ErrorMessage_ExceptionRoutedEventArgs_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        object global::Fievus.Windows.Mvc.Wrappers.IExceptionRoutedEventArgsResolver.OriginalSource(global::Windows.UI.Xaml.ExceptionRoutedEventArgs e)
        {
            return _stubs.GetMethodStub<OriginalSource_ExceptionRoutedEventArgs_Delegate>("OriginalSource").Invoke(e);
        }

        public delegate object OriginalSource_ExceptionRoutedEventArgs_Delegate(global::Windows.UI.Xaml.ExceptionRoutedEventArgs e);

        public StubIExceptionRoutedEventArgsResolver OriginalSource(OriginalSource_ExceptionRoutedEventArgs_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }
    }
}

namespace Fievus.Windows.Mvc.Wrappers
{
    [CompilerGenerated]
    public class StubIFocusDisengagedEventArgsResolver : IFocusDisengagedEventArgsResolver
    {
        private readonly StubContainer<StubIFocusDisengagedEventArgsResolver> _stubs = new StubContainer<StubIFocusDisengagedEventArgsResolver>();

        object global::Fievus.Windows.Mvc.Wrappers.IFocusDisengagedEventArgsResolver.OriginalSource(global::Windows.UI.Xaml.Controls.FocusDisengagedEventArgs e)
        {
            return _stubs.GetMethodStub<OriginalSource_FocusDisengagedEventArgs_Delegate>("OriginalSource").Invoke(e);
        }

        public delegate object OriginalSource_FocusDisengagedEventArgs_Delegate(global::Windows.UI.Xaml.Controls.FocusDisengagedEventArgs e);

        public StubIFocusDisengagedEventArgsResolver OriginalSource(OriginalSource_FocusDisengagedEventArgs_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }
    }
}

namespace Fievus.Windows.Mvc.Wrappers
{
    [CompilerGenerated]
    public class StubIFocusEngagedEventArgsResolver : IFocusEngagedEventArgsResolver
    {
        private readonly StubContainer<StubIFocusEngagedEventArgsResolver> _stubs = new StubContainer<StubIFocusEngagedEventArgsResolver>();

        object global::Fievus.Windows.Mvc.Wrappers.IFocusEngagedEventArgsResolver.OriginalSource(global::Windows.UI.Xaml.Controls.FocusEngagedEventArgs e)
        {
            return _stubs.GetMethodStub<OriginalSource_FocusEngagedEventArgs_Delegate>("OriginalSource").Invoke(e);
        }

        public delegate object OriginalSource_FocusEngagedEventArgs_Delegate(global::Windows.UI.Xaml.Controls.FocusEngagedEventArgs e);

        public StubIFocusEngagedEventArgsResolver OriginalSource(OriginalSource_FocusEngagedEventArgs_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }
    }
}

namespace Fievus.Windows.Mvc.Wrappers
{
    [CompilerGenerated]
    public class StubIHoldingRoutedEventArgsResolver : IHoldingRoutedEventArgsResolver
    {
        private readonly StubContainer<StubIHoldingRoutedEventArgsResolver> _stubs = new StubContainer<StubIHoldingRoutedEventArgsResolver>();

        bool global::Fievus.Windows.Mvc.Wrappers.IHoldingRoutedEventArgsResolver.Handled(global::Windows.UI.Xaml.Input.HoldingRoutedEventArgs e)
        {
            return _stubs.GetMethodStub<Handled_HoldingRoutedEventArgs_Delegate>("Handled").Invoke(e);
        }

        public delegate bool Handled_HoldingRoutedEventArgs_Delegate(global::Windows.UI.Xaml.Input.HoldingRoutedEventArgs e);

        public StubIHoldingRoutedEventArgsResolver Handled(Handled_HoldingRoutedEventArgs_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        void global::Fievus.Windows.Mvc.Wrappers.IHoldingRoutedEventArgsResolver.Handled(global::Windows.UI.Xaml.Input.HoldingRoutedEventArgs e, bool handled)
        {
            _stubs.GetMethodStub<Handled_HoldingRoutedEventArgs_Boolean_Delegate>("Handled").Invoke(e, handled);
        }

        public delegate void Handled_HoldingRoutedEventArgs_Boolean_Delegate(global::Windows.UI.Xaml.Input.HoldingRoutedEventArgs e, bool handled);

        public StubIHoldingRoutedEventArgsResolver Handled(Handled_HoldingRoutedEventArgs_Boolean_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        global::Windows.UI.Input.HoldingState global::Fievus.Windows.Mvc.Wrappers.IHoldingRoutedEventArgsResolver.HoldingState(global::Windows.UI.Xaml.Input.HoldingRoutedEventArgs e)
        {
            return _stubs.GetMethodStub<HoldingState_HoldingRoutedEventArgs_Delegate>("HoldingState").Invoke(e);
        }

        public delegate global::Windows.UI.Input.HoldingState HoldingState_HoldingRoutedEventArgs_Delegate(global::Windows.UI.Xaml.Input.HoldingRoutedEventArgs e);

        public StubIHoldingRoutedEventArgsResolver HoldingState(HoldingState_HoldingRoutedEventArgs_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        object global::Fievus.Windows.Mvc.Wrappers.IHoldingRoutedEventArgsResolver.OriginalSource(global::Windows.UI.Xaml.Input.HoldingRoutedEventArgs e)
        {
            return _stubs.GetMethodStub<OriginalSource_HoldingRoutedEventArgs_Delegate>("OriginalSource").Invoke(e);
        }

        public delegate object OriginalSource_HoldingRoutedEventArgs_Delegate(global::Windows.UI.Xaml.Input.HoldingRoutedEventArgs e);

        public StubIHoldingRoutedEventArgsResolver OriginalSource(OriginalSource_HoldingRoutedEventArgs_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        global::Windows.Devices.Input.PointerDeviceType global::Fievus.Windows.Mvc.Wrappers.IHoldingRoutedEventArgsResolver.PointerDeviceType(global::Windows.UI.Xaml.Input.HoldingRoutedEventArgs e)
        {
            return _stubs.GetMethodStub<PointerDeviceType_HoldingRoutedEventArgs_Delegate>("PointerDeviceType").Invoke(e);
        }

        public delegate global::Windows.Devices.Input.PointerDeviceType PointerDeviceType_HoldingRoutedEventArgs_Delegate(global::Windows.UI.Xaml.Input.HoldingRoutedEventArgs e);

        public StubIHoldingRoutedEventArgsResolver PointerDeviceType(PointerDeviceType_HoldingRoutedEventArgs_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        global::Windows.Foundation.Point global::Fievus.Windows.Mvc.Wrappers.IHoldingRoutedEventArgsResolver.GetPosition(global::Windows.UI.Xaml.Input.HoldingRoutedEventArgs e, global::Windows.UI.Xaml.UIElement relativeTo)
        {
            return _stubs.GetMethodStub<GetPosition_HoldingRoutedEventArgs_UIElement_Delegate>("GetPosition").Invoke(e, relativeTo);
        }

        public delegate global::Windows.Foundation.Point GetPosition_HoldingRoutedEventArgs_UIElement_Delegate(global::Windows.UI.Xaml.Input.HoldingRoutedEventArgs e, global::Windows.UI.Xaml.UIElement relativeTo);

        public StubIHoldingRoutedEventArgsResolver GetPosition(GetPosition_HoldingRoutedEventArgs_UIElement_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }
    }
}

namespace Fievus.Windows.Mvc.Wrappers
{
    [CompilerGenerated]
    public class StubIHubSectionHeaderClickEventArgsResolver : IHubSectionHeaderClickEventArgsResolver
    {
        private readonly StubContainer<StubIHubSectionHeaderClickEventArgsResolver> _stubs = new StubContainer<StubIHubSectionHeaderClickEventArgsResolver>();

        global::Windows.UI.Xaml.Controls.HubSection global::Fievus.Windows.Mvc.Wrappers.IHubSectionHeaderClickEventArgsResolver.Section(global::Windows.UI.Xaml.Controls.HubSectionHeaderClickEventArgs e)
        {
            return _stubs.GetMethodStub<Section_HubSectionHeaderClickEventArgs_Delegate>("Section").Invoke(e);
        }

        public delegate global::Windows.UI.Xaml.Controls.HubSection Section_HubSectionHeaderClickEventArgs_Delegate(global::Windows.UI.Xaml.Controls.HubSectionHeaderClickEventArgs e);

        public StubIHubSectionHeaderClickEventArgsResolver Section(Section_HubSectionHeaderClickEventArgs_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }
    }
}

namespace Fievus.Windows.Mvc.Wrappers
{
    [CompilerGenerated]
    public class StubIInertiaExpansionBehaviorResolver : IInertiaExpansionBehaviorResolver
    {
        private readonly StubContainer<StubIInertiaExpansionBehaviorResolver> _stubs = new StubContainer<StubIInertiaExpansionBehaviorResolver>();

        double global::Fievus.Windows.Mvc.Wrappers.IInertiaExpansionBehaviorResolver.DesiredDeceleration(global::Windows.UI.Xaml.Input.InertiaExpansionBehavior expansionBehavior)
        {
            return _stubs.GetMethodStub<DesiredDeceleration_InertiaExpansionBehavior_Delegate>("DesiredDeceleration").Invoke(expansionBehavior);
        }

        public delegate double DesiredDeceleration_InertiaExpansionBehavior_Delegate(global::Windows.UI.Xaml.Input.InertiaExpansionBehavior expansionBehavior);

        public StubIInertiaExpansionBehaviorResolver DesiredDeceleration(DesiredDeceleration_InertiaExpansionBehavior_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        void global::Fievus.Windows.Mvc.Wrappers.IInertiaExpansionBehaviorResolver.DesiredDeceleration(global::Windows.UI.Xaml.Input.InertiaExpansionBehavior expansionBehavior, double desiredDeceleration)
        {
            _stubs.GetMethodStub<DesiredDeceleration_InertiaExpansionBehavior_Double_Delegate>("DesiredDeceleration").Invoke(expansionBehavior, desiredDeceleration);
        }

        public delegate void DesiredDeceleration_InertiaExpansionBehavior_Double_Delegate(global::Windows.UI.Xaml.Input.InertiaExpansionBehavior expansionBehavior, double desiredDeceleration);

        public StubIInertiaExpansionBehaviorResolver DesiredDeceleration(DesiredDeceleration_InertiaExpansionBehavior_Double_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        double global::Fievus.Windows.Mvc.Wrappers.IInertiaExpansionBehaviorResolver.DesiredExpansion(global::Windows.UI.Xaml.Input.InertiaExpansionBehavior expansionBehavior)
        {
            return _stubs.GetMethodStub<DesiredExpansion_InertiaExpansionBehavior_Delegate>("DesiredExpansion").Invoke(expansionBehavior);
        }

        public delegate double DesiredExpansion_InertiaExpansionBehavior_Delegate(global::Windows.UI.Xaml.Input.InertiaExpansionBehavior expansionBehavior);

        public StubIInertiaExpansionBehaviorResolver DesiredExpansion(DesiredExpansion_InertiaExpansionBehavior_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        void global::Fievus.Windows.Mvc.Wrappers.IInertiaExpansionBehaviorResolver.DesiredExpansion(global::Windows.UI.Xaml.Input.InertiaExpansionBehavior expansionBehavior, double desiredExpansion)
        {
            _stubs.GetMethodStub<DesiredExpansion_InertiaExpansionBehavior_Double_Delegate>("DesiredExpansion").Invoke(expansionBehavior, desiredExpansion);
        }

        public delegate void DesiredExpansion_InertiaExpansionBehavior_Double_Delegate(global::Windows.UI.Xaml.Input.InertiaExpansionBehavior expansionBehavior, double desiredExpansion);

        public StubIInertiaExpansionBehaviorResolver DesiredExpansion(DesiredExpansion_InertiaExpansionBehavior_Double_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }
    }
}

namespace Fievus.Windows.Mvc.Wrappers
{
    [CompilerGenerated]
    public class StubIInertiaRotationBehaviorResolver : IInertiaRotationBehaviorResolver
    {
        private readonly StubContainer<StubIInertiaRotationBehaviorResolver> _stubs = new StubContainer<StubIInertiaRotationBehaviorResolver>();

        double global::Fievus.Windows.Mvc.Wrappers.IInertiaRotationBehaviorResolver.DesiredDeceleration(global::Windows.UI.Xaml.Input.InertiaRotationBehavior rotationBehavior)
        {
            return _stubs.GetMethodStub<DesiredDeceleration_InertiaRotationBehavior_Delegate>("DesiredDeceleration").Invoke(rotationBehavior);
        }

        public delegate double DesiredDeceleration_InertiaRotationBehavior_Delegate(global::Windows.UI.Xaml.Input.InertiaRotationBehavior rotationBehavior);

        public StubIInertiaRotationBehaviorResolver DesiredDeceleration(DesiredDeceleration_InertiaRotationBehavior_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        void global::Fievus.Windows.Mvc.Wrappers.IInertiaRotationBehaviorResolver.DesiredDeceleration(global::Windows.UI.Xaml.Input.InertiaRotationBehavior rotationBehavior, double desiredDeceleration)
        {
            _stubs.GetMethodStub<DesiredDeceleration_InertiaRotationBehavior_Double_Delegate>("DesiredDeceleration").Invoke(rotationBehavior, desiredDeceleration);
        }

        public delegate void DesiredDeceleration_InertiaRotationBehavior_Double_Delegate(global::Windows.UI.Xaml.Input.InertiaRotationBehavior rotationBehavior, double desiredDeceleration);

        public StubIInertiaRotationBehaviorResolver DesiredDeceleration(DesiredDeceleration_InertiaRotationBehavior_Double_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        double global::Fievus.Windows.Mvc.Wrappers.IInertiaRotationBehaviorResolver.DesiredRotation(global::Windows.UI.Xaml.Input.InertiaRotationBehavior rotationBehavior)
        {
            return _stubs.GetMethodStub<DesiredRotation_InertiaRotationBehavior_Delegate>("DesiredRotation").Invoke(rotationBehavior);
        }

        public delegate double DesiredRotation_InertiaRotationBehavior_Delegate(global::Windows.UI.Xaml.Input.InertiaRotationBehavior rotationBehavior);

        public StubIInertiaRotationBehaviorResolver DesiredRotation(DesiredRotation_InertiaRotationBehavior_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        void global::Fievus.Windows.Mvc.Wrappers.IInertiaRotationBehaviorResolver.DesiredRotation(global::Windows.UI.Xaml.Input.InertiaRotationBehavior rotationBehavior, double desiredRotation)
        {
            _stubs.GetMethodStub<DesiredRotation_InertiaRotationBehavior_Double_Delegate>("DesiredRotation").Invoke(rotationBehavior, desiredRotation);
        }

        public delegate void DesiredRotation_InertiaRotationBehavior_Double_Delegate(global::Windows.UI.Xaml.Input.InertiaRotationBehavior rotationBehavior, double desiredRotation);

        public StubIInertiaRotationBehaviorResolver DesiredRotation(DesiredRotation_InertiaRotationBehavior_Double_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }
    }
}

namespace Fievus.Windows.Mvc.Wrappers
{
    [CompilerGenerated]
    public class StubIInertiaTranslationBehaviorResolver : IInertiaTranslationBehaviorResolver
    {
        private readonly StubContainer<StubIInertiaTranslationBehaviorResolver> _stubs = new StubContainer<StubIInertiaTranslationBehaviorResolver>();

        double global::Fievus.Windows.Mvc.Wrappers.IInertiaTranslationBehaviorResolver.DesiredDeceleration(global::Windows.UI.Xaml.Input.InertiaTranslationBehavior translationBehavior)
        {
            return _stubs.GetMethodStub<DesiredDeceleration_InertiaTranslationBehavior_Delegate>("DesiredDeceleration").Invoke(translationBehavior);
        }

        public delegate double DesiredDeceleration_InertiaTranslationBehavior_Delegate(global::Windows.UI.Xaml.Input.InertiaTranslationBehavior translationBehavior);

        public StubIInertiaTranslationBehaviorResolver DesiredDeceleration(DesiredDeceleration_InertiaTranslationBehavior_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        void global::Fievus.Windows.Mvc.Wrappers.IInertiaTranslationBehaviorResolver.DesiredDeceleration(global::Windows.UI.Xaml.Input.InertiaTranslationBehavior translationBehavior, double desiredDeceleration)
        {
            _stubs.GetMethodStub<DesiredDeceleration_InertiaTranslationBehavior_Double_Delegate>("DesiredDeceleration").Invoke(translationBehavior, desiredDeceleration);
        }

        public delegate void DesiredDeceleration_InertiaTranslationBehavior_Double_Delegate(global::Windows.UI.Xaml.Input.InertiaTranslationBehavior translationBehavior, double desiredDeceleration);

        public StubIInertiaTranslationBehaviorResolver DesiredDeceleration(DesiredDeceleration_InertiaTranslationBehavior_Double_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        double global::Fievus.Windows.Mvc.Wrappers.IInertiaTranslationBehaviorResolver.DesiredDisplacement(global::Windows.UI.Xaml.Input.InertiaTranslationBehavior translationBehavior)
        {
            return _stubs.GetMethodStub<DesiredDisplacement_InertiaTranslationBehavior_Delegate>("DesiredDisplacement").Invoke(translationBehavior);
        }

        public delegate double DesiredDisplacement_InertiaTranslationBehavior_Delegate(global::Windows.UI.Xaml.Input.InertiaTranslationBehavior translationBehavior);

        public StubIInertiaTranslationBehaviorResolver DesiredDisplacement(DesiredDisplacement_InertiaTranslationBehavior_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        void global::Fievus.Windows.Mvc.Wrappers.IInertiaTranslationBehaviorResolver.DesiredDisplacement(global::Windows.UI.Xaml.Input.InertiaTranslationBehavior translationBehavior, double desiredDeisplacement)
        {
            _stubs.GetMethodStub<DesiredDisplacement_InertiaTranslationBehavior_Double_Delegate>("DesiredDisplacement").Invoke(translationBehavior, desiredDeisplacement);
        }

        public delegate void DesiredDisplacement_InertiaTranslationBehavior_Double_Delegate(global::Windows.UI.Xaml.Input.InertiaTranslationBehavior translationBehavior, double desiredDeisplacement);

        public StubIInertiaTranslationBehaviorResolver DesiredDisplacement(DesiredDisplacement_InertiaTranslationBehavior_Double_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }
    }
}

namespace Fievus.Windows.Mvc.Wrappers
{
    [CompilerGenerated]
    public class StubIItemClickEventArgsResolver : IItemClickEventArgsResolver
    {
        private readonly StubContainer<StubIItemClickEventArgsResolver> _stubs = new StubContainer<StubIItemClickEventArgsResolver>();

        object global::Fievus.Windows.Mvc.Wrappers.IItemClickEventArgsResolver.ClickedItem(global::Windows.UI.Xaml.Controls.ItemClickEventArgs e)
        {
            return _stubs.GetMethodStub<ClickedItem_ItemClickEventArgs_Delegate>("ClickedItem").Invoke(e);
        }

        public delegate object ClickedItem_ItemClickEventArgs_Delegate(global::Windows.UI.Xaml.Controls.ItemClickEventArgs e);

        public StubIItemClickEventArgsResolver ClickedItem(ClickedItem_ItemClickEventArgs_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        object global::Fievus.Windows.Mvc.Wrappers.IItemClickEventArgsResolver.OriginalSource(global::Windows.UI.Xaml.Controls.ItemClickEventArgs e)
        {
            return _stubs.GetMethodStub<OriginalSource_ItemClickEventArgs_Delegate>("OriginalSource").Invoke(e);
        }

        public delegate object OriginalSource_ItemClickEventArgs_Delegate(global::Windows.UI.Xaml.Controls.ItemClickEventArgs e);

        public StubIItemClickEventArgsResolver OriginalSource(OriginalSource_ItemClickEventArgs_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }
    }
}

namespace Fievus.Windows.Mvc.Wrappers
{
    [CompilerGenerated]
    public class StubIKeyRoutedEventArgsResolver : IKeyRoutedEventArgsResolver
    {
        private readonly StubContainer<StubIKeyRoutedEventArgsResolver> _stubs = new StubContainer<StubIKeyRoutedEventArgsResolver>();

        string global::Fievus.Windows.Mvc.Wrappers.IKeyRoutedEventArgsResolver.DeviceId(global::Windows.UI.Xaml.Input.KeyRoutedEventArgs e)
        {
            return _stubs.GetMethodStub<DeviceId_KeyRoutedEventArgs_Delegate>("DeviceId").Invoke(e);
        }

        public delegate string DeviceId_KeyRoutedEventArgs_Delegate(global::Windows.UI.Xaml.Input.KeyRoutedEventArgs e);

        public StubIKeyRoutedEventArgsResolver DeviceId(DeviceId_KeyRoutedEventArgs_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        bool global::Fievus.Windows.Mvc.Wrappers.IKeyRoutedEventArgsResolver.Handled(global::Windows.UI.Xaml.Input.KeyRoutedEventArgs e)
        {
            return _stubs.GetMethodStub<Handled_KeyRoutedEventArgs_Delegate>("Handled").Invoke(e);
        }

        public delegate bool Handled_KeyRoutedEventArgs_Delegate(global::Windows.UI.Xaml.Input.KeyRoutedEventArgs e);

        public StubIKeyRoutedEventArgsResolver Handled(Handled_KeyRoutedEventArgs_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        void global::Fievus.Windows.Mvc.Wrappers.IKeyRoutedEventArgsResolver.Handled(global::Windows.UI.Xaml.Input.KeyRoutedEventArgs e, bool handled)
        {
            _stubs.GetMethodStub<Handled_KeyRoutedEventArgs_Boolean_Delegate>("Handled").Invoke(e, handled);
        }

        public delegate void Handled_KeyRoutedEventArgs_Boolean_Delegate(global::Windows.UI.Xaml.Input.KeyRoutedEventArgs e, bool handled);

        public StubIKeyRoutedEventArgsResolver Handled(Handled_KeyRoutedEventArgs_Boolean_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        global::Windows.System.VirtualKey global::Fievus.Windows.Mvc.Wrappers.IKeyRoutedEventArgsResolver.Key(global::Windows.UI.Xaml.Input.KeyRoutedEventArgs e)
        {
            return _stubs.GetMethodStub<Key_KeyRoutedEventArgs_Delegate>("Key").Invoke(e);
        }

        public delegate global::Windows.System.VirtualKey Key_KeyRoutedEventArgs_Delegate(global::Windows.UI.Xaml.Input.KeyRoutedEventArgs e);

        public StubIKeyRoutedEventArgsResolver Key(Key_KeyRoutedEventArgs_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        global::Windows.UI.Core.CorePhysicalKeyStatus global::Fievus.Windows.Mvc.Wrappers.IKeyRoutedEventArgsResolver.KeyStatus(global::Windows.UI.Xaml.Input.KeyRoutedEventArgs e)
        {
            return _stubs.GetMethodStub<KeyStatus_KeyRoutedEventArgs_Delegate>("KeyStatus").Invoke(e);
        }

        public delegate global::Windows.UI.Core.CorePhysicalKeyStatus KeyStatus_KeyRoutedEventArgs_Delegate(global::Windows.UI.Xaml.Input.KeyRoutedEventArgs e);

        public StubIKeyRoutedEventArgsResolver KeyStatus(KeyStatus_KeyRoutedEventArgs_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        global::Windows.System.VirtualKey global::Fievus.Windows.Mvc.Wrappers.IKeyRoutedEventArgsResolver.OriginalKey(global::Windows.UI.Xaml.Input.KeyRoutedEventArgs e)
        {
            return _stubs.GetMethodStub<OriginalKey_KeyRoutedEventArgs_Delegate>("OriginalKey").Invoke(e);
        }

        public delegate global::Windows.System.VirtualKey OriginalKey_KeyRoutedEventArgs_Delegate(global::Windows.UI.Xaml.Input.KeyRoutedEventArgs e);

        public StubIKeyRoutedEventArgsResolver OriginalKey(OriginalKey_KeyRoutedEventArgs_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        object global::Fievus.Windows.Mvc.Wrappers.IKeyRoutedEventArgsResolver.OriginalSource(global::Windows.UI.Xaml.Input.KeyRoutedEventArgs e)
        {
            return _stubs.GetMethodStub<OriginalSource_KeyRoutedEventArgs_Delegate>("OriginalSource").Invoke(e);
        }

        public delegate object OriginalSource_KeyRoutedEventArgs_Delegate(global::Windows.UI.Xaml.Input.KeyRoutedEventArgs e);

        public StubIKeyRoutedEventArgsResolver OriginalSource(OriginalSource_KeyRoutedEventArgs_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }
    }
}

namespace Fievus.Windows.Mvc.Wrappers
{
    [CompilerGenerated]
    public class StubIManipulationCompletedRoutedEventArgsResolver : IManipulationCompletedRoutedEventArgsResolver
    {
        private readonly StubContainer<StubIManipulationCompletedRoutedEventArgsResolver> _stubs = new StubContainer<StubIManipulationCompletedRoutedEventArgsResolver>();

        global::Windows.UI.Xaml.UIElement global::Fievus.Windows.Mvc.Wrappers.IManipulationCompletedRoutedEventArgsResolver.Container(global::Windows.UI.Xaml.Input.ManipulationCompletedRoutedEventArgs e)
        {
            return _stubs.GetMethodStub<Container_ManipulationCompletedRoutedEventArgs_Delegate>("Container").Invoke(e);
        }

        public delegate global::Windows.UI.Xaml.UIElement Container_ManipulationCompletedRoutedEventArgs_Delegate(global::Windows.UI.Xaml.Input.ManipulationCompletedRoutedEventArgs e);

        public StubIManipulationCompletedRoutedEventArgsResolver Container(Container_ManipulationCompletedRoutedEventArgs_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        global::Windows.UI.Input.ManipulationDelta global::Fievus.Windows.Mvc.Wrappers.IManipulationCompletedRoutedEventArgsResolver.Cumulative(global::Windows.UI.Xaml.Input.ManipulationCompletedRoutedEventArgs e)
        {
            return _stubs.GetMethodStub<Cumulative_ManipulationCompletedRoutedEventArgs_Delegate>("Cumulative").Invoke(e);
        }

        public delegate global::Windows.UI.Input.ManipulationDelta Cumulative_ManipulationCompletedRoutedEventArgs_Delegate(global::Windows.UI.Xaml.Input.ManipulationCompletedRoutedEventArgs e);

        public StubIManipulationCompletedRoutedEventArgsResolver Cumulative(Cumulative_ManipulationCompletedRoutedEventArgs_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        bool global::Fievus.Windows.Mvc.Wrappers.IManipulationCompletedRoutedEventArgsResolver.Handled(global::Windows.UI.Xaml.Input.ManipulationCompletedRoutedEventArgs e)
        {
            return _stubs.GetMethodStub<Handled_ManipulationCompletedRoutedEventArgs_Delegate>("Handled").Invoke(e);
        }

        public delegate bool Handled_ManipulationCompletedRoutedEventArgs_Delegate(global::Windows.UI.Xaml.Input.ManipulationCompletedRoutedEventArgs e);

        public StubIManipulationCompletedRoutedEventArgsResolver Handled(Handled_ManipulationCompletedRoutedEventArgs_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        void global::Fievus.Windows.Mvc.Wrappers.IManipulationCompletedRoutedEventArgsResolver.Handled(global::Windows.UI.Xaml.Input.ManipulationCompletedRoutedEventArgs e, bool handled)
        {
            _stubs.GetMethodStub<Handled_ManipulationCompletedRoutedEventArgs_Boolean_Delegate>("Handled").Invoke(e, handled);
        }

        public delegate void Handled_ManipulationCompletedRoutedEventArgs_Boolean_Delegate(global::Windows.UI.Xaml.Input.ManipulationCompletedRoutedEventArgs e, bool handled);

        public StubIManipulationCompletedRoutedEventArgsResolver Handled(Handled_ManipulationCompletedRoutedEventArgs_Boolean_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        bool global::Fievus.Windows.Mvc.Wrappers.IManipulationCompletedRoutedEventArgsResolver.IsInertial(global::Windows.UI.Xaml.Input.ManipulationCompletedRoutedEventArgs e)
        {
            return _stubs.GetMethodStub<IsInertial_ManipulationCompletedRoutedEventArgs_Delegate>("IsInertial").Invoke(e);
        }

        public delegate bool IsInertial_ManipulationCompletedRoutedEventArgs_Delegate(global::Windows.UI.Xaml.Input.ManipulationCompletedRoutedEventArgs e);

        public StubIManipulationCompletedRoutedEventArgsResolver IsInertial(IsInertial_ManipulationCompletedRoutedEventArgs_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        object global::Fievus.Windows.Mvc.Wrappers.IManipulationCompletedRoutedEventArgsResolver.OriginalSource(global::Windows.UI.Xaml.Input.ManipulationCompletedRoutedEventArgs e)
        {
            return _stubs.GetMethodStub<OriginalSource_ManipulationCompletedRoutedEventArgs_Delegate>("OriginalSource").Invoke(e);
        }

        public delegate object OriginalSource_ManipulationCompletedRoutedEventArgs_Delegate(global::Windows.UI.Xaml.Input.ManipulationCompletedRoutedEventArgs e);

        public StubIManipulationCompletedRoutedEventArgsResolver OriginalSource(OriginalSource_ManipulationCompletedRoutedEventArgs_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        global::Windows.Devices.Input.PointerDeviceType global::Fievus.Windows.Mvc.Wrappers.IManipulationCompletedRoutedEventArgsResolver.PointerDeviceType(global::Windows.UI.Xaml.Input.ManipulationCompletedRoutedEventArgs e)
        {
            return _stubs.GetMethodStub<PointerDeviceType_ManipulationCompletedRoutedEventArgs_Delegate>("PointerDeviceType").Invoke(e);
        }

        public delegate global::Windows.Devices.Input.PointerDeviceType PointerDeviceType_ManipulationCompletedRoutedEventArgs_Delegate(global::Windows.UI.Xaml.Input.ManipulationCompletedRoutedEventArgs e);

        public StubIManipulationCompletedRoutedEventArgsResolver PointerDeviceType(PointerDeviceType_ManipulationCompletedRoutedEventArgs_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        global::Windows.Foundation.Point global::Fievus.Windows.Mvc.Wrappers.IManipulationCompletedRoutedEventArgsResolver.Position(global::Windows.UI.Xaml.Input.ManipulationCompletedRoutedEventArgs e)
        {
            return _stubs.GetMethodStub<Position_ManipulationCompletedRoutedEventArgs_Delegate>("Position").Invoke(e);
        }

        public delegate global::Windows.Foundation.Point Position_ManipulationCompletedRoutedEventArgs_Delegate(global::Windows.UI.Xaml.Input.ManipulationCompletedRoutedEventArgs e);

        public StubIManipulationCompletedRoutedEventArgsResolver Position(Position_ManipulationCompletedRoutedEventArgs_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        global::Windows.UI.Input.ManipulationVelocities global::Fievus.Windows.Mvc.Wrappers.IManipulationCompletedRoutedEventArgsResolver.Velocities(global::Windows.UI.Xaml.Input.ManipulationCompletedRoutedEventArgs e)
        {
            return _stubs.GetMethodStub<Velocities_ManipulationCompletedRoutedEventArgs_Delegate>("Velocities").Invoke(e);
        }

        public delegate global::Windows.UI.Input.ManipulationVelocities Velocities_ManipulationCompletedRoutedEventArgs_Delegate(global::Windows.UI.Xaml.Input.ManipulationCompletedRoutedEventArgs e);

        public StubIManipulationCompletedRoutedEventArgsResolver Velocities(Velocities_ManipulationCompletedRoutedEventArgs_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }
    }
}

namespace Fievus.Windows.Mvc.Wrappers
{
    [CompilerGenerated]
    public class StubIManipulationDeltaRoutedEventArgsResolver : IManipulationDeltaRoutedEventArgsResolver
    {
        private readonly StubContainer<StubIManipulationDeltaRoutedEventArgsResolver> _stubs = new StubContainer<StubIManipulationDeltaRoutedEventArgsResolver>();

        global::Windows.UI.Xaml.UIElement global::Fievus.Windows.Mvc.Wrappers.IManipulationDeltaRoutedEventArgsResolver.Container(global::Windows.UI.Xaml.Input.ManipulationDeltaRoutedEventArgs e)
        {
            return _stubs.GetMethodStub<Container_ManipulationDeltaRoutedEventArgs_Delegate>("Container").Invoke(e);
        }

        public delegate global::Windows.UI.Xaml.UIElement Container_ManipulationDeltaRoutedEventArgs_Delegate(global::Windows.UI.Xaml.Input.ManipulationDeltaRoutedEventArgs e);

        public StubIManipulationDeltaRoutedEventArgsResolver Container(Container_ManipulationDeltaRoutedEventArgs_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        global::Windows.UI.Input.ManipulationDelta global::Fievus.Windows.Mvc.Wrappers.IManipulationDeltaRoutedEventArgsResolver.Cumulative(global::Windows.UI.Xaml.Input.ManipulationDeltaRoutedEventArgs e)
        {
            return _stubs.GetMethodStub<Cumulative_ManipulationDeltaRoutedEventArgs_Delegate>("Cumulative").Invoke(e);
        }

        public delegate global::Windows.UI.Input.ManipulationDelta Cumulative_ManipulationDeltaRoutedEventArgs_Delegate(global::Windows.UI.Xaml.Input.ManipulationDeltaRoutedEventArgs e);

        public StubIManipulationDeltaRoutedEventArgsResolver Cumulative(Cumulative_ManipulationDeltaRoutedEventArgs_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        global::Windows.UI.Input.ManipulationDelta global::Fievus.Windows.Mvc.Wrappers.IManipulationDeltaRoutedEventArgsResolver.Delta(global::Windows.UI.Xaml.Input.ManipulationDeltaRoutedEventArgs e)
        {
            return _stubs.GetMethodStub<Delta_ManipulationDeltaRoutedEventArgs_Delegate>("Delta").Invoke(e);
        }

        public delegate global::Windows.UI.Input.ManipulationDelta Delta_ManipulationDeltaRoutedEventArgs_Delegate(global::Windows.UI.Xaml.Input.ManipulationDeltaRoutedEventArgs e);

        public StubIManipulationDeltaRoutedEventArgsResolver Delta(Delta_ManipulationDeltaRoutedEventArgs_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        bool global::Fievus.Windows.Mvc.Wrappers.IManipulationDeltaRoutedEventArgsResolver.Handled(global::Windows.UI.Xaml.Input.ManipulationDeltaRoutedEventArgs e)
        {
            return _stubs.GetMethodStub<Handled_ManipulationDeltaRoutedEventArgs_Delegate>("Handled").Invoke(e);
        }

        public delegate bool Handled_ManipulationDeltaRoutedEventArgs_Delegate(global::Windows.UI.Xaml.Input.ManipulationDeltaRoutedEventArgs e);

        public StubIManipulationDeltaRoutedEventArgsResolver Handled(Handled_ManipulationDeltaRoutedEventArgs_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        void global::Fievus.Windows.Mvc.Wrappers.IManipulationDeltaRoutedEventArgsResolver.Handled(global::Windows.UI.Xaml.Input.ManipulationDeltaRoutedEventArgs e, bool handled)
        {
            _stubs.GetMethodStub<Handled_ManipulationDeltaRoutedEventArgs_Boolean_Delegate>("Handled").Invoke(e, handled);
        }

        public delegate void Handled_ManipulationDeltaRoutedEventArgs_Boolean_Delegate(global::Windows.UI.Xaml.Input.ManipulationDeltaRoutedEventArgs e, bool handled);

        public StubIManipulationDeltaRoutedEventArgsResolver Handled(Handled_ManipulationDeltaRoutedEventArgs_Boolean_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        bool global::Fievus.Windows.Mvc.Wrappers.IManipulationDeltaRoutedEventArgsResolver.IsInertial(global::Windows.UI.Xaml.Input.ManipulationDeltaRoutedEventArgs e)
        {
            return _stubs.GetMethodStub<IsInertial_ManipulationDeltaRoutedEventArgs_Delegate>("IsInertial").Invoke(e);
        }

        public delegate bool IsInertial_ManipulationDeltaRoutedEventArgs_Delegate(global::Windows.UI.Xaml.Input.ManipulationDeltaRoutedEventArgs e);

        public StubIManipulationDeltaRoutedEventArgsResolver IsInertial(IsInertial_ManipulationDeltaRoutedEventArgs_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        object global::Fievus.Windows.Mvc.Wrappers.IManipulationDeltaRoutedEventArgsResolver.OriginalSource(global::Windows.UI.Xaml.Input.ManipulationDeltaRoutedEventArgs e)
        {
            return _stubs.GetMethodStub<OriginalSource_ManipulationDeltaRoutedEventArgs_Delegate>("OriginalSource").Invoke(e);
        }

        public delegate object OriginalSource_ManipulationDeltaRoutedEventArgs_Delegate(global::Windows.UI.Xaml.Input.ManipulationDeltaRoutedEventArgs e);

        public StubIManipulationDeltaRoutedEventArgsResolver OriginalSource(OriginalSource_ManipulationDeltaRoutedEventArgs_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        global::Windows.Devices.Input.PointerDeviceType global::Fievus.Windows.Mvc.Wrappers.IManipulationDeltaRoutedEventArgsResolver.PointerDeviceType(global::Windows.UI.Xaml.Input.ManipulationDeltaRoutedEventArgs e)
        {
            return _stubs.GetMethodStub<PointerDeviceType_ManipulationDeltaRoutedEventArgs_Delegate>("PointerDeviceType").Invoke(e);
        }

        public delegate global::Windows.Devices.Input.PointerDeviceType PointerDeviceType_ManipulationDeltaRoutedEventArgs_Delegate(global::Windows.UI.Xaml.Input.ManipulationDeltaRoutedEventArgs e);

        public StubIManipulationDeltaRoutedEventArgsResolver PointerDeviceType(PointerDeviceType_ManipulationDeltaRoutedEventArgs_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        global::Windows.Foundation.Point global::Fievus.Windows.Mvc.Wrappers.IManipulationDeltaRoutedEventArgsResolver.Position(global::Windows.UI.Xaml.Input.ManipulationDeltaRoutedEventArgs e)
        {
            return _stubs.GetMethodStub<Position_ManipulationDeltaRoutedEventArgs_Delegate>("Position").Invoke(e);
        }

        public delegate global::Windows.Foundation.Point Position_ManipulationDeltaRoutedEventArgs_Delegate(global::Windows.UI.Xaml.Input.ManipulationDeltaRoutedEventArgs e);

        public StubIManipulationDeltaRoutedEventArgsResolver Position(Position_ManipulationDeltaRoutedEventArgs_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        global::Windows.UI.Input.ManipulationVelocities global::Fievus.Windows.Mvc.Wrappers.IManipulationDeltaRoutedEventArgsResolver.Velocities(global::Windows.UI.Xaml.Input.ManipulationDeltaRoutedEventArgs e)
        {
            return _stubs.GetMethodStub<Velocities_ManipulationDeltaRoutedEventArgs_Delegate>("Velocities").Invoke(e);
        }

        public delegate global::Windows.UI.Input.ManipulationVelocities Velocities_ManipulationDeltaRoutedEventArgs_Delegate(global::Windows.UI.Xaml.Input.ManipulationDeltaRoutedEventArgs e);

        public StubIManipulationDeltaRoutedEventArgsResolver Velocities(Velocities_ManipulationDeltaRoutedEventArgs_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        void global::Fievus.Windows.Mvc.Wrappers.IManipulationDeltaRoutedEventArgsResolver.Complete(global::Windows.UI.Xaml.Input.ManipulationDeltaRoutedEventArgs e)
        {
            _stubs.GetMethodStub<Complete_ManipulationDeltaRoutedEventArgs_Delegate>("Complete").Invoke(e);
        }

        public delegate void Complete_ManipulationDeltaRoutedEventArgs_Delegate(global::Windows.UI.Xaml.Input.ManipulationDeltaRoutedEventArgs e);

        public StubIManipulationDeltaRoutedEventArgsResolver Complete(Complete_ManipulationDeltaRoutedEventArgs_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }
    }
}

namespace Fievus.Windows.Mvc.Wrappers
{
    [CompilerGenerated]
    public class StubIManipulationInertiaStartingRoutedEventArgsResolver : IManipulationInertiaStartingRoutedEventArgsResolver
    {
        private readonly StubContainer<StubIManipulationInertiaStartingRoutedEventArgsResolver> _stubs = new StubContainer<StubIManipulationInertiaStartingRoutedEventArgsResolver>();

        global::Windows.UI.Xaml.UIElement global::Fievus.Windows.Mvc.Wrappers.IManipulationInertiaStartingRoutedEventArgsResolver.Container(global::Windows.UI.Xaml.Input.ManipulationInertiaStartingRoutedEventArgs e)
        {
            return _stubs.GetMethodStub<Container_ManipulationInertiaStartingRoutedEventArgs_Delegate>("Container").Invoke(e);
        }

        public delegate global::Windows.UI.Xaml.UIElement Container_ManipulationInertiaStartingRoutedEventArgs_Delegate(global::Windows.UI.Xaml.Input.ManipulationInertiaStartingRoutedEventArgs e);

        public StubIManipulationInertiaStartingRoutedEventArgsResolver Container(Container_ManipulationInertiaStartingRoutedEventArgs_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        global::Windows.UI.Input.ManipulationDelta global::Fievus.Windows.Mvc.Wrappers.IManipulationInertiaStartingRoutedEventArgsResolver.Cumulative(global::Windows.UI.Xaml.Input.ManipulationInertiaStartingRoutedEventArgs e)
        {
            return _stubs.GetMethodStub<Cumulative_ManipulationInertiaStartingRoutedEventArgs_Delegate>("Cumulative").Invoke(e);
        }

        public delegate global::Windows.UI.Input.ManipulationDelta Cumulative_ManipulationInertiaStartingRoutedEventArgs_Delegate(global::Windows.UI.Xaml.Input.ManipulationInertiaStartingRoutedEventArgs e);

        public StubIManipulationInertiaStartingRoutedEventArgsResolver Cumulative(Cumulative_ManipulationInertiaStartingRoutedEventArgs_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        global::Windows.UI.Input.ManipulationDelta global::Fievus.Windows.Mvc.Wrappers.IManipulationInertiaStartingRoutedEventArgsResolver.Delta(global::Windows.UI.Xaml.Input.ManipulationInertiaStartingRoutedEventArgs e)
        {
            return _stubs.GetMethodStub<Delta_ManipulationInertiaStartingRoutedEventArgs_Delegate>("Delta").Invoke(e);
        }

        public delegate global::Windows.UI.Input.ManipulationDelta Delta_ManipulationInertiaStartingRoutedEventArgs_Delegate(global::Windows.UI.Xaml.Input.ManipulationInertiaStartingRoutedEventArgs e);

        public StubIManipulationInertiaStartingRoutedEventArgsResolver Delta(Delta_ManipulationInertiaStartingRoutedEventArgs_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        global::Windows.UI.Xaml.Input.InertiaExpansionBehavior global::Fievus.Windows.Mvc.Wrappers.IManipulationInertiaStartingRoutedEventArgsResolver.ExpansionBehavior(global::Windows.UI.Xaml.Input.ManipulationInertiaStartingRoutedEventArgs e)
        {
            return _stubs.GetMethodStub<ExpansionBehavior_ManipulationInertiaStartingRoutedEventArgs_Delegate>("ExpansionBehavior").Invoke(e);
        }

        public delegate global::Windows.UI.Xaml.Input.InertiaExpansionBehavior ExpansionBehavior_ManipulationInertiaStartingRoutedEventArgs_Delegate(global::Windows.UI.Xaml.Input.ManipulationInertiaStartingRoutedEventArgs e);

        public StubIManipulationInertiaStartingRoutedEventArgsResolver ExpansionBehavior(ExpansionBehavior_ManipulationInertiaStartingRoutedEventArgs_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        void global::Fievus.Windows.Mvc.Wrappers.IManipulationInertiaStartingRoutedEventArgsResolver.ExpansionBehavior(global::Windows.UI.Xaml.Input.ManipulationInertiaStartingRoutedEventArgs e, global::Windows.UI.Xaml.Input.InertiaExpansionBehavior expansionBehavior)
        {
            _stubs.GetMethodStub<ExpansionBehavior_ManipulationInertiaStartingRoutedEventArgs_InertiaExpansionBehavior_Delegate>("ExpansionBehavior").Invoke(e, expansionBehavior);
        }

        public delegate void ExpansionBehavior_ManipulationInertiaStartingRoutedEventArgs_InertiaExpansionBehavior_Delegate(global::Windows.UI.Xaml.Input.ManipulationInertiaStartingRoutedEventArgs e, global::Windows.UI.Xaml.Input.InertiaExpansionBehavior expansionBehavior);

        public StubIManipulationInertiaStartingRoutedEventArgsResolver ExpansionBehavior(ExpansionBehavior_ManipulationInertiaStartingRoutedEventArgs_InertiaExpansionBehavior_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        bool global::Fievus.Windows.Mvc.Wrappers.IManipulationInertiaStartingRoutedEventArgsResolver.Handled(global::Windows.UI.Xaml.Input.ManipulationInertiaStartingRoutedEventArgs e)
        {
            return _stubs.GetMethodStub<Handled_ManipulationInertiaStartingRoutedEventArgs_Delegate>("Handled").Invoke(e);
        }

        public delegate bool Handled_ManipulationInertiaStartingRoutedEventArgs_Delegate(global::Windows.UI.Xaml.Input.ManipulationInertiaStartingRoutedEventArgs e);

        public StubIManipulationInertiaStartingRoutedEventArgsResolver Handled(Handled_ManipulationInertiaStartingRoutedEventArgs_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        void global::Fievus.Windows.Mvc.Wrappers.IManipulationInertiaStartingRoutedEventArgsResolver.Handled(global::Windows.UI.Xaml.Input.ManipulationInertiaStartingRoutedEventArgs e, bool handled)
        {
            _stubs.GetMethodStub<Handled_ManipulationInertiaStartingRoutedEventArgs_Boolean_Delegate>("Handled").Invoke(e, handled);
        }

        public delegate void Handled_ManipulationInertiaStartingRoutedEventArgs_Boolean_Delegate(global::Windows.UI.Xaml.Input.ManipulationInertiaStartingRoutedEventArgs e, bool handled);

        public StubIManipulationInertiaStartingRoutedEventArgsResolver Handled(Handled_ManipulationInertiaStartingRoutedEventArgs_Boolean_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        object global::Fievus.Windows.Mvc.Wrappers.IManipulationInertiaStartingRoutedEventArgsResolver.OriginalSource(global::Windows.UI.Xaml.Input.ManipulationInertiaStartingRoutedEventArgs e)
        {
            return _stubs.GetMethodStub<OriginalSource_ManipulationInertiaStartingRoutedEventArgs_Delegate>("OriginalSource").Invoke(e);
        }

        public delegate object OriginalSource_ManipulationInertiaStartingRoutedEventArgs_Delegate(global::Windows.UI.Xaml.Input.ManipulationInertiaStartingRoutedEventArgs e);

        public StubIManipulationInertiaStartingRoutedEventArgsResolver OriginalSource(OriginalSource_ManipulationInertiaStartingRoutedEventArgs_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        global::Windows.Devices.Input.PointerDeviceType global::Fievus.Windows.Mvc.Wrappers.IManipulationInertiaStartingRoutedEventArgsResolver.PointerDeviceType(global::Windows.UI.Xaml.Input.ManipulationInertiaStartingRoutedEventArgs e)
        {
            return _stubs.GetMethodStub<PointerDeviceType_ManipulationInertiaStartingRoutedEventArgs_Delegate>("PointerDeviceType").Invoke(e);
        }

        public delegate global::Windows.Devices.Input.PointerDeviceType PointerDeviceType_ManipulationInertiaStartingRoutedEventArgs_Delegate(global::Windows.UI.Xaml.Input.ManipulationInertiaStartingRoutedEventArgs e);

        public StubIManipulationInertiaStartingRoutedEventArgsResolver PointerDeviceType(PointerDeviceType_ManipulationInertiaStartingRoutedEventArgs_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        global::Windows.UI.Xaml.Input.InertiaRotationBehavior global::Fievus.Windows.Mvc.Wrappers.IManipulationInertiaStartingRoutedEventArgsResolver.RotationBehavior(global::Windows.UI.Xaml.Input.ManipulationInertiaStartingRoutedEventArgs e)
        {
            return _stubs.GetMethodStub<RotationBehavior_ManipulationInertiaStartingRoutedEventArgs_Delegate>("RotationBehavior").Invoke(e);
        }

        public delegate global::Windows.UI.Xaml.Input.InertiaRotationBehavior RotationBehavior_ManipulationInertiaStartingRoutedEventArgs_Delegate(global::Windows.UI.Xaml.Input.ManipulationInertiaStartingRoutedEventArgs e);

        public StubIManipulationInertiaStartingRoutedEventArgsResolver RotationBehavior(RotationBehavior_ManipulationInertiaStartingRoutedEventArgs_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        void global::Fievus.Windows.Mvc.Wrappers.IManipulationInertiaStartingRoutedEventArgsResolver.RotationBehavior(global::Windows.UI.Xaml.Input.ManipulationInertiaStartingRoutedEventArgs e, global::Windows.UI.Xaml.Input.InertiaRotationBehavior rotationBehavior)
        {
            _stubs.GetMethodStub<RotationBehavior_ManipulationInertiaStartingRoutedEventArgs_InertiaRotationBehavior_Delegate>("RotationBehavior").Invoke(e, rotationBehavior);
        }

        public delegate void RotationBehavior_ManipulationInertiaStartingRoutedEventArgs_InertiaRotationBehavior_Delegate(global::Windows.UI.Xaml.Input.ManipulationInertiaStartingRoutedEventArgs e, global::Windows.UI.Xaml.Input.InertiaRotationBehavior rotationBehavior);

        public StubIManipulationInertiaStartingRoutedEventArgsResolver RotationBehavior(RotationBehavior_ManipulationInertiaStartingRoutedEventArgs_InertiaRotationBehavior_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        global::Windows.UI.Xaml.Input.InertiaTranslationBehavior global::Fievus.Windows.Mvc.Wrappers.IManipulationInertiaStartingRoutedEventArgsResolver.TranslationBehavior(global::Windows.UI.Xaml.Input.ManipulationInertiaStartingRoutedEventArgs e)
        {
            return _stubs.GetMethodStub<TranslationBehavior_ManipulationInertiaStartingRoutedEventArgs_Delegate>("TranslationBehavior").Invoke(e);
        }

        public delegate global::Windows.UI.Xaml.Input.InertiaTranslationBehavior TranslationBehavior_ManipulationInertiaStartingRoutedEventArgs_Delegate(global::Windows.UI.Xaml.Input.ManipulationInertiaStartingRoutedEventArgs e);

        public StubIManipulationInertiaStartingRoutedEventArgsResolver TranslationBehavior(TranslationBehavior_ManipulationInertiaStartingRoutedEventArgs_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        void global::Fievus.Windows.Mvc.Wrappers.IManipulationInertiaStartingRoutedEventArgsResolver.TranslationBehavior(global::Windows.UI.Xaml.Input.ManipulationInertiaStartingRoutedEventArgs e, global::Windows.UI.Xaml.Input.InertiaTranslationBehavior translationBehavior)
        {
            _stubs.GetMethodStub<TranslationBehavior_ManipulationInertiaStartingRoutedEventArgs_InertiaTranslationBehavior_Delegate>("TranslationBehavior").Invoke(e, translationBehavior);
        }

        public delegate void TranslationBehavior_ManipulationInertiaStartingRoutedEventArgs_InertiaTranslationBehavior_Delegate(global::Windows.UI.Xaml.Input.ManipulationInertiaStartingRoutedEventArgs e, global::Windows.UI.Xaml.Input.InertiaTranslationBehavior translationBehavior);

        public StubIManipulationInertiaStartingRoutedEventArgsResolver TranslationBehavior(TranslationBehavior_ManipulationInertiaStartingRoutedEventArgs_InertiaTranslationBehavior_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        global::Windows.UI.Input.ManipulationVelocities global::Fievus.Windows.Mvc.Wrappers.IManipulationInertiaStartingRoutedEventArgsResolver.Velocities(global::Windows.UI.Xaml.Input.ManipulationInertiaStartingRoutedEventArgs e)
        {
            return _stubs.GetMethodStub<Velocities_ManipulationInertiaStartingRoutedEventArgs_Delegate>("Velocities").Invoke(e);
        }

        public delegate global::Windows.UI.Input.ManipulationVelocities Velocities_ManipulationInertiaStartingRoutedEventArgs_Delegate(global::Windows.UI.Xaml.Input.ManipulationInertiaStartingRoutedEventArgs e);

        public StubIManipulationInertiaStartingRoutedEventArgsResolver Velocities(Velocities_ManipulationInertiaStartingRoutedEventArgs_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }
    }
}

namespace Fievus.Windows.Mvc.Wrappers
{
    [CompilerGenerated]
    public class StubIManipulationStartedRoutedEventArgsResolver : IManipulationStartedRoutedEventArgsResolver
    {
        private readonly StubContainer<StubIManipulationStartedRoutedEventArgsResolver> _stubs = new StubContainer<StubIManipulationStartedRoutedEventArgsResolver>();

        global::Windows.UI.Xaml.UIElement global::Fievus.Windows.Mvc.Wrappers.IManipulationStartedRoutedEventArgsResolver.Container(global::Windows.UI.Xaml.Input.ManipulationStartedRoutedEventArgs e)
        {
            return _stubs.GetMethodStub<Container_ManipulationStartedRoutedEventArgs_Delegate>("Container").Invoke(e);
        }

        public delegate global::Windows.UI.Xaml.UIElement Container_ManipulationStartedRoutedEventArgs_Delegate(global::Windows.UI.Xaml.Input.ManipulationStartedRoutedEventArgs e);

        public StubIManipulationStartedRoutedEventArgsResolver Container(Container_ManipulationStartedRoutedEventArgs_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        global::Windows.UI.Input.ManipulationDelta global::Fievus.Windows.Mvc.Wrappers.IManipulationStartedRoutedEventArgsResolver.Cumulative(global::Windows.UI.Xaml.Input.ManipulationStartedRoutedEventArgs e)
        {
            return _stubs.GetMethodStub<Cumulative_ManipulationStartedRoutedEventArgs_Delegate>("Cumulative").Invoke(e);
        }

        public delegate global::Windows.UI.Input.ManipulationDelta Cumulative_ManipulationStartedRoutedEventArgs_Delegate(global::Windows.UI.Xaml.Input.ManipulationStartedRoutedEventArgs e);

        public StubIManipulationStartedRoutedEventArgsResolver Cumulative(Cumulative_ManipulationStartedRoutedEventArgs_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        bool global::Fievus.Windows.Mvc.Wrappers.IManipulationStartedRoutedEventArgsResolver.Handled(global::Windows.UI.Xaml.Input.ManipulationStartedRoutedEventArgs e)
        {
            return _stubs.GetMethodStub<Handled_ManipulationStartedRoutedEventArgs_Delegate>("Handled").Invoke(e);
        }

        public delegate bool Handled_ManipulationStartedRoutedEventArgs_Delegate(global::Windows.UI.Xaml.Input.ManipulationStartedRoutedEventArgs e);

        public StubIManipulationStartedRoutedEventArgsResolver Handled(Handled_ManipulationStartedRoutedEventArgs_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        void global::Fievus.Windows.Mvc.Wrappers.IManipulationStartedRoutedEventArgsResolver.Handled(global::Windows.UI.Xaml.Input.ManipulationStartedRoutedEventArgs e, bool handled)
        {
            _stubs.GetMethodStub<Handled_ManipulationStartedRoutedEventArgs_Boolean_Delegate>("Handled").Invoke(e, handled);
        }

        public delegate void Handled_ManipulationStartedRoutedEventArgs_Boolean_Delegate(global::Windows.UI.Xaml.Input.ManipulationStartedRoutedEventArgs e, bool handled);

        public StubIManipulationStartedRoutedEventArgsResolver Handled(Handled_ManipulationStartedRoutedEventArgs_Boolean_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        object global::Fievus.Windows.Mvc.Wrappers.IManipulationStartedRoutedEventArgsResolver.OriginalSource(global::Windows.UI.Xaml.Input.ManipulationStartedRoutedEventArgs e)
        {
            return _stubs.GetMethodStub<OriginalSource_ManipulationStartedRoutedEventArgs_Delegate>("OriginalSource").Invoke(e);
        }

        public delegate object OriginalSource_ManipulationStartedRoutedEventArgs_Delegate(global::Windows.UI.Xaml.Input.ManipulationStartedRoutedEventArgs e);

        public StubIManipulationStartedRoutedEventArgsResolver OriginalSource(OriginalSource_ManipulationStartedRoutedEventArgs_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        global::Windows.Devices.Input.PointerDeviceType global::Fievus.Windows.Mvc.Wrappers.IManipulationStartedRoutedEventArgsResolver.PointerDeviceType(global::Windows.UI.Xaml.Input.ManipulationStartedRoutedEventArgs e)
        {
            return _stubs.GetMethodStub<PointerDeviceType_ManipulationStartedRoutedEventArgs_Delegate>("PointerDeviceType").Invoke(e);
        }

        public delegate global::Windows.Devices.Input.PointerDeviceType PointerDeviceType_ManipulationStartedRoutedEventArgs_Delegate(global::Windows.UI.Xaml.Input.ManipulationStartedRoutedEventArgs e);

        public StubIManipulationStartedRoutedEventArgsResolver PointerDeviceType(PointerDeviceType_ManipulationStartedRoutedEventArgs_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        global::Windows.Foundation.Point global::Fievus.Windows.Mvc.Wrappers.IManipulationStartedRoutedEventArgsResolver.Position(global::Windows.UI.Xaml.Input.ManipulationStartedRoutedEventArgs e)
        {
            return _stubs.GetMethodStub<Position_ManipulationStartedRoutedEventArgs_Delegate>("Position").Invoke(e);
        }

        public delegate global::Windows.Foundation.Point Position_ManipulationStartedRoutedEventArgs_Delegate(global::Windows.UI.Xaml.Input.ManipulationStartedRoutedEventArgs e);

        public StubIManipulationStartedRoutedEventArgsResolver Position(Position_ManipulationStartedRoutedEventArgs_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        void global::Fievus.Windows.Mvc.Wrappers.IManipulationStartedRoutedEventArgsResolver.Complete(global::Windows.UI.Xaml.Input.ManipulationStartedRoutedEventArgs e)
        {
            _stubs.GetMethodStub<Complete_ManipulationStartedRoutedEventArgs_Delegate>("Complete").Invoke(e);
        }

        public delegate void Complete_ManipulationStartedRoutedEventArgs_Delegate(global::Windows.UI.Xaml.Input.ManipulationStartedRoutedEventArgs e);

        public StubIManipulationStartedRoutedEventArgsResolver Complete(Complete_ManipulationStartedRoutedEventArgs_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }
    }
}

namespace Fievus.Windows.Mvc.Wrappers
{
    [CompilerGenerated]
    public class StubIManipulationStartingRoutedEventArgsResolver : IManipulationStartingRoutedEventArgsResolver
    {
        private readonly StubContainer<StubIManipulationStartingRoutedEventArgsResolver> _stubs = new StubContainer<StubIManipulationStartingRoutedEventArgsResolver>();

        global::Windows.UI.Xaml.UIElement global::Fievus.Windows.Mvc.Wrappers.IManipulationStartingRoutedEventArgsResolver.Container(global::Windows.UI.Xaml.Input.ManipulationStartingRoutedEventArgs e)
        {
            return _stubs.GetMethodStub<Container_ManipulationStartingRoutedEventArgs_Delegate>("Container").Invoke(e);
        }

        public delegate global::Windows.UI.Xaml.UIElement Container_ManipulationStartingRoutedEventArgs_Delegate(global::Windows.UI.Xaml.Input.ManipulationStartingRoutedEventArgs e);

        public StubIManipulationStartingRoutedEventArgsResolver Container(Container_ManipulationStartingRoutedEventArgs_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        bool global::Fievus.Windows.Mvc.Wrappers.IManipulationStartingRoutedEventArgsResolver.Handled(global::Windows.UI.Xaml.Input.ManipulationStartingRoutedEventArgs e)
        {
            return _stubs.GetMethodStub<Handled_ManipulationStartingRoutedEventArgs_Delegate>("Handled").Invoke(e);
        }

        public delegate bool Handled_ManipulationStartingRoutedEventArgs_Delegate(global::Windows.UI.Xaml.Input.ManipulationStartingRoutedEventArgs e);

        public StubIManipulationStartingRoutedEventArgsResolver Handled(Handled_ManipulationStartingRoutedEventArgs_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        void global::Fievus.Windows.Mvc.Wrappers.IManipulationStartingRoutedEventArgsResolver.Handled(global::Windows.UI.Xaml.Input.ManipulationStartingRoutedEventArgs e, bool handled)
        {
            _stubs.GetMethodStub<Handled_ManipulationStartingRoutedEventArgs_Boolean_Delegate>("Handled").Invoke(e, handled);
        }

        public delegate void Handled_ManipulationStartingRoutedEventArgs_Boolean_Delegate(global::Windows.UI.Xaml.Input.ManipulationStartingRoutedEventArgs e, bool handled);

        public StubIManipulationStartingRoutedEventArgsResolver Handled(Handled_ManipulationStartingRoutedEventArgs_Boolean_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        global::Windows.UI.Xaml.Input.ManipulationModes global::Fievus.Windows.Mvc.Wrappers.IManipulationStartingRoutedEventArgsResolver.Mode(global::Windows.UI.Xaml.Input.ManipulationStartingRoutedEventArgs e)
        {
            return _stubs.GetMethodStub<Mode_ManipulationStartingRoutedEventArgs_Delegate>("Mode").Invoke(e);
        }

        public delegate global::Windows.UI.Xaml.Input.ManipulationModes Mode_ManipulationStartingRoutedEventArgs_Delegate(global::Windows.UI.Xaml.Input.ManipulationStartingRoutedEventArgs e);

        public StubIManipulationStartingRoutedEventArgsResolver Mode(Mode_ManipulationStartingRoutedEventArgs_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        void global::Fievus.Windows.Mvc.Wrappers.IManipulationStartingRoutedEventArgsResolver.Mode(global::Windows.UI.Xaml.Input.ManipulationStartingRoutedEventArgs e, global::Windows.UI.Xaml.Input.ManipulationModes mode)
        {
            _stubs.GetMethodStub<Mode_ManipulationStartingRoutedEventArgs_ManipulationModes_Delegate>("Mode").Invoke(e, mode);
        }

        public delegate void Mode_ManipulationStartingRoutedEventArgs_ManipulationModes_Delegate(global::Windows.UI.Xaml.Input.ManipulationStartingRoutedEventArgs e, global::Windows.UI.Xaml.Input.ManipulationModes mode);

        public StubIManipulationStartingRoutedEventArgsResolver Mode(Mode_ManipulationStartingRoutedEventArgs_ManipulationModes_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        object global::Fievus.Windows.Mvc.Wrappers.IManipulationStartingRoutedEventArgsResolver.OriginalSource(global::Windows.UI.Xaml.Input.ManipulationStartingRoutedEventArgs e)
        {
            return _stubs.GetMethodStub<OriginalSource_ManipulationStartingRoutedEventArgs_Delegate>("OriginalSource").Invoke(e);
        }

        public delegate object OriginalSource_ManipulationStartingRoutedEventArgs_Delegate(global::Windows.UI.Xaml.Input.ManipulationStartingRoutedEventArgs e);

        public StubIManipulationStartingRoutedEventArgsResolver OriginalSource(OriginalSource_ManipulationStartingRoutedEventArgs_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        global::Windows.UI.Xaml.Input.ManipulationPivot global::Fievus.Windows.Mvc.Wrappers.IManipulationStartingRoutedEventArgsResolver.Pivot(global::Windows.UI.Xaml.Input.ManipulationStartingRoutedEventArgs e)
        {
            return _stubs.GetMethodStub<Pivot_ManipulationStartingRoutedEventArgs_Delegate>("Pivot").Invoke(e);
        }

        public delegate global::Windows.UI.Xaml.Input.ManipulationPivot Pivot_ManipulationStartingRoutedEventArgs_Delegate(global::Windows.UI.Xaml.Input.ManipulationStartingRoutedEventArgs e);

        public StubIManipulationStartingRoutedEventArgsResolver Pivot(Pivot_ManipulationStartingRoutedEventArgs_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        void global::Fievus.Windows.Mvc.Wrappers.IManipulationStartingRoutedEventArgsResolver.Pivot(global::Windows.UI.Xaml.Input.ManipulationStartingRoutedEventArgs e, global::Windows.UI.Xaml.Input.ManipulationPivot pivot)
        {
            _stubs.GetMethodStub<Pivot_ManipulationStartingRoutedEventArgs_ManipulationPivot_Delegate>("Pivot").Invoke(e, pivot);
        }

        public delegate void Pivot_ManipulationStartingRoutedEventArgs_ManipulationPivot_Delegate(global::Windows.UI.Xaml.Input.ManipulationStartingRoutedEventArgs e, global::Windows.UI.Xaml.Input.ManipulationPivot pivot);

        public StubIManipulationStartingRoutedEventArgsResolver Pivot(Pivot_ManipulationStartingRoutedEventArgs_ManipulationPivot_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }
    }
}

namespace Fievus.Windows.Mvc.Wrappers
{
    [CompilerGenerated]
    public class StubIMapActualCameraChangedEventArgsResolver : IMapActualCameraChangedEventArgsResolver
    {
        private readonly StubContainer<StubIMapActualCameraChangedEventArgsResolver> _stubs = new StubContainer<StubIMapActualCameraChangedEventArgsResolver>();

        global::Windows.UI.Xaml.Controls.Maps.MapCamera global::Fievus.Windows.Mvc.Wrappers.IMapActualCameraChangedEventArgsResolver.Camera(global::Windows.UI.Xaml.Controls.Maps.MapActualCameraChangedEventArgs e)
        {
            return _stubs.GetMethodStub<Camera_MapActualCameraChangedEventArgs_Delegate>("Camera").Invoke(e);
        }

        public delegate global::Windows.UI.Xaml.Controls.Maps.MapCamera Camera_MapActualCameraChangedEventArgs_Delegate(global::Windows.UI.Xaml.Controls.Maps.MapActualCameraChangedEventArgs e);

        public StubIMapActualCameraChangedEventArgsResolver Camera(Camera_MapActualCameraChangedEventArgs_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        global::Windows.UI.Xaml.Controls.Maps.MapCameraChangeReason global::Fievus.Windows.Mvc.Wrappers.IMapActualCameraChangedEventArgsResolver.ChangeReason(global::Windows.UI.Xaml.Controls.Maps.MapActualCameraChangedEventArgs e)
        {
            return _stubs.GetMethodStub<ChangeReason_MapActualCameraChangedEventArgs_Delegate>("ChangeReason").Invoke(e);
        }

        public delegate global::Windows.UI.Xaml.Controls.Maps.MapCameraChangeReason ChangeReason_MapActualCameraChangedEventArgs_Delegate(global::Windows.UI.Xaml.Controls.Maps.MapActualCameraChangedEventArgs e);

        public StubIMapActualCameraChangedEventArgsResolver ChangeReason(ChangeReason_MapActualCameraChangedEventArgs_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }
    }
}

namespace Fievus.Windows.Mvc.Wrappers
{
    [CompilerGenerated]
    public class StubIMapActualCameraChangingEventArgsResolver : IMapActualCameraChangingEventArgsResolver
    {
        private readonly StubContainer<StubIMapActualCameraChangingEventArgsResolver> _stubs = new StubContainer<StubIMapActualCameraChangingEventArgsResolver>();

        global::Windows.UI.Xaml.Controls.Maps.MapCamera global::Fievus.Windows.Mvc.Wrappers.IMapActualCameraChangingEventArgsResolver.Camera(global::Windows.UI.Xaml.Controls.Maps.MapActualCameraChangingEventArgs e)
        {
            return _stubs.GetMethodStub<Camera_MapActualCameraChangingEventArgs_Delegate>("Camera").Invoke(e);
        }

        public delegate global::Windows.UI.Xaml.Controls.Maps.MapCamera Camera_MapActualCameraChangingEventArgs_Delegate(global::Windows.UI.Xaml.Controls.Maps.MapActualCameraChangingEventArgs e);

        public StubIMapActualCameraChangingEventArgsResolver Camera(Camera_MapActualCameraChangingEventArgs_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        global::Windows.UI.Xaml.Controls.Maps.MapCameraChangeReason global::Fievus.Windows.Mvc.Wrappers.IMapActualCameraChangingEventArgsResolver.ChangeReason(global::Windows.UI.Xaml.Controls.Maps.MapActualCameraChangingEventArgs e)
        {
            return _stubs.GetMethodStub<ChangeReason_MapActualCameraChangingEventArgs_Delegate>("ChangeReason").Invoke(e);
        }

        public delegate global::Windows.UI.Xaml.Controls.Maps.MapCameraChangeReason ChangeReason_MapActualCameraChangingEventArgs_Delegate(global::Windows.UI.Xaml.Controls.Maps.MapActualCameraChangingEventArgs e);

        public StubIMapActualCameraChangingEventArgsResolver ChangeReason(ChangeReason_MapActualCameraChangingEventArgs_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }
    }
}

namespace Fievus.Windows.Mvc.Wrappers
{
    [CompilerGenerated]
    public class StubIMapElementClickEventArgsResolver : IMapElementClickEventArgsResolver
    {
        private readonly StubContainer<StubIMapElementClickEventArgsResolver> _stubs = new StubContainer<StubIMapElementClickEventArgsResolver>();

        global::Windows.Devices.Geolocation.Geopoint global::Fievus.Windows.Mvc.Wrappers.IMapElementClickEventArgsResolver.Location(global::Windows.UI.Xaml.Controls.Maps.MapElementClickEventArgs e)
        {
            return _stubs.GetMethodStub<Location_MapElementClickEventArgs_Delegate>("Location").Invoke(e);
        }

        public delegate global::Windows.Devices.Geolocation.Geopoint Location_MapElementClickEventArgs_Delegate(global::Windows.UI.Xaml.Controls.Maps.MapElementClickEventArgs e);

        public StubIMapElementClickEventArgsResolver Location(Location_MapElementClickEventArgs_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        global::System.Collections.Generic.IList<global::Windows.UI.Xaml.Controls.Maps.MapElement> global::Fievus.Windows.Mvc.Wrappers.IMapElementClickEventArgsResolver.MapElements(global::Windows.UI.Xaml.Controls.Maps.MapElementClickEventArgs e)
        {
            return _stubs.GetMethodStub<MapElements_MapElementClickEventArgs_Delegate>("MapElements").Invoke(e);
        }

        public delegate global::System.Collections.Generic.IList<global::Windows.UI.Xaml.Controls.Maps.MapElement> MapElements_MapElementClickEventArgs_Delegate(global::Windows.UI.Xaml.Controls.Maps.MapElementClickEventArgs e);

        public StubIMapElementClickEventArgsResolver MapElements(MapElements_MapElementClickEventArgs_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        global::Windows.Foundation.Point global::Fievus.Windows.Mvc.Wrappers.IMapElementClickEventArgsResolver.Position(global::Windows.UI.Xaml.Controls.Maps.MapElementClickEventArgs e)
        {
            return _stubs.GetMethodStub<Position_MapElementClickEventArgs_Delegate>("Position").Invoke(e);
        }

        public delegate global::Windows.Foundation.Point Position_MapElementClickEventArgs_Delegate(global::Windows.UI.Xaml.Controls.Maps.MapElementClickEventArgs e);

        public StubIMapElementClickEventArgsResolver Position(Position_MapElementClickEventArgs_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }
    }
}

namespace Fievus.Windows.Mvc.Wrappers
{
    [CompilerGenerated]
    public class StubIMapElementPointerEnteredEventArgsResolver : IMapElementPointerEnteredEventArgsResolver
    {
        private readonly StubContainer<StubIMapElementPointerEnteredEventArgsResolver> _stubs = new StubContainer<StubIMapElementPointerEnteredEventArgsResolver>();

        global::Windows.Devices.Geolocation.Geopoint global::Fievus.Windows.Mvc.Wrappers.IMapElementPointerEnteredEventArgsResolver.Location(global::Windows.UI.Xaml.Controls.Maps.MapElementPointerEnteredEventArgs e)
        {
            return _stubs.GetMethodStub<Location_MapElementPointerEnteredEventArgs_Delegate>("Location").Invoke(e);
        }

        public delegate global::Windows.Devices.Geolocation.Geopoint Location_MapElementPointerEnteredEventArgs_Delegate(global::Windows.UI.Xaml.Controls.Maps.MapElementPointerEnteredEventArgs e);

        public StubIMapElementPointerEnteredEventArgsResolver Location(Location_MapElementPointerEnteredEventArgs_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        global::Windows.UI.Xaml.Controls.Maps.MapElement global::Fievus.Windows.Mvc.Wrappers.IMapElementPointerEnteredEventArgsResolver.MapElement(global::Windows.UI.Xaml.Controls.Maps.MapElementPointerEnteredEventArgs e)
        {
            return _stubs.GetMethodStub<MapElement_MapElementPointerEnteredEventArgs_Delegate>("MapElement").Invoke(e);
        }

        public delegate global::Windows.UI.Xaml.Controls.Maps.MapElement MapElement_MapElementPointerEnteredEventArgs_Delegate(global::Windows.UI.Xaml.Controls.Maps.MapElementPointerEnteredEventArgs e);

        public StubIMapElementPointerEnteredEventArgsResolver MapElement(MapElement_MapElementPointerEnteredEventArgs_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        global::Windows.Foundation.Point global::Fievus.Windows.Mvc.Wrappers.IMapElementPointerEnteredEventArgsResolver.Position(global::Windows.UI.Xaml.Controls.Maps.MapElementPointerEnteredEventArgs e)
        {
            return _stubs.GetMethodStub<Position_MapElementPointerEnteredEventArgs_Delegate>("Position").Invoke(e);
        }

        public delegate global::Windows.Foundation.Point Position_MapElementPointerEnteredEventArgs_Delegate(global::Windows.UI.Xaml.Controls.Maps.MapElementPointerEnteredEventArgs e);

        public StubIMapElementPointerEnteredEventArgsResolver Position(Position_MapElementPointerEnteredEventArgs_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }
    }
}

namespace Fievus.Windows.Mvc.Wrappers
{
    [CompilerGenerated]
    public class StubIMapElementPointerExitedEventArgsResolver : IMapElementPointerExitedEventArgsResolver
    {
        private readonly StubContainer<StubIMapElementPointerExitedEventArgsResolver> _stubs = new StubContainer<StubIMapElementPointerExitedEventArgsResolver>();

        global::Windows.Devices.Geolocation.Geopoint global::Fievus.Windows.Mvc.Wrappers.IMapElementPointerExitedEventArgsResolver.Location(global::Windows.UI.Xaml.Controls.Maps.MapElementPointerExitedEventArgs e)
        {
            return _stubs.GetMethodStub<Location_MapElementPointerExitedEventArgs_Delegate>("Location").Invoke(e);
        }

        public delegate global::Windows.Devices.Geolocation.Geopoint Location_MapElementPointerExitedEventArgs_Delegate(global::Windows.UI.Xaml.Controls.Maps.MapElementPointerExitedEventArgs e);

        public StubIMapElementPointerExitedEventArgsResolver Location(Location_MapElementPointerExitedEventArgs_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        global::Windows.UI.Xaml.Controls.Maps.MapElement global::Fievus.Windows.Mvc.Wrappers.IMapElementPointerExitedEventArgsResolver.MapElement(global::Windows.UI.Xaml.Controls.Maps.MapElementPointerExitedEventArgs e)
        {
            return _stubs.GetMethodStub<MapElement_MapElementPointerExitedEventArgs_Delegate>("MapElement").Invoke(e);
        }

        public delegate global::Windows.UI.Xaml.Controls.Maps.MapElement MapElement_MapElementPointerExitedEventArgs_Delegate(global::Windows.UI.Xaml.Controls.Maps.MapElementPointerExitedEventArgs e);

        public StubIMapElementPointerExitedEventArgsResolver MapElement(MapElement_MapElementPointerExitedEventArgs_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        global::Windows.Foundation.Point global::Fievus.Windows.Mvc.Wrappers.IMapElementPointerExitedEventArgsResolver.Position(global::Windows.UI.Xaml.Controls.Maps.MapElementPointerExitedEventArgs e)
        {
            return _stubs.GetMethodStub<Position_MapElementPointerExitedEventArgs_Delegate>("Position").Invoke(e);
        }

        public delegate global::Windows.Foundation.Point Position_MapElementPointerExitedEventArgs_Delegate(global::Windows.UI.Xaml.Controls.Maps.MapElementPointerExitedEventArgs e);

        public StubIMapElementPointerExitedEventArgsResolver Position(Position_MapElementPointerExitedEventArgs_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }
    }
}

namespace Fievus.Windows.Mvc.Wrappers
{
    [CompilerGenerated]
    public class StubIMapInputEventArgsResolver : IMapInputEventArgsResolver
    {
        private readonly StubContainer<StubIMapInputEventArgsResolver> _stubs = new StubContainer<StubIMapInputEventArgsResolver>();

        global::Windows.Devices.Geolocation.Geopoint global::Fievus.Windows.Mvc.Wrappers.IMapInputEventArgsResolver.Location(global::Windows.UI.Xaml.Controls.Maps.MapInputEventArgs e)
        {
            return _stubs.GetMethodStub<Location_MapInputEventArgs_Delegate>("Location").Invoke(e);
        }

        public delegate global::Windows.Devices.Geolocation.Geopoint Location_MapInputEventArgs_Delegate(global::Windows.UI.Xaml.Controls.Maps.MapInputEventArgs e);

        public StubIMapInputEventArgsResolver Location(Location_MapInputEventArgs_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        global::Windows.Foundation.Point global::Fievus.Windows.Mvc.Wrappers.IMapInputEventArgsResolver.Position(global::Windows.UI.Xaml.Controls.Maps.MapInputEventArgs e)
        {
            return _stubs.GetMethodStub<Position_MapInputEventArgs_Delegate>("Position").Invoke(e);
        }

        public delegate global::Windows.Foundation.Point Position_MapInputEventArgs_Delegate(global::Windows.UI.Xaml.Controls.Maps.MapInputEventArgs e);

        public StubIMapInputEventArgsResolver Position(Position_MapInputEventArgs_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }
    }
}

namespace Fievus.Windows.Mvc.Wrappers
{
    [CompilerGenerated]
    public class StubIMapRightTappedEventArgsResolver : IMapRightTappedEventArgsResolver
    {
        private readonly StubContainer<StubIMapRightTappedEventArgsResolver> _stubs = new StubContainer<StubIMapRightTappedEventArgsResolver>();

        global::Windows.Devices.Geolocation.Geopoint global::Fievus.Windows.Mvc.Wrappers.IMapRightTappedEventArgsResolver.Location(global::Windows.UI.Xaml.Controls.Maps.MapRightTappedEventArgs e)
        {
            return _stubs.GetMethodStub<Location_MapRightTappedEventArgs_Delegate>("Location").Invoke(e);
        }

        public delegate global::Windows.Devices.Geolocation.Geopoint Location_MapRightTappedEventArgs_Delegate(global::Windows.UI.Xaml.Controls.Maps.MapRightTappedEventArgs e);

        public StubIMapRightTappedEventArgsResolver Location(Location_MapRightTappedEventArgs_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        global::Windows.Foundation.Point global::Fievus.Windows.Mvc.Wrappers.IMapRightTappedEventArgsResolver.Position(global::Windows.UI.Xaml.Controls.Maps.MapRightTappedEventArgs e)
        {
            return _stubs.GetMethodStub<Position_MapRightTappedEventArgs_Delegate>("Position").Invoke(e);
        }

        public delegate global::Windows.Foundation.Point Position_MapRightTappedEventArgs_Delegate(global::Windows.UI.Xaml.Controls.Maps.MapRightTappedEventArgs e);

        public StubIMapRightTappedEventArgsResolver Position(Position_MapRightTappedEventArgs_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }
    }
}

namespace Fievus.Windows.Mvc.Wrappers
{
    [CompilerGenerated]
    public class StubIMapTargetCameraChangedEventArgsResolver : IMapTargetCameraChangedEventArgsResolver
    {
        private readonly StubContainer<StubIMapTargetCameraChangedEventArgsResolver> _stubs = new StubContainer<StubIMapTargetCameraChangedEventArgsResolver>();

        global::Windows.UI.Xaml.Controls.Maps.MapCamera global::Fievus.Windows.Mvc.Wrappers.IMapTargetCameraChangedEventArgsResolver.Camera(global::Windows.UI.Xaml.Controls.Maps.MapTargetCameraChangedEventArgs e)
        {
            return _stubs.GetMethodStub<Camera_MapTargetCameraChangedEventArgs_Delegate>("Camera").Invoke(e);
        }

        public delegate global::Windows.UI.Xaml.Controls.Maps.MapCamera Camera_MapTargetCameraChangedEventArgs_Delegate(global::Windows.UI.Xaml.Controls.Maps.MapTargetCameraChangedEventArgs e);

        public StubIMapTargetCameraChangedEventArgsResolver Camera(Camera_MapTargetCameraChangedEventArgs_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        global::Windows.UI.Xaml.Controls.Maps.MapCameraChangeReason global::Fievus.Windows.Mvc.Wrappers.IMapTargetCameraChangedEventArgsResolver.ChangeReason(global::Windows.UI.Xaml.Controls.Maps.MapTargetCameraChangedEventArgs e)
        {
            return _stubs.GetMethodStub<ChangeReason_MapTargetCameraChangedEventArgs_Delegate>("ChangeReason").Invoke(e);
        }

        public delegate global::Windows.UI.Xaml.Controls.Maps.MapCameraChangeReason ChangeReason_MapTargetCameraChangedEventArgs_Delegate(global::Windows.UI.Xaml.Controls.Maps.MapTargetCameraChangedEventArgs e);

        public StubIMapTargetCameraChangedEventArgsResolver ChangeReason(ChangeReason_MapTargetCameraChangedEventArgs_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }
    }
}

namespace Fievus.Windows.Mvc.Wrappers
{
    [CompilerGenerated]
    public class StubIMediaTransportControlsThumbnailRequestedEventArgsResolver : IMediaTransportControlsThumbnailRequestedEventArgsResolver
    {
        private readonly StubContainer<StubIMediaTransportControlsThumbnailRequestedEventArgsResolver> _stubs = new StubContainer<StubIMediaTransportControlsThumbnailRequestedEventArgsResolver>();

        global::Windows.Foundation.Deferral global::Fievus.Windows.Mvc.Wrappers.IMediaTransportControlsThumbnailRequestedEventArgsResolver.GetDeferral(global::Windows.UI.Xaml.Media.MediaTransportControlsThumbnailRequestedEventArgs e)
        {
            return _stubs.GetMethodStub<GetDeferral_MediaTransportControlsThumbnailRequestedEventArgs_Delegate>("GetDeferral").Invoke(e);
        }

        public delegate global::Windows.Foundation.Deferral GetDeferral_MediaTransportControlsThumbnailRequestedEventArgs_Delegate(global::Windows.UI.Xaml.Media.MediaTransportControlsThumbnailRequestedEventArgs e);

        public StubIMediaTransportControlsThumbnailRequestedEventArgsResolver GetDeferral(GetDeferral_MediaTransportControlsThumbnailRequestedEventArgs_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        void global::Fievus.Windows.Mvc.Wrappers.IMediaTransportControlsThumbnailRequestedEventArgsResolver.SetThumbnailImage(global::Windows.UI.Xaml.Media.MediaTransportControlsThumbnailRequestedEventArgs e, global::Windows.Storage.Streams.IInputStream source)
        {
            _stubs.GetMethodStub<SetThumbnailImage_MediaTransportControlsThumbnailRequestedEventArgs_IInputStream_Delegate>("SetThumbnailImage").Invoke(e, source);
        }

        public delegate void SetThumbnailImage_MediaTransportControlsThumbnailRequestedEventArgs_IInputStream_Delegate(global::Windows.UI.Xaml.Media.MediaTransportControlsThumbnailRequestedEventArgs e, global::Windows.Storage.Streams.IInputStream source);

        public StubIMediaTransportControlsThumbnailRequestedEventArgsResolver SetThumbnailImage(SetThumbnailImage_MediaTransportControlsThumbnailRequestedEventArgs_IInputStream_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }
    }
}

namespace Fievus.Windows.Mvc.Wrappers
{
    [CompilerGenerated]
    public class StubINavigatingCancelEventArgsResolver : INavigatingCancelEventArgsResolver
    {
        private readonly StubContainer<StubINavigatingCancelEventArgsResolver> _stubs = new StubContainer<StubINavigatingCancelEventArgsResolver>();

        bool global::Fievus.Windows.Mvc.Wrappers.INavigatingCancelEventArgsResolver.Cancel(global::Windows.UI.Xaml.Navigation.NavigatingCancelEventArgs e)
        {
            return _stubs.GetMethodStub<Cancel_NavigatingCancelEventArgs_Delegate>("Cancel").Invoke(e);
        }

        public delegate bool Cancel_NavigatingCancelEventArgs_Delegate(global::Windows.UI.Xaml.Navigation.NavigatingCancelEventArgs e);

        public StubINavigatingCancelEventArgsResolver Cancel(Cancel_NavigatingCancelEventArgs_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        void global::Fievus.Windows.Mvc.Wrappers.INavigatingCancelEventArgsResolver.Cancel(global::Windows.UI.Xaml.Navigation.NavigatingCancelEventArgs e, bool cancel)
        {
            _stubs.GetMethodStub<Cancel_NavigatingCancelEventArgs_Boolean_Delegate>("Cancel").Invoke(e, cancel);
        }

        public delegate void Cancel_NavigatingCancelEventArgs_Boolean_Delegate(global::Windows.UI.Xaml.Navigation.NavigatingCancelEventArgs e, bool cancel);

        public StubINavigatingCancelEventArgsResolver Cancel(Cancel_NavigatingCancelEventArgs_Boolean_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        global::Windows.UI.Xaml.Navigation.NavigationMode global::Fievus.Windows.Mvc.Wrappers.INavigatingCancelEventArgsResolver.NavigationMode(global::Windows.UI.Xaml.Navigation.NavigatingCancelEventArgs e)
        {
            return _stubs.GetMethodStub<NavigationMode_NavigatingCancelEventArgs_Delegate>("NavigationMode").Invoke(e);
        }

        public delegate global::Windows.UI.Xaml.Navigation.NavigationMode NavigationMode_NavigatingCancelEventArgs_Delegate(global::Windows.UI.Xaml.Navigation.NavigatingCancelEventArgs e);

        public StubINavigatingCancelEventArgsResolver NavigationMode(NavigationMode_NavigatingCancelEventArgs_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        global::Windows.UI.Xaml.Media.Animation.NavigationTransitionInfo global::Fievus.Windows.Mvc.Wrappers.INavigatingCancelEventArgsResolver.NavigationTransitionInfo(global::Windows.UI.Xaml.Navigation.NavigatingCancelEventArgs e)
        {
            return _stubs.GetMethodStub<NavigationTransitionInfo_NavigatingCancelEventArgs_Delegate>("NavigationTransitionInfo").Invoke(e);
        }

        public delegate global::Windows.UI.Xaml.Media.Animation.NavigationTransitionInfo NavigationTransitionInfo_NavigatingCancelEventArgs_Delegate(global::Windows.UI.Xaml.Navigation.NavigatingCancelEventArgs e);

        public StubINavigatingCancelEventArgsResolver NavigationTransitionInfo(NavigationTransitionInfo_NavigatingCancelEventArgs_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        object global::Fievus.Windows.Mvc.Wrappers.INavigatingCancelEventArgsResolver.Parameter(global::Windows.UI.Xaml.Navigation.NavigatingCancelEventArgs e)
        {
            return _stubs.GetMethodStub<Parameter_NavigatingCancelEventArgs_Delegate>("Parameter").Invoke(e);
        }

        public delegate object Parameter_NavigatingCancelEventArgs_Delegate(global::Windows.UI.Xaml.Navigation.NavigatingCancelEventArgs e);

        public StubINavigatingCancelEventArgsResolver Parameter(Parameter_NavigatingCancelEventArgs_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        global::System.Type global::Fievus.Windows.Mvc.Wrappers.INavigatingCancelEventArgsResolver.SourcePageType(global::Windows.UI.Xaml.Navigation.NavigatingCancelEventArgs e)
        {
            return _stubs.GetMethodStub<SourcePageType_NavigatingCancelEventArgs_Delegate>("SourcePageType").Invoke(e);
        }

        public delegate global::System.Type SourcePageType_NavigatingCancelEventArgs_Delegate(global::Windows.UI.Xaml.Navigation.NavigatingCancelEventArgs e);

        public StubINavigatingCancelEventArgsResolver SourcePageType(SourcePageType_NavigatingCancelEventArgs_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }
    }
}

namespace Fievus.Windows.Mvc.Wrappers
{
    [CompilerGenerated]
    public class StubINavigationEventArgsResolver : INavigationEventArgsResolver
    {
        private readonly StubContainer<StubINavigationEventArgsResolver> _stubs = new StubContainer<StubINavigationEventArgsResolver>();

        object global::Fievus.Windows.Mvc.Wrappers.INavigationEventArgsResolver.Content(global::Windows.UI.Xaml.Navigation.NavigationEventArgs e)
        {
            return _stubs.GetMethodStub<Content_NavigationEventArgs_Delegate>("Content").Invoke(e);
        }

        public delegate object Content_NavigationEventArgs_Delegate(global::Windows.UI.Xaml.Navigation.NavigationEventArgs e);

        public StubINavigationEventArgsResolver Content(Content_NavigationEventArgs_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        global::Windows.UI.Xaml.Navigation.NavigationMode global::Fievus.Windows.Mvc.Wrappers.INavigationEventArgsResolver.NavigationMode(global::Windows.UI.Xaml.Navigation.NavigationEventArgs e)
        {
            return _stubs.GetMethodStub<NavigationMode_NavigationEventArgs_Delegate>("NavigationMode").Invoke(e);
        }

        public delegate global::Windows.UI.Xaml.Navigation.NavigationMode NavigationMode_NavigationEventArgs_Delegate(global::Windows.UI.Xaml.Navigation.NavigationEventArgs e);

        public StubINavigationEventArgsResolver NavigationMode(NavigationMode_NavigationEventArgs_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        global::Windows.UI.Xaml.Media.Animation.NavigationTransitionInfo global::Fievus.Windows.Mvc.Wrappers.INavigationEventArgsResolver.NavigationTransitionInfo(global::Windows.UI.Xaml.Navigation.NavigationEventArgs e)
        {
            return _stubs.GetMethodStub<NavigationTransitionInfo_NavigationEventArgs_Delegate>("NavigationTransitionInfo").Invoke(e);
        }

        public delegate global::Windows.UI.Xaml.Media.Animation.NavigationTransitionInfo NavigationTransitionInfo_NavigationEventArgs_Delegate(global::Windows.UI.Xaml.Navigation.NavigationEventArgs e);

        public StubINavigationEventArgsResolver NavigationTransitionInfo(NavigationTransitionInfo_NavigationEventArgs_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        object global::Fievus.Windows.Mvc.Wrappers.INavigationEventArgsResolver.Parameter(global::Windows.UI.Xaml.Navigation.NavigationEventArgs e)
        {
            return _stubs.GetMethodStub<Parameter_NavigationEventArgs_Delegate>("Parameter").Invoke(e);
        }

        public delegate object Parameter_NavigationEventArgs_Delegate(global::Windows.UI.Xaml.Navigation.NavigationEventArgs e);

        public StubINavigationEventArgsResolver Parameter(Parameter_NavigationEventArgs_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        global::System.Type global::Fievus.Windows.Mvc.Wrappers.INavigationEventArgsResolver.SourcePageType(global::Windows.UI.Xaml.Navigation.NavigationEventArgs e)
        {
            return _stubs.GetMethodStub<SourcePageType_NavigationEventArgs_Delegate>("SourcePageType").Invoke(e);
        }

        public delegate global::System.Type SourcePageType_NavigationEventArgs_Delegate(global::Windows.UI.Xaml.Navigation.NavigationEventArgs e);

        public StubINavigationEventArgsResolver SourcePageType(SourcePageType_NavigationEventArgs_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        global::System.Uri global::Fievus.Windows.Mvc.Wrappers.INavigationEventArgsResolver.Uri(global::Windows.UI.Xaml.Navigation.NavigationEventArgs e)
        {
            return _stubs.GetMethodStub<Uri_NavigationEventArgs_Delegate>("Uri").Invoke(e);
        }

        public delegate global::System.Uri Uri_NavigationEventArgs_Delegate(global::Windows.UI.Xaml.Navigation.NavigationEventArgs e);

        public StubINavigationEventArgsResolver Uri(Uri_NavigationEventArgs_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }
    }
}

namespace Fievus.Windows.Mvc.Wrappers
{
    [CompilerGenerated]
    public class StubINavigationFailedEventArgsResolver : INavigationFailedEventArgsResolver
    {
        private readonly StubContainer<StubINavigationFailedEventArgsResolver> _stubs = new StubContainer<StubINavigationFailedEventArgsResolver>();

        global::System.Exception global::Fievus.Windows.Mvc.Wrappers.INavigationFailedEventArgsResolver.Exception(global::Windows.UI.Xaml.Navigation.NavigationFailedEventArgs e)
        {
            return _stubs.GetMethodStub<Exception_NavigationFailedEventArgs_Delegate>("Exception").Invoke(e);
        }

        public delegate global::System.Exception Exception_NavigationFailedEventArgs_Delegate(global::Windows.UI.Xaml.Navigation.NavigationFailedEventArgs e);

        public StubINavigationFailedEventArgsResolver Exception(Exception_NavigationFailedEventArgs_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        bool global::Fievus.Windows.Mvc.Wrappers.INavigationFailedEventArgsResolver.Handled(global::Windows.UI.Xaml.Navigation.NavigationFailedEventArgs e)
        {
            return _stubs.GetMethodStub<Handled_NavigationFailedEventArgs_Delegate>("Handled").Invoke(e);
        }

        public delegate bool Handled_NavigationFailedEventArgs_Delegate(global::Windows.UI.Xaml.Navigation.NavigationFailedEventArgs e);

        public StubINavigationFailedEventArgsResolver Handled(Handled_NavigationFailedEventArgs_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        void global::Fievus.Windows.Mvc.Wrappers.INavigationFailedEventArgsResolver.Handled(global::Windows.UI.Xaml.Navigation.NavigationFailedEventArgs e, bool handled)
        {
            _stubs.GetMethodStub<Handled_NavigationFailedEventArgs_Boolean_Delegate>("Handled").Invoke(e, handled);
        }

        public delegate void Handled_NavigationFailedEventArgs_Boolean_Delegate(global::Windows.UI.Xaml.Navigation.NavigationFailedEventArgs e, bool handled);

        public StubINavigationFailedEventArgsResolver Handled(Handled_NavigationFailedEventArgs_Boolean_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        global::System.Type global::Fievus.Windows.Mvc.Wrappers.INavigationFailedEventArgsResolver.SourcePageType(global::Windows.UI.Xaml.Navigation.NavigationFailedEventArgs e)
        {
            return _stubs.GetMethodStub<SourcePageType_NavigationFailedEventArgs_Delegate>("SourcePageType").Invoke(e);
        }

        public delegate global::System.Type SourcePageType_NavigationFailedEventArgs_Delegate(global::Windows.UI.Xaml.Navigation.NavigationFailedEventArgs e);

        public StubINavigationFailedEventArgsResolver SourcePageType(SourcePageType_NavigationFailedEventArgs_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }
    }
}

namespace Fievus.Windows.Mvc.Wrappers
{
    [CompilerGenerated]
    public class StubINotifyEventArgsResolver : INotifyEventArgsResolver
    {
        private readonly StubContainer<StubINotifyEventArgsResolver> _stubs = new StubContainer<StubINotifyEventArgsResolver>();

        global::System.Uri global::Fievus.Windows.Mvc.Wrappers.INotifyEventArgsResolver.CallingUri(global::Windows.UI.Xaml.Controls.NotifyEventArgs e)
        {
            return _stubs.GetMethodStub<CallingUri_NotifyEventArgs_Delegate>("CallingUri").Invoke(e);
        }

        public delegate global::System.Uri CallingUri_NotifyEventArgs_Delegate(global::Windows.UI.Xaml.Controls.NotifyEventArgs e);

        public StubINotifyEventArgsResolver CallingUri(CallingUri_NotifyEventArgs_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        string global::Fievus.Windows.Mvc.Wrappers.INotifyEventArgsResolver.Value(global::Windows.UI.Xaml.Controls.NotifyEventArgs e)
        {
            return _stubs.GetMethodStub<Value_NotifyEventArgs_Delegate>("Value").Invoke(e);
        }

        public delegate string Value_NotifyEventArgs_Delegate(global::Windows.UI.Xaml.Controls.NotifyEventArgs e);

        public StubINotifyEventArgsResolver Value(Value_NotifyEventArgs_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }
    }
}

namespace Fievus.Windows.Mvc.Wrappers
{
    [CompilerGenerated]
    public class StubIPartialMediaFailureDetectedEventArgsResolver : IPartialMediaFailureDetectedEventArgsResolver
    {
        private readonly StubContainer<StubIPartialMediaFailureDetectedEventArgsResolver> _stubs = new StubContainer<StubIPartialMediaFailureDetectedEventArgsResolver>();

        global::System.Exception global::Fievus.Windows.Mvc.Wrappers.IPartialMediaFailureDetectedEventArgsResolver.ExtendedError(global::Windows.UI.Xaml.Media.PartialMediaFailureDetectedEventArgs e)
        {
            return _stubs.GetMethodStub<ExtendedError_PartialMediaFailureDetectedEventArgs_Delegate>("ExtendedError").Invoke(e);
        }

        public delegate global::System.Exception ExtendedError_PartialMediaFailureDetectedEventArgs_Delegate(global::Windows.UI.Xaml.Media.PartialMediaFailureDetectedEventArgs e);

        public StubIPartialMediaFailureDetectedEventArgsResolver ExtendedError(ExtendedError_PartialMediaFailureDetectedEventArgs_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        global::Windows.Media.Playback.FailedMediaStreamKind global::Fievus.Windows.Mvc.Wrappers.IPartialMediaFailureDetectedEventArgsResolver.StreamKind(global::Windows.UI.Xaml.Media.PartialMediaFailureDetectedEventArgs e)
        {
            return _stubs.GetMethodStub<StreamKind_PartialMediaFailureDetectedEventArgs_Delegate>("StreamKind").Invoke(e);
        }

        public delegate global::Windows.Media.Playback.FailedMediaStreamKind StreamKind_PartialMediaFailureDetectedEventArgs_Delegate(global::Windows.UI.Xaml.Media.PartialMediaFailureDetectedEventArgs e);

        public StubIPartialMediaFailureDetectedEventArgsResolver StreamKind(StreamKind_PartialMediaFailureDetectedEventArgs_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }
    }
}

namespace Fievus.Windows.Mvc.Wrappers
{
    [CompilerGenerated]
    public class StubIPointerDeviceResolver : IPointerDeviceResolver
    {
        private readonly StubContainer<StubIPointerDeviceResolver> _stubs = new StubContainer<StubIPointerDeviceResolver>();

        bool global::Fievus.Windows.Mvc.Wrappers.IPointerDeviceResolver.IsIntegrated(global::Windows.Devices.Input.PointerDevice pointerDevice)
        {
            return _stubs.GetMethodStub<IsIntegrated_PointerDevice_Delegate>("IsIntegrated").Invoke(pointerDevice);
        }

        public delegate bool IsIntegrated_PointerDevice_Delegate(global::Windows.Devices.Input.PointerDevice pointerDevice);

        public StubIPointerDeviceResolver IsIntegrated(IsIntegrated_PointerDevice_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        uint global::Fievus.Windows.Mvc.Wrappers.IPointerDeviceResolver.MaxContacts(global::Windows.Devices.Input.PointerDevice pointerDevice)
        {
            return _stubs.GetMethodStub<MaxContacts_PointerDevice_Delegate>("MaxContacts").Invoke(pointerDevice);
        }

        public delegate uint MaxContacts_PointerDevice_Delegate(global::Windows.Devices.Input.PointerDevice pointerDevice);

        public StubIPointerDeviceResolver MaxContacts(MaxContacts_PointerDevice_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        global::Windows.Foundation.Rect global::Fievus.Windows.Mvc.Wrappers.IPointerDeviceResolver.PhysicalDeviceRect(global::Windows.Devices.Input.PointerDevice pointerDevice)
        {
            return _stubs.GetMethodStub<PhysicalDeviceRect_PointerDevice_Delegate>("PhysicalDeviceRect").Invoke(pointerDevice);
        }

        public delegate global::Windows.Foundation.Rect PhysicalDeviceRect_PointerDevice_Delegate(global::Windows.Devices.Input.PointerDevice pointerDevice);

        public StubIPointerDeviceResolver PhysicalDeviceRect(PhysicalDeviceRect_PointerDevice_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        global::Windows.Devices.Input.PointerDeviceType global::Fievus.Windows.Mvc.Wrappers.IPointerDeviceResolver.PointerDeviceType(global::Windows.Devices.Input.PointerDevice pointerDevice)
        {
            return _stubs.GetMethodStub<PointerDeviceType_PointerDevice_Delegate>("PointerDeviceType").Invoke(pointerDevice);
        }

        public delegate global::Windows.Devices.Input.PointerDeviceType PointerDeviceType_PointerDevice_Delegate(global::Windows.Devices.Input.PointerDevice pointerDevice);

        public StubIPointerDeviceResolver PointerDeviceType(PointerDeviceType_PointerDevice_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        global::Windows.Foundation.Rect global::Fievus.Windows.Mvc.Wrappers.IPointerDeviceResolver.ScreenRect(global::Windows.Devices.Input.PointerDevice pointerDevice)
        {
            return _stubs.GetMethodStub<ScreenRect_PointerDevice_Delegate>("ScreenRect").Invoke(pointerDevice);
        }

        public delegate global::Windows.Foundation.Rect ScreenRect_PointerDevice_Delegate(global::Windows.Devices.Input.PointerDevice pointerDevice);

        public StubIPointerDeviceResolver ScreenRect(ScreenRect_PointerDevice_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        global::System.Collections.Generic.IReadOnlyList<global::Windows.Devices.Input.PointerDeviceUsage> global::Fievus.Windows.Mvc.Wrappers.IPointerDeviceResolver.SupportedUsages(global::Windows.Devices.Input.PointerDevice pointerDevice)
        {
            return _stubs.GetMethodStub<SupportedUsages_PointerDevice_Delegate>("SupportedUsages").Invoke(pointerDevice);
        }

        public delegate global::System.Collections.Generic.IReadOnlyList<global::Windows.Devices.Input.PointerDeviceUsage> SupportedUsages_PointerDevice_Delegate(global::Windows.Devices.Input.PointerDevice pointerDevice);

        public StubIPointerDeviceResolver SupportedUsages(SupportedUsages_PointerDevice_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }
    }
}

namespace Fievus.Windows.Mvc.Wrappers
{
    [CompilerGenerated]
    public class StubIPointerPointPropertiesResolver : IPointerPointPropertiesResolver
    {
        private readonly StubContainer<StubIPointerPointPropertiesResolver> _stubs = new StubContainer<StubIPointerPointPropertiesResolver>();

        global::Windows.Foundation.Rect global::Fievus.Windows.Mvc.Wrappers.IPointerPointPropertiesResolver.ContactRect(global::Windows.UI.Input.PointerPointProperties properties)
        {
            return _stubs.GetMethodStub<ContactRect_PointerPointProperties_Delegate>("ContactRect").Invoke(properties);
        }

        public delegate global::Windows.Foundation.Rect ContactRect_PointerPointProperties_Delegate(global::Windows.UI.Input.PointerPointProperties properties);

        public StubIPointerPointPropertiesResolver ContactRect(ContactRect_PointerPointProperties_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        global::Windows.Foundation.Rect global::Fievus.Windows.Mvc.Wrappers.IPointerPointPropertiesResolver.ContactRectRaw(global::Windows.UI.Input.PointerPointProperties properties)
        {
            return _stubs.GetMethodStub<ContactRectRaw_PointerPointProperties_Delegate>("ContactRectRaw").Invoke(properties);
        }

        public delegate global::Windows.Foundation.Rect ContactRectRaw_PointerPointProperties_Delegate(global::Windows.UI.Input.PointerPointProperties properties);

        public StubIPointerPointPropertiesResolver ContactRectRaw(ContactRectRaw_PointerPointProperties_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        bool global::Fievus.Windows.Mvc.Wrappers.IPointerPointPropertiesResolver.IsBarrelButtonPressed(global::Windows.UI.Input.PointerPointProperties properties)
        {
            return _stubs.GetMethodStub<IsBarrelButtonPressed_PointerPointProperties_Delegate>("IsBarrelButtonPressed").Invoke(properties);
        }

        public delegate bool IsBarrelButtonPressed_PointerPointProperties_Delegate(global::Windows.UI.Input.PointerPointProperties properties);

        public StubIPointerPointPropertiesResolver IsBarrelButtonPressed(IsBarrelButtonPressed_PointerPointProperties_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        bool global::Fievus.Windows.Mvc.Wrappers.IPointerPointPropertiesResolver.IsCanceled(global::Windows.UI.Input.PointerPointProperties properties)
        {
            return _stubs.GetMethodStub<IsCanceled_PointerPointProperties_Delegate>("IsCanceled").Invoke(properties);
        }

        public delegate bool IsCanceled_PointerPointProperties_Delegate(global::Windows.UI.Input.PointerPointProperties properties);

        public StubIPointerPointPropertiesResolver IsCanceled(IsCanceled_PointerPointProperties_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        bool global::Fievus.Windows.Mvc.Wrappers.IPointerPointPropertiesResolver.IsEraser(global::Windows.UI.Input.PointerPointProperties properties)
        {
            return _stubs.GetMethodStub<IsEraser_PointerPointProperties_Delegate>("IsEraser").Invoke(properties);
        }

        public delegate bool IsEraser_PointerPointProperties_Delegate(global::Windows.UI.Input.PointerPointProperties properties);

        public StubIPointerPointPropertiesResolver IsEraser(IsEraser_PointerPointProperties_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        bool global::Fievus.Windows.Mvc.Wrappers.IPointerPointPropertiesResolver.IsHorizontalMouseWheel(global::Windows.UI.Input.PointerPointProperties properties)
        {
            return _stubs.GetMethodStub<IsHorizontalMouseWheel_PointerPointProperties_Delegate>("IsHorizontalMouseWheel").Invoke(properties);
        }

        public delegate bool IsHorizontalMouseWheel_PointerPointProperties_Delegate(global::Windows.UI.Input.PointerPointProperties properties);

        public StubIPointerPointPropertiesResolver IsHorizontalMouseWheel(IsHorizontalMouseWheel_PointerPointProperties_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        bool global::Fievus.Windows.Mvc.Wrappers.IPointerPointPropertiesResolver.IsInRange(global::Windows.UI.Input.PointerPointProperties properties)
        {
            return _stubs.GetMethodStub<IsInRange_PointerPointProperties_Delegate>("IsInRange").Invoke(properties);
        }

        public delegate bool IsInRange_PointerPointProperties_Delegate(global::Windows.UI.Input.PointerPointProperties properties);

        public StubIPointerPointPropertiesResolver IsInRange(IsInRange_PointerPointProperties_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        bool global::Fievus.Windows.Mvc.Wrappers.IPointerPointPropertiesResolver.IsInverted(global::Windows.UI.Input.PointerPointProperties properties)
        {
            return _stubs.GetMethodStub<IsInverted_PointerPointProperties_Delegate>("IsInverted").Invoke(properties);
        }

        public delegate bool IsInverted_PointerPointProperties_Delegate(global::Windows.UI.Input.PointerPointProperties properties);

        public StubIPointerPointPropertiesResolver IsInverted(IsInverted_PointerPointProperties_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        bool global::Fievus.Windows.Mvc.Wrappers.IPointerPointPropertiesResolver.IsLeftButtonPressed(global::Windows.UI.Input.PointerPointProperties properties)
        {
            return _stubs.GetMethodStub<IsLeftButtonPressed_PointerPointProperties_Delegate>("IsLeftButtonPressed").Invoke(properties);
        }

        public delegate bool IsLeftButtonPressed_PointerPointProperties_Delegate(global::Windows.UI.Input.PointerPointProperties properties);

        public StubIPointerPointPropertiesResolver IsLeftButtonPressed(IsLeftButtonPressed_PointerPointProperties_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        bool global::Fievus.Windows.Mvc.Wrappers.IPointerPointPropertiesResolver.IsMiddleButtonPressed(global::Windows.UI.Input.PointerPointProperties properties)
        {
            return _stubs.GetMethodStub<IsMiddleButtonPressed_PointerPointProperties_Delegate>("IsMiddleButtonPressed").Invoke(properties);
        }

        public delegate bool IsMiddleButtonPressed_PointerPointProperties_Delegate(global::Windows.UI.Input.PointerPointProperties properties);

        public StubIPointerPointPropertiesResolver IsMiddleButtonPressed(IsMiddleButtonPressed_PointerPointProperties_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        bool global::Fievus.Windows.Mvc.Wrappers.IPointerPointPropertiesResolver.IsPrimary(global::Windows.UI.Input.PointerPointProperties properties)
        {
            return _stubs.GetMethodStub<IsPrimary_PointerPointProperties_Delegate>("IsPrimary").Invoke(properties);
        }

        public delegate bool IsPrimary_PointerPointProperties_Delegate(global::Windows.UI.Input.PointerPointProperties properties);

        public StubIPointerPointPropertiesResolver IsPrimary(IsPrimary_PointerPointProperties_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        bool global::Fievus.Windows.Mvc.Wrappers.IPointerPointPropertiesResolver.IsRightButtonPressed(global::Windows.UI.Input.PointerPointProperties properties)
        {
            return _stubs.GetMethodStub<IsRightButtonPressed_PointerPointProperties_Delegate>("IsRightButtonPressed").Invoke(properties);
        }

        public delegate bool IsRightButtonPressed_PointerPointProperties_Delegate(global::Windows.UI.Input.PointerPointProperties properties);

        public StubIPointerPointPropertiesResolver IsRightButtonPressed(IsRightButtonPressed_PointerPointProperties_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        bool global::Fievus.Windows.Mvc.Wrappers.IPointerPointPropertiesResolver.IsXButton1Pressed(global::Windows.UI.Input.PointerPointProperties properties)
        {
            return _stubs.GetMethodStub<IsXButton1Pressed_PointerPointProperties_Delegate>("IsXButton1Pressed").Invoke(properties);
        }

        public delegate bool IsXButton1Pressed_PointerPointProperties_Delegate(global::Windows.UI.Input.PointerPointProperties properties);

        public StubIPointerPointPropertiesResolver IsXButton1Pressed(IsXButton1Pressed_PointerPointProperties_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        bool global::Fievus.Windows.Mvc.Wrappers.IPointerPointPropertiesResolver.IsXButton2Pressed(global::Windows.UI.Input.PointerPointProperties properties)
        {
            return _stubs.GetMethodStub<IsXButton2Pressed_PointerPointProperties_Delegate>("IsXButton2Pressed").Invoke(properties);
        }

        public delegate bool IsXButton2Pressed_PointerPointProperties_Delegate(global::Windows.UI.Input.PointerPointProperties properties);

        public StubIPointerPointPropertiesResolver IsXButton2Pressed(IsXButton2Pressed_PointerPointProperties_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        int global::Fievus.Windows.Mvc.Wrappers.IPointerPointPropertiesResolver.MouseWheelDelta(global::Windows.UI.Input.PointerPointProperties properties)
        {
            return _stubs.GetMethodStub<MouseWheelDelta_PointerPointProperties_Delegate>("MouseWheelDelta").Invoke(properties);
        }

        public delegate int MouseWheelDelta_PointerPointProperties_Delegate(global::Windows.UI.Input.PointerPointProperties properties);

        public StubIPointerPointPropertiesResolver MouseWheelDelta(MouseWheelDelta_PointerPointProperties_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        float global::Fievus.Windows.Mvc.Wrappers.IPointerPointPropertiesResolver.Orientation(global::Windows.UI.Input.PointerPointProperties properties)
        {
            return _stubs.GetMethodStub<Orientation_PointerPointProperties_Delegate>("Orientation").Invoke(properties);
        }

        public delegate float Orientation_PointerPointProperties_Delegate(global::Windows.UI.Input.PointerPointProperties properties);

        public StubIPointerPointPropertiesResolver Orientation(Orientation_PointerPointProperties_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        global::Windows.UI.Input.PointerUpdateKind global::Fievus.Windows.Mvc.Wrappers.IPointerPointPropertiesResolver.PointerUpdateKind(global::Windows.UI.Input.PointerPointProperties properties)
        {
            return _stubs.GetMethodStub<PointerUpdateKind_PointerPointProperties_Delegate>("PointerUpdateKind").Invoke(properties);
        }

        public delegate global::Windows.UI.Input.PointerUpdateKind PointerUpdateKind_PointerPointProperties_Delegate(global::Windows.UI.Input.PointerPointProperties properties);

        public StubIPointerPointPropertiesResolver PointerUpdateKind(PointerUpdateKind_PointerPointProperties_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        float global::Fievus.Windows.Mvc.Wrappers.IPointerPointPropertiesResolver.Pressure(global::Windows.UI.Input.PointerPointProperties properties)
        {
            return _stubs.GetMethodStub<Pressure_PointerPointProperties_Delegate>("Pressure").Invoke(properties);
        }

        public delegate float Pressure_PointerPointProperties_Delegate(global::Windows.UI.Input.PointerPointProperties properties);

        public StubIPointerPointPropertiesResolver Pressure(Pressure_PointerPointProperties_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        bool global::Fievus.Windows.Mvc.Wrappers.IPointerPointPropertiesResolver.TouchConfidence(global::Windows.UI.Input.PointerPointProperties properties)
        {
            return _stubs.GetMethodStub<TouchConfidence_PointerPointProperties_Delegate>("TouchConfidence").Invoke(properties);
        }

        public delegate bool TouchConfidence_PointerPointProperties_Delegate(global::Windows.UI.Input.PointerPointProperties properties);

        public StubIPointerPointPropertiesResolver TouchConfidence(TouchConfidence_PointerPointProperties_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        float global::Fievus.Windows.Mvc.Wrappers.IPointerPointPropertiesResolver.Twist(global::Windows.UI.Input.PointerPointProperties properties)
        {
            return _stubs.GetMethodStub<Twist_PointerPointProperties_Delegate>("Twist").Invoke(properties);
        }

        public delegate float Twist_PointerPointProperties_Delegate(global::Windows.UI.Input.PointerPointProperties properties);

        public StubIPointerPointPropertiesResolver Twist(Twist_PointerPointProperties_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        float global::Fievus.Windows.Mvc.Wrappers.IPointerPointPropertiesResolver.XTilt(global::Windows.UI.Input.PointerPointProperties properties)
        {
            return _stubs.GetMethodStub<XTilt_PointerPointProperties_Delegate>("XTilt").Invoke(properties);
        }

        public delegate float XTilt_PointerPointProperties_Delegate(global::Windows.UI.Input.PointerPointProperties properties);

        public StubIPointerPointPropertiesResolver XTilt(XTilt_PointerPointProperties_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        float global::Fievus.Windows.Mvc.Wrappers.IPointerPointPropertiesResolver.YTilt(global::Windows.UI.Input.PointerPointProperties properties)
        {
            return _stubs.GetMethodStub<YTilt_PointerPointProperties_Delegate>("YTilt").Invoke(properties);
        }

        public delegate float YTilt_PointerPointProperties_Delegate(global::Windows.UI.Input.PointerPointProperties properties);

        public StubIPointerPointPropertiesResolver YTilt(YTilt_PointerPointProperties_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        float? global::Fievus.Windows.Mvc.Wrappers.IPointerPointPropertiesResolver.ZDistance(global::Windows.UI.Input.PointerPointProperties properties)
        {
            return _stubs.GetMethodStub<ZDistance_PointerPointProperties_Delegate>("ZDistance").Invoke(properties);
        }

        public delegate float? ZDistance_PointerPointProperties_Delegate(global::Windows.UI.Input.PointerPointProperties properties);

        public StubIPointerPointPropertiesResolver ZDistance(ZDistance_PointerPointProperties_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        int global::Fievus.Windows.Mvc.Wrappers.IPointerPointPropertiesResolver.GetUsageValue(global::Windows.UI.Input.PointerPointProperties properties, uint usagePage, uint usageId)
        {
            return _stubs.GetMethodStub<GetUsageValue_PointerPointProperties_UInt32_UInt32_Delegate>("GetUsageValue").Invoke(properties, usagePage, usageId);
        }

        public delegate int GetUsageValue_PointerPointProperties_UInt32_UInt32_Delegate(global::Windows.UI.Input.PointerPointProperties properties, uint usagePage, uint usageId);

        public StubIPointerPointPropertiesResolver GetUsageValue(GetUsageValue_PointerPointProperties_UInt32_UInt32_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        bool global::Fievus.Windows.Mvc.Wrappers.IPointerPointPropertiesResolver.HasUsage(global::Windows.UI.Input.PointerPointProperties properties, uint usagePage, uint usageId)
        {
            return _stubs.GetMethodStub<HasUsage_PointerPointProperties_UInt32_UInt32_Delegate>("HasUsage").Invoke(properties, usagePage, usageId);
        }

        public delegate bool HasUsage_PointerPointProperties_UInt32_UInt32_Delegate(global::Windows.UI.Input.PointerPointProperties properties, uint usagePage, uint usageId);

        public StubIPointerPointPropertiesResolver HasUsage(HasUsage_PointerPointProperties_UInt32_UInt32_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }
    }
}

namespace Fievus.Windows.Mvc.Wrappers
{
    [CompilerGenerated]
    public class StubIPointerPointResolver : IPointerPointResolver
    {
        private readonly StubContainer<StubIPointerPointResolver> _stubs = new StubContainer<StubIPointerPointResolver>();

        uint global::Fievus.Windows.Mvc.Wrappers.IPointerPointResolver.FrameId(global::Windows.UI.Input.PointerPoint pointerPoint)
        {
            return _stubs.GetMethodStub<FrameId_PointerPoint_Delegate>("FrameId").Invoke(pointerPoint);
        }

        public delegate uint FrameId_PointerPoint_Delegate(global::Windows.UI.Input.PointerPoint pointerPoint);

        public StubIPointerPointResolver FrameId(FrameId_PointerPoint_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        bool global::Fievus.Windows.Mvc.Wrappers.IPointerPointResolver.IsInContact(global::Windows.UI.Input.PointerPoint pointerPoint)
        {
            return _stubs.GetMethodStub<IsInContact_PointerPoint_Delegate>("IsInContact").Invoke(pointerPoint);
        }

        public delegate bool IsInContact_PointerPoint_Delegate(global::Windows.UI.Input.PointerPoint pointerPoint);

        public StubIPointerPointResolver IsInContact(IsInContact_PointerPoint_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        global::Windows.Devices.Input.PointerDevice global::Fievus.Windows.Mvc.Wrappers.IPointerPointResolver.PointerDevice(global::Windows.UI.Input.PointerPoint pointerPoint)
        {
            return _stubs.GetMethodStub<PointerDevice_PointerPoint_Delegate>("PointerDevice").Invoke(pointerPoint);
        }

        public delegate global::Windows.Devices.Input.PointerDevice PointerDevice_PointerPoint_Delegate(global::Windows.UI.Input.PointerPoint pointerPoint);

        public StubIPointerPointResolver PointerDevice(PointerDevice_PointerPoint_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        uint global::Fievus.Windows.Mvc.Wrappers.IPointerPointResolver.PointerId(global::Windows.UI.Input.PointerPoint pointerPoint)
        {
            return _stubs.GetMethodStub<PointerId_PointerPoint_Delegate>("PointerId").Invoke(pointerPoint);
        }

        public delegate uint PointerId_PointerPoint_Delegate(global::Windows.UI.Input.PointerPoint pointerPoint);

        public StubIPointerPointResolver PointerId(PointerId_PointerPoint_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        global::Windows.Foundation.Point global::Fievus.Windows.Mvc.Wrappers.IPointerPointResolver.Position(global::Windows.UI.Input.PointerPoint pointerPoint)
        {
            return _stubs.GetMethodStub<Position_PointerPoint_Delegate>("Position").Invoke(pointerPoint);
        }

        public delegate global::Windows.Foundation.Point Position_PointerPoint_Delegate(global::Windows.UI.Input.PointerPoint pointerPoint);

        public StubIPointerPointResolver Position(Position_PointerPoint_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        global::Windows.UI.Input.PointerPointProperties global::Fievus.Windows.Mvc.Wrappers.IPointerPointResolver.Properties(global::Windows.UI.Input.PointerPoint poitnerPoint)
        {
            return _stubs.GetMethodStub<Properties_PointerPoint_Delegate>("Properties").Invoke(poitnerPoint);
        }

        public delegate global::Windows.UI.Input.PointerPointProperties Properties_PointerPoint_Delegate(global::Windows.UI.Input.PointerPoint poitnerPoint);

        public StubIPointerPointResolver Properties(Properties_PointerPoint_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        global::Windows.Foundation.Point global::Fievus.Windows.Mvc.Wrappers.IPointerPointResolver.RawPosition(global::Windows.UI.Input.PointerPoint pointerPoint)
        {
            return _stubs.GetMethodStub<RawPosition_PointerPoint_Delegate>("RawPosition").Invoke(pointerPoint);
        }

        public delegate global::Windows.Foundation.Point RawPosition_PointerPoint_Delegate(global::Windows.UI.Input.PointerPoint pointerPoint);

        public StubIPointerPointResolver RawPosition(RawPosition_PointerPoint_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        ulong global::Fievus.Windows.Mvc.Wrappers.IPointerPointResolver.Timestamp(global::Windows.UI.Input.PointerPoint pointerPoint)
        {
            return _stubs.GetMethodStub<Timestamp_PointerPoint_Delegate>("Timestamp").Invoke(pointerPoint);
        }

        public delegate ulong Timestamp_PointerPoint_Delegate(global::Windows.UI.Input.PointerPoint pointerPoint);

        public StubIPointerPointResolver Timestamp(Timestamp_PointerPoint_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }
    }
}

namespace Fievus.Windows.Mvc.Wrappers
{
    [CompilerGenerated]
    public class StubIPointerRoutedEventArgsResolver : IPointerRoutedEventArgsResolver
    {
        private readonly StubContainer<StubIPointerRoutedEventArgsResolver> _stubs = new StubContainer<StubIPointerRoutedEventArgsResolver>();

        bool global::Fievus.Windows.Mvc.Wrappers.IPointerRoutedEventArgsResolver.Handled(global::Windows.UI.Xaml.Input.PointerRoutedEventArgs e)
        {
            return _stubs.GetMethodStub<Handled_PointerRoutedEventArgs_Delegate>("Handled").Invoke(e);
        }

        public delegate bool Handled_PointerRoutedEventArgs_Delegate(global::Windows.UI.Xaml.Input.PointerRoutedEventArgs e);

        public StubIPointerRoutedEventArgsResolver Handled(Handled_PointerRoutedEventArgs_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        void global::Fievus.Windows.Mvc.Wrappers.IPointerRoutedEventArgsResolver.Handled(global::Windows.UI.Xaml.Input.PointerRoutedEventArgs e, bool handled)
        {
            _stubs.GetMethodStub<Handled_PointerRoutedEventArgs_Boolean_Delegate>("Handled").Invoke(e, handled);
        }

        public delegate void Handled_PointerRoutedEventArgs_Boolean_Delegate(global::Windows.UI.Xaml.Input.PointerRoutedEventArgs e, bool handled);

        public StubIPointerRoutedEventArgsResolver Handled(Handled_PointerRoutedEventArgs_Boolean_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        global::Windows.System.VirtualKeyModifiers global::Fievus.Windows.Mvc.Wrappers.IPointerRoutedEventArgsResolver.KeyModifiers(global::Windows.UI.Xaml.Input.PointerRoutedEventArgs e)
        {
            return _stubs.GetMethodStub<KeyModifiers_PointerRoutedEventArgs_Delegate>("KeyModifiers").Invoke(e);
        }

        public delegate global::Windows.System.VirtualKeyModifiers KeyModifiers_PointerRoutedEventArgs_Delegate(global::Windows.UI.Xaml.Input.PointerRoutedEventArgs e);

        public StubIPointerRoutedEventArgsResolver KeyModifiers(KeyModifiers_PointerRoutedEventArgs_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        object global::Fievus.Windows.Mvc.Wrappers.IPointerRoutedEventArgsResolver.OriginalSource(global::Windows.UI.Xaml.Input.PointerRoutedEventArgs e)
        {
            return _stubs.GetMethodStub<OriginalSource_PointerRoutedEventArgs_Delegate>("OriginalSource").Invoke(e);
        }

        public delegate object OriginalSource_PointerRoutedEventArgs_Delegate(global::Windows.UI.Xaml.Input.PointerRoutedEventArgs e);

        public StubIPointerRoutedEventArgsResolver OriginalSource(OriginalSource_PointerRoutedEventArgs_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        global::Windows.UI.Xaml.Input.Pointer global::Fievus.Windows.Mvc.Wrappers.IPointerRoutedEventArgsResolver.Pointer(global::Windows.UI.Xaml.Input.PointerRoutedEventArgs e)
        {
            return _stubs.GetMethodStub<Pointer_PointerRoutedEventArgs_Delegate>("Pointer").Invoke(e);
        }

        public delegate global::Windows.UI.Xaml.Input.Pointer Pointer_PointerRoutedEventArgs_Delegate(global::Windows.UI.Xaml.Input.PointerRoutedEventArgs e);

        public StubIPointerRoutedEventArgsResolver Pointer(Pointer_PointerRoutedEventArgs_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        global::Windows.UI.Input.PointerPoint global::Fievus.Windows.Mvc.Wrappers.IPointerRoutedEventArgsResolver.GetCurrentPoint(global::Windows.UI.Xaml.Input.PointerRoutedEventArgs e, global::Windows.UI.Xaml.UIElement relativeTo)
        {
            return _stubs.GetMethodStub<GetCurrentPoint_PointerRoutedEventArgs_UIElement_Delegate>("GetCurrentPoint").Invoke(e, relativeTo);
        }

        public delegate global::Windows.UI.Input.PointerPoint GetCurrentPoint_PointerRoutedEventArgs_UIElement_Delegate(global::Windows.UI.Xaml.Input.PointerRoutedEventArgs e, global::Windows.UI.Xaml.UIElement relativeTo);

        public StubIPointerRoutedEventArgsResolver GetCurrentPoint(GetCurrentPoint_PointerRoutedEventArgs_UIElement_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        global::System.Collections.Generic.IList<global::Windows.UI.Input.PointerPoint> global::Fievus.Windows.Mvc.Wrappers.IPointerRoutedEventArgsResolver.GetIntermediatePoints(global::Windows.UI.Xaml.Input.PointerRoutedEventArgs e, global::Windows.UI.Xaml.UIElement relativeTo)
        {
            return _stubs.GetMethodStub<GetIntermediatePoints_PointerRoutedEventArgs_UIElement_Delegate>("GetIntermediatePoints").Invoke(e, relativeTo);
        }

        public delegate global::System.Collections.Generic.IList<global::Windows.UI.Input.PointerPoint> GetIntermediatePoints_PointerRoutedEventArgs_UIElement_Delegate(global::Windows.UI.Xaml.Input.PointerRoutedEventArgs e, global::Windows.UI.Xaml.UIElement relativeTo);

        public StubIPointerRoutedEventArgsResolver GetIntermediatePoints(GetIntermediatePoints_PointerRoutedEventArgs_UIElement_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }
    }
}

namespace Fievus.Windows.Mvc.Wrappers
{
    [CompilerGenerated]
    public class StubIPointerResolver : IPointerResolver
    {
        private readonly StubContainer<StubIPointerResolver> _stubs = new StubContainer<StubIPointerResolver>();

        bool global::Fievus.Windows.Mvc.Wrappers.IPointerResolver.IsInContact(global::Windows.UI.Xaml.Input.Pointer pointer)
        {
            return _stubs.GetMethodStub<IsInContact_Pointer_Delegate>("IsInContact").Invoke(pointer);
        }

        public delegate bool IsInContact_Pointer_Delegate(global::Windows.UI.Xaml.Input.Pointer pointer);

        public StubIPointerResolver IsInContact(IsInContact_Pointer_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        bool global::Fievus.Windows.Mvc.Wrappers.IPointerResolver.IsInRange(global::Windows.UI.Xaml.Input.Pointer pointer)
        {
            return _stubs.GetMethodStub<IsInRange_Pointer_Delegate>("IsInRange").Invoke(pointer);
        }

        public delegate bool IsInRange_Pointer_Delegate(global::Windows.UI.Xaml.Input.Pointer pointer);

        public StubIPointerResolver IsInRange(IsInRange_Pointer_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        global::Windows.Devices.Input.PointerDeviceType global::Fievus.Windows.Mvc.Wrappers.IPointerResolver.PointerDeviceType(global::Windows.UI.Xaml.Input.Pointer pointer)
        {
            return _stubs.GetMethodStub<PointerDeviceType_Pointer_Delegate>("PointerDeviceType").Invoke(pointer);
        }

        public delegate global::Windows.Devices.Input.PointerDeviceType PointerDeviceType_Pointer_Delegate(global::Windows.UI.Xaml.Input.Pointer pointer);

        public StubIPointerResolver PointerDeviceType(PointerDeviceType_Pointer_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        uint global::Fievus.Windows.Mvc.Wrappers.IPointerResolver.PointerId(global::Windows.UI.Xaml.Input.Pointer pointer)
        {
            return _stubs.GetMethodStub<PointerId_Pointer_Delegate>("PointerId").Invoke(pointer);
        }

        public delegate uint PointerId_Pointer_Delegate(global::Windows.UI.Xaml.Input.Pointer pointer);

        public StubIPointerResolver PointerId(PointerId_Pointer_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }
    }
}

namespace Fievus.Windows.Mvc.Wrappers
{
    [CompilerGenerated]
    public class StubIRangeBaseValueChangedEventArgsResolver : IRangeBaseValueChangedEventArgsResolver
    {
        private readonly StubContainer<StubIRangeBaseValueChangedEventArgsResolver> _stubs = new StubContainer<StubIRangeBaseValueChangedEventArgsResolver>();

        double global::Fievus.Windows.Mvc.Wrappers.IRangeBaseValueChangedEventArgsResolver.NewValue(global::Windows.UI.Xaml.Controls.Primitives.RangeBaseValueChangedEventArgs e)
        {
            return _stubs.GetMethodStub<NewValue_RangeBaseValueChangedEventArgs_Delegate>("NewValue").Invoke(e);
        }

        public delegate double NewValue_RangeBaseValueChangedEventArgs_Delegate(global::Windows.UI.Xaml.Controls.Primitives.RangeBaseValueChangedEventArgs e);

        public StubIRangeBaseValueChangedEventArgsResolver NewValue(NewValue_RangeBaseValueChangedEventArgs_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        double global::Fievus.Windows.Mvc.Wrappers.IRangeBaseValueChangedEventArgsResolver.OldValue(global::Windows.UI.Xaml.Controls.Primitives.RangeBaseValueChangedEventArgs e)
        {
            return _stubs.GetMethodStub<OldValue_RangeBaseValueChangedEventArgs_Delegate>("OldValue").Invoke(e);
        }

        public delegate double OldValue_RangeBaseValueChangedEventArgs_Delegate(global::Windows.UI.Xaml.Controls.Primitives.RangeBaseValueChangedEventArgs e);

        public StubIRangeBaseValueChangedEventArgsResolver OldValue(OldValue_RangeBaseValueChangedEventArgs_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        object global::Fievus.Windows.Mvc.Wrappers.IRangeBaseValueChangedEventArgsResolver.OriginalSource(global::Windows.UI.Xaml.Controls.Primitives.RangeBaseValueChangedEventArgs e)
        {
            return _stubs.GetMethodStub<OriginalSource_RangeBaseValueChangedEventArgs_Delegate>("OriginalSource").Invoke(e);
        }

        public delegate object OriginalSource_RangeBaseValueChangedEventArgs_Delegate(global::Windows.UI.Xaml.Controls.Primitives.RangeBaseValueChangedEventArgs e);

        public StubIRangeBaseValueChangedEventArgsResolver OriginalSource(OriginalSource_RangeBaseValueChangedEventArgs_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }
    }
}

namespace Fievus.Windows.Mvc.Wrappers
{
    [CompilerGenerated]
    public class StubIRightTappedRoutedEventArgsResolver : IRightTappedRoutedEventArgsResolver
    {
        private readonly StubContainer<StubIRightTappedRoutedEventArgsResolver> _stubs = new StubContainer<StubIRightTappedRoutedEventArgsResolver>();

        bool global::Fievus.Windows.Mvc.Wrappers.IRightTappedRoutedEventArgsResolver.Handled(global::Windows.UI.Xaml.Input.RightTappedRoutedEventArgs e)
        {
            return _stubs.GetMethodStub<Handled_RightTappedRoutedEventArgs_Delegate>("Handled").Invoke(e);
        }

        public delegate bool Handled_RightTappedRoutedEventArgs_Delegate(global::Windows.UI.Xaml.Input.RightTappedRoutedEventArgs e);

        public StubIRightTappedRoutedEventArgsResolver Handled(Handled_RightTappedRoutedEventArgs_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        void global::Fievus.Windows.Mvc.Wrappers.IRightTappedRoutedEventArgsResolver.Handled(global::Windows.UI.Xaml.Input.RightTappedRoutedEventArgs e, bool handled)
        {
            _stubs.GetMethodStub<Handled_RightTappedRoutedEventArgs_Boolean_Delegate>("Handled").Invoke(e, handled);
        }

        public delegate void Handled_RightTappedRoutedEventArgs_Boolean_Delegate(global::Windows.UI.Xaml.Input.RightTappedRoutedEventArgs e, bool handled);

        public StubIRightTappedRoutedEventArgsResolver Handled(Handled_RightTappedRoutedEventArgs_Boolean_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        object global::Fievus.Windows.Mvc.Wrappers.IRightTappedRoutedEventArgsResolver.OriginalSource(global::Windows.UI.Xaml.Input.RightTappedRoutedEventArgs e)
        {
            return _stubs.GetMethodStub<OriginalSource_RightTappedRoutedEventArgs_Delegate>("OriginalSource").Invoke(e);
        }

        public delegate object OriginalSource_RightTappedRoutedEventArgs_Delegate(global::Windows.UI.Xaml.Input.RightTappedRoutedEventArgs e);

        public StubIRightTappedRoutedEventArgsResolver OriginalSource(OriginalSource_RightTappedRoutedEventArgs_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        global::Windows.Devices.Input.PointerDeviceType global::Fievus.Windows.Mvc.Wrappers.IRightTappedRoutedEventArgsResolver.PointerDeviceType(global::Windows.UI.Xaml.Input.RightTappedRoutedEventArgs e)
        {
            return _stubs.GetMethodStub<PointerDeviceType_RightTappedRoutedEventArgs_Delegate>("PointerDeviceType").Invoke(e);
        }

        public delegate global::Windows.Devices.Input.PointerDeviceType PointerDeviceType_RightTappedRoutedEventArgs_Delegate(global::Windows.UI.Xaml.Input.RightTappedRoutedEventArgs e);

        public StubIRightTappedRoutedEventArgsResolver PointerDeviceType(PointerDeviceType_RightTappedRoutedEventArgs_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        global::Windows.Foundation.Point global::Fievus.Windows.Mvc.Wrappers.IRightTappedRoutedEventArgsResolver.GetPosition(global::Windows.UI.Xaml.Input.RightTappedRoutedEventArgs e, global::Windows.UI.Xaml.UIElement relativeTo)
        {
            return _stubs.GetMethodStub<GetPosition_RightTappedRoutedEventArgs_UIElement_Delegate>("GetPosition").Invoke(e, relativeTo);
        }

        public delegate global::Windows.Foundation.Point GetPosition_RightTappedRoutedEventArgs_UIElement_Delegate(global::Windows.UI.Xaml.Input.RightTappedRoutedEventArgs e, global::Windows.UI.Xaml.UIElement relativeTo);

        public StubIRightTappedRoutedEventArgsResolver GetPosition(GetPosition_RightTappedRoutedEventArgs_UIElement_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }
    }
}

namespace Fievus.Windows.Mvc.Wrappers
{
    [CompilerGenerated]
    public class StubIRoutedEventArgsResolver : IRoutedEventArgsResolver
    {
        private readonly StubContainer<StubIRoutedEventArgsResolver> _stubs = new StubContainer<StubIRoutedEventArgsResolver>();

        object global::Fievus.Windows.Mvc.Wrappers.IRoutedEventArgsResolver.OriginalSource(global::Windows.UI.Xaml.RoutedEventArgs e)
        {
            return _stubs.GetMethodStub<OriginalSource_RoutedEventArgs_Delegate>("OriginalSource").Invoke(e);
        }

        public delegate object OriginalSource_RoutedEventArgs_Delegate(global::Windows.UI.Xaml.RoutedEventArgs e);

        public StubIRoutedEventArgsResolver OriginalSource(OriginalSource_RoutedEventArgs_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }
    }
}

namespace Fievus.Windows.Mvc.Wrappers
{
    [CompilerGenerated]
    public class StubIScrollEventArgsResolver : IScrollEventArgsResolver
    {
        private readonly StubContainer<StubIScrollEventArgsResolver> _stubs = new StubContainer<StubIScrollEventArgsResolver>();

        double global::Fievus.Windows.Mvc.Wrappers.IScrollEventArgsResolver.NewValue(global::Windows.UI.Xaml.Controls.Primitives.ScrollEventArgs e)
        {
            return _stubs.GetMethodStub<NewValue_ScrollEventArgs_Delegate>("NewValue").Invoke(e);
        }

        public delegate double NewValue_ScrollEventArgs_Delegate(global::Windows.UI.Xaml.Controls.Primitives.ScrollEventArgs e);

        public StubIScrollEventArgsResolver NewValue(NewValue_ScrollEventArgs_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        object global::Fievus.Windows.Mvc.Wrappers.IScrollEventArgsResolver.OriginalSource(global::Windows.UI.Xaml.Controls.Primitives.ScrollEventArgs e)
        {
            return _stubs.GetMethodStub<OriginalSource_ScrollEventArgs_Delegate>("OriginalSource").Invoke(e);
        }

        public delegate object OriginalSource_ScrollEventArgs_Delegate(global::Windows.UI.Xaml.Controls.Primitives.ScrollEventArgs e);

        public StubIScrollEventArgsResolver OriginalSource(OriginalSource_ScrollEventArgs_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        global::Windows.UI.Xaml.Controls.Primitives.ScrollEventType global::Fievus.Windows.Mvc.Wrappers.IScrollEventArgsResolver.ScrollEventType(global::Windows.UI.Xaml.Controls.Primitives.ScrollEventArgs e)
        {
            return _stubs.GetMethodStub<ScrollEventType_ScrollEventArgs_Delegate>("ScrollEventType").Invoke(e);
        }

        public delegate global::Windows.UI.Xaml.Controls.Primitives.ScrollEventType ScrollEventType_ScrollEventArgs_Delegate(global::Windows.UI.Xaml.Controls.Primitives.ScrollEventArgs e);

        public StubIScrollEventArgsResolver ScrollEventType(ScrollEventType_ScrollEventArgs_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }
    }
}

namespace Fievus.Windows.Mvc.Wrappers
{
    [CompilerGenerated]
    public class StubIScrollViewerViewChangedEventArgsResolver : IScrollViewerViewChangedEventArgsResolver
    {
        private readonly StubContainer<StubIScrollViewerViewChangedEventArgsResolver> _stubs = new StubContainer<StubIScrollViewerViewChangedEventArgsResolver>();

        bool global::Fievus.Windows.Mvc.Wrappers.IScrollViewerViewChangedEventArgsResolver.IsIntermediate(global::Windows.UI.Xaml.Controls.ScrollViewerViewChangedEventArgs e)
        {
            return _stubs.GetMethodStub<IsIntermediate_ScrollViewerViewChangedEventArgs_Delegate>("IsIntermediate").Invoke(e);
        }

        public delegate bool IsIntermediate_ScrollViewerViewChangedEventArgs_Delegate(global::Windows.UI.Xaml.Controls.ScrollViewerViewChangedEventArgs e);

        public StubIScrollViewerViewChangedEventArgsResolver IsIntermediate(IsIntermediate_ScrollViewerViewChangedEventArgs_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }
    }
}

namespace Fievus.Windows.Mvc.Wrappers
{
    [CompilerGenerated]
    public class StubIScrollViewerViewChangingEventArgsResolver : IScrollViewerViewChangingEventArgsResolver
    {
        private readonly StubContainer<StubIScrollViewerViewChangingEventArgsResolver> _stubs = new StubContainer<StubIScrollViewerViewChangingEventArgsResolver>();

        global::Windows.UI.Xaml.Controls.ScrollViewerView global::Fievus.Windows.Mvc.Wrappers.IScrollViewerViewChangingEventArgsResolver.FinalView(global::Windows.UI.Xaml.Controls.ScrollViewerViewChangingEventArgs e)
        {
            return _stubs.GetMethodStub<FinalView_ScrollViewerViewChangingEventArgs_Delegate>("FinalView").Invoke(e);
        }

        public delegate global::Windows.UI.Xaml.Controls.ScrollViewerView FinalView_ScrollViewerViewChangingEventArgs_Delegate(global::Windows.UI.Xaml.Controls.ScrollViewerViewChangingEventArgs e);

        public StubIScrollViewerViewChangingEventArgsResolver FinalView(FinalView_ScrollViewerViewChangingEventArgs_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        bool global::Fievus.Windows.Mvc.Wrappers.IScrollViewerViewChangingEventArgsResolver.IsInertial(global::Windows.UI.Xaml.Controls.ScrollViewerViewChangingEventArgs e)
        {
            return _stubs.GetMethodStub<IsInertial_ScrollViewerViewChangingEventArgs_Delegate>("IsInertial").Invoke(e);
        }

        public delegate bool IsInertial_ScrollViewerViewChangingEventArgs_Delegate(global::Windows.UI.Xaml.Controls.ScrollViewerViewChangingEventArgs e);

        public StubIScrollViewerViewChangingEventArgsResolver IsInertial(IsInertial_ScrollViewerViewChangingEventArgs_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        global::Windows.UI.Xaml.Controls.ScrollViewerView global::Fievus.Windows.Mvc.Wrappers.IScrollViewerViewChangingEventArgsResolver.NextView(global::Windows.UI.Xaml.Controls.ScrollViewerViewChangingEventArgs e)
        {
            return _stubs.GetMethodStub<NextView_ScrollViewerViewChangingEventArgs_Delegate>("NextView").Invoke(e);
        }

        public delegate global::Windows.UI.Xaml.Controls.ScrollViewerView NextView_ScrollViewerViewChangingEventArgs_Delegate(global::Windows.UI.Xaml.Controls.ScrollViewerViewChangingEventArgs e);

        public StubIScrollViewerViewChangingEventArgsResolver NextView(NextView_ScrollViewerViewChangingEventArgs_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }
    }
}

namespace Fievus.Windows.Mvc.Wrappers
{
    [CompilerGenerated]
    public class StubISearchBoxQueryChangedEventArgsResolver : ISearchBoxQueryChangedEventArgsResolver
    {
        private readonly StubContainer<StubISearchBoxQueryChangedEventArgsResolver> _stubs = new StubContainer<StubISearchBoxQueryChangedEventArgsResolver>();

        string global::Fievus.Windows.Mvc.Wrappers.ISearchBoxQueryChangedEventArgsResolver.Language(global::Windows.UI.Xaml.Controls.SearchBoxQueryChangedEventArgs e)
        {
            return _stubs.GetMethodStub<Language_SearchBoxQueryChangedEventArgs_Delegate>("Language").Invoke(e);
        }

        public delegate string Language_SearchBoxQueryChangedEventArgs_Delegate(global::Windows.UI.Xaml.Controls.SearchBoxQueryChangedEventArgs e);

        public StubISearchBoxQueryChangedEventArgsResolver Language(Language_SearchBoxQueryChangedEventArgs_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        global::Windows.ApplicationModel.Search.SearchQueryLinguisticDetails global::Fievus.Windows.Mvc.Wrappers.ISearchBoxQueryChangedEventArgsResolver.LinguisticDetails(global::Windows.UI.Xaml.Controls.SearchBoxQueryChangedEventArgs e)
        {
            return _stubs.GetMethodStub<LinguisticDetails_SearchBoxQueryChangedEventArgs_Delegate>("LinguisticDetails").Invoke(e);
        }

        public delegate global::Windows.ApplicationModel.Search.SearchQueryLinguisticDetails LinguisticDetails_SearchBoxQueryChangedEventArgs_Delegate(global::Windows.UI.Xaml.Controls.SearchBoxQueryChangedEventArgs e);

        public StubISearchBoxQueryChangedEventArgsResolver LinguisticDetails(LinguisticDetails_SearchBoxQueryChangedEventArgs_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        string global::Fievus.Windows.Mvc.Wrappers.ISearchBoxQueryChangedEventArgsResolver.QueryText(global::Windows.UI.Xaml.Controls.SearchBoxQueryChangedEventArgs e)
        {
            return _stubs.GetMethodStub<QueryText_SearchBoxQueryChangedEventArgs_Delegate>("QueryText").Invoke(e);
        }

        public delegate string QueryText_SearchBoxQueryChangedEventArgs_Delegate(global::Windows.UI.Xaml.Controls.SearchBoxQueryChangedEventArgs e);

        public StubISearchBoxQueryChangedEventArgsResolver QueryText(QueryText_SearchBoxQueryChangedEventArgs_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }
    }
}

namespace Fievus.Windows.Mvc.Wrappers
{
    [CompilerGenerated]
    public class StubISearchBoxQuerySubmittedEventArgsResolver : ISearchBoxQuerySubmittedEventArgsResolver
    {
        private readonly StubContainer<StubISearchBoxQuerySubmittedEventArgsResolver> _stubs = new StubContainer<StubISearchBoxQuerySubmittedEventArgsResolver>();

        global::Windows.System.VirtualKeyModifiers global::Fievus.Windows.Mvc.Wrappers.ISearchBoxQuerySubmittedEventArgsResolver.KeyModifiers(global::Windows.UI.Xaml.Controls.SearchBoxQuerySubmittedEventArgs e)
        {
            return _stubs.GetMethodStub<KeyModifiers_SearchBoxQuerySubmittedEventArgs_Delegate>("KeyModifiers").Invoke(e);
        }

        public delegate global::Windows.System.VirtualKeyModifiers KeyModifiers_SearchBoxQuerySubmittedEventArgs_Delegate(global::Windows.UI.Xaml.Controls.SearchBoxQuerySubmittedEventArgs e);

        public StubISearchBoxQuerySubmittedEventArgsResolver KeyModifiers(KeyModifiers_SearchBoxQuerySubmittedEventArgs_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        string global::Fievus.Windows.Mvc.Wrappers.ISearchBoxQuerySubmittedEventArgsResolver.Language(global::Windows.UI.Xaml.Controls.SearchBoxQuerySubmittedEventArgs e)
        {
            return _stubs.GetMethodStub<Language_SearchBoxQuerySubmittedEventArgs_Delegate>("Language").Invoke(e);
        }

        public delegate string Language_SearchBoxQuerySubmittedEventArgs_Delegate(global::Windows.UI.Xaml.Controls.SearchBoxQuerySubmittedEventArgs e);

        public StubISearchBoxQuerySubmittedEventArgsResolver Language(Language_SearchBoxQuerySubmittedEventArgs_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        global::Windows.ApplicationModel.Search.SearchQueryLinguisticDetails global::Fievus.Windows.Mvc.Wrappers.ISearchBoxQuerySubmittedEventArgsResolver.LinguisticDetails(global::Windows.UI.Xaml.Controls.SearchBoxQuerySubmittedEventArgs e)
        {
            return _stubs.GetMethodStub<LinguisticDetails_SearchBoxQuerySubmittedEventArgs_Delegate>("LinguisticDetails").Invoke(e);
        }

        public delegate global::Windows.ApplicationModel.Search.SearchQueryLinguisticDetails LinguisticDetails_SearchBoxQuerySubmittedEventArgs_Delegate(global::Windows.UI.Xaml.Controls.SearchBoxQuerySubmittedEventArgs e);

        public StubISearchBoxQuerySubmittedEventArgsResolver LinguisticDetails(LinguisticDetails_SearchBoxQuerySubmittedEventArgs_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        string global::Fievus.Windows.Mvc.Wrappers.ISearchBoxQuerySubmittedEventArgsResolver.QueryText(global::Windows.UI.Xaml.Controls.SearchBoxQuerySubmittedEventArgs e)
        {
            return _stubs.GetMethodStub<QueryText_SearchBoxQuerySubmittedEventArgs_Delegate>("QueryText").Invoke(e);
        }

        public delegate string QueryText_SearchBoxQuerySubmittedEventArgs_Delegate(global::Windows.UI.Xaml.Controls.SearchBoxQuerySubmittedEventArgs e);

        public StubISearchBoxQuerySubmittedEventArgsResolver QueryText(QueryText_SearchBoxQuerySubmittedEventArgs_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }
    }
}

namespace Fievus.Windows.Mvc.Wrappers
{
    [CompilerGenerated]
    public class StubISearchBoxResultSuggestionChosenEventArgsResolver : ISearchBoxResultSuggestionChosenEventArgsResolver
    {
        private readonly StubContainer<StubISearchBoxResultSuggestionChosenEventArgsResolver> _stubs = new StubContainer<StubISearchBoxResultSuggestionChosenEventArgsResolver>();

        global::Windows.System.VirtualKeyModifiers global::Fievus.Windows.Mvc.Wrappers.ISearchBoxResultSuggestionChosenEventArgsResolver.KeyModifiers(global::Windows.UI.Xaml.Controls.SearchBoxResultSuggestionChosenEventArgs e)
        {
            return _stubs.GetMethodStub<KeyModifiers_SearchBoxResultSuggestionChosenEventArgs_Delegate>("KeyModifiers").Invoke(e);
        }

        public delegate global::Windows.System.VirtualKeyModifiers KeyModifiers_SearchBoxResultSuggestionChosenEventArgs_Delegate(global::Windows.UI.Xaml.Controls.SearchBoxResultSuggestionChosenEventArgs e);

        public StubISearchBoxResultSuggestionChosenEventArgsResolver KeyModifiers(KeyModifiers_SearchBoxResultSuggestionChosenEventArgs_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        string global::Fievus.Windows.Mvc.Wrappers.ISearchBoxResultSuggestionChosenEventArgsResolver.Tag(global::Windows.UI.Xaml.Controls.SearchBoxResultSuggestionChosenEventArgs e)
        {
            return _stubs.GetMethodStub<Tag_SearchBoxResultSuggestionChosenEventArgs_Delegate>("Tag").Invoke(e);
        }

        public delegate string Tag_SearchBoxResultSuggestionChosenEventArgs_Delegate(global::Windows.UI.Xaml.Controls.SearchBoxResultSuggestionChosenEventArgs e);

        public StubISearchBoxResultSuggestionChosenEventArgsResolver Tag(Tag_SearchBoxResultSuggestionChosenEventArgs_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }
    }
}

namespace Fievus.Windows.Mvc.Wrappers
{
    [CompilerGenerated]
    public class StubISearchBoxSuggestionsRequestedEventArgsResolver : ISearchBoxSuggestionsRequestedEventArgsResolver
    {
        private readonly StubContainer<StubISearchBoxSuggestionsRequestedEventArgsResolver> _stubs = new StubContainer<StubISearchBoxSuggestionsRequestedEventArgsResolver>();

        string global::Fievus.Windows.Mvc.Wrappers.ISearchBoxSuggestionsRequestedEventArgsResolver.Language(global::Windows.UI.Xaml.Controls.SearchBoxSuggestionsRequestedEventArgs e)
        {
            return _stubs.GetMethodStub<Language_SearchBoxSuggestionsRequestedEventArgs_Delegate>("Language").Invoke(e);
        }

        public delegate string Language_SearchBoxSuggestionsRequestedEventArgs_Delegate(global::Windows.UI.Xaml.Controls.SearchBoxSuggestionsRequestedEventArgs e);

        public StubISearchBoxSuggestionsRequestedEventArgsResolver Language(Language_SearchBoxSuggestionsRequestedEventArgs_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        global::Windows.ApplicationModel.Search.SearchQueryLinguisticDetails global::Fievus.Windows.Mvc.Wrappers.ISearchBoxSuggestionsRequestedEventArgsResolver.LinguisticDetails(global::Windows.UI.Xaml.Controls.SearchBoxSuggestionsRequestedEventArgs e)
        {
            return _stubs.GetMethodStub<LinguisticDetails_SearchBoxSuggestionsRequestedEventArgs_Delegate>("LinguisticDetails").Invoke(e);
        }

        public delegate global::Windows.ApplicationModel.Search.SearchQueryLinguisticDetails LinguisticDetails_SearchBoxSuggestionsRequestedEventArgs_Delegate(global::Windows.UI.Xaml.Controls.SearchBoxSuggestionsRequestedEventArgs e);

        public StubISearchBoxSuggestionsRequestedEventArgsResolver LinguisticDetails(LinguisticDetails_SearchBoxSuggestionsRequestedEventArgs_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        string global::Fievus.Windows.Mvc.Wrappers.ISearchBoxSuggestionsRequestedEventArgsResolver.QueryText(global::Windows.UI.Xaml.Controls.SearchBoxSuggestionsRequestedEventArgs e)
        {
            return _stubs.GetMethodStub<QueryText_SearchBoxSuggestionsRequestedEventArgs_Delegate>("QueryText").Invoke(e);
        }

        public delegate string QueryText_SearchBoxSuggestionsRequestedEventArgs_Delegate(global::Windows.UI.Xaml.Controls.SearchBoxSuggestionsRequestedEventArgs e);

        public StubISearchBoxSuggestionsRequestedEventArgsResolver QueryText(QueryText_SearchBoxSuggestionsRequestedEventArgs_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        global::Windows.ApplicationModel.Search.SearchSuggestionsRequest global::Fievus.Windows.Mvc.Wrappers.ISearchBoxSuggestionsRequestedEventArgsResolver.Request(global::Windows.UI.Xaml.Controls.SearchBoxSuggestionsRequestedEventArgs e)
        {
            return _stubs.GetMethodStub<Request_SearchBoxSuggestionsRequestedEventArgs_Delegate>("Request").Invoke(e);
        }

        public delegate global::Windows.ApplicationModel.Search.SearchSuggestionsRequest Request_SearchBoxSuggestionsRequestedEventArgs_Delegate(global::Windows.UI.Xaml.Controls.SearchBoxSuggestionsRequestedEventArgs e);

        public StubISearchBoxSuggestionsRequestedEventArgsResolver Request(Request_SearchBoxSuggestionsRequestedEventArgs_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }
    }
}

namespace Fievus.Windows.Mvc.Wrappers
{
    [CompilerGenerated]
    public class StubISectionsInViewChangedEventArgsResolver : ISectionsInViewChangedEventArgsResolver
    {
        private readonly StubContainer<StubISectionsInViewChangedEventArgsResolver> _stubs = new StubContainer<StubISectionsInViewChangedEventArgsResolver>();

        global::System.Collections.Generic.IList<global::Windows.UI.Xaml.Controls.HubSection> global::Fievus.Windows.Mvc.Wrappers.ISectionsInViewChangedEventArgsResolver.AddedSections(global::Windows.UI.Xaml.Controls.SectionsInViewChangedEventArgs e)
        {
            return _stubs.GetMethodStub<AddedSections_SectionsInViewChangedEventArgs_Delegate>("AddedSections").Invoke(e);
        }

        public delegate global::System.Collections.Generic.IList<global::Windows.UI.Xaml.Controls.HubSection> AddedSections_SectionsInViewChangedEventArgs_Delegate(global::Windows.UI.Xaml.Controls.SectionsInViewChangedEventArgs e);

        public StubISectionsInViewChangedEventArgsResolver AddedSections(AddedSections_SectionsInViewChangedEventArgs_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        global::System.Collections.Generic.IList<global::Windows.UI.Xaml.Controls.HubSection> global::Fievus.Windows.Mvc.Wrappers.ISectionsInViewChangedEventArgsResolver.RemovedSections(global::Windows.UI.Xaml.Controls.SectionsInViewChangedEventArgs e)
        {
            return _stubs.GetMethodStub<RemovedSections_SectionsInViewChangedEventArgs_Delegate>("RemovedSections").Invoke(e);
        }

        public delegate global::System.Collections.Generic.IList<global::Windows.UI.Xaml.Controls.HubSection> RemovedSections_SectionsInViewChangedEventArgs_Delegate(global::Windows.UI.Xaml.Controls.SectionsInViewChangedEventArgs e);

        public StubISectionsInViewChangedEventArgsResolver RemovedSections(RemovedSections_SectionsInViewChangedEventArgs_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }
    }
}

namespace Fievus.Windows.Mvc.Wrappers
{
    [CompilerGenerated]
    public class StubISelectionChangedEventArgsResolver : ISelectionChangedEventArgsResolver
    {
        private readonly StubContainer<StubISelectionChangedEventArgsResolver> _stubs = new StubContainer<StubISelectionChangedEventArgsResolver>();

        global::System.Collections.Generic.IList<object> global::Fievus.Windows.Mvc.Wrappers.ISelectionChangedEventArgsResolver.AddedItems(global::Windows.UI.Xaml.Controls.SelectionChangedEventArgs e)
        {
            return _stubs.GetMethodStub<AddedItems_SelectionChangedEventArgs_Delegate>("AddedItems").Invoke(e);
        }

        public delegate global::System.Collections.Generic.IList<object> AddedItems_SelectionChangedEventArgs_Delegate(global::Windows.UI.Xaml.Controls.SelectionChangedEventArgs e);

        public StubISelectionChangedEventArgsResolver AddedItems(AddedItems_SelectionChangedEventArgs_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        object global::Fievus.Windows.Mvc.Wrappers.ISelectionChangedEventArgsResolver.OriginalSource(global::Windows.UI.Xaml.Controls.SelectionChangedEventArgs e)
        {
            return _stubs.GetMethodStub<OriginalSource_SelectionChangedEventArgs_Delegate>("OriginalSource").Invoke(e);
        }

        public delegate object OriginalSource_SelectionChangedEventArgs_Delegate(global::Windows.UI.Xaml.Controls.SelectionChangedEventArgs e);

        public StubISelectionChangedEventArgsResolver OriginalSource(OriginalSource_SelectionChangedEventArgs_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        global::System.Collections.Generic.IList<object> global::Fievus.Windows.Mvc.Wrappers.ISelectionChangedEventArgsResolver.RemovedItems(global::Windows.UI.Xaml.Controls.SelectionChangedEventArgs e)
        {
            return _stubs.GetMethodStub<RemovedItems_SelectionChangedEventArgs_Delegate>("RemovedItems").Invoke(e);
        }

        public delegate global::System.Collections.Generic.IList<object> RemovedItems_SelectionChangedEventArgs_Delegate(global::Windows.UI.Xaml.Controls.SelectionChangedEventArgs e);

        public StubISelectionChangedEventArgsResolver RemovedItems(RemovedItems_SelectionChangedEventArgs_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }
    }
}

namespace Fievus.Windows.Mvc.Wrappers
{
    [CompilerGenerated]
    public class StubISizeChangedEventArgsResolver : ISizeChangedEventArgsResolver
    {
        private readonly StubContainer<StubISizeChangedEventArgsResolver> _stubs = new StubContainer<StubISizeChangedEventArgsResolver>();

        global::Windows.Foundation.Size global::Fievus.Windows.Mvc.Wrappers.ISizeChangedEventArgsResolver.NewSize(global::Windows.UI.Xaml.SizeChangedEventArgs e)
        {
            return _stubs.GetMethodStub<NewSize_SizeChangedEventArgs_Delegate>("NewSize").Invoke(e);
        }

        public delegate global::Windows.Foundation.Size NewSize_SizeChangedEventArgs_Delegate(global::Windows.UI.Xaml.SizeChangedEventArgs e);

        public StubISizeChangedEventArgsResolver NewSize(NewSize_SizeChangedEventArgs_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        object global::Fievus.Windows.Mvc.Wrappers.ISizeChangedEventArgsResolver.OriginalSource(global::Windows.UI.Xaml.SizeChangedEventArgs e)
        {
            return _stubs.GetMethodStub<OriginalSource_SizeChangedEventArgs_Delegate>("OriginalSource").Invoke(e);
        }

        public delegate object OriginalSource_SizeChangedEventArgs_Delegate(global::Windows.UI.Xaml.SizeChangedEventArgs e);

        public StubISizeChangedEventArgsResolver OriginalSource(OriginalSource_SizeChangedEventArgs_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        global::Windows.Foundation.Size global::Fievus.Windows.Mvc.Wrappers.ISizeChangedEventArgsResolver.PreviousSize(global::Windows.UI.Xaml.SizeChangedEventArgs e)
        {
            return _stubs.GetMethodStub<PreviousSize_SizeChangedEventArgs_Delegate>("PreviousSize").Invoke(e);
        }

        public delegate global::Windows.Foundation.Size PreviousSize_SizeChangedEventArgs_Delegate(global::Windows.UI.Xaml.SizeChangedEventArgs e);

        public StubISizeChangedEventArgsResolver PreviousSize(PreviousSize_SizeChangedEventArgs_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }
    }
}

namespace Fievus.Windows.Mvc.Wrappers
{
    [CompilerGenerated]
    public class StubISplitViewPaneClosingEventArgsResolver : ISplitViewPaneClosingEventArgsResolver
    {
        private readonly StubContainer<StubISplitViewPaneClosingEventArgsResolver> _stubs = new StubContainer<StubISplitViewPaneClosingEventArgsResolver>();

        bool global::Fievus.Windows.Mvc.Wrappers.ISplitViewPaneClosingEventArgsResolver.Cancel(global::Windows.UI.Xaml.Controls.SplitViewPaneClosingEventArgs e)
        {
            return _stubs.GetMethodStub<Cancel_SplitViewPaneClosingEventArgs_Delegate>("Cancel").Invoke(e);
        }

        public delegate bool Cancel_SplitViewPaneClosingEventArgs_Delegate(global::Windows.UI.Xaml.Controls.SplitViewPaneClosingEventArgs e);

        public StubISplitViewPaneClosingEventArgsResolver Cancel(Cancel_SplitViewPaneClosingEventArgs_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        void global::Fievus.Windows.Mvc.Wrappers.ISplitViewPaneClosingEventArgsResolver.Cancel(global::Windows.UI.Xaml.Controls.SplitViewPaneClosingEventArgs e, bool cancel)
        {
            _stubs.GetMethodStub<Cancel_SplitViewPaneClosingEventArgs_Boolean_Delegate>("Cancel").Invoke(e, cancel);
        }

        public delegate void Cancel_SplitViewPaneClosingEventArgs_Boolean_Delegate(global::Windows.UI.Xaml.Controls.SplitViewPaneClosingEventArgs e, bool cancel);

        public StubISplitViewPaneClosingEventArgsResolver Cancel(Cancel_SplitViewPaneClosingEventArgs_Boolean_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }
    }
}

namespace Fievus.Windows.Mvc.Wrappers
{
    [CompilerGenerated]
    public class StubITappedRoutedEventArgsResolver : ITappedRoutedEventArgsResolver
    {
        private readonly StubContainer<StubITappedRoutedEventArgsResolver> _stubs = new StubContainer<StubITappedRoutedEventArgsResolver>();

        bool global::Fievus.Windows.Mvc.Wrappers.ITappedRoutedEventArgsResolver.Handled(global::Windows.UI.Xaml.Input.TappedRoutedEventArgs e)
        {
            return _stubs.GetMethodStub<Handled_TappedRoutedEventArgs_Delegate>("Handled").Invoke(e);
        }

        public delegate bool Handled_TappedRoutedEventArgs_Delegate(global::Windows.UI.Xaml.Input.TappedRoutedEventArgs e);

        public StubITappedRoutedEventArgsResolver Handled(Handled_TappedRoutedEventArgs_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        void global::Fievus.Windows.Mvc.Wrappers.ITappedRoutedEventArgsResolver.Handled(global::Windows.UI.Xaml.Input.TappedRoutedEventArgs e, bool handled)
        {
            _stubs.GetMethodStub<Handled_TappedRoutedEventArgs_Boolean_Delegate>("Handled").Invoke(e, handled);
        }

        public delegate void Handled_TappedRoutedEventArgs_Boolean_Delegate(global::Windows.UI.Xaml.Input.TappedRoutedEventArgs e, bool handled);

        public StubITappedRoutedEventArgsResolver Handled(Handled_TappedRoutedEventArgs_Boolean_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        object global::Fievus.Windows.Mvc.Wrappers.ITappedRoutedEventArgsResolver.OriginalSource(global::Windows.UI.Xaml.Input.TappedRoutedEventArgs e)
        {
            return _stubs.GetMethodStub<OriginalSource_TappedRoutedEventArgs_Delegate>("OriginalSource").Invoke(e);
        }

        public delegate object OriginalSource_TappedRoutedEventArgs_Delegate(global::Windows.UI.Xaml.Input.TappedRoutedEventArgs e);

        public StubITappedRoutedEventArgsResolver OriginalSource(OriginalSource_TappedRoutedEventArgs_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        global::Windows.Devices.Input.PointerDeviceType global::Fievus.Windows.Mvc.Wrappers.ITappedRoutedEventArgsResolver.PointerDeviceType(global::Windows.UI.Xaml.Input.TappedRoutedEventArgs e)
        {
            return _stubs.GetMethodStub<PointerDeviceType_TappedRoutedEventArgs_Delegate>("PointerDeviceType").Invoke(e);
        }

        public delegate global::Windows.Devices.Input.PointerDeviceType PointerDeviceType_TappedRoutedEventArgs_Delegate(global::Windows.UI.Xaml.Input.TappedRoutedEventArgs e);

        public StubITappedRoutedEventArgsResolver PointerDeviceType(PointerDeviceType_TappedRoutedEventArgs_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        global::Windows.Foundation.Point global::Fievus.Windows.Mvc.Wrappers.ITappedRoutedEventArgsResolver.GetPosition(global::Windows.UI.Xaml.Input.TappedRoutedEventArgs e, global::Windows.UI.Xaml.UIElement relativeTo)
        {
            return _stubs.GetMethodStub<GetPosition_TappedRoutedEventArgs_UIElement_Delegate>("GetPosition").Invoke(e, relativeTo);
        }

        public delegate global::Windows.Foundation.Point GetPosition_TappedRoutedEventArgs_UIElement_Delegate(global::Windows.UI.Xaml.Input.TappedRoutedEventArgs e, global::Windows.UI.Xaml.UIElement relativeTo);

        public StubITappedRoutedEventArgsResolver GetPosition(GetPosition_TappedRoutedEventArgs_UIElement_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }
    }
}

namespace Fievus.Windows.Mvc.Wrappers
{
    [CompilerGenerated]
    public class StubITextCompositionChangedEventArgsResolver : ITextCompositionChangedEventArgsResolver
    {
        private readonly StubContainer<StubITextCompositionChangedEventArgsResolver> _stubs = new StubContainer<StubITextCompositionChangedEventArgsResolver>();

        int global::Fievus.Windows.Mvc.Wrappers.ITextCompositionChangedEventArgsResolver.Length(global::Windows.UI.Xaml.Controls.TextCompositionChangedEventArgs e)
        {
            return _stubs.GetMethodStub<Length_TextCompositionChangedEventArgs_Delegate>("Length").Invoke(e);
        }

        public delegate int Length_TextCompositionChangedEventArgs_Delegate(global::Windows.UI.Xaml.Controls.TextCompositionChangedEventArgs e);

        public StubITextCompositionChangedEventArgsResolver Length(Length_TextCompositionChangedEventArgs_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        int global::Fievus.Windows.Mvc.Wrappers.ITextCompositionChangedEventArgsResolver.StartIndex(global::Windows.UI.Xaml.Controls.TextCompositionChangedEventArgs e)
        {
            return _stubs.GetMethodStub<StartIndex_TextCompositionChangedEventArgs_Delegate>("StartIndex").Invoke(e);
        }

        public delegate int StartIndex_TextCompositionChangedEventArgs_Delegate(global::Windows.UI.Xaml.Controls.TextCompositionChangedEventArgs e);

        public StubITextCompositionChangedEventArgsResolver StartIndex(StartIndex_TextCompositionChangedEventArgs_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }
    }
}

namespace Fievus.Windows.Mvc.Wrappers
{
    [CompilerGenerated]
    public class StubITextCompositionEndedEventArgsResolver : ITextCompositionEndedEventArgsResolver
    {
        private readonly StubContainer<StubITextCompositionEndedEventArgsResolver> _stubs = new StubContainer<StubITextCompositionEndedEventArgsResolver>();

        int global::Fievus.Windows.Mvc.Wrappers.ITextCompositionEndedEventArgsResolver.Length(global::Windows.UI.Xaml.Controls.TextCompositionEndedEventArgs e)
        {
            return _stubs.GetMethodStub<Length_TextCompositionEndedEventArgs_Delegate>("Length").Invoke(e);
        }

        public delegate int Length_TextCompositionEndedEventArgs_Delegate(global::Windows.UI.Xaml.Controls.TextCompositionEndedEventArgs e);

        public StubITextCompositionEndedEventArgsResolver Length(Length_TextCompositionEndedEventArgs_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        int global::Fievus.Windows.Mvc.Wrappers.ITextCompositionEndedEventArgsResolver.StartIndex(global::Windows.UI.Xaml.Controls.TextCompositionEndedEventArgs e)
        {
            return _stubs.GetMethodStub<StartIndex_TextCompositionEndedEventArgs_Delegate>("StartIndex").Invoke(e);
        }

        public delegate int StartIndex_TextCompositionEndedEventArgs_Delegate(global::Windows.UI.Xaml.Controls.TextCompositionEndedEventArgs e);

        public StubITextCompositionEndedEventArgsResolver StartIndex(StartIndex_TextCompositionEndedEventArgs_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }
    }
}

namespace Fievus.Windows.Mvc.Wrappers
{
    [CompilerGenerated]
    public class StubITextCompositionStartedEventArgsResolver : ITextCompositionStartedEventArgsResolver
    {
        private readonly StubContainer<StubITextCompositionStartedEventArgsResolver> _stubs = new StubContainer<StubITextCompositionStartedEventArgsResolver>();

        int global::Fievus.Windows.Mvc.Wrappers.ITextCompositionStartedEventArgsResolver.Length(global::Windows.UI.Xaml.Controls.TextCompositionStartedEventArgs e)
        {
            return _stubs.GetMethodStub<Length_TextCompositionStartedEventArgs_Delegate>("Length").Invoke(e);
        }

        public delegate int Length_TextCompositionStartedEventArgs_Delegate(global::Windows.UI.Xaml.Controls.TextCompositionStartedEventArgs e);

        public StubITextCompositionStartedEventArgsResolver Length(Length_TextCompositionStartedEventArgs_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        int global::Fievus.Windows.Mvc.Wrappers.ITextCompositionStartedEventArgsResolver.StartIndex(global::Windows.UI.Xaml.Controls.TextCompositionStartedEventArgs e)
        {
            return _stubs.GetMethodStub<StartIndex_TextCompositionStartedEventArgs_Delegate>("StartIndex").Invoke(e);
        }

        public delegate int StartIndex_TextCompositionStartedEventArgs_Delegate(global::Windows.UI.Xaml.Controls.TextCompositionStartedEventArgs e);

        public StubITextCompositionStartedEventArgsResolver StartIndex(StartIndex_TextCompositionStartedEventArgs_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }
    }
}

namespace Fievus.Windows.Mvc.Wrappers
{
    [CompilerGenerated]
    public class StubITextControlPasteEventArgsResolver : ITextControlPasteEventArgsResolver
    {
        private readonly StubContainer<StubITextControlPasteEventArgsResolver> _stubs = new StubContainer<StubITextControlPasteEventArgsResolver>();

        bool global::Fievus.Windows.Mvc.Wrappers.ITextControlPasteEventArgsResolver.Handled(global::Windows.UI.Xaml.Controls.TextControlPasteEventArgs e)
        {
            return _stubs.GetMethodStub<Handled_TextControlPasteEventArgs_Delegate>("Handled").Invoke(e);
        }

        public delegate bool Handled_TextControlPasteEventArgs_Delegate(global::Windows.UI.Xaml.Controls.TextControlPasteEventArgs e);

        public StubITextControlPasteEventArgsResolver Handled(Handled_TextControlPasteEventArgs_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        void global::Fievus.Windows.Mvc.Wrappers.ITextControlPasteEventArgsResolver.Handled(global::Windows.UI.Xaml.Controls.TextControlPasteEventArgs e, bool handled)
        {
            _stubs.GetMethodStub<Handled_TextControlPasteEventArgs_Boolean_Delegate>("Handled").Invoke(e, handled);
        }

        public delegate void Handled_TextControlPasteEventArgs_Boolean_Delegate(global::Windows.UI.Xaml.Controls.TextControlPasteEventArgs e, bool handled);

        public StubITextControlPasteEventArgsResolver Handled(Handled_TextControlPasteEventArgs_Boolean_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }
    }
}

namespace Fievus.Windows.Mvc.Wrappers
{
    [CompilerGenerated]
    public class StubITimelineMarkerRoutedEventArgsResolver : ITimelineMarkerRoutedEventArgsResolver
    {
        private readonly StubContainer<StubITimelineMarkerRoutedEventArgsResolver> _stubs = new StubContainer<StubITimelineMarkerRoutedEventArgsResolver>();

        global::Windows.UI.Xaml.Media.TimelineMarker global::Fievus.Windows.Mvc.Wrappers.ITimelineMarkerRoutedEventArgsResolver.Marker(global::Windows.UI.Xaml.Media.TimelineMarkerRoutedEventArgs e)
        {
            return _stubs.GetMethodStub<Marker_TimelineMarkerRoutedEventArgs_Delegate>("Marker").Invoke(e);
        }

        public delegate global::Windows.UI.Xaml.Media.TimelineMarker Marker_TimelineMarkerRoutedEventArgs_Delegate(global::Windows.UI.Xaml.Media.TimelineMarkerRoutedEventArgs e);

        public StubITimelineMarkerRoutedEventArgsResolver Marker(Marker_TimelineMarkerRoutedEventArgs_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        object global::Fievus.Windows.Mvc.Wrappers.ITimelineMarkerRoutedEventArgsResolver.OriginalSource(global::Windows.UI.Xaml.Media.TimelineMarkerRoutedEventArgs e)
        {
            return _stubs.GetMethodStub<OriginalSource_TimelineMarkerRoutedEventArgs_Delegate>("OriginalSource").Invoke(e);
        }

        public delegate object OriginalSource_TimelineMarkerRoutedEventArgs_Delegate(global::Windows.UI.Xaml.Media.TimelineMarkerRoutedEventArgs e);

        public StubITimelineMarkerRoutedEventArgsResolver OriginalSource(OriginalSource_TimelineMarkerRoutedEventArgs_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }
    }
}

namespace Fievus.Windows.Mvc.Wrappers
{
    [CompilerGenerated]
    public class StubITimePickerValueChangedEventArgsResolver : ITimePickerValueChangedEventArgsResolver
    {
        private readonly StubContainer<StubITimePickerValueChangedEventArgsResolver> _stubs = new StubContainer<StubITimePickerValueChangedEventArgsResolver>();

        global::System.TimeSpan global::Fievus.Windows.Mvc.Wrappers.ITimePickerValueChangedEventArgsResolver.NewTime(global::Windows.UI.Xaml.Controls.TimePickerValueChangedEventArgs e)
        {
            return _stubs.GetMethodStub<NewTime_TimePickerValueChangedEventArgs_Delegate>("NewTime").Invoke(e);
        }

        public delegate global::System.TimeSpan NewTime_TimePickerValueChangedEventArgs_Delegate(global::Windows.UI.Xaml.Controls.TimePickerValueChangedEventArgs e);

        public StubITimePickerValueChangedEventArgsResolver NewTime(NewTime_TimePickerValueChangedEventArgs_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        global::System.TimeSpan global::Fievus.Windows.Mvc.Wrappers.ITimePickerValueChangedEventArgsResolver.OldTime(global::Windows.UI.Xaml.Controls.TimePickerValueChangedEventArgs e)
        {
            return _stubs.GetMethodStub<OldTime_TimePickerValueChangedEventArgs_Delegate>("OldTime").Invoke(e);
        }

        public delegate global::System.TimeSpan OldTime_TimePickerValueChangedEventArgs_Delegate(global::Windows.UI.Xaml.Controls.TimePickerValueChangedEventArgs e);

        public StubITimePickerValueChangedEventArgsResolver OldTime(OldTime_TimePickerValueChangedEventArgs_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }
    }
}

namespace Fievus.Windows.Mvc.Wrappers
{
    [CompilerGenerated]
    public class StubIWebViewNavigationFailedEventArgsResolver : IWebViewNavigationFailedEventArgsResolver
    {
        private readonly StubContainer<StubIWebViewNavigationFailedEventArgsResolver> _stubs = new StubContainer<StubIWebViewNavigationFailedEventArgsResolver>();

        global::System.Uri global::Fievus.Windows.Mvc.Wrappers.IWebViewNavigationFailedEventArgsResolver.Uri(global::Windows.UI.Xaml.Controls.WebViewNavigationFailedEventArgs e)
        {
            return _stubs.GetMethodStub<Uri_WebViewNavigationFailedEventArgs_Delegate>("Uri").Invoke(e);
        }

        public delegate global::System.Uri Uri_WebViewNavigationFailedEventArgs_Delegate(global::Windows.UI.Xaml.Controls.WebViewNavigationFailedEventArgs e);

        public StubIWebViewNavigationFailedEventArgsResolver Uri(Uri_WebViewNavigationFailedEventArgs_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        global::Windows.Web.WebErrorStatus global::Fievus.Windows.Mvc.Wrappers.IWebViewNavigationFailedEventArgsResolver.WebErrorStatus(global::Windows.UI.Xaml.Controls.WebViewNavigationFailedEventArgs e)
        {
            return _stubs.GetMethodStub<WebErrorStatus_WebViewNavigationFailedEventArgs_Delegate>("WebErrorStatus").Invoke(e);
        }

        public delegate global::Windows.Web.WebErrorStatus WebErrorStatus_WebViewNavigationFailedEventArgs_Delegate(global::Windows.UI.Xaml.Controls.WebViewNavigationFailedEventArgs e);

        public StubIWebViewNavigationFailedEventArgsResolver WebErrorStatus(WebErrorStatus_WebViewNavigationFailedEventArgs_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }
    }
}

namespace Fievus.Windows.Mvc.Wrappers
{
    [CompilerGenerated]
    public class StubIWebViewContentLoadingEventArgsResolver : IWebViewContentLoadingEventArgsResolver
    {
        private readonly StubContainer<StubIWebViewContentLoadingEventArgsResolver> _stubs = new StubContainer<StubIWebViewContentLoadingEventArgsResolver>();

        global::System.Uri global::Fievus.Windows.Mvc.Wrappers.IWebViewContentLoadingEventArgsResolver.Uri(global::Windows.UI.Xaml.Controls.WebViewContentLoadingEventArgs e)
        {
            return _stubs.GetMethodStub<Uri_WebViewContentLoadingEventArgs_Delegate>("Uri").Invoke(e);
        }

        public delegate global::System.Uri Uri_WebViewContentLoadingEventArgs_Delegate(global::Windows.UI.Xaml.Controls.WebViewContentLoadingEventArgs e);

        public StubIWebViewContentLoadingEventArgsResolver Uri(Uri_WebViewContentLoadingEventArgs_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }
    }
}

namespace Fievus.Windows.Mvc.Wrappers
{
    [CompilerGenerated]
    public class StubIWebViewDOMContentLoadedEventArgsResolver : IWebViewDOMContentLoadedEventArgsResolver
    {
        private readonly StubContainer<StubIWebViewDOMContentLoadedEventArgsResolver> _stubs = new StubContainer<StubIWebViewDOMContentLoadedEventArgsResolver>();

        global::System.Uri global::Fievus.Windows.Mvc.Wrappers.IWebViewDOMContentLoadedEventArgsResolver.Uri(global::Windows.UI.Xaml.Controls.WebViewDOMContentLoadedEventArgs e)
        {
            return _stubs.GetMethodStub<Uri_WebViewDOMContentLoadedEventArgs_Delegate>("Uri").Invoke(e);
        }

        public delegate global::System.Uri Uri_WebViewDOMContentLoadedEventArgs_Delegate(global::Windows.UI.Xaml.Controls.WebViewDOMContentLoadedEventArgs e);

        public StubIWebViewDOMContentLoadedEventArgsResolver Uri(Uri_WebViewDOMContentLoadedEventArgs_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }
    }
}

namespace Fievus.Windows.Mvc.Wrappers
{
    [CompilerGenerated]
    public class StubIWebViewLongRunningScriptDetectedEventArgsResolver : IWebViewLongRunningScriptDetectedEventArgsResolver
    {
        private readonly StubContainer<StubIWebViewLongRunningScriptDetectedEventArgsResolver> _stubs = new StubContainer<StubIWebViewLongRunningScriptDetectedEventArgsResolver>();

        global::System.TimeSpan global::Fievus.Windows.Mvc.Wrappers.IWebViewLongRunningScriptDetectedEventArgsResolver.ExceptionTime(global::Windows.UI.Xaml.Controls.WebViewLongRunningScriptDetectedEventArgs e)
        {
            return _stubs.GetMethodStub<ExceptionTime_WebViewLongRunningScriptDetectedEventArgs_Delegate>("ExceptionTime").Invoke(e);
        }

        public delegate global::System.TimeSpan ExceptionTime_WebViewLongRunningScriptDetectedEventArgs_Delegate(global::Windows.UI.Xaml.Controls.WebViewLongRunningScriptDetectedEventArgs e);

        public StubIWebViewLongRunningScriptDetectedEventArgsResolver ExceptionTime(ExceptionTime_WebViewLongRunningScriptDetectedEventArgs_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        bool global::Fievus.Windows.Mvc.Wrappers.IWebViewLongRunningScriptDetectedEventArgsResolver.StopPageScriptExecution(global::Windows.UI.Xaml.Controls.WebViewLongRunningScriptDetectedEventArgs e)
        {
            return _stubs.GetMethodStub<StopPageScriptExecution_WebViewLongRunningScriptDetectedEventArgs_Delegate>("StopPageScriptExecution").Invoke(e);
        }

        public delegate bool StopPageScriptExecution_WebViewLongRunningScriptDetectedEventArgs_Delegate(global::Windows.UI.Xaml.Controls.WebViewLongRunningScriptDetectedEventArgs e);

        public StubIWebViewLongRunningScriptDetectedEventArgsResolver StopPageScriptExecution(StopPageScriptExecution_WebViewLongRunningScriptDetectedEventArgs_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }
    }
}

namespace Fievus.Windows.Mvc.Wrappers
{
    [CompilerGenerated]
    public class StubIWebViewNavigationCompletedEventArgsResolver : IWebViewNavigationCompletedEventArgsResolver
    {
        private readonly StubContainer<StubIWebViewNavigationCompletedEventArgsResolver> _stubs = new StubContainer<StubIWebViewNavigationCompletedEventArgsResolver>();

        bool global::Fievus.Windows.Mvc.Wrappers.IWebViewNavigationCompletedEventArgsResolver.IsSuccess(global::Windows.UI.Xaml.Controls.WebViewNavigationCompletedEventArgs e)
        {
            return _stubs.GetMethodStub<IsSuccess_WebViewNavigationCompletedEventArgs_Delegate>("IsSuccess").Invoke(e);
        }

        public delegate bool IsSuccess_WebViewNavigationCompletedEventArgs_Delegate(global::Windows.UI.Xaml.Controls.WebViewNavigationCompletedEventArgs e);

        public StubIWebViewNavigationCompletedEventArgsResolver IsSuccess(IsSuccess_WebViewNavigationCompletedEventArgs_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        global::System.Uri global::Fievus.Windows.Mvc.Wrappers.IWebViewNavigationCompletedEventArgsResolver.Uri(global::Windows.UI.Xaml.Controls.WebViewNavigationCompletedEventArgs e)
        {
            return _stubs.GetMethodStub<Uri_WebViewNavigationCompletedEventArgs_Delegate>("Uri").Invoke(e);
        }

        public delegate global::System.Uri Uri_WebViewNavigationCompletedEventArgs_Delegate(global::Windows.UI.Xaml.Controls.WebViewNavigationCompletedEventArgs e);

        public StubIWebViewNavigationCompletedEventArgsResolver Uri(Uri_WebViewNavigationCompletedEventArgs_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        global::Windows.Web.WebErrorStatus global::Fievus.Windows.Mvc.Wrappers.IWebViewNavigationCompletedEventArgsResolver.WebErrorStatus(global::Windows.UI.Xaml.Controls.WebViewNavigationCompletedEventArgs e)
        {
            return _stubs.GetMethodStub<WebErrorStatus_WebViewNavigationCompletedEventArgs_Delegate>("WebErrorStatus").Invoke(e);
        }

        public delegate global::Windows.Web.WebErrorStatus WebErrorStatus_WebViewNavigationCompletedEventArgs_Delegate(global::Windows.UI.Xaml.Controls.WebViewNavigationCompletedEventArgs e);

        public StubIWebViewNavigationCompletedEventArgsResolver WebErrorStatus(WebErrorStatus_WebViewNavigationCompletedEventArgs_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }
    }
}

namespace Fievus.Windows.Mvc.Wrappers
{
    [CompilerGenerated]
    public class StubIWebViewNavigationStartingEventArgsResolver : IWebViewNavigationStartingEventArgsResolver
    {
        private readonly StubContainer<StubIWebViewNavigationStartingEventArgsResolver> _stubs = new StubContainer<StubIWebViewNavigationStartingEventArgsResolver>();

        bool global::Fievus.Windows.Mvc.Wrappers.IWebViewNavigationStartingEventArgsResolver.Cancel(global::Windows.UI.Xaml.Controls.WebViewNavigationStartingEventArgs e)
        {
            return _stubs.GetMethodStub<Cancel_WebViewNavigationStartingEventArgs_Delegate>("Cancel").Invoke(e);
        }

        public delegate bool Cancel_WebViewNavigationStartingEventArgs_Delegate(global::Windows.UI.Xaml.Controls.WebViewNavigationStartingEventArgs e);

        public StubIWebViewNavigationStartingEventArgsResolver Cancel(Cancel_WebViewNavigationStartingEventArgs_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        void global::Fievus.Windows.Mvc.Wrappers.IWebViewNavigationStartingEventArgsResolver.Cancel(global::Windows.UI.Xaml.Controls.WebViewNavigationStartingEventArgs e, bool cancel)
        {
            _stubs.GetMethodStub<Cancel_WebViewNavigationStartingEventArgs_Boolean_Delegate>("Cancel").Invoke(e, cancel);
        }

        public delegate void Cancel_WebViewNavigationStartingEventArgs_Boolean_Delegate(global::Windows.UI.Xaml.Controls.WebViewNavigationStartingEventArgs e, bool cancel);

        public StubIWebViewNavigationStartingEventArgsResolver Cancel(Cancel_WebViewNavigationStartingEventArgs_Boolean_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        global::System.Uri global::Fievus.Windows.Mvc.Wrappers.IWebViewNavigationStartingEventArgsResolver.Uri(global::Windows.UI.Xaml.Controls.WebViewNavigationStartingEventArgs e)
        {
            return _stubs.GetMethodStub<Uri_WebViewNavigationStartingEventArgs_Delegate>("Uri").Invoke(e);
        }

        public delegate global::System.Uri Uri_WebViewNavigationStartingEventArgs_Delegate(global::Windows.UI.Xaml.Controls.WebViewNavigationStartingEventArgs e);

        public StubIWebViewNavigationStartingEventArgsResolver Uri(Uri_WebViewNavigationStartingEventArgs_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }
    }
}

namespace Fievus.Windows.Mvc.Wrappers
{
    [CompilerGenerated]
    public class StubIWebViewNewWindowRequestedEventArgsResolver : IWebViewNewWindowRequestedEventArgsResolver
    {
        private readonly StubContainer<StubIWebViewNewWindowRequestedEventArgsResolver> _stubs = new StubContainer<StubIWebViewNewWindowRequestedEventArgsResolver>();

        bool global::Fievus.Windows.Mvc.Wrappers.IWebViewNewWindowRequestedEventArgsResolver.Handled(global::Windows.UI.Xaml.Controls.WebViewNewWindowRequestedEventArgs e)
        {
            return _stubs.GetMethodStub<Handled_WebViewNewWindowRequestedEventArgs_Delegate>("Handled").Invoke(e);
        }

        public delegate bool Handled_WebViewNewWindowRequestedEventArgs_Delegate(global::Windows.UI.Xaml.Controls.WebViewNewWindowRequestedEventArgs e);

        public StubIWebViewNewWindowRequestedEventArgsResolver Handled(Handled_WebViewNewWindowRequestedEventArgs_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        void global::Fievus.Windows.Mvc.Wrappers.IWebViewNewWindowRequestedEventArgsResolver.Handled(global::Windows.UI.Xaml.Controls.WebViewNewWindowRequestedEventArgs e, bool handled)
        {
            _stubs.GetMethodStub<Handled_WebViewNewWindowRequestedEventArgs_Boolean_Delegate>("Handled").Invoke(e, handled);
        }

        public delegate void Handled_WebViewNewWindowRequestedEventArgs_Boolean_Delegate(global::Windows.UI.Xaml.Controls.WebViewNewWindowRequestedEventArgs e, bool handled);

        public StubIWebViewNewWindowRequestedEventArgsResolver Handled(Handled_WebViewNewWindowRequestedEventArgs_Boolean_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        global::System.Uri global::Fievus.Windows.Mvc.Wrappers.IWebViewNewWindowRequestedEventArgsResolver.Referrer(global::Windows.UI.Xaml.Controls.WebViewNewWindowRequestedEventArgs e)
        {
            return _stubs.GetMethodStub<Referrer_WebViewNewWindowRequestedEventArgs_Delegate>("Referrer").Invoke(e);
        }

        public delegate global::System.Uri Referrer_WebViewNewWindowRequestedEventArgs_Delegate(global::Windows.UI.Xaml.Controls.WebViewNewWindowRequestedEventArgs e);

        public StubIWebViewNewWindowRequestedEventArgsResolver Referrer(Referrer_WebViewNewWindowRequestedEventArgs_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        global::System.Uri global::Fievus.Windows.Mvc.Wrappers.IWebViewNewWindowRequestedEventArgsResolver.Uri(global::Windows.UI.Xaml.Controls.WebViewNewWindowRequestedEventArgs e)
        {
            return _stubs.GetMethodStub<Uri_WebViewNewWindowRequestedEventArgs_Delegate>("Uri").Invoke(e);
        }

        public delegate global::System.Uri Uri_WebViewNewWindowRequestedEventArgs_Delegate(global::Windows.UI.Xaml.Controls.WebViewNewWindowRequestedEventArgs e);

        public StubIWebViewNewWindowRequestedEventArgsResolver Uri(Uri_WebViewNewWindowRequestedEventArgs_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }
    }
}

namespace Fievus.Windows.Mvc.Wrappers
{
    [CompilerGenerated]
    public class StubIWebViewPermissionRequestedEventArgsResolver : IWebViewPermissionRequestedEventArgsResolver
    {
        private readonly StubContainer<StubIWebViewPermissionRequestedEventArgsResolver> _stubs = new StubContainer<StubIWebViewPermissionRequestedEventArgsResolver>();

        global::Windows.UI.Xaml.Controls.WebViewPermissionRequest global::Fievus.Windows.Mvc.Wrappers.IWebViewPermissionRequestedEventArgsResolver.PermissionRequest(global::Windows.UI.Xaml.Controls.WebViewPermissionRequestedEventArgs e)
        {
            return _stubs.GetMethodStub<PermissionRequest_WebViewPermissionRequestedEventArgs_Delegate>("PermissionRequest").Invoke(e);
        }

        public delegate global::Windows.UI.Xaml.Controls.WebViewPermissionRequest PermissionRequest_WebViewPermissionRequestedEventArgs_Delegate(global::Windows.UI.Xaml.Controls.WebViewPermissionRequestedEventArgs e);

        public StubIWebViewPermissionRequestedEventArgsResolver PermissionRequest(PermissionRequest_WebViewPermissionRequestedEventArgs_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }
    }
}

namespace Fievus.Windows.Mvc.Wrappers
{
    [CompilerGenerated]
    public class StubIWebViewPermissionRequestResolver : IWebViewPermissionRequestResolver
    {
        private readonly StubContainer<StubIWebViewPermissionRequestResolver> _stubs = new StubContainer<StubIWebViewPermissionRequestResolver>();

        uint global::Fievus.Windows.Mvc.Wrappers.IWebViewPermissionRequestResolver.Id(global::Windows.UI.Xaml.Controls.WebViewPermissionRequest permissionRequest)
        {
            return _stubs.GetMethodStub<Id_WebViewPermissionRequest_Delegate>("Id").Invoke(permissionRequest);
        }

        public delegate uint Id_WebViewPermissionRequest_Delegate(global::Windows.UI.Xaml.Controls.WebViewPermissionRequest permissionRequest);

        public StubIWebViewPermissionRequestResolver Id(Id_WebViewPermissionRequest_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        global::Windows.UI.Xaml.Controls.WebViewPermissionType global::Fievus.Windows.Mvc.Wrappers.IWebViewPermissionRequestResolver.PermissionType(global::Windows.UI.Xaml.Controls.WebViewPermissionRequest permissionRequest)
        {
            return _stubs.GetMethodStub<PermissionType_WebViewPermissionRequest_Delegate>("PermissionType").Invoke(permissionRequest);
        }

        public delegate global::Windows.UI.Xaml.Controls.WebViewPermissionType PermissionType_WebViewPermissionRequest_Delegate(global::Windows.UI.Xaml.Controls.WebViewPermissionRequest permissionRequest);

        public StubIWebViewPermissionRequestResolver PermissionType(PermissionType_WebViewPermissionRequest_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        global::Windows.UI.Xaml.Controls.WebViewPermissionState global::Fievus.Windows.Mvc.Wrappers.IWebViewPermissionRequestResolver.State(global::Windows.UI.Xaml.Controls.WebViewPermissionRequest permissionRequest)
        {
            return _stubs.GetMethodStub<State_WebViewPermissionRequest_Delegate>("State").Invoke(permissionRequest);
        }

        public delegate global::Windows.UI.Xaml.Controls.WebViewPermissionState State_WebViewPermissionRequest_Delegate(global::Windows.UI.Xaml.Controls.WebViewPermissionRequest permissionRequest);

        public StubIWebViewPermissionRequestResolver State(State_WebViewPermissionRequest_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        global::System.Uri global::Fievus.Windows.Mvc.Wrappers.IWebViewPermissionRequestResolver.Uri(global::Windows.UI.Xaml.Controls.WebViewPermissionRequest permissionRequest)
        {
            return _stubs.GetMethodStub<Uri_WebViewPermissionRequest_Delegate>("Uri").Invoke(permissionRequest);
        }

        public delegate global::System.Uri Uri_WebViewPermissionRequest_Delegate(global::Windows.UI.Xaml.Controls.WebViewPermissionRequest permissionRequest);

        public StubIWebViewPermissionRequestResolver Uri(Uri_WebViewPermissionRequest_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        void global::Fievus.Windows.Mvc.Wrappers.IWebViewPermissionRequestResolver.Allow(global::Windows.UI.Xaml.Controls.WebViewPermissionRequest permissionRequest)
        {
            _stubs.GetMethodStub<Allow_WebViewPermissionRequest_Delegate>("Allow").Invoke(permissionRequest);
        }

        public delegate void Allow_WebViewPermissionRequest_Delegate(global::Windows.UI.Xaml.Controls.WebViewPermissionRequest permissionRequest);

        public StubIWebViewPermissionRequestResolver Allow(Allow_WebViewPermissionRequest_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        void global::Fievus.Windows.Mvc.Wrappers.IWebViewPermissionRequestResolver.Defer(global::Windows.UI.Xaml.Controls.WebViewPermissionRequest permissionRequest)
        {
            _stubs.GetMethodStub<Defer_WebViewPermissionRequest_Delegate>("Defer").Invoke(permissionRequest);
        }

        public delegate void Defer_WebViewPermissionRequest_Delegate(global::Windows.UI.Xaml.Controls.WebViewPermissionRequest permissionRequest);

        public StubIWebViewPermissionRequestResolver Defer(Defer_WebViewPermissionRequest_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        void global::Fievus.Windows.Mvc.Wrappers.IWebViewPermissionRequestResolver.Deny(global::Windows.UI.Xaml.Controls.WebViewPermissionRequest permissionRequest)
        {
            _stubs.GetMethodStub<Deny_WebViewPermissionRequest_Delegate>("Deny").Invoke(permissionRequest);
        }

        public delegate void Deny_WebViewPermissionRequest_Delegate(global::Windows.UI.Xaml.Controls.WebViewPermissionRequest permissionRequest);

        public StubIWebViewPermissionRequestResolver Deny(Deny_WebViewPermissionRequest_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }
    }
}

namespace Fievus.Windows.Mvc.Wrappers
{
    [CompilerGenerated]
    public class StubIWebViewUnsupportedUriSchemeIdentifiedEventArgsResolver : IWebViewUnsupportedUriSchemeIdentifiedEventArgsResolver
    {
        private readonly StubContainer<StubIWebViewUnsupportedUriSchemeIdentifiedEventArgsResolver> _stubs = new StubContainer<StubIWebViewUnsupportedUriSchemeIdentifiedEventArgsResolver>();

        bool global::Fievus.Windows.Mvc.Wrappers.IWebViewUnsupportedUriSchemeIdentifiedEventArgsResolver.Handled(global::Windows.UI.Xaml.Controls.WebViewUnsupportedUriSchemeIdentifiedEventArgs e)
        {
            return _stubs.GetMethodStub<Handled_WebViewUnsupportedUriSchemeIdentifiedEventArgs_Delegate>("Handled").Invoke(e);
        }

        public delegate bool Handled_WebViewUnsupportedUriSchemeIdentifiedEventArgs_Delegate(global::Windows.UI.Xaml.Controls.WebViewUnsupportedUriSchemeIdentifiedEventArgs e);

        public StubIWebViewUnsupportedUriSchemeIdentifiedEventArgsResolver Handled(Handled_WebViewUnsupportedUriSchemeIdentifiedEventArgs_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        void global::Fievus.Windows.Mvc.Wrappers.IWebViewUnsupportedUriSchemeIdentifiedEventArgsResolver.Handled(global::Windows.UI.Xaml.Controls.WebViewUnsupportedUriSchemeIdentifiedEventArgs e, bool handled)
        {
            _stubs.GetMethodStub<Handled_WebViewUnsupportedUriSchemeIdentifiedEventArgs_Boolean_Delegate>("Handled").Invoke(e, handled);
        }

        public delegate void Handled_WebViewUnsupportedUriSchemeIdentifiedEventArgs_Boolean_Delegate(global::Windows.UI.Xaml.Controls.WebViewUnsupportedUriSchemeIdentifiedEventArgs e, bool handled);

        public StubIWebViewUnsupportedUriSchemeIdentifiedEventArgsResolver Handled(Handled_WebViewUnsupportedUriSchemeIdentifiedEventArgs_Boolean_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        global::System.Uri global::Fievus.Windows.Mvc.Wrappers.IWebViewUnsupportedUriSchemeIdentifiedEventArgsResolver.Uri(global::Windows.UI.Xaml.Controls.WebViewUnsupportedUriSchemeIdentifiedEventArgs e)
        {
            return _stubs.GetMethodStub<Uri_WebViewUnsupportedUriSchemeIdentifiedEventArgs_Delegate>("Uri").Invoke(e);
        }

        public delegate global::System.Uri Uri_WebViewUnsupportedUriSchemeIdentifiedEventArgs_Delegate(global::Windows.UI.Xaml.Controls.WebViewUnsupportedUriSchemeIdentifiedEventArgs e);

        public StubIWebViewUnsupportedUriSchemeIdentifiedEventArgsResolver Uri(Uri_WebViewUnsupportedUriSchemeIdentifiedEventArgs_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }
    }
}

namespace Fievus.Windows.Mvc.Wrappers
{
    [CompilerGenerated]
    public class StubIWebViewUnviewableContentIdentifiedEventArgsResolver : IWebViewUnviewableContentIdentifiedEventArgsResolver
    {
        private readonly StubContainer<StubIWebViewUnviewableContentIdentifiedEventArgsResolver> _stubs = new StubContainer<StubIWebViewUnviewableContentIdentifiedEventArgsResolver>();

        global::System.Uri global::Fievus.Windows.Mvc.Wrappers.IWebViewUnviewableContentIdentifiedEventArgsResolver.Referrer(global::Windows.UI.Xaml.Controls.WebViewUnviewableContentIdentifiedEventArgs e)
        {
            return _stubs.GetMethodStub<Referrer_WebViewUnviewableContentIdentifiedEventArgs_Delegate>("Referrer").Invoke(e);
        }

        public delegate global::System.Uri Referrer_WebViewUnviewableContentIdentifiedEventArgs_Delegate(global::Windows.UI.Xaml.Controls.WebViewUnviewableContentIdentifiedEventArgs e);

        public StubIWebViewUnviewableContentIdentifiedEventArgsResolver Referrer(Referrer_WebViewUnviewableContentIdentifiedEventArgs_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }

        global::System.Uri global::Fievus.Windows.Mvc.Wrappers.IWebViewUnviewableContentIdentifiedEventArgsResolver.Uri(global::Windows.UI.Xaml.Controls.WebViewUnviewableContentIdentifiedEventArgs e)
        {
            return _stubs.GetMethodStub<Uri_WebViewUnviewableContentIdentifiedEventArgs_Delegate>("Uri").Invoke(e);
        }

        public delegate global::System.Uri Uri_WebViewUnviewableContentIdentifiedEventArgs_Delegate(global::Windows.UI.Xaml.Controls.WebViewUnviewableContentIdentifiedEventArgs e);

        public StubIWebViewUnviewableContentIdentifiedEventArgsResolver Uri(Uri_WebViewUnviewableContentIdentifiedEventArgs_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }
    }
}

namespace Fievus.Windows.Samples.SimpleLoginDemo.Presentation.Login
{
    [CompilerGenerated]
    public class StubIUserAuthentication : IUserAuthentication
    {
        private readonly StubContainer<StubIUserAuthentication> _stubs = new StubContainer<StubIUserAuthentication>();

        global::Fievus.Windows.Samples.SimpleLoginDemo.Presentation.Login.UserAuthenticationResult global::Fievus.Windows.Samples.SimpleLoginDemo.Presentation.Login.IUserAuthentication.Authenticate(global::Fievus.Windows.Samples.SimpleLoginDemo.Presentation.Login.LoginContent loginContent)
        {
            return _stubs.GetMethodStub<Authenticate_LoginContent_Delegate>("Authenticate").Invoke(loginContent);
        }

        public delegate global::Fievus.Windows.Samples.SimpleLoginDemo.Presentation.Login.UserAuthenticationResult Authenticate_LoginContent_Delegate(global::Fievus.Windows.Samples.SimpleLoginDemo.Presentation.Login.LoginContent loginContent);

        public StubIUserAuthentication Authenticate(Authenticate_LoginContent_Delegate del, int count = Times.Forever, bool overwrite = false)
        {
            _stubs.SetMethodStub(del, count, overwrite);
            return this;
        }
    }
}