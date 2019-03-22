// Copyright (C) 2019 Fievus
//
// This software may be modified and distributed under the terms
// of the MIT license.  See the LICENSE file for details.
using Windows.Foundation;
using Windows.UI.Xaml;

namespace Charites.Windows.Mvc.Wrappers
{
    /// <summary>
    /// Provides data of the <see cref="BringIntoViewRequestedEventArgs"/>
    /// resolved by <see cref="IBringIntoViewRequestedEventArgsResolver"/>.
    /// </summary>
    public static class BringIntoViewRequestedEventArgsWrapper
    {
        /// <summary>
        /// Gets or sets the <see cref="IBringIntoViewRequestedEventArgsResolver"/>
        /// that resolves data of the <see cref="BringIntoViewRequestedEventArgs"/>.
        /// </summary>
        public static IBringIntoViewRequestedEventArgsResolver Resolver { get; set; } = new DefaultBringIntoViewRequestedEventArgsResolver();

        /// <summary>
        /// Gets the element that should be made visible in response to the event.
        /// </summary>
        /// <param name="e">The requested <see cref="BringIntoViewRequestedEventArgs"/>.</param>
        /// <returns>The element that should be made visible in response to the event.</returns>
        public static UIElement TargetElement(this BringIntoViewRequestedEventArgs e) => Resolver.TargetElement(e);

        /// <summary>
        /// Sets the element that should be made visible in response to the event.
        /// </summary>
        /// <param name="e">The requested <see cref="BringIntoViewRequestedEventArgs"/>.</param>
        /// <param name="targetElement">The element that should be made visible in response to the event.</param>
        public static void TargetElement(this BringIntoViewRequestedEventArgs e, UIElement targetElement) => Resolver.TargetElement(e, targetElement);

        /// <summary>
        /// Gets a value that specifies whether the scrolling should be animated.
        /// </summary>
        /// <param name="e">The requested <see cref="BringIntoViewRequestedEventArgs"/>.</param>
        /// <returns><c>true</c> to animate the scrolling; otherwise, <c>false</c>.</returns>
        public static bool AnimationDesired(this BringIntoViewRequestedEventArgs e) => Resolver.AnimationDesired(e);

        /// <summary>
        /// Sets a value that specifies whether the scrolling should be animated.
        /// </summary>
        /// <param name="e">The requested <see cref="BringIntoViewRequestedEventArgs"/>.</param>
        /// <param name="animationDesired"><c>true</c> to animate the scrolling; otherwise, <c>false</c>.</param>
        public static void AnimationDesired(this BringIntoViewRequestedEventArgs e, bool animationDesired) => Resolver.AnimationDesired(e, animationDesired);

        /// <summary>
        /// Gets the Rect in the TargetElement’s coordinate space to bring into view.
        /// </summary>
        /// <param name="e">The requested <see cref="BringIntoViewRequestedEventArgs"/>.</param>
        /// <returns>The Rect in the TargetElement’s coordinate space to bring into view.</returns>
        public static Rect TargetRect(this BringIntoViewRequestedEventArgs e) => Resolver.TargetRect(e);

        /// <summary>
        /// Sets the Rect in the TargetElement’s coordinate space to bring into view.
        /// </summary>
        /// <param name="e">The requested <see cref="BringIntoViewRequestedEventArgs"/>.</param>
        /// <param name="targetRect">The Rect in the TargetElement’s coordinate space to bring into view.</param>
        public static void TargetRect(this BringIntoViewRequestedEventArgs e, Rect targetRect) => Resolver.TargetRect(e, targetRect);

        /// <summary>
        /// Gets the horizontal distance that should be added to the viewport-relative position of the TargetRect
        /// after satisfying the requested HorizontalAlignmentRatio.
        /// </summary>
        /// <param name="e">The requested <see cref="BringIntoViewRequestedEventArgs"/>.</param>
        /// <returns>
        /// The horizontal distance that should be added to the viewport-relative position of the TargetRect
        /// after satisfying the requested HorizontalAlignmentRatio.
        /// </returns>
        public static double HorizontalAlignmentRatio(this BringIntoViewRequestedEventArgs e) => Resolver.HorizontalAlignmentRatio(e);

        /// <summary>
        /// Gets the vertical distance that should be added to the viewport-relative position of the TargetRect
        /// after satisfying the requested VerticalAlignmentRatio.
        /// </summary>
        /// <param name="e">The requested <see cref="BringIntoViewRequestedEventArgs"/>.</param>
        /// <returns>
        /// The vertical distance that should be added to the viewport-relative position of the TargetRect
        /// after satisfying the requested VerticalAlignmentRatio.
        /// </returns>
        public static double VerticalAlignmentRatio(this BringIntoViewRequestedEventArgs e) => Resolver.VerticalAlignmentRatio(e);

        /// <summary>
        /// Gets the horizontal distance to add to the viewport-relative position of the TargetRect
        /// after satisfying the requested HorizontalAlignmentRatio.
        /// </summary>
        /// <param name="e">The requested <see cref="BringIntoViewRequestedEventArgs"/>.</param>
        /// <returns>
        /// The horizontal distance to add to the viewport-relative position of the TargetRect
        /// after satisfying the requested HorizontalAlignmentRatio.
        /// </returns>
        public static double HorizontalOffset(this BringIntoViewRequestedEventArgs e) => Resolver.HorizontalOffset(e);

        /// <summary>
        /// Sets the horizontal distance to add to the viewport-relative position of the TargetRect
        /// after satisfying the requested HorizontalAlignmentRatio.
        /// </summary>
        /// <param name="e">The requested <see cref="BringIntoViewRequestedEventArgs"/>.</param>
        /// <param name="horizontalOffset">
        /// The horizontal distance to add to the viewport-relative position of the TargetRect
        /// after satisfying the requested HorizontalAlignmentRatio.
        /// </param>>
        public static void HorizontalOffset(this BringIntoViewRequestedEventArgs e, double horizontalOffset) => Resolver.HorizontalOffset(e, horizontalOffset);

        /// <summary>
        /// Gets the vertical distance to add to the viewport-relative position of the TargetRect
        /// after satisfying the requested VerticalAlignmentRatio.
        /// </summary>
        /// <param name="e">The requested <see cref="BringIntoViewRequestedEventArgs"/>.</param>
        /// <returns>
        /// The vertical distance to add to the viewport-relative position of the TargetRect
        /// after satisfying the requested VerticalAlignmentRatio.
        /// </returns>
        public static double VerticalOffset(this BringIntoViewRequestedEventArgs e) => Resolver.VerticalOffset(e);

        /// <summary>
        /// Sets the vertical distance to add to the viewport-relative position of the TargetRect
        /// after satisfying the requested VerticalAlignmentRatio.
        /// </summary>
        /// <param name="e">The requested <see cref="BringIntoViewRequestedEventArgs"/>.</param>
        /// <param name="verticalOffset">
        /// The vertical distance to add to the viewport-relative position of the TargetRect
        /// after satisfying the requested VerticalAlignmentRatio.
        /// </param>
        public static void VerticalOffset(this BringIntoViewRequestedEventArgs e, double verticalOffset) => Resolver.VerticalOffset(e, verticalOffset);

        /// <summary>
        /// Gets a value that marks the routed event as handled. A <c>true</c> value prevents most handlers
        /// along the event route from handling the same event again.
        /// </summary>
        /// <param name="e">The requested <see cref="BringIntoViewRequestedEventArgs"/>.</param>
        /// <returns>
        /// <c>true</c> to mark the routed event handled. <c>false</c> to leave the routed event unhandled,
        /// which permits the event to potentially route further and be acted on by other handlers.
        /// The default is <c>false</c>.
        /// </returns>
        public static bool Handled(this BringIntoViewRequestedEventArgs e) => Resolver.Handled(e);

        /// <summary>
        /// Sets a value that marks the routed event as handled. A <c>true</c> value prevents most handlers
        /// along the event route from handling the same event again.
        /// </summary>
        /// <param name="e">The requested <see cref="BringIntoViewRequestedEventArgs"/>.</param>
        /// <param name="handled">
        /// <c>true</c> to mark the routed event handled. <c>false</c> to leave the routed event unhandled,
        /// which permits the event to potentially route further and be acted on by other handlers.
        /// The default is <c>false</c>.
        /// </param>>
        public static void Handled(this BringIntoViewRequestedEventArgs e, bool handled) => Resolver.Handled(e, handled);

        /// <summary>
        /// Gets a reference to the object that raised the event.
        /// This is often a template part of a control rather than an element that was declared in your app UI.
        /// </summary>
        /// <param name="e">The requested <see cref="BringIntoViewRequestedEventArgs"/>.</param>
        /// <returns>The object that raised the event.</returns>
        public static object OriginalSource(this BringIntoViewRequestedEventArgs e) => Resolver.OriginalSource(e);

        private sealed class DefaultBringIntoViewRequestedEventArgsResolver : IBringIntoViewRequestedEventArgsResolver
        {
            UIElement IBringIntoViewRequestedEventArgsResolver.TargetElement(BringIntoViewRequestedEventArgs e) => e.TargetElement;
            void IBringIntoViewRequestedEventArgsResolver.TargetElement(BringIntoViewRequestedEventArgs e, UIElement targetElement) => e.TargetElement = targetElement;
            bool IBringIntoViewRequestedEventArgsResolver.AnimationDesired(BringIntoViewRequestedEventArgs e) => e.AnimationDesired;
            void IBringIntoViewRequestedEventArgsResolver.AnimationDesired(BringIntoViewRequestedEventArgs e, bool animationDesired) => e.AnimationDesired = animationDesired;
            Rect IBringIntoViewRequestedEventArgsResolver.TargetRect(BringIntoViewRequestedEventArgs e) => e.TargetRect;
            void IBringIntoViewRequestedEventArgsResolver.TargetRect(BringIntoViewRequestedEventArgs e, Rect targetRect) => e.TargetRect = targetRect;
            double IBringIntoViewRequestedEventArgsResolver.HorizontalAlignmentRatio(BringIntoViewRequestedEventArgs e) => e.HorizontalAlignmentRatio;
            double IBringIntoViewRequestedEventArgsResolver.VerticalAlignmentRatio(BringIntoViewRequestedEventArgs e) => e.VerticalAlignmentRatio;
            double IBringIntoViewRequestedEventArgsResolver.HorizontalOffset(BringIntoViewRequestedEventArgs e) => e.HorizontalOffset;
            void IBringIntoViewRequestedEventArgsResolver.HorizontalOffset(BringIntoViewRequestedEventArgs e, double horizontalOffset) => e.HorizontalOffset = horizontalOffset;
            double IBringIntoViewRequestedEventArgsResolver.VerticalOffset(BringIntoViewRequestedEventArgs e) => e.VerticalOffset;
            void IBringIntoViewRequestedEventArgsResolver.VerticalOffset(BringIntoViewRequestedEventArgs e, double verticalOffset) => e.VerticalOffset = verticalOffset;
            bool IBringIntoViewRequestedEventArgsResolver.Handled(BringIntoViewRequestedEventArgs e) => e.Handled;
            void IBringIntoViewRequestedEventArgsResolver.Handled(BringIntoViewRequestedEventArgs e, bool handled) => e.Handled = handled;
            object IBringIntoViewRequestedEventArgsResolver.OriginalSource(BringIntoViewRequestedEventArgs e) => e.OriginalSource;
        }
    }

    /// <summary>
    /// Resolves data of the <see cref="BringIntoViewRequestedEventArgs"/>.
    /// </summary>
    public interface IBringIntoViewRequestedEventArgsResolver
    {
        /// <summary>
        /// Gets the element that should be made visible in response to the event.
        /// </summary>
        /// <param name="e">The requested <see cref="BringIntoViewRequestedEventArgs"/>.</param>
        /// <returns>The element that should be made visible in response to the event.</returns>
        UIElement TargetElement(BringIntoViewRequestedEventArgs e);

        /// <summary>
        /// Sets the element that should be made visible in response to the event.
        /// </summary>
        /// <param name="e">The requested <see cref="BringIntoViewRequestedEventArgs"/>.</param>
        /// <param name="targetElement">The element that should be made visible in response to the event.</param>
        void TargetElement(BringIntoViewRequestedEventArgs e, UIElement targetElement);

        /// <summary>
        /// Gets a value that specifies whether the scrolling should be animated.
        /// </summary>
        /// <param name="e">The requested <see cref="BringIntoViewRequestedEventArgs"/>.</param>
        /// <returns><c>true</c> to animate the scrolling; otherwise, <c>false</c>.</returns>
        bool AnimationDesired(BringIntoViewRequestedEventArgs e);

        /// <summary>
        /// Sets a value that specifies whether the scrolling should be animated.
        /// </summary>
        /// <param name="e">The requested <see cref="BringIntoViewRequestedEventArgs"/>.</param>
        /// <param name="animationDesired"><c>true</c> to animate the scrolling; otherwise, <c>false</c>.</param>
        void AnimationDesired(BringIntoViewRequestedEventArgs e, bool animationDesired);

        /// <summary>
        /// Gets the Rect in the TargetElement’s coordinate space to bring into view.
        /// </summary>
        /// <param name="e">The requested <see cref="BringIntoViewRequestedEventArgs"/>.</param>
        /// <returns>The Rect in the TargetElement’s coordinate space to bring into view.</returns>
        Rect TargetRect(BringIntoViewRequestedEventArgs e);

        /// <summary>
        /// Sets the Rect in the TargetElement’s coordinate space to bring into view.
        /// </summary>
        /// <param name="e">The requested <see cref="BringIntoViewRequestedEventArgs"/>.</param>
        /// <param name="targetRect">The Rect in the TargetElement’s coordinate space to bring into view.</param>
        void TargetRect(BringIntoViewRequestedEventArgs e, Rect targetRect);

        /// <summary>
        /// Gets the horizontal distance that should be added to the viewport-relative position of the TargetRect
        /// after satisfying the requested HorizontalAlignmentRatio.
        /// </summary>
        /// <param name="e">The requested <see cref="BringIntoViewRequestedEventArgs"/>.</param>
        /// <returns>
        /// The horizontal distance that should be added to the viewport-relative position of the TargetRect
        /// after satisfying the requested HorizontalAlignmentRatio.
        /// </returns>
        double HorizontalAlignmentRatio(BringIntoViewRequestedEventArgs e);

        /// <summary>
        /// Gets the vertical distance that should be added to the viewport-relative position of the TargetRect
        /// after satisfying the requested VerticalAlignmentRatio.
        /// </summary>
        /// <param name="e">The requested <see cref="BringIntoViewRequestedEventArgs"/>.</param>
        /// <returns>
        /// The vertical distance that should be added to the viewport-relative position of the TargetRect
        /// after satisfying the requested VerticalAlignmentRatio.
        /// </returns>
        double VerticalAlignmentRatio(BringIntoViewRequestedEventArgs e);

        /// <summary>
        /// Gets the horizontal distance to add to the viewport-relative position of the TargetRect
        /// after satisfying the requested HorizontalAlignmentRatio.
        /// </summary>
        /// <param name="e">The requested <see cref="BringIntoViewRequestedEventArgs"/>.</param>
        /// <returns>
        /// The horizontal distance to add to the viewport-relative position of the TargetRect
        /// after satisfying the requested HorizontalAlignmentRatio.
        /// </returns>
        double HorizontalOffset(BringIntoViewRequestedEventArgs e);

        /// <summary>
        /// Sets the horizontal distance to add to the viewport-relative position of the TargetRect
        /// after satisfying the requested HorizontalAlignmentRatio.
        /// </summary>
        /// <param name="e">The requested <see cref="BringIntoViewRequestedEventArgs"/>.</param>
        /// <param name="horizontalOffset">
        /// The horizontal distance to add to the viewport-relative position of the TargetRect
        /// after satisfying the requested HorizontalAlignmentRatio.
        /// </param>>
        void HorizontalOffset(BringIntoViewRequestedEventArgs e, double horizontalOffset);

        /// <summary>
        /// Gets the vertical distance to add to the viewport-relative position of the TargetRect
        /// after satisfying the requested VerticalAlignmentRatio.
        /// </summary>
        /// <param name="e">The requested <see cref="BringIntoViewRequestedEventArgs"/>.</param>
        /// <returns>
        /// The vertical distance to add to the viewport-relative position of the TargetRect
        /// after satisfying the requested VerticalAlignmentRatio.
        /// </returns>
        double VerticalOffset(BringIntoViewRequestedEventArgs e);

        /// <summary>
        /// Sets the vertical distance to add to the viewport-relative position of the TargetRect
        /// after satisfying the requested VerticalAlignmentRatio.
        /// </summary>
        /// <param name="e">The requested <see cref="BringIntoViewRequestedEventArgs"/>.</param>
        /// <param name="verticalOffset">
        /// The vertical distance to add to the viewport-relative position of the TargetRect
        /// after satisfying the requested VerticalAlignmentRatio.
        /// </param>
        void VerticalOffset(BringIntoViewRequestedEventArgs e, double verticalOffset);

        /// <summary>
        /// Gets a value that marks the routed event as handled. A <c>true</c> value prevents most handlers
        /// along the event route from handling the same event again.
        /// </summary>
        /// <param name="e">The requested <see cref="BringIntoViewRequestedEventArgs"/>.</param>
        /// <returns>
        /// <c>true</c> to mark the routed event handled. <c>false</c> to leave the routed event unhandled,
        /// which permits the event to potentially route further and be acted on by other handlers.
        /// The default is <c>false</c>.
        /// </returns>
        bool Handled(BringIntoViewRequestedEventArgs e);

        /// <summary>
        /// Sets a value that marks the routed event as handled. A <c>true</c> value prevents most handlers
        /// along the event route from handling the same event again.
        /// </summary>
        /// <param name="e">The requested <see cref="BringIntoViewRequestedEventArgs"/>.</param>
        /// <param name="handled">
        /// <c>true</c> to mark the routed event handled. <c>false</c> to leave the routed event unhandled,
        /// which permits the event to potentially route further and be acted on by other handlers.
        /// The default is <c>false</c>.
        /// </param>>
        void Handled(BringIntoViewRequestedEventArgs e, bool handled);

        /// <summary>
        /// Gets a reference to the object that raised the event.
        /// This is often a template part of a control rather than an element that was declared in your app UI.
        /// </summary>
        /// <param name="e">The requested <see cref="BringIntoViewRequestedEventArgs"/>.</param>
        /// <returns>The object that raised the event.</returns>
        object OriginalSource(BringIntoViewRequestedEventArgs e);
    }
}
