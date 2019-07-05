// Copyright (C) 2019 Fievus
//
// This software may be modified and distributed under the terms
// of the MIT license.  See the LICENSE file for details.

using Windows.Foundation;
using Windows.Graphics.Imaging;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Media.Imaging;

namespace Charites.Windows.Mvc.Wrappers
{
    /// <summary>
    /// Provides the <see cref="DragUIOverride"/> operation
    /// resolved by <see cref="IDragUIOverrideResolver"/>.
    /// </summary>
    public static class DragUIOverrideWrapper
    {
        /// <summary>
        /// Gets or sets the <see cref="IDragUIOverrideResolver"/>
        /// that resolves the <see cref="DragUIOverride"/> operation.
        /// </summary>
        public static IDragUIOverrideResolver Resolver { get; set; } = new DefaultDragUIOverrideResolver();

        /// <summary>
        /// Gets the caption text that overlays the drag visual. The text typically describes the drag-and-drop action.
        /// </summary>
        /// <param name="dragUIOverride">The requested <see cref="DragUIOverride"/>.</param>
        /// <returns>The caption text that overlays the drag visual.</returns>
        public static string Caption(this DragUIOverride dragUIOverride) => Resolver.Caption(dragUIOverride);

        /// <summary>
        /// Sets the caption text that overlays the drag visual. The text typically describes the drag-and-drop action.
        /// </summary>
        /// <param name="dragUIOverride">The requested <see cref="DragUIOverride"/>.</param>
        /// <param name="caption">The caption text that overlays the drag visual.</param>
        public static void Caption(this DragUIOverride dragUIOverride, string caption) => Resolver.Caption(dragUIOverride, caption);

        /// <summary>
        /// Gets a value that indicates whether the content of the drag visual is shown.
        /// </summary>
        /// <param name="dragUIOverride">The requested <see cref="DragUIOverride"/>.</param>
        /// <returns><c>true</c> if the content is shown; otherwise, <c>false</c>.</returns>
        public static bool IsContentVisible(this DragUIOverride dragUIOverride) => Resolver.IsContentVisible(dragUIOverride);

        /// <summary>
        /// Sets a value that indicates whether the content of the drag visual is shown.
        /// </summary>
        /// <param name="dragUIOverride">The requested <see cref="DragUIOverride"/>.</param>
        /// <param name="isContentVisible"><c>true</c> if the content is shown; otherwise, <c>false</c>.</param>
        public static void IsContentVisible(this DragUIOverride dragUIOverride, bool isContentVisible) => Resolver.IsContentVisible(dragUIOverride, isContentVisible);

        /// <summary>
        /// Gets a value that indicates whether the caption text is shown.
        /// </summary>
        /// <param name="dragUIOverride">The requested <see cref="DragUIOverride"/>.</param>
        /// <returns><c>true</c> if the caption text is shown; otherwise, <c>false</c>.</returns>
        public static bool IsCaptionVisible(this DragUIOverride dragUIOverride) => Resolver.IsCaptionVisible(dragUIOverride);

        /// <summary>
        /// Sets a value that indicates whether the caption text is shown.
        /// </summary>
        /// <param name="dragUIOverride">The requested <see cref="DragUIOverride"/>.</param>
        /// <param name="isCaptionVisible"><c>true</c> if the caption text is shown; otherwise, <c>false</c>.</param>
        public static void IsCaptionVisible(this DragUIOverride dragUIOverride, bool isCaptionVisible) => Resolver.IsCaptionVisible(dragUIOverride, isCaptionVisible);

        /// <summary>
        /// Gets a value that indicates whether the glyph is shown.
        /// </summary>
        /// <param name="dragUIOverride">The requested <see cref="DragUIOverride"/>.</param>
        /// <returns><c>true</c> if the glyph is shown; otherwise, <c>false</c>.</returns>
        public static bool IsGlyphVisible(this DragUIOverride dragUIOverride) => Resolver.IsGlyphVisible(dragUIOverride);

        /// <summary>
        /// Sets a value that indicates whether the glyph is shown.
        /// </summary>
        /// <param name="dragUIOverride">The requested <see cref="DragUIOverride"/>.</param>
        /// <param name="isGlyphVisible"><c>true</c> if the glyph is shown; otherwise, <c>false</c>.</param>
        public static void IsGlyphVisible(this DragUIOverride dragUIOverride, bool isGlyphVisible) => Resolver.IsGlyphVisible(dragUIOverride, isGlyphVisible);

        /// <summary>
        /// Clears the content, caption, and glyph of the drag visual.
        /// </summary>
        /// <param name="dragUIOverride">The requested <see cref="DragUIOverride"/>.</param>
        public static void ClearWrapped(this DragUIOverride dragUIOverride) => Resolver.Clear(dragUIOverride);

        /// <summary>
        /// Creates a visual element from a provided BitmapImage to represent the dragged data in a drag-and-drop operation.
        /// </summary>
        /// <param name="dragUIOverride">The requested <see cref="DragUIOverride"/>.</param>
        /// <param name="bitmapImage">The source image used to create the drag visual.</param>
        public static void SetContentFromBitmapImageWrapped(this DragUIOverride dragUIOverride, BitmapImage bitmapImage) => Resolver.SetContentFromBitmapImage(dragUIOverride, bitmapImage);

        /// <summary>
        /// Creates a visual element from a provided BitmapImage to represent the dragged data in a drag-and-drop operation,
        /// and sets the relative position of the visual from the pointer.
        /// </summary>
        /// <param name="dragUIOverride">The requested <see cref="DragUIOverride"/>.</param>
        /// <param name="bitmapImage">The source image used to create the drag visual.</param>
        /// <param name="anchorPoint">The relative position of the drag visual from the pointer.</param>
        public static void SetContentFromBitmapImageWrapped(this DragUIOverride dragUIOverride, BitmapImage bitmapImage, Point anchorPoint) => Resolver.SetContentFromBitmapImage(dragUIOverride, bitmapImage, anchorPoint);

        /// <summary>
        /// Creates a visual element from a provided SoftwareBitmap to represent the dragged data in a drag-and-drop operation.
        /// </summary>
        /// <param name="dragUIOverride">The requested <see cref="DragUIOverride"/>.</param>
        /// <param name="softwareBitmap">The source image used to create the drag visual.</param>
        public static void SetContentFromSoftwareBitmapWrapped(this DragUIOverride dragUIOverride, SoftwareBitmap softwareBitmap) => Resolver.SetContentFromSoftwareBitmap(dragUIOverride, softwareBitmap);

        /// <summary>
        /// Creates a visual element from a provided SoftwareBitmap to represent the dragged data in a drag-and-drop operation,
        /// and sets the relative position of the visual from the pointer.
        /// </summary>
        /// <param name="dragUIOverride">The requested <see cref="DragUIOverride"/>.</param>
        /// <param name="softwareBitmap">The source image used to create the drag visual.</param>
        /// <param name="anchorPoint">The relative position of the drag visual from the pointer.</param>
        public static void SetContentFromSoftwareBitmapWrapped(this DragUIOverride dragUIOverride, SoftwareBitmap softwareBitmap, Point anchorPoint) => Resolver.SetContentFromSoftwareBitmap(dragUIOverride, softwareBitmap, anchorPoint);

        private sealed class DefaultDragUIOverrideResolver : IDragUIOverrideResolver
        {
            string IDragUIOverrideResolver.Caption(DragUIOverride dragUIOverride) => dragUIOverride.Caption;
            void IDragUIOverrideResolver.Caption(DragUIOverride dragUIOverride, string caption) => dragUIOverride.Caption = caption;
            bool IDragUIOverrideResolver.IsContentVisible(DragUIOverride dragUIOverride) => dragUIOverride.IsContentVisible;
            void IDragUIOverrideResolver.IsContentVisible(DragUIOverride dragUIOverride, bool isContentVisible) => dragUIOverride.IsContentVisible = isContentVisible;
            bool IDragUIOverrideResolver.IsCaptionVisible(DragUIOverride dragUIOverride) => dragUIOverride.IsCaptionVisible;
            void IDragUIOverrideResolver.IsCaptionVisible(DragUIOverride dragUIOverride, bool isCaptionVisible) => dragUIOverride.IsCaptionVisible = isCaptionVisible;
            bool IDragUIOverrideResolver.IsGlyphVisible(DragUIOverride dragUIOverride) => dragUIOverride.IsGlyphVisible;
            void IDragUIOverrideResolver.IsGlyphVisible(DragUIOverride dragUIOverride, bool isGlyphVisible) => dragUIOverride.IsGlyphVisible = isGlyphVisible;
            void IDragUIOverrideResolver.Clear(DragUIOverride dragUIOverride) => dragUIOverride.Clear();
            void IDragUIOverrideResolver.SetContentFromBitmapImage(DragUIOverride dragUIOverride, BitmapImage bitmapImage) => dragUIOverride.SetContentFromBitmapImage(bitmapImage);
            void IDragUIOverrideResolver.SetContentFromBitmapImage(DragUIOverride dragUIOverride, BitmapImage bitmapImage, Point anchorPoint) => dragUIOverride.SetContentFromBitmapImage(bitmapImage, anchorPoint);
            void IDragUIOverrideResolver.SetContentFromSoftwareBitmap(DragUIOverride dragUIOverride, SoftwareBitmap softwareBitmap) => dragUIOverride.SetContentFromSoftwareBitmap(softwareBitmap);
            void IDragUIOverrideResolver.SetContentFromSoftwareBitmap(DragUIOverride dragUIOverride, SoftwareBitmap softwareBitmap, Point anchorPoint) => dragUIOverride.SetContentFromSoftwareBitmap(softwareBitmap, anchorPoint);
        }
    }

    public interface IDragUIOverrideResolver
    {
        /// <summary>
        /// Gets the caption text that overlays the drag visual. The text typically describes the drag-and-drop action.
        /// </summary>
        /// <param name="dragUIOverride">The requested <see cref="DragUIOverride"/>.</param>
        /// <returns>The caption text that overlays the drag visual.</returns>
        string Caption(DragUIOverride dragUIOverride);

        /// <summary>
        /// Sets the caption text that overlays the drag visual. The text typically describes the drag-and-drop action.
        /// </summary>
        /// <param name="dragUIOverride">The requested <see cref="DragUIOverride"/>.</param>
        /// <param name="caption">The caption text that overlays the drag visual.</param>
        void Caption(DragUIOverride dragUIOverride, string caption);

        /// <summary>
        /// Gets a value that indicates whether the content of the drag visual is shown.
        /// </summary>
        /// <param name="dragUIOverride">The requested <see cref="DragUIOverride"/>.</param>
        /// <returns><c>true</c> if the content is shown; otherwise, <c>false</c>.</returns>
        bool IsContentVisible(DragUIOverride dragUIOverride);

        /// <summary>
        /// Sets a value that indicates whether the content of the drag visual is shown.
        /// </summary>
        /// <param name="dragUIOverride">The requested <see cref="DragUIOverride"/>.</param>
        /// <param name="isContentVisible"><c>true</c> if the content is shown; otherwise, <c>false</c>.</param>
        void IsContentVisible(DragUIOverride dragUIOverride, bool isContentVisible);

        /// <summary>
        /// Gets a value that indicates whether the caption text is shown.
        /// </summary>
        /// <param name="dragUIOverride">The requested <see cref="DragUIOverride"/>.</param>
        /// <returns><c>true</c> if the caption text is shown; otherwise, <c>false</c>.</returns>
        bool IsCaptionVisible(DragUIOverride dragUIOverride);

        /// <summary>
        /// Sets a value that indicates whether the caption text is shown.
        /// </summary>
        /// <param name="dragUIOverride">The requested <see cref="DragUIOverride"/>.</param>
        /// <param name="isCaptionVisible"><c>true</c> if the caption text is shown; otherwise, <c>false</c>.</param>
        void IsCaptionVisible(DragUIOverride dragUIOverride, bool isCaptionVisible);

        /// <summary>
        /// Gets a value that indicates whether the glyph is shown.
        /// </summary>
        /// <param name="dragUIOverride">The requested <see cref="DragUIOverride"/>.</param>
        /// <returns><c>true</c> if the glyph is shown; otherwise, <c>false</c>.</returns>
        bool IsGlyphVisible(DragUIOverride dragUIOverride);

        /// <summary>
        /// Sets a value that indicates whether the glyph is shown.
        /// </summary>
        /// <param name="dragUIOverride">The requested <see cref="DragUIOverride"/>.</param>
        /// <param name="isGlyphVisible"><c>true</c> if the glyph is shown; otherwise, <c>false</c>.</param>
        void IsGlyphVisible(DragUIOverride dragUIOverride, bool isGlyphVisible);

        /// <summary>
        /// Clears the content, caption, and glyph of the drag visual.
        /// </summary>
        /// <param name="dragUIOverride">The requested <see cref="DragUIOverride"/>.</param>
        void Clear(DragUIOverride dragUIOverride);

        /// <summary>
        /// Creates a visual element from a provided BitmapImage to represent the dragged data in a drag-and-drop operation.
        /// </summary>
        /// <param name="dragUIOverride">The requested <see cref="DragUIOverride"/>.</param>
        /// <param name="bitmapImage">The source image used to create the drag visual.</param>
        void SetContentFromBitmapImage(DragUIOverride dragUIOverride, BitmapImage bitmapImage);

        /// <summary>
        /// Creates a visual element from a provided BitmapImage to represent the dragged data in a drag-and-drop operation,
        /// and sets the relative position of the visual from the pointer.
        /// </summary>
        /// <param name="dragUIOverride">The requested <see cref="DragUIOverride"/>.</param>
        /// <param name="bitmapImage">The source image used to create the drag visual.</param>
        /// <param name="anchorPoint">The relative position of the drag visual from the pointer.</param>
        void SetContentFromBitmapImage(DragUIOverride dragUIOverride, BitmapImage bitmapImage, Point anchorPoint);

        /// <summary>
        /// Creates a visual element from a provided SoftwareBitmap to represent the dragged data in a drag-and-drop operation.
        /// </summary>
        /// <param name="dragUIOverride">The requested <see cref="DragUIOverride"/>.</param>
        /// <param name="softwareBitmap">The source image used to create the drag visual.</param>
        void SetContentFromSoftwareBitmap(DragUIOverride dragUIOverride, SoftwareBitmap softwareBitmap);

        /// <summary>
        /// Creates a visual element from a provided SoftwareBitmap to represent the dragged data in a drag-and-drop operation,
        /// and sets the relative position of the visual from the pointer.
        /// </summary>
        /// <param name="dragUIOverride">The requested <see cref="DragUIOverride"/>.</param>
        /// <param name="softwareBitmap">The source image used to create the drag visual.</param>
        /// <param name="anchorPoint">The relative position of the drag visual from the pointer.</param>
        void SetContentFromSoftwareBitmap(DragUIOverride dragUIOverride, SoftwareBitmap softwareBitmap, Point anchorPoint);
    }
}
