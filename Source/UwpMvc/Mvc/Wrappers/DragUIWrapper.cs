// Copyright (C) 2017 Fievus
//
// This software may be modified and distributed under the terms
// of the MIT license.  See the LICENSE file for details.
using Windows.Foundation;
using Windows.Graphics.Imaging;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Media.Imaging;

namespace Fievus.Windows.Mvc.Wrappers
{
    /// <summary>
    /// Provides the <see cref="DragUI"/> operation
    /// resolved by <see cref="IDragUIResolver"/>.
    /// </summary>
    public static class DragUIWrapper
    {
        /// <summary>
        /// Gets or sets the <see cref="IDragUIResolver"/>
        /// that resolves the <see cref="DragUI"/> operation.
        /// </summary>
        public static IDragUIResolver Resolver { get; set; } = new DefaultDragUIResolver();

        /// <summary>
        /// Creates a visula element from a provided <see cref="BitmapImage"/> to represent
        /// the dragged data in a drag-and-drop operation.
        /// </summary>
        /// <param name="dragUI">The requested <see cref="DragUI"/>.</param>
        /// <param name="bitmapImage">The source image used to create the drag visual.</param>
        public static void SetContentFromBitmapImage(this DragUI dragUI, BitmapImage bitmapImage) => Resolver.SetContentFromBitmapImage(dragUI, bitmapImage);

        /// <summary>
        /// Creates a visual element from a provided <see cref="BitmapImage"/> to represent
        /// the dragged data in a drag-and-drop operation, and sets the relative position
        /// of the visual from the pointer.
        /// </summary>
        /// <param name="dragUI">The requested <see cref="DragUI"/>.</param>
        /// <param name="bitmapImage">The source image used to create the drag visual.</param>
        /// <param name="anchorPoint">The relative position of the drag visual from the pointer.</param>
        public static void SetContentFromBitmapImage(this DragUI dragUI, BitmapImage bitmapImage, Point anchorPoint) => Resolver.SetContentFromBitmapImage(dragUI, bitmapImage, anchorPoint);

        /// <summary>
        /// Creates a system provided visual element that represents the format of the dragged data
        /// in a drag-and-drop operation, typically the icon of the default handler for the file format.
        /// </summary>
        /// <param name="dragUI">The requested <see cref="DragUI"/>.</param>
        public static void SetContentFromDataPackage(this DragUI dragUI) => Resolver.SetContentFromDataPackage(dragUI);

        /// <summary>
        /// Creates a visual element from a provided <see cref="SoftwareBitmap"/> to represent the dragged data
        /// in a drag-and-drop operation.
        /// </summary>
        /// <param name="dragUI">The requested <see cref="DragUI"/>.</param>
        /// <param name="softwareBitmap">The source image used to create the drag visual.</param>
        public static void SetContentFromSoftwareBitmap(this DragUI dragUI, SoftwareBitmap softwareBitmap) => Resolver.SetContentFromSoftwareBitmap(dragUI, softwareBitmap);

        /// <summary>
        /// Creates a visual element from a provided <see cref="SoftwareBitmap"/> to represent the dragged data
        /// in a drag-and-drop operation, and sets the relative position of the visual from the pointer.
        /// </summary>
        /// <param name="dragUI">The requested <see cref="DragUI"/>.</param>
        /// <param name="softwareBitmap">The source image used to create the drag visual.</param>
        /// <param name="anchorPoint">The relative position of the drag visual from the pointer.</param>
        public static void SetContentFromSoftwareBitmap(this DragUI dragUI, SoftwareBitmap softwareBitmap, Point anchorPoint) => Resolver.SetContentFromSoftwareBitmap(dragUI, softwareBitmap, anchorPoint);

        private sealed class DefaultDragUIResolver : IDragUIResolver
        {
            void IDragUIResolver.SetContentFromBitmapImage(DragUI dragUI, BitmapImage bitmapImage) => dragUI.SetContentFromBitmapImage(bitmapImage);
            void IDragUIResolver.SetContentFromBitmapImage(DragUI dragUI, BitmapImage bitmapImage, Point anchorPoint) => dragUI.SetContentFromBitmapImage(bitmapImage, anchorPoint);
            void IDragUIResolver.SetContentFromDataPackage(DragUI dragUI) => dragUI.SetContentFromDataPackage();
            void IDragUIResolver.SetContentFromSoftwareBitmap(DragUI dragUI, SoftwareBitmap softwareBitmap) => dragUI.SetContentFromSoftwareBitmap(softwareBitmap);
            void IDragUIResolver.SetContentFromSoftwareBitmap(DragUI dragUI, SoftwareBitmap softwareBitmap, Point anchorPoint) => dragUI.SetContentFromSoftwareBitmap(softwareBitmap, anchorPoint);
        }
    }

    /// <summary>
    /// Resolves the <see cref="DragUI"/> operation.
    /// </summary>
    public interface IDragUIResolver
    {
        /// <summary>
        /// Creates a visula element from a provided <see cref="BitmapImage"/> to represent
        /// the dragged data in a drag-and-drop operation.
        /// </summary>
        /// <param name="dragUI">The requested <see cref="DragUI"/>.</param>
        /// <param name="bitmapImage">The source image used to create the drag visual.</param>
        void SetContentFromBitmapImage(DragUI dragUI, BitmapImage bitmapImage);

        /// <summary>
        /// Creates a visual element from a provided <see cref="BitmapImage"/> to represent
        /// the dragged data in a drag-and-drop operation, and sets the relative position
        /// of the visual from the pointer.
        /// </summary>
        /// <param name="dragUI">The requested <see cref="DragUI"/>.</param>
        /// <param name="bitmapImage">The source image used to create the drag visual.</param>
        /// <param name="anchorPoint">The relative position of the drag visual from the pointer.</param>
        void SetContentFromBitmapImage(DragUI dragUI, BitmapImage bitmapImage, Point anchorPoint);

        /// <summary>
        /// Creates a system provided visual element that represents the format of the dragged data
        /// in a drag-and-drop operation, typically the icon of the default handler for the file format.
        /// </summary>
        /// <param name="dragUI">The requested <see cref="DragUI"/>.</param>
        void SetContentFromDataPackage(DragUI dragUI);

        /// <summary>
        /// Creates a visual element from a provided <see cref="SoftwareBitmap"/> to represent the dragged data
        /// in a drag-and-drop operation.
        /// </summary>
        /// <param name="dragUI">The requested <see cref="DragUI"/>.</param>
        /// <param name="softwareBitmap">The source image used to create the drag visual.</param>
        void SetContentFromSoftwareBitmap(DragUI dragUI, SoftwareBitmap softwareBitmap);

        /// <summary>
        /// Creates a visual element from a provided <see cref="SoftwareBitmap"/> to represent the dragged data
        /// in a drag-and-drop operation, and sets the relative position of the visual from the pointer.
        /// </summary>
        /// <param name="dragUI">The requested <see cref="DragUI"/>.</param>
        /// <param name="softwareBitmap">The source image used to create the drag visual.</param>
        /// <param name="anchorPoint">The relative position of the drag visual from the pointer.</param>
        void SetContentFromSoftwareBitmap(DragUI dragUI, SoftwareBitmap softwareBitmap, Point anchorPoint);
    }
}
