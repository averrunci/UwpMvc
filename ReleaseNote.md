# Release note

## v2.3.0

### Add

- Add wrappers.
  - DataPackageViewWrapper
  - DragUIOverrideWrapper
- Add the function to inject dependencies of parameters based on teh FromDIAttribute attribute.

### Changes

- Change the target version to version 1903.
- Change Charites version to 1.3.0.

### Bug fix

- Fixed the exclusive control of the EventArgsResolver.

## v2.2.0

### Add

- Add the following event args wrappers.
  - AnchorRequestedEventArgsWrapper
  - AutoSuggestBoxTextChangedEventArgsWrapper
  - BackClickEventArgsWrapper
  - BringIntoViewRequestedEventArgsWrapper
  - CharacterReeivedRoutedEventArgsWrapper
  - CleanUpVirtualizedItemEventArgsWrapper
  - ColorChangedEventArgsWrapper
  - ComboBoxTextSubmittedEventArgsWrapper
  - ContentDialogButtonClickEventArgsWrapper
  - ContentLinkChangedEventArgsWrapper
  - ContentLinkInvokedEventArgsWrapper
  - EffectiveViewportChangedEventArgsWrapper
  - InkToolBarIsStencilButtonCheckedChangedEventArgsWrapper
  - LosingFocusEventArgsWrapper
  - MapContentRequestedEventArgsWrapper
  - NavigationViewDisplayModeChangedEventArgsWrapper
  - NavigationViewItemInvokedEventArgsWrapper
  - NavigationViewPaneClosingEventArgsWrapper
  - NoFocusCandidateFoundEventArgsWrapper
  - PasswordBoxPasswordChangingEventArgsWrapper
  - PivotItemEventArgsWrapper
  - ProcessKeyboardAcceleratorEventArgsWrapper
  - RefreshRequestedEventArgsWrapper
  - RefreshStateChangedEventArgsWrapper
  - RichEditBoxSelectionChangingEventArgsWrapper
  - RichEditBoxTextChangingEventArgsWrapper
  - SemanticZoomViewChangedEventArgsWrapper
  - TextBoxBeforeTextChangingEventArgsWrapper
  - TextBoxSelectionChangingEventArgsWrapper
  - TextControlCopyingToClipboardEventArgsWrapper
  - TextControlCuttingtoClipboardEventArgsWrapper
  - TimePickerSelectedValueChangedEventArgsWrapper
  - TreeViewDragItemsCompletedEventArgsWrapper
  - TreeViewDragItemsStartingEventArgsWrapper
  - WebViewWebResourceRequestedEventArgsWrapper
- Add the method to the following event args wrappers.
  - DragEventArgsWrapper
  - FocusEngagedEventArgsWrapper
  - NavigationEventArgsWrapper
  - PointerRoutedEventArgsWrapper
  - TreeViewCollapsedEventArgsWrapper
  - TreeViewExpandingEventArgsWrapper
  - WebViewUnviewableContentIdentifiedEventArgsWrapper

### Changes

- Change the target version to version 1809.
- Change Charites version to 1.2.0.
- Change Charites.Bindings version to 1.2.0.
- Change to be able to specify multiple EventArgsResolver.

### Bux fix

- Fixed the method name of the wrapper class to add the suffix "Wrapped".

## v2.1.0

### Add

- Add the UnhandledException event to the UwpController.

### Bug fix

- Fixed how to decide whether an event handler is the routed event handler.

## v2.0.1

### Add

- Add wrappers.
  - TreeViewCollapsedEventArgsWrapper
  - TreeViewExpandingEventArgsWrapper
  - TreeViewItemInvokedEvetArgsWrapper

### Changes

- Change the target version to version 1803.

### Bug fix

- Fixed to be able to search the DataTemplate in resources of the container with the DataTypeDataTemplateSelector too.
- Fixed to attach controllers correctly when the DataTypeDataTemplateSelector is set to the ItemTemplateSelector.
- Fixed not to find the controller of the same type when to find the type of the controller with the UwpControllerTypeFinder.

## v2.0.0

### Add

- Add EventArgsResolverScope that makes a code block for a resolver of an event args wrapper. It can be used by calling the Using method of the UwpController.

### Changes

- Move bindings properties to the Charites.Bindings assembly.
- Move attributes and base implementations to the Charites assembly.
- Remove the Controllers attached property of the UwpController. The controller is specified using the ViewAttribute.
- Change the namespace from Fievus to Charites.
- Change the testing framework from xUnit to Carna.

## v1.3.0

### Add

- Add BindTwoWay method with converters that convert the value from/to the source value.
- Add IElementInjector that injects elements in a target element to the WPF controller.
- Add IDataContextInjector that injects a data context to the WPF controller.
- Add ElementInjectionException that is thrown when an element injection is failed.
- Add DataContextInjectionException that is thrown when a data context injection is failed.
- Add EditableContentProperty that represents a property value that can be edited with a dedicated content.
- Add EditableTextProperty that represents a property of a text that can be edited with a dedicated content using a text control.
- Add EditableSelectionProperty that represents a property value that can be selected with a dedicated content using a selection control.

### Changes

- Change RoutedEventHandlerAction class from a nested class to an independent class.
- Change the way to select DataTemplate using DataTypeDataTemplateSelector. It searches the implemeted interfaces and generic types. The full name of the generic type can be specified the one with/without the typed parameter name.

### Bug fix

- Fixed the way to get a full name of a data type when selecting DataTemplate using DataTypeDataTemplateSelector.

## v1.2.2

### Bug fix

- Fixed the name value of DisplayNameAttribute when it is retrieved from a resource.
- Fixed the implementation of DefaultAccessKeyDisplayRequestedEventArgsResolver.

## v1.2.1

### Changes

- Change the type of the element specified by ElementAttribute. Its type is not only FrameworkElement but also any object.
- Change the way of selecting DataTemplate using DataTypeDataTemplateSelector. It selects one including the full name of the data type, too.

## v1.2.0

### Add

- Add RaiseAsync method to EventHandlerBase.Executor class so that an async event handler can be awaited.
- Add foundElementOnly parameter to SetElement method of the UwpController class. If its value is true, an element is not set to the UWP controller when it is not found in the specified element; otherwise, null is set. Its default value is false.

### Changes

- Change the event call when an element is attached to a controller. The DataContextChanged event whose EventArgs is null is raised before the Loaded event is raised.

## v1.1.0

### Add

- Add the method of ObservableProperty that binds some observable properties.

### Changes

- Change the way of selecting DataTemplate using DataTypeDataTemplateSelector. It selects one including the name of base type, too.
