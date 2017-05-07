## Overview

UWP MVC is a class library for Universal Windows Platform app with Model View Controller architecture.

![UWP MVC overview](Images/mvcsummary.png)

In UWP MVC, the roles of a model, view, and controller are redefined as follows.

### Model

The model represents an object model in the presentation domain.
It has its properties, its internal states, events that occur when its internal states are changed, that are usually normal .NET events, and so on,
but does not have any business logic.
It is similar to Presentation Model, but unlike to Presentation Model, it does not have main presentaion logic.
It has only behaviors for internal states that is encapsulated.
It has also references to other models and sends messages to each other.

### View

The view represents an appearance of the model. It is defined with a DataTemplate.
As it knows a model associated with it, values of its properties are set by binding values of the model.

### Controller

The controller handles events that occur on the view by using the model associated with the view.
It has a reference to the business domain and sends a message to it to execute business logic.
Its reference to the business domain is usually injected by DI container.

The basic flow is as follows;

1. An event occurs on the view or on other domain.
1. The controller receives it and sends an appropriate message to the model.
1. The model updates its internal states.
1. The view receives the change of the model and updates its appearance.

## Features

This library provides a feature to specify a controller with an attached property to the target element.

```
<Grid xmlns:u="using:Fievus.Windows.Mvc">
    <u:UwpController.Controllers>
        <local:Controller/>
    </u:UwpController.Controllers>
</Grid>
```

A controller can be created with a factory that implements IUwpControllerFactory. If a factory is not specified, a default factory that creates a controller with Activator.CreateInstance method is used.

```
class ControllerFactory : IUwpControllerFactory {...}
```

```
UwpController.Factory = new ControllerFactory();
```

```
<Grid xmlns:u="using:Fievus.Windows.Mvc">
    <u:UwpController.Controllers>
        <u:UwpController ControllerType="TargetNamespace.Controller,TargetAssembly"/>
    </u:UwpController.Controllers>
</Grid>
```

This library also provides features to inject event handlers, a data context, and visual elements to the controller using attributes.
The available attributes are as follows.

### EventHandlerAttribute

This attribute is specified to the method to handle an event.
It is also specified to the property or the field that is defined with a delegate.
The method is declared as follows;

- No argument.
```
[EventHandler(ElementName = "ActionButton", Event = "Click")]
private void OnActionButtonClick()
{
    // implements the action.
}
```

- One argument that is a second argument of EventHandler.
```
[EventHandler(ElementName = "ActionButton", Event = "Click")]
private void OnActionButtonClick(RoutedEventArgs e)
{
    // implements the action.
}
```

- Two arguments that are a first argument and a second argument of EventHandler.
```
[EventHandler(ElementName = "ActionButton", Event = "Click")]
private void OnActionButtonClick(object sender, RoutedEventArgs e)
{
    // implements the action.
}
```

### DataContextAttribute

This attribute is specified to the field, property, or method to which a DataContext is injected.
The method has an argument the type of which is the one of a DataContext.
The implementation is as follows;

- Field
```
[DataContext]
private DataContexType context;
```

- Property
```
[DataContext]
public DataContexType Context { get; set; }
```

- Method
```
[DataContext]
public void SetContext(DataContexType context)
{
    this.context = context;
}
private DataContexType context;
```

### ElementAttribute

This attribute is specified to the field, property, or method to which an element is injected.
The method has an argument the type of which is the one of an element.
The element the name of which is equal to the one of field, property, or method is injected.
When the name of the method starts with "Set", the target name of the method is the value removed "Set" from the method name.
If the name of the element is different from the one of the field, property, or method,
the name of the element is specified to the Name property of the ElementAttribute.
The implementation to inject an element the name of which is "Element" is as follows;

- Field
```
[Element(Name = "Element")]
private UIElement element;
```

- Property
```
[Element]
public UIElement Element { get; set; }
```

- Method
```
[Element]
public void SetElement(UIElement element)
{
    this.element = element;
}
private UIElement element;
```

## LICENCE

This software is released under the MIT License, see LICENSE.