# Release note

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
