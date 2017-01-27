// Copyright (C) 2017 Fievus
//
// This software may be modified and distributed under the terms
// of the MIT license.  See the LICENSE file for details.
using Windows.UI.Xaml.Input;

namespace Fievus.Windows.Mvc.Wrappers
{
    /// <summary>
    /// Provides data of the <see cref="InertiaTranslationBehavior"/>
    /// resolved by <see cref="IInertiaTranslationBehaviorResolver"/>.
    /// </summary>
    public static class InertiaTranslationBehaviorWrapper
    {
        /// <summary>
        /// Gets or sets the <see cref="IInertiaTranslationBehaviorResolver"/>
        /// that resolves data of the <see cref="InertiaTranslationBehavior"/>.
        /// </summary>
        public static IInertiaTranslationBehaviorResolver Resolver { get; set; } = new DefaultInertiaTrnaslationBehaviorResolver();

        /// <summary>
        /// Gets the rate the linear movement slows in device-independent units (1/96th inch per unit)
        /// per squared millisecond.
        /// </summary>
        /// <param name="translationBehavior">The requested <see cref="InertiaTranslationBehavior"/>.</param>
        /// <returns>
        /// The rate the linear movement slows in device-independent units (1/96th inch per unit)
        /// per squared millisecond.
        /// </returns>
        public static double DesiredDeceleration(this InertiaTranslationBehavior translationBehavior) => Resolver.DesiredDeceleration(translationBehavior);

        /// <summary>
        /// Sets the rate the linear movement slows in device-independent units (1/96th inch per unit)
        /// per squared millisecond.
        /// </summary>
        /// <param name="translationBehavior">The requested <see cref="InertiaTranslationBehavior"/>.</param>
        /// <param name="desiredDeceleration">
        /// The rate the linear movement slows in device-independent units (1/96th inch per unit)
        /// per squared millisecond.
        /// </param>
        public static void DesiredDeceleration(this InertiaTranslationBehavior translationBehavior, double desiredDeceleration) => Resolver.DesiredDeceleration(translationBehavior, desiredDeceleration);

        /// <summary>
        /// Gets the linear movement of the manipulation at the end of inertia.
        /// </summary>
        /// <param name="translationBehavior">The requested <see cref="InertiaTranslationBehavior"/>.</param>
        /// <returns>The linear movement of the manipulation at the end of inertia.</returns>
        public static double DesiredDisplacement(this InertiaTranslationBehavior translationBehavior) => Resolver.DesiredDisplacement(translationBehavior);

        /// <summary>
        /// Sets the linear movement of the manipulation at the end of inertia.
        /// </summary>
        /// <param name="translationBehavior">The requested <see cref="InertiaTranslationBehavior"/>.</param>
        /// <param name="desiredDeisplacement">The linear movement of the manipulation at the end of inertia.</param>
        public static void DesiredDisplacement(this InertiaTranslationBehavior translationBehavior, double desiredDeisplacement) => Resolver.DesiredDisplacement(translationBehavior, desiredDeisplacement);

        private sealed class DefaultInertiaTrnaslationBehaviorResolver : IInertiaTranslationBehaviorResolver
        {
            double IInertiaTranslationBehaviorResolver.DesiredDeceleration(InertiaTranslationBehavior translationBehavior) => translationBehavior.DesiredDeceleration;
            void IInertiaTranslationBehaviorResolver.DesiredDeceleration(InertiaTranslationBehavior translationBehavior, double desiredDeceleration) => translationBehavior.DesiredDeceleration = desiredDeceleration;
            double IInertiaTranslationBehaviorResolver.DesiredDisplacement(InertiaTranslationBehavior translationBehavior) => translationBehavior.DesiredDisplacement;
            void IInertiaTranslationBehaviorResolver.DesiredDisplacement(InertiaTranslationBehavior translationBehavior, double desiredDeisplacement) => translationBehavior.DesiredDisplacement = desiredDeisplacement;
        }
    }

    /// <summary>
    /// Resolves data of the <see cref="InertiaTranslationBehavior"/>.
    /// </summary>
    public interface IInertiaTranslationBehaviorResolver
    {
        /// <summary>
        /// Gets the rate the linear movement slows in device-independent units (1/96th inch per unit)
        /// per squared millisecond.
        /// </summary>
        /// <param name="translationBehavior">The requested <see cref="InertiaTranslationBehavior"/>.</param>
        /// <returns>
        /// The rate the linear movement slows in device-independent units (1/96th inch per unit)
        /// per squared millisecond.
        /// </returns>
        double DesiredDeceleration(InertiaTranslationBehavior translationBehavior);

        /// <summary>
        /// Sets the rate the linear movement slows in device-independent units (1/96th inch per unit)
        /// per squared millisecond.
        /// </summary>
        /// <param name="translationBehavior">The requested <see cref="InertiaTranslationBehavior"/>.</param>
        /// <param name="desiredDeceleration">
        /// The rate the linear movement slows in device-independent units (1/96th inch per unit)
        /// per squared millisecond.
        /// </param>
        void DesiredDeceleration(InertiaTranslationBehavior translationBehavior, double desiredDeceleration);

        /// <summary>
        /// Gets the linear movement of the manipulation at the end of inertia.
        /// </summary>
        /// <param name="translationBehavior">The requested <see cref="InertiaTranslationBehavior"/>.</param>
        /// <returns>The linear movement of the manipulation at the end of inertia.</returns>
        double DesiredDisplacement(InertiaTranslationBehavior translationBehavior);

        /// <summary>
        /// Sets the linear movement of the manipulation at the end of inertia.
        /// </summary>
        /// <param name="translationBehavior">The requested <see cref="InertiaTranslationBehavior"/>.</param>
        /// <param name="desiredDeisplacement">The linear movement of the manipulation at the end of inertia.</param>
        void DesiredDisplacement(InertiaTranslationBehavior translationBehavior, double desiredDeisplacement);
    }
}
