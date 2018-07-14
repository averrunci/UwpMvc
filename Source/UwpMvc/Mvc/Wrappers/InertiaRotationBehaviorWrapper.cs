// Copyright (C) 2018 Fievus
//
// This software may be modified and distributed under the terms
// of the MIT license.  See the LICENSE file for details.
using Windows.UI.Xaml.Input;

namespace Charites.Windows.Mvc.Wrappers
{
    /// <summary>
    /// Provides data of the <see cref="InertiaRotationBehavior"/>
    /// resolved by <see cref="IInertiaRotationBehaviorResolver"/>.
    /// </summary>
    public static class InertiaRotationBehaviorWrapper
    {
        /// <summary>
        /// Gets or sets the <see cref="IInertiaRotationBehaviorResolver"/>
        /// that resolves data of the <see cref="InertiaRotationBehavior"/>.
        /// </summary>
        public static IInertiaRotationBehaviorResolver Resolver { get; set; } = new DefaultInertiaRotationBehaviorResolver();

        /// <summary>
        /// Gets the rate the rotation slows in degrees per squared millisecond.
        /// </summary>
        /// <param name="rotationBehavior">The requested <see cref="InertiaRotationBehavior"/>.</param>
        /// <returns>The rate the rotation slows in degrees per squared millisecond.</returns>
        public static double DesiredDeceleration(this InertiaRotationBehavior rotationBehavior) => Resolver.DesiredDeceleration(rotationBehavior);

        /// <summary>
        /// Sets the rate the rotation slows in degrees per squared millisecond.
        /// </summary>
        /// <param name="rotationBehavior">The requested <see cref="InertiaRotationBehavior"/>.</param>
        /// <param name="desiredDeceleration">The rate the rotation slows in degrees per squared millisecond.</param>
        public static void DesiredDeceleration(this InertiaRotationBehavior rotationBehavior, double desiredDeceleration) => Resolver.DesiredDeceleration(rotationBehavior, desiredDeceleration);

        /// <summary>
        /// Gets the rotation, in degrees, at the end of the inertial movement.
        /// </summary>
        /// <param name="rotationBehavior">The requested <see cref="InertiaRotationBehavior"/>.</param>
        /// <returns>The rotation, in degrees, at the end of the inertial movement.</returns>
        public static double DesiredRotation(this InertiaRotationBehavior rotationBehavior) => Resolver.DesiredRotation(rotationBehavior);

        /// <summary>
        /// Sets the rotation, in degrees, at the end of the inertial movement.
        /// </summary>
        /// <param name="rotationBehavior">The requested <see cref="InertiaRotationBehavior"/>.</param>
        /// <param name="desiredRotation">The rotation, in degrees, at the end of the inertial movement.</param>
        public static void DesiredRotation(this InertiaRotationBehavior rotationBehavior, double desiredRotation) => Resolver.DesiredRotation(rotationBehavior, desiredRotation);

        private sealed class DefaultInertiaRotationBehaviorResolver : IInertiaRotationBehaviorResolver
        {
            double IInertiaRotationBehaviorResolver.DesiredDeceleration(InertiaRotationBehavior rotationBehavior) => rotationBehavior.DesiredDeceleration;
            void IInertiaRotationBehaviorResolver.DesiredDeceleration(InertiaRotationBehavior rotationBehavior, double desiredDeceleration) => rotationBehavior.DesiredDeceleration = desiredDeceleration;
            double IInertiaRotationBehaviorResolver.DesiredRotation(InertiaRotationBehavior rotationBehavior) => rotationBehavior.DesiredRotation;
            void IInertiaRotationBehaviorResolver.DesiredRotation(InertiaRotationBehavior rotationBehavior, double desiredRotation) => rotationBehavior.DesiredRotation = desiredRotation;
        }
    }

    /// <summary>
    /// Resolves data of the <see cref="InertiaRotationBehavior"/>.
    /// </summary>
    public interface IInertiaRotationBehaviorResolver
    {
        /// <summary>
        /// Gets the rate the rotation slows in degrees per squared millisecond.
        /// </summary>
        /// <param name="rotationBehavior">The requested <see cref="InertiaRotationBehavior"/>.</param>
        /// <returns>The rate the rotation slows in degrees per squared millisecond.</returns>
        double DesiredDeceleration(InertiaRotationBehavior rotationBehavior);

        /// <summary>
        /// Sets the rate the rotation slows in degrees per squared millisecond.
        /// </summary>
        /// <param name="rotationBehavior">The requested <see cref="InertiaRotationBehavior"/>.</param>
        /// <param name="desiredDeceleration">The rate the rotation slows in degrees per squared millisecond.</param>
        void DesiredDeceleration(InertiaRotationBehavior rotationBehavior, double desiredDeceleration);

        /// <summary>
        /// Gets the rotation, in degrees, at the end of the inertial movement.
        /// </summary>
        /// <param name="rotationBehavior">The requested <see cref="InertiaRotationBehavior"/>.</param>
        /// <returns>The rotation, in degrees, at the end of the inertial movement.</returns>
        double DesiredRotation(InertiaRotationBehavior rotationBehavior);

        /// <summary>
        /// Sets the rotation, in degrees, at the end of the inertial movement.
        /// </summary>
        /// <param name="rotationBehavior">The requested <see cref="InertiaRotationBehavior"/>.</param>
        /// <param name="desiredRotation">The rotation, in degrees, at the end of the inertial movement.</param>
        void DesiredRotation(InertiaRotationBehavior rotationBehavior, double desiredRotation);
    }
}
