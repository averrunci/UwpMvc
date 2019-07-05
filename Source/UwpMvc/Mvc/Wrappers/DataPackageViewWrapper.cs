// Copyright (C) 2019 Fievus
//
// This software may be modified and distributed under the terms
// of the MIT license.  See the LICENSE file for details.
using System;
using System.Collections.Generic;
using Windows.ApplicationModel.DataTransfer;
using Windows.Foundation;
using Windows.Security.EnterpriseData;
using Windows.Storage;
using Windows.Storage.Streams;

namespace Charites.Windows.Mvc.Wrappers
{
    /// <summary>
    /// Provides the <see cref="DataPackageView"/> operation
    /// resolved by <see cref="IDataPackageViewResolver"/>.
    /// </summary>
    public static class DataPackageViewWrapper
    {
        /// <summary>
        /// Gets or sets the <see cref="IDataPackageViewResolver"/>
        /// that resolves the <see cref="DataPackageView"/> operation.
        /// </summary>
        public static IDataPackageViewResolver Resolver { get; set; } = new DefaultDataPackageViewResolver();

        /// <summary>
        /// Gets a DataPackagePropertySetView object, which contains a read-only set of properties for the data in the DataPackageView object.
        /// </summary>
        /// <param name="dataPackageView">The requested <see cref="DataPackageView"/>.</param>
        /// <returns>The object that contains a read-only set of properties for the data.</returns>
        public static DataPackagePropertySetView Properties(this DataPackageView dataPackageView) => Resolver.Properties(dataPackageView);

        /// <summary>
        /// Gets the requested operation (such as copy or move). Primarily used for Clipboard actions.
        /// </summary>
        /// <param name="dataPackageView">The requested <see cref="DataPackageView"/>.</param>
        /// <returns>An enumeration that states what operation (such as copy or move) was completed.</returns>
        public static DataPackageOperation RequestedOperation(this DataPackageView dataPackageView) => Resolver.RequestedOperation(dataPackageView);

        /// <summary>
        /// Informs the system that your app is finished using the DataPackageView object. Primarily used for Clipboard operations.
        /// </summary>
        /// <param name="dataPackageView">The requested <see cref="DataPackageView"/>.</param>
        /// <param name="value">An enumeration that states what operation (such as copy or move) was completed. At most one operation flag can be set.</param>
        public static void ReportOperationCompletedWrapped(this DataPackageView dataPackageView, DataPackageOperation value) => Resolver.ReportOperationCompleted(dataPackageView, value);

        /// <summary>
        /// Returns the formats the DataPackageView contains.
        /// </summary>
        /// <param name="dataPackageView">The requested <see cref="DataPackageView"/>.</param>
        /// <returns>The formats the DataPackageView contains.</returns>
        public static IReadOnlyList<string> AvailableFormats(this DataPackageView dataPackageView) => Resolver.AvailableFormats(dataPackageView);

        /// <summary>
        /// Checks to see if the DataPackageView contains a specific data format.
        /// </summary>
        /// <param name="dataPackageView">The requested <see cref="DataPackageView"/>.</param>
        /// <param name="formatId">The name of the format.</param>
        /// <returns>True if the DataPackageView contains the format; false otherwise.</returns>
        public static bool ContainsWrapped(this DataPackageView dataPackageView, string formatId) => Resolver.Contains(dataPackageView, formatId);

        /// <summary>
        /// Gets the data contained in the DataPackageView.
        /// </summary>
        /// <param name="dataPackageView">The requested <see cref="DataPackageView"/>.</param>
        /// <param name="formatId">Specifies the format of the data. We recommend that you set this value by using the StandardDataFormats class.</param>
        /// <returns>The data.</returns>
        public static IAsyncOperation<object> GetDataAsyncWrapped(this DataPackageView dataPackageView, string formatId) => Resolver.GetDataAsync(dataPackageView, formatId);

        /// <summary>
        /// Gets the text in the DataPackageView object.
        /// </summary>
        /// <param name="dataPackageView">The requested <see cref="DataPackageView"/>.</param>
        /// <returns>The text.</returns>
        public static IAsyncOperation<string> GetTextAsyncWrapped(this DataPackageView dataPackageView) => Resolver.GetTextAsync(dataPackageView);

        /// <summary>
        /// Gets the text in the DataPackageView object.
        /// </summary>
        /// <param name="dataPackageView">The requested <see cref="DataPackageView"/>.</param>
        /// <param name="formatId">A string that represents the data format. Usually StandardDataFormats.text.</param>
        /// <returns>The text.</returns>
        public static IAsyncOperation<string> GetTextAsyncWrapped(this DataPackageView dataPackageView, string formatId) => Resolver.GetTextAsync(dataPackageView, formatId);

        /// <summary>
        /// Gets the HTML stored in the DataPackageView object.
        /// <param name="dataPackageView">The requested <see cref="DataPackageView"/>.</param>
        /// </summary>
        /// <returns>The HTML.</returns>
        public static IAsyncOperation<string> GetHtmlFormatAsyncWrapped(this DataPackageView dataPackageView) => Resolver.GetHtmlFormatAsync(dataPackageView);

        /// <summary>
        /// Gets the data (such as an image) referenced in HTML content.
        /// </summary>
        /// <param name="dataPackageView">The requested <see cref="DataPackageView"/>.</param>
        /// <returns>The data referenced in the HTML content.</returns>
        public static IAsyncOperation<IReadOnlyDictionary<string, RandomAccessStreamReference>> GetResourceMapAsyncWrapped(this DataPackageView dataPackageView) => Resolver.GetResourceMapAsync(dataPackageView);

        /// <summary>
        /// Gets the rich text formatted (RTF) content contained in a DataPackageView.
        /// </summary>
        /// <param name="dataPackageView">The requested <see cref="DataPackageView"/>.</param>
        /// <returns>The rich text formatted content for the DataPackage.</returns>
        public static IAsyncOperation<string> GetRtfAsyncWrapped(this DataPackageView dataPackageView) => Resolver.GetRtfAsync(dataPackageView);

        /// <summary>
        /// Gets the bitmap image contained in the DataPackageView
        /// </summary>
        /// <param name="dataPackageView">The requested <see cref="DataPackageView"/>.</param>
        /// <returns>A stream containing the bitmap image.</returns>
        public static IAsyncOperation<RandomAccessStreamReference> GetBitmapAsyncWrapped(this DataPackageView dataPackageView) => Resolver.GetBitmapAsync(dataPackageView);

        /// <summary>
        /// Gets the files and folders stored in a DataPackageView object.
        /// </summary>
        /// <param name="dataPackageView">The requested <see cref="DataPackageView"/>.</param>
        /// <returns>An array of files and folders stored in a DataPackageView.</returns>
        public static IAsyncOperation<IReadOnlyList<IStorageItem>> GetStorageItemsAsyncWrapped(this DataPackageView dataPackageView) => Resolver.GetStorageItemsAsync(dataPackageView);

        /// <summary>
        /// Gets the application link in the DataPackageView object.
        /// </summary>
        /// <param name="dataPackageView">The requested <see cref="DataPackageView"/>.</param>
        /// <returns>The application link.</returns>
        public static IAsyncOperation<Uri> GetApplicationLinkAsyncWrapped(this DataPackageView dataPackageView) => Resolver.GetApplicationLinkAsync(dataPackageView);

        /// <summary>
        /// Gets the web link in the DataPackageView object.
        /// </summary>
        /// <param name="dataPackageView">The requested <see cref="DataPackageView"/>.</param>
        /// <returns>The web link.</returns>
        public static IAsyncOperation<Uri> GetWebLinkAsyncWrapped(this DataPackageView dataPackageView) => Resolver.GetWebLinkAsync(dataPackageView);

        /// <summary>
        /// Requests permission to unlock and access a data package that is secured with a protection policy.
        /// </summary>
        /// <param name="dataPackageView">The requested <see cref="DataPackageView"/>.</param>
        /// <returns>When this method completes, it returns the results of the protection policy evaluation, which indicates whether or not the data is accessible.</returns>
        public static IAsyncOperation<ProtectionPolicyEvaluationResult> RequestAccessAsyncWrapped(this DataPackageView dataPackageView) => Resolver.RequestAccessAsync(dataPackageView);

        /// <summary>
        /// Requests permission to unlock and access a data package that is secured with a protection policy.
        /// </summary>
        /// <param name="dataPackageView">The requested <see cref="DataPackageView"/>.</param>
        /// <param name="enterpriseId">The enterprise Id.</param>
        /// <returns>When this method completes, it returns the results of the protection policy evaluation, which indicates whether or not the data is accessible.</returns>
        public static IAsyncOperation<ProtectionPolicyEvaluationResult> RequestAccessAsyncWrapped(this DataPackageView dataPackageView, string enterpriseId) => Resolver.RequestAccessAsync(dataPackageView, enterpriseId);

        /// <summary>
        /// Unlocks a data package and assumes an enterprise identity for it.
        /// </summary>
        /// <param name="dataPackageView">The requested <see cref="DataPackageView"/>.</param>
        /// <returns>When this method completes, it returns the results of the protection policy evaluation.</returns>
        public static ProtectionPolicyEvaluationResult UnlockAndAssumeEnterpriseIdentityWrapped(this DataPackageView dataPackageView) => Resolver.UnlockAndAssumeEnterpriseIdentity(dataPackageView);

        /// <summary>
        /// Sets the accepted format Id.
        /// </summary>
        /// <param name="dataPackageView">The requested <see cref="DataPackageView"/>.</param>
        /// <param name="formatId">The format Id.</param>
        public static void SetAcceptedFormatIdWrapped(this DataPackageView dataPackageView, string formatId) => Resolver.SetAcceptedFormatId(dataPackageView, formatId);

        private sealed class DefaultDataPackageViewResolver : IDataPackageViewResolver
        {
            DataPackagePropertySetView IDataPackageViewResolver.Properties(DataPackageView dataPackageView) => dataPackageView.Properties;
            DataPackageOperation IDataPackageViewResolver.RequestedOperation(DataPackageView dataPackageView) => dataPackageView.RequestedOperation;
            void IDataPackageViewResolver.ReportOperationCompleted(DataPackageView dataPackageView, DataPackageOperation value) => dataPackageView.ReportOperationCompleted(value);
            IReadOnlyList<string> IDataPackageViewResolver.AvailableFormats(DataPackageView dataPackageView) => dataPackageView.AvailableFormats;
            bool IDataPackageViewResolver.Contains(DataPackageView dataPackageView, string formatId) => dataPackageView.Contains(formatId);
            IAsyncOperation<object> IDataPackageViewResolver.GetDataAsync(DataPackageView dataPackageView, string formatId) => dataPackageView.GetDataAsync(formatId);
            IAsyncOperation<string> IDataPackageViewResolver.GetTextAsync(DataPackageView dataPackageView) => dataPackageView.GetTextAsync();
            IAsyncOperation<string> IDataPackageViewResolver.GetTextAsync(DataPackageView dataPackageView, string formatId) => dataPackageView.GetTextAsync(formatId);
            IAsyncOperation<string> IDataPackageViewResolver.GetHtmlFormatAsync(DataPackageView dataPackageView) => dataPackageView.GetHtmlFormatAsync();
            IAsyncOperation<IReadOnlyDictionary<string, RandomAccessStreamReference>> IDataPackageViewResolver.GetResourceMapAsync(DataPackageView dataPackageView) => dataPackageView.GetResourceMapAsync();
            IAsyncOperation<string> IDataPackageViewResolver.GetRtfAsync(DataPackageView dataPackageView) => dataPackageView.GetRtfAsync();
            IAsyncOperation<RandomAccessStreamReference> IDataPackageViewResolver.GetBitmapAsync(DataPackageView dataPackageView) => dataPackageView.GetBitmapAsync();
            IAsyncOperation<IReadOnlyList<IStorageItem>> IDataPackageViewResolver.GetStorageItemsAsync(DataPackageView dataPackageView) => dataPackageView.GetStorageItemsAsync();
            IAsyncOperation<Uri> IDataPackageViewResolver.GetApplicationLinkAsync(DataPackageView dataPackageView) => dataPackageView.GetApplicationLinkAsync();
            IAsyncOperation<Uri> IDataPackageViewResolver.GetWebLinkAsync(DataPackageView dataPackageView) => dataPackageView.GetWebLinkAsync();
            IAsyncOperation<ProtectionPolicyEvaluationResult> IDataPackageViewResolver.RequestAccessAsync(DataPackageView dataPackageView) => dataPackageView.RequestAccessAsync();
            IAsyncOperation<ProtectionPolicyEvaluationResult> IDataPackageViewResolver.RequestAccessAsync(DataPackageView dataPackageView, string enterpriseId) => dataPackageView.RequestAccessAsync(enterpriseId);
            ProtectionPolicyEvaluationResult IDataPackageViewResolver.UnlockAndAssumeEnterpriseIdentity(DataPackageView dataPackageView) => dataPackageView.UnlockAndAssumeEnterpriseIdentity();
            void IDataPackageViewResolver.SetAcceptedFormatId(DataPackageView dataPackageView, string formatId) => dataPackageView.SetAcceptedFormatId(formatId);
        }
    }

    /// <summary>
    /// Resolves the <see cref="DataPackageView"/> operation.
    /// </summary>
    public interface IDataPackageViewResolver
    {
        /// <summary>
        /// Gets a DataPackagePropertySetView object, which contains a read-only set of properties for the data in the DataPackageView object.
        /// </summary>
        /// <param name="dataPackageView">The requested <see cref="DataPackageView"/>.</param>
        /// <returns>The object that contains a read-only set of properties for the data.</returns>
        DataPackagePropertySetView Properties(DataPackageView dataPackageView);

        /// <summary>
        /// Gets the requested operation (such as copy or move). Primarily used for Clipboard actions.
        /// </summary>
        /// <param name="dataPackageView">The requested <see cref="DataPackageView"/>.</param>
        /// <returns>An enumeration that states what operation (such as copy or move) was completed.</returns>
        DataPackageOperation RequestedOperation(DataPackageView dataPackageView);

        /// <summary>
        /// Informs the system that your app is finished using the DataPackageView object. Primarily used for Clipboard operations.
        /// </summary>
        /// <param name="dataPackageView">The requested <see cref="DataPackageView"/>.</param>
        /// <param name="value">An enumeration that states what operation (such as copy or move) was completed. At most one operation flag can be set.</param>
        void ReportOperationCompleted(DataPackageView dataPackageView, DataPackageOperation value);

        /// <summary>
        /// Returns the formats the DataPackageView contains.
        /// </summary>
        /// <param name="dataPackageView">The requested <see cref="DataPackageView"/>.</param>
        /// <returns>The formats the DataPackageView contains.</returns>
        IReadOnlyList<string> AvailableFormats(DataPackageView dataPackageView);

        /// <summary>
        /// Checks to see if the DataPackageView contains a specific data format.
        /// </summary>
        /// <param name="dataPackageView">The requested <see cref="DataPackageView"/>.</param>
        /// <param name="formatId">The name of the format.</param>
        /// <returns>True if the DataPackageView contains the format; false otherwise.</returns>
        bool Contains(DataPackageView dataPackageView, string formatId);

        /// <summary>
        /// Gets the data contained in the DataPackageView.
        /// </summary>
        /// <param name="dataPackageView">The requested <see cref="DataPackageView"/>.</param>
        /// <param name="formatId">Specifies the format of the data. We recommend that you set this value by using the StandardDataFormats class.</param>
        /// <returns>The data.</returns>
        IAsyncOperation<object> GetDataAsync(DataPackageView dataPackageView, string formatId);

        /// <summary>
        /// Gets the text in the DataPackageView object.
        /// </summary>
        /// <param name="dataPackageView">The requested <see cref="DataPackageView"/>.</param>
        /// <returns>The text.</returns>
        IAsyncOperation<string> GetTextAsync(DataPackageView dataPackageView);

        /// <summary>
        /// Gets the text in the DataPackageView object.
        /// </summary>
        /// <param name="dataPackageView">The requested <see cref="DataPackageView"/>.</param>
        /// <param name="formatId">A string that represents the data format. Usually StandardDataFormats.text.</param>
        /// <returns>The text.</returns>
        IAsyncOperation<string> GetTextAsync(DataPackageView dataPackageView, string formatId);

        /// <summary>
        /// Gets the HTML stored in the DataPackageView object.
        /// <param name="dataPackageView">The requested <see cref="DataPackageView"/>.</param>
        /// </summary>
        /// <returns>The HTML.</returns>
        IAsyncOperation<string> GetHtmlFormatAsync(DataPackageView dataPackageView);

        /// <summary>
        /// Gets the data (such as an image) referenced in HTML content.
        /// </summary>
        /// <param name="dataPackageView">The requested <see cref="DataPackageView"/>.</param>
        /// <returns>The data referenced in the HTML content.</returns>
        IAsyncOperation<IReadOnlyDictionary<string, RandomAccessStreamReference>> GetResourceMapAsync(DataPackageView dataPackageView);

        /// <summary>
        /// Gets the rich text formatted (RTF) content contained in a DataPackageView.
        /// </summary>
        /// <param name="dataPackageView">The requested <see cref="DataPackageView"/>.</param>
        /// <returns>The rich text formatted content for the DataPackage.</returns>
        IAsyncOperation<string> GetRtfAsync(DataPackageView dataPackageView);

        /// <summary>
        /// Gets the bitmap image contained in the DataPackageView
        /// </summary>
        /// <param name="dataPackageView">The requested <see cref="DataPackageView"/>.</param>
        /// <returns>A stream containing the bitmap image.</returns>
        IAsyncOperation<RandomAccessStreamReference> GetBitmapAsync(DataPackageView dataPackageView);

        /// <summary>
        /// Gets the files and folders stored in a DataPackageView object.
        /// </summary>
        /// <param name="dataPackageView">The requested <see cref="DataPackageView"/>.</param>
        /// <returns>An array of files and folders stored in a DataPackageView.</returns>
        IAsyncOperation<IReadOnlyList<IStorageItem>> GetStorageItemsAsync(DataPackageView dataPackageView);

        /// <summary>
        /// Gets the application link in the DataPackageView object.
        /// </summary>
        /// <param name="dataPackageView">The requested <see cref="DataPackageView"/>.</param>
        /// <returns>The application link.</returns>
        IAsyncOperation<Uri> GetApplicationLinkAsync(DataPackageView dataPackageView);

        /// <summary>
        /// Gets the web link in the DataPackageView object.
        /// </summary>
        /// <param name="dataPackageView">The requested <see cref="DataPackageView"/>.</param>
        /// <returns>The web link.</returns>
        IAsyncOperation<Uri> GetWebLinkAsync(DataPackageView dataPackageView);

        /// <summary>
        /// Requests permission to unlock and access a data package that is secured with a protection policy.
        /// </summary>
        /// <param name="dataPackageView">The requested <see cref="DataPackageView"/>.</param>
        /// <returns>When this method completes, it returns the results of the protection policy evaluation, which indicates whether or not the data is accessible.</returns>
        IAsyncOperation<ProtectionPolicyEvaluationResult> RequestAccessAsync(DataPackageView dataPackageView);

        /// <summary>
        /// Requests permission to unlock and access a data package that is secured with a protection policy.
        /// </summary>
        /// <param name="dataPackageView">The requested <see cref="DataPackageView"/>.</param>
        /// <param name="enterpriseId">The enterprise Id.</param>
        /// <returns>When this method completes, it returns the results of the protection policy evaluation, which indicates whether or not the data is accessible.</returns>
        IAsyncOperation<ProtectionPolicyEvaluationResult> RequestAccessAsync(DataPackageView dataPackageView, string enterpriseId);

        /// <summary>
        /// Unlocks a data package and assumes an enterprise identity for it.
        /// </summary>
        /// <param name="dataPackageView">The requested <see cref="DataPackageView"/>.</param>
        /// <returns>When this method completes, it returns the results of the protection policy evaluation.</returns>
        ProtectionPolicyEvaluationResult UnlockAndAssumeEnterpriseIdentity(DataPackageView dataPackageView);

        /// <summary>
        /// Sets the accepted format Id.
        /// </summary>
        /// <param name="dataPackageView">The requested <see cref="DataPackageView"/>.</param>
        /// <param name="formatId">The format Id.</param>
        void SetAcceptedFormatId(DataPackageView dataPackageView, string formatId);
    }
}
