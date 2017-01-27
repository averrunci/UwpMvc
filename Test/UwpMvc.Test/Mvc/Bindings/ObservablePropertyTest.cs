// Copyright (C) 2017 Fievus
//
// This software may be modified and distributed under the terms
// of the MIT license.  See the LICENSE file for details.
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;

using Xunit;

namespace Fievus.Windows.Mvc.Bindings.ObservablePropertyTest
{
    public class ObservableProperty_InstanceCreation
    {
        [Fact]
        public void CreatesWithDefaultInitialValue()
        {
            var property = new ObservableProperty<string>();

            Assert.Null(property.Value);
        }

        [Fact]
        public void CreatesWithSpecifiedInitialValue()
        {
            var property = new ObservableProperty<string>("Test");

            Assert.Equal("Test", property.Value);
        }

        [Fact]
        public void CreatesWithSpecifiedInitialValueWithFactoryMethod()
        {
            Assert.Equal("Test", ObservableProperty<string>.Of("Test").Value);
        }
    }

    public class ObservableProperty_PropertyChanged
    {
        [Fact]
        public void RaisesPropertyChangedEventWhenNotNullValueIsSet()
        {
            var propertyChangedOccurred = false;
            var property = ObservableProperty<string>.Of("Test");
            property.PropertyChanged += (s, e) => propertyChangedOccurred = (e.PropertyName == "Value");

            property.Value = "Changed";

            Assert.True(propertyChangedOccurred);
        }

        [Fact]
        public void RaisesPropertyChangedEventWhenNullValueIsSet()
        {
            var propertyChangedOccurred = false;
            var property = ObservableProperty<string>.Of("Test");
            property.PropertyChanged += (s, e) => propertyChangedOccurred = (e.PropertyName == "Value");

            property.Value = null;

            Assert.True(propertyChangedOccurred);
        }

        [Fact]
        public void DoesNotRaisePropertyChangedEventWhenTheSameValueIsSet()
        {
            var propertyChangedOccurred = false;
            var property = ObservableProperty<string>.Of("Test");
            property.PropertyChanged += (s, e) => propertyChangedOccurred = true;

            property.Value = "Test";

            Assert.False(propertyChangedOccurred);
        }

        [Fact]
        public void DoesNotRaisePropertyChangedEventWhenNullIsSetToItWhoseValueIsNull()
        {
            var propertyChangedOccurred = false;
            var property = ObservableProperty<string>.Of(null);
            property.PropertyChanged += (s, e) => propertyChangedOccurred = true;

            property.Value = null;

            Assert.False(propertyChangedOccurred);
        }

        [Fact]
        public void RaisesPropertyChangedEventWhenNotNullValueIsSetToItWhoseValueIsNull()
        {
            var propertyChangedOccurred = false;
            var property = ObservableProperty<string>.Of("Changed");
            property.PropertyChanged += (s, e) => propertyChangedOccurred = (e.PropertyName == "Value");

            property.Value = null;

            Assert.True(propertyChangedOccurred);
        }
    }

    public class ObservableProperty_OneWayBinding
    {
        [Fact]
        public void BindsSpecifiedObservableProperty()
        {
            var property1 = ObservableProperty<string>.Of("Test1");
            var property2 = ObservableProperty<string>.Of("Test2");

            property1.Bind(property2);
            Assert.Equal("Test2", property1.Value);
            Assert.Equal("Test2", property2.Value);

            property2.Value = "Changed";
            Assert.Equal("Changed", property1.Value);
            Assert.Equal("Changed", property2.Value);

            property1.Value = "Test";
            Assert.Equal("Test", property1.Value);
            Assert.Equal("Changed", property2.Value);
        }

        [Fact]
        public void UnbindsBoundObservableProperty()
        {
            var property1 = ObservableProperty<string>.Of("Test1");
            var property2 = ObservableProperty<string>.Of("Test2");

            property1.Bind(property2);
            Assert.Equal("Test2", property1.Value);
            Assert.Equal("Test2", property2.Value);

            property1.Unbind();

            property2.Value = "Changed";
            Assert.Equal("Test2", property1.Value);
            Assert.Equal("Changed", property2.Value);
        }

        [Fact]
        public void ThrowsExceptionWhenObservablePropertyWhichIsBoundBind()
        {
            var property1 = ObservableProperty<string>.Of("Test1");
            var property2 = ObservableProperty<string>.Of("Test2");

            property1.Bind(property2);

            Assert.Throws<InvalidOperationException>(() => property1.Bind(property2));
        }

        [Fact]
        public void ThrowsExceptionWhenObservablePropertyWhichIsNotBoundUnbind()
        {
            var property1 = ObservableProperty<string>.Of("Test1");

            Assert.Throws<InvalidOperationException>(() => property1.Unbind());
        }
    }

    public class ObservableProperty_OneWayWithConverterBinding
    {
        [Fact]
        public void BindsSpecifiedObservablePropertyWithConverter()
        {
            var property1 = ObservableProperty<string>.Of("Test1");
            var property2 = ObservableProperty<int>.Of(3);

            property1.Bind(property2, t => t.ToString());
            Assert.Equal("3", property1.Value);
            Assert.Equal(3, property2.Value);

            property2.Value = 7;
            Assert.Equal("7", property1.Value);
            Assert.Equal(7, property2.Value);

            property1.Value = "Test";
            Assert.Equal("Test", property1.Value);
            Assert.Equal(7, property2.Value);
        }

        [Fact]
        public void UnbindsBoundObservablePropertyWithConverter()
        {
            var property1 = ObservableProperty<string>.Of("Test1");
            var property2 = ObservableProperty<int>.Of(3);

            property1.Bind(property2, t => t.ToString());
            Assert.Equal("3", property1.Value);
            Assert.Equal(3, property2.Value);

            property1.Unbind();

            property2.Value = 7;
            Assert.Equal("3", property1.Value);
            Assert.Equal(7, property2.Value);
        }

        [Fact]
        public void ThrowsExceptionWhenObservablePropertyWhichIsBoundBindWithConverter()
        {
            var property1 = ObservableProperty<string>.Of("Test1");
            var property2 = ObservableProperty<int>.Of(3);

            property1.Bind(property2, t => t.ToString());

            Assert.Throws<InvalidOperationException>(() => property1.Bind(property2, t => t.ToString()));
        }
    }

    public class ObservableProperty_TwoWayBinding
    {
        [Fact]
        public void BindsSpecifiedObservablePropertyAsTwoWay()
        {
            var property1 = ObservableProperty<string>.Of("Test1");
            var property2 = ObservableProperty<string>.Of("Test2");

            property1.BindTwoWay(property2);
            Assert.Equal("Test2", property1.Value);
            Assert.Equal("Test2", property2.Value);

            property2.Value = "Changed";
            Assert.Equal("Changed", property1.Value);
            Assert.Equal("Changed", property2.Value);

            property1.Value = "Test";
            Assert.Equal("Test", property1.Value);
            Assert.Equal("Test", property2.Value);
        }

        [Fact]
        public void UnbindsBoundObservablePropertyAsTwoWay()
        {
            var property1 = ObservableProperty<string>.Of("Test1");
            var property2 = ObservableProperty<string>.Of("Test2");

            property1.BindTwoWay(property2);
            Assert.Equal("Test2", property1.Value);
            Assert.Equal("Test2", property2.Value);

            property1.UnbindTwoWay(property2);

            property2.Value = "Changed";
            Assert.Equal("Test2", property1.Value);
            Assert.Equal("Changed", property2.Value);
        }

        [Fact]
        public void ThrowsExceptionWhenObservablePropertyWhichIsBoundBindAsTwoWay()
        {
            var property1 = ObservableProperty<string>.Of("Test1");
            var property2 = ObservableProperty<string>.Of("Test2");

            property1.BindTwoWay(property2);

            Assert.Throws<InvalidOperationException>(() => property1.BindTwoWay(property2));
        }

        [Fact]
        public void ThrowsExceptionWhenObservablePropertyWhichIsNotBoundUnbindAsTwoWay()
        {
            var property1 = ObservableProperty<string>.Of("Test1");
            var property2 = ObservableProperty<string>.Of("Test2");

            Assert.Throws<InvalidOperationException>(() => property1.UnbindTwoWay(property2));
        }
    }

    public class ObservableProperty_PropertyValueChanging
    {
        [Fact]
        public void AddsPropertyValueChangingHandler()
        {
            var property = new ObservableProperty<string>();
            property.PropertyValueChanging += (s, e) =>
            {
                Assert.Null(e.OldValue);
                Assert.Equal("Changed", e.NewValue);
            };

            property.Value = "Changed";

            Assert.Equal("Changed", property.Value);
        }

        [Fact]
        public void AddsPropertyValueChangingHandlerWithCancelingValueChanged()
        {
            var property = ObservableProperty<string>.Of("Test");
            property.PropertyValueChanging += (s, e) =>
            {
                Assert.Equal("Test", e.OldValue);
                Assert.Equal("Changed", e.NewValue);
                e.Disable();
            };

            property.Value = "Changed";

            Assert.Equal("Test", property.Value);
        }
    }

    public class ObservableProperty_PropertyValueChanged
    {
        [Fact]
        public void AddsPropertyValueChangedHandler()
        {
            var property = new ObservableProperty<string>();
            property.PropertyValueChanged += (s, e) =>
            {
                Assert.Null(e.OldValue);
                Assert.Equal("Changed", e.NewValue);
            };

            property.Value = "Changed";

            Assert.Equal("Changed", property.Value);
        }
    }

    public class ObservableProperty_Validation : IDisposable
    {
        public ObservableProperty<string> PropertyNotAnnotatedValidation { get { return propertyNotAnnotatedValidation; } }
        private ObservableProperty<string> propertyNotAnnotatedValidation;

        [Display(Name = "String Expression")]
        [StringLength(10, ErrorMessage = "Please enter {0} within {1} characters.")]
        public ObservableProperty<string> PropertyAnnotatedValidation { get { return propertyAnnotatedValidation; } }
        private ObservableProperty<string> propertyAnnotatedValidation;

        [StringLength(6, ErrorMessage = "Please enter within {1} characters.")]
        [RegularExpression("\\d+", ErrorMessage = "Please enter a digit only.")]
        public ObservableProperty<string> PropertyAnnotatedMultiValidations { get { return propertyAnnotatedMultiValidations; } }
        private ObservableProperty<string> propertyAnnotatedMultiValidations;

        [Required(ErrorMessage = "Please enter a value.")]
        public ObservableProperty<string> RequiredProperty { get { return requiredProperty; } }
        private ObservableProperty<string> requiredProperty;

        private readonly PropertyValueValidateEventHandler<string> propertyValueValidate = (s, e) =>
        {
            if (e.Value != "Correct")
            {
                e.Add("The value does not correct.");
            }
        };

        private bool errorsChangedOccurred;
        private readonly EventHandler<DataErrorsChangedEventArgs> errorsChangedVerificationHandler;

        public ObservableProperty_Validation()
        {
            errorsChangedVerificationHandler = (s, e) =>
            {
                Assert.Equal("Value", e.PropertyName);
                errorsChangedOccurred = true;
            };

            propertyNotAnnotatedValidation = new ObservableProperty<string>();
            propertyAnnotatedValidation = new ObservableProperty<string>();
            propertyAnnotatedMultiValidations = new ObservableProperty<string>();
            requiredProperty = new ObservableProperty<string>();

            PropertyNotAnnotatedValidation.EnableValidation(() => PropertyNotAnnotatedValidation);
            PropertyAnnotatedValidation.EnableValidation(() => PropertyAnnotatedValidation);
            PropertyAnnotatedMultiValidations.EnableValidation(() => PropertyAnnotatedMultiValidations);
            RequiredProperty.EnableValidation(() => RequiredProperty);
        }

        public void Dispose()
        {
            PropertyNotAnnotatedValidation.DisableValidation();
            PropertyAnnotatedValidation.DisableValidation();
            PropertyAnnotatedMultiValidations.DisableValidation();
            RequiredProperty.DisableValidation();
        }

        private void SetValue<T>(T value, ObservableProperty<T> property)
        {
            errorsChangedOccurred = false;
            property.ErrorsChanged += errorsChangedVerificationHandler;
            property.Value = value;
            property.ErrorsChanged -= errorsChangedVerificationHandler;
        }

        private void AssertNoValidationError<T>(ObservableProperty<T> property)
        {
            Assert.Empty(property.Error);
            Assert.Empty(property.Errors);
            Assert.False((property as INotifyDataErrorInfo).HasErrors);
            Assert.Empty((property as INotifyDataErrorInfo).GetErrors("Value"));
        }

        private void AssertValidationError<T>(ObservableProperty<T> property, params string[] messages)
        {
            var expectedMessage = string.Join(Environment.NewLine, messages);

            Assert.Equal(expectedMessage, property.Error);
            Assert.Equal(messages.OrderBy(m => m), property.Errors.OrderBy(m => m));
            Assert.True((property as INotifyDataErrorInfo).HasErrors);
            Assert.Equal(messages.OrderBy(m => m), (property as INotifyDataErrorInfo).GetErrors("Value").OfType<string>().OrderBy(m => m));
        }

        [Fact]
        public void DoesNotGetErrorWhenValidationAttributeNotAnnotated()
        {
            SetValue("Changed", PropertyNotAnnotatedValidation);

            AssertNoValidationError(PropertyNotAnnotatedValidation);
            Assert.False(errorsChangedOccurred);
        }

        [Fact]
        public void GetsErrorForInvalidPropertyWhenValidationAttributeIsAnnotated()
        {
            SetValue("ABCDEFGHIJK", PropertyAnnotatedValidation);

            AssertValidationError(
                PropertyAnnotatedValidation,
                "Please enter String Expression within 10 characters."
            );
            Assert.True(errorsChangedOccurred);
        }

        [Fact]
        public void DoesNotGetErrorForValidPropertyWhenValidationAttributeIsAnnotated()
        {
            SetValue("ABCDEFGHIJK", PropertyAnnotatedValidation);

            AssertValidationError(
                PropertyAnnotatedValidation,
                "Please enter String Expression within 10 characters."
            );
            Assert.True(errorsChangedOccurred);


            SetValue("ABCDEFGHIJ", PropertyAnnotatedValidation);

            Assert.True(errorsChangedOccurred);
            AssertNoValidationError(PropertyAnnotatedValidation);
        }

        [Fact]
        public void GetsMultiErrorsForInvalidPropertyWhenMultiValidationAttributesAreAnnotated()
        {
            SetValue("ABCDEFG", PropertyAnnotatedMultiValidations);

            AssertValidationError(
                PropertyAnnotatedMultiValidations,
                "Please enter within 6 characters.",
                "Please enter a digit only."
            );
            Assert.True(errorsChangedOccurred);
        }

        [Fact]
        public void DoesNotGetsErrorForValidPropertyWhenMultiValidationAttributesAreAnnotated()
        {
            SetValue("ABCDEFG", PropertyAnnotatedMultiValidations);

            AssertValidationError(
                PropertyAnnotatedMultiValidations,
                "Please enter within 6 characters.",
                "Please enter a digit only."
            );
            Assert.True(errorsChangedOccurred);

            SetValue("123456", PropertyAnnotatedMultiValidations);

            AssertNoValidationError(PropertyAnnotatedMultiValidations);
            Assert.True(errorsChangedOccurred);
        }

        [Fact]
        public void GetsErrorForInvalidPropertyWhenValidationEventIsRegistered()
        {
            PropertyNotAnnotatedValidation.PropertyValueValidate += propertyValueValidate;
            SetValue("ABCDEFGHIJK", PropertyNotAnnotatedValidation);

            AssertValidationError(
                PropertyNotAnnotatedValidation,
                "The value does not correct."
            );
            Assert.True(errorsChangedOccurred);
        }

        [Fact]
        public void DoesNotGetErrorForValidPropertyWhenValidationEventIsRegistered()
        {
            PropertyNotAnnotatedValidation.PropertyValueValidate += propertyValueValidate;
            SetValue("ABCDEFGHIJK", PropertyNotAnnotatedValidation);

            AssertValidationError(
                PropertyNotAnnotatedValidation,
                "The value does not correct."
            );
            Assert.True(errorsChangedOccurred);


            SetValue("Correct", PropertyNotAnnotatedValidation);

            Assert.True(errorsChangedOccurred);
            AssertNoValidationError(PropertyNotAnnotatedValidation);
        }

        [Fact]
        public void GetsErrorForInvalidPropertyWhenValidationAttributeIsAnnotatedAndValidationEventIsRegistered()
        {
            PropertyAnnotatedValidation.PropertyValueValidate += propertyValueValidate;
            SetValue("ABCDEFGHIJK", PropertyAnnotatedValidation);

            AssertValidationError(
                PropertyAnnotatedValidation,
                "Please enter String Expression within 10 characters.",
                "The value does not correct."
            );
            Assert.True(errorsChangedOccurred);
        }

        [Fact]
        public void DoesNotGetErrorForValidPropertyWhenValidationAttributeIsAnnotatedAndValidationEventIsRegistered()
        {
            PropertyAnnotatedValidation.PropertyValueValidate += propertyValueValidate;
            SetValue("ABCDEFGHIJK", PropertyAnnotatedValidation);

            AssertValidationError(
                PropertyAnnotatedValidation,
                "Please enter String Expression within 10 characters.",
                "The value does not correct."
            );
            Assert.True(errorsChangedOccurred);


            SetValue("Correct", PropertyAnnotatedValidation);

            Assert.True(errorsChangedOccurred);
            AssertNoValidationError(PropertyAnnotatedValidation);
        }

        [Fact]
        public void CancelsChangeOfValueWhenValueIsInvalidBySettingTrueToMethodParameter()
        {
            PropertyAnnotatedValidation.EnableValidation(() => PropertyAnnotatedValidation, true);

            PropertyAnnotatedValidation.Value = "ABCDEFGHIJ";
            Assert.Equal("ABCDEFGHIJ", PropertyAnnotatedValidation.Value);

            PropertyAnnotatedValidation.Value = "ABCDEFGHIJK";
            Assert.Equal("ABCDEFGHIJ", PropertyAnnotatedValidation.Value);
        }

        [Fact]
        public void EnsuresThatPropertyValueIsValidated()
        {
            RequiredProperty.EnsureValidation();

            AssertValidationError(RequiredProperty, "Please enter a value.");
        }
    }
}
