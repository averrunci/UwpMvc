// Copyright (C) 2017 Fievus
//
// This software may be modified and distributed under the terms
// of the MIT license.  See the LICENSE file for details.
using Xunit;

namespace Fievus.Windows.Mvc
{
    public class UwpControllerCollectionTest
    {
        [Fact]
        public void AddUwpControllerWhenIUwpControllerFactoryIsSpecified()
        {
            var controller = new TestUwpControllers.TestUwpController();
            var controllerType = controller.GetType();

            UwpController.Factory = new StubIUwpControllerFactory().Create(c => c == controllerType ? controller : null);

            var uwpController = new UwpController
            {
                ControllerType = controllerType.AssemblyQualifiedName
            };
            var controllers = new UwpControllerCollection();
            controllers.Add(uwpController);

            Assert.Equal(1, controllers.Count);
            Assert.Equal(controller, controllers[0]);
        }

        [Fact]
        public void AddUwpControllerWhenIUwpControllerFactoryIsNotSpecified()
        {
            var controllerType = typeof(TestUwpControllers.TestUwpController);

            var uwpController = new UwpController
            {
                ControllerType = controllerType.AssemblyQualifiedName
            };
            var controllers = new UwpControllerCollection();
            controllers.Add(uwpController);

            Assert.Equal(1, controllers.Count);
            Assert.IsType<TestUwpControllers.TestUwpController>(controllers[0]);
        }

        [Fact]
        public void AddUwpControllerWithSpecifiedIUwpControllerFactory()
        {
            var controller = new TestUwpControllers.TestUwpController();

            var factory = new StubIUwpControllerFactory().Create(c => c == null ? controller : null);

            var controllers = new UwpControllerCollection();
            controllers.Add(factory);

            Assert.Equal(1, controllers.Count);
            Assert.Equal(controller, controllers[0]);
        }
    }
}
