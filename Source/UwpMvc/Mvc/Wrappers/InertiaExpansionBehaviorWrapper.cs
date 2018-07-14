// Copyright (C) 2018 Fievus
//
// This software may be modified and distributed under the terms
// of the MIT license.  See the LICENSE file for details.
using Windows.UI.Xaml.Input;

namespace Charites.Windows.Mvc.Wrappers
{
    /// <summary>
    /// Provides data of the <see cref="InertiaExpansionBehavior"/>
    /// resolved by <see cref="IInertiaExpansionBehaviorResolver"/>.
    /// </summary>
    public static class InertiaExpansionBehaviorWrapper
    {
        /// <summary>
        /// Gets or sets the <see cref="IInertiaExpansionBehaviorResolver"/>
        /// that resolves data of the <see cref="InertiaExpansionBehavior"/>.
        /// </summary>
        public static IInertiaExpansionBehaviorResolver Resolver { get; set; } = new DefaultInertiaExpansionBehaviorResolver();

        /// <summary>
        /// Gets the rate that resizing slows.
        /// </summary>
        /// <param name="expansionBehavior">The requested <see cref="InertiaExpansionBehavior"/>.</param>
        /// <returns>The rate that resizing slows.</returns>
        public static double DesiredDeceleration(this InertiaExpansionBehavior expansionBehavior) => Resolver.DesiredDeceleration(expansionBehavior);

        /// <summary>
        /// Sets the rate that resizing slows.
        /// </summary>
        /// <param name="expansionBehavior">The requested <see cref="InertiaExpansionBehavior"/>.</param>
        /// <param name="desiredDeceleration">The rate that resizing slows.</param>
        public static void DesiredDeceleration(this InertiaExpansionBehavior expansionBehavior, double desiredDeceleration) => Resolver.DesiredDeceleration(expansionBehavior, desiredDeceleration);

        /// <summary>
        /// Gets the amount the element resizes at the end of inertia.
        /// </summary>
        /// <param name="expansionBehavior">The requested <see cref="InertiaExpansionBehavior"/>.</param>
        /// <returns>The amount the element resizes at the end of inertia.</returns>
        public static double DesiredExpansion(this InertiaExpansionBehavior expansionBehavior) => Resolver.DesiredExpansion(expansionBehavior);

        /// <summary>
        /// Sets the amount the element resizes at the end of inertia.
        /// </summary>
        /// <param name="expansionBehavior">The requested <see cref="InertiaExpansionBehavior"/>.</param>
        /// <param name="desiredExpansion">The amount the element resizes at the end of inertia.</param>
        public static void DesiredExpansion(this InertiaExpansionBehavior expansionBehavior, double desiredExpansion) => Resolver.DesiredExpansion(expansionBehavior, desiredExpansion);

        private sealed class DefaultInertiaExpansionBehaviorResolver : IInertiaExpansionBehaviorResolver
        {
            double IInertiaExpansionBehaviorResolver.DesiredDeceleration(InertiaExpansionBehavior expansionBehavior) => expansionBehavior.DesiredDeceleration;
            void IInertiaExpansionBehaviorResolver.DesiredDeceleration(InertiaExpansionBehavior expansionBehavior, double desiredDeceleration) => expansionBehavior.DesiredDeceleration = desiredDeceleration;
            double IInertiaExpansionBehaviorResolver.DesiredExpansion(InertiaExpansionBehavior expansionBehavior) => expansionBehavior.DesiredExpansion;
            void IInertiaExpansionBehaviorResolver.DesiredExpansion(InertiaExpansionBehavior expansionBehavior, double desiredExpansion) => expansionBehavior.DesiredExpansion = desiredExpansion;
        }
    }

    /// <summary>
    /// Resolves data of the <see cref="InertiaExpansionBehavior"/>.
    /// </summary>
    public interface IInertiaExpansionBehaviorResolver
    {
        /// <summary>
        /// Gets the rate that resizing slows.
        /// </summary>
        /// <param name="expansionBehavior">The requested <see cref="InertiaExpansionBehavior"/>.</param>
        /// <returns>The rate that resizing slows.</returns>
        double DesiredDeceleration(InertiaExpansionBehavior expansionBehavior);

        /// <summary>
        /// Sets the rate that resizing slows.
        /// </summary>
        /// <param name="expansionBehavior">The requested <see cref="InertiaExpansionBehavior"/>.</param>
        /// <param name="desiredDeceleration">The rate that resizing slows.</param>
        void DesiredDeceleration(InertiaExpansionBehavior expansionBehavior, double desiredDeceleration);

        /// <summary>
        /// Gets the amount the element resizes at the end of inertia.
        /// </summary>
        /// <param name="expansionBehavior">The requested <see cref="InertiaExpansionBehavior"/>.</param>
        /// <returns>The amount the element resizes at the end of inertia.</returns>
        double DesiredExpansion(InertiaExpansionBehavior expansionBehavior);

        /// <summary>
        /// Sets the amount the element resizes at the end of inertia.
        /// </summary>
        /// <param name="expansionBehavior">The requested <see cref="InertiaExpansionBehavior"/>.</param>
        /// <param name="desiredExpansion">The amount the element resizes at the end of inertia.</param>
        void DesiredExpansion(InertiaExpansionBehavior expansionBehavior, double desiredExpansion);
    }
}
