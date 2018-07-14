// Copyright (C) 2018 Fievus
//
// This software may be modified and distributed under the terms
// of the MIT license.  See the LICENSE file for details.
using System;
using Windows.UI.Xaml.Controls;

namespace Charites.Windows.Mvc.Wrappers
{
    /// <summary>
    /// Provides data of the <see cref="WebViewPermissionRequest"/>
    /// resolved by <see cref="IWebViewPermissionRequestResolver"/>.
    /// </summary>
    public static class WebViewPermissionRequestWrapper
    {
        /// <summary>
        /// Gets or sets the <see cref="IWebViewPermissionRequestResolver"/>
        /// that resolves data of the <see cref="WebViewPermissionRequest"/>.
        /// </summary>
        public static IWebViewPermissionRequestResolver Resolver { get; set; } = new DefaultWebViewPermissionRequestResolver();

        /// <summary>
        /// Gets the identifier for the permission request.
        /// </summary>
        /// <param name="permissionRequest">The requested <see cref="WebViewPermissionRequest"/>.</param>
        /// <returns>The identifier for the permission request.</returns>
        public static uint Id(this WebViewPermissionRequest permissionRequest) => Resolver.Id(permissionRequest);

        /// <summary>
        /// Gets a value that indicates the type of permission that's requested.
        /// </summary>
        /// <param name="permissionRequest">The requested <see cref="WebViewPermissionRequest"/>.</param>
        /// <returns>An enumeration value that indicates the type of permission requested.</returns>
        public static WebViewPermissionType PermissionType(this WebViewPermissionRequest permissionRequest) => Resolver.PermissionType(permissionRequest);

        /// <summary>
        /// Gets the current state of the permission request.
        /// </summary>
        /// <param name="permissionRequest">The requested <see cref="WebViewPermissionRequest"/>.</param>
        /// <returns>An enumeration value that indicates the current state of the permission request.</returns>
        public static WebViewPermissionState State(this WebViewPermissionRequest permissionRequest) => Resolver.State(permissionRequest);

        /// <summary>
        /// Gets the Uniform Resource Identifier (URI) of the content where the permission request originated.
        /// </summary>
        /// <param name="permissionRequest">The requested <see cref="WebViewPermissionRequest"/>.</param>
        /// <returns>The URI of the content where the permission request originated.</returns>
        public static Uri Uri(this WebViewPermissionRequest permissionRequest) => Resolver.Uri(permissionRequest);

        /// <summary>
        /// Grants the requested permission.
        /// </summary>
        /// <param name="permissionRequest">The requested <see cref="WebViewPermissionRequest"/>.</param>
        public static void Allow(this WebViewPermissionRequest permissionRequest) => Resolver.Allow(permissionRequest);

        /// <summary>
        /// Defers the permission request to be allowed or denied at a later time.
        /// </summary>
        /// <param name="permissionRequest">The requested <see cref="WebViewPermissionRequest"/>.</param>
        public static void Defer(this WebViewPermissionRequest permissionRequest) => Resolver.Defer(permissionRequest);

        /// <summary>
        /// Denies the requested permission.
        /// </summary>
        /// <param name="permissionRequest">The requested <see cref="WebViewPermissionRequest"/>.</param>
        public static void Deny(this WebViewPermissionRequest permissionRequest) => Resolver.Deny(permissionRequest);

        private sealed class DefaultWebViewPermissionRequestResolver : IWebViewPermissionRequestResolver
        {
            uint IWebViewPermissionRequestResolver.Id(WebViewPermissionRequest permissionRequest) => permissionRequest.Id;
            WebViewPermissionType IWebViewPermissionRequestResolver.PermissionType(WebViewPermissionRequest permissionRequest) => permissionRequest.PermissionType;
            WebViewPermissionState IWebViewPermissionRequestResolver.State(WebViewPermissionRequest permissionRequest) => permissionRequest.State;
            Uri IWebViewPermissionRequestResolver.Uri(WebViewPermissionRequest permissionRequest) => permissionRequest.Uri;
            void IWebViewPermissionRequestResolver.Allow(WebViewPermissionRequest permissionRequest) => permissionRequest.Allow();
            void IWebViewPermissionRequestResolver.Defer(WebViewPermissionRequest permissionRequest) => permissionRequest.Defer();
            void IWebViewPermissionRequestResolver.Deny(WebViewPermissionRequest permissionRequest) => permissionRequest.Deny();
        }
    }

    /// <summary>
    /// Resolves data of the <see cref="WebViewPermissionRequest"/>.
    /// </summary>
    public interface IWebViewPermissionRequestResolver
    {
        /// <summary>
        /// Gets the identifier for the permission request.
        /// </summary>
        /// <param name="permissionRequest">The requested <see cref="WebViewPermissionRequest"/>.</param>
        /// <returns>The identifier for the permission request.</returns>
        uint Id(WebViewPermissionRequest permissionRequest);

        /// <summary>
        /// Gets a value that indicates the type of permission that's requested.
        /// </summary>
        /// <param name="permissionRequest">The requested <see cref="WebViewPermissionRequest"/>.</param>
        /// <returns>An enumeration value that indicates the type of permission requested.</returns>
        WebViewPermissionType PermissionType(WebViewPermissionRequest permissionRequest);

        /// <summary>
        /// Gets the current state of the permission request.
        /// </summary>
        /// <param name="permissionRequest">The requested <see cref="WebViewPermissionRequest"/>.</param>
        /// <returns>An enumeration value that indicates the current state of the permission request.</returns>
        WebViewPermissionState State(WebViewPermissionRequest permissionRequest);

        /// <summary>
        /// Gets the Uniform Resource Identifier (URI) of the content where the permission request originated.
        /// </summary>
        /// <param name="permissionRequest">The requested <see cref="WebViewPermissionRequest"/>.</param>
        /// <returns>The URI of the content where the permission request originated.</returns>
        Uri Uri(WebViewPermissionRequest permissionRequest);

        /// <summary>
        /// Grants the requested permission.
        /// </summary>
        /// <param name="permissionRequest">The requested <see cref="WebViewPermissionRequest"/>.</param>
        void Allow(WebViewPermissionRequest permissionRequest);

        /// <summary>
        /// Defers the permission request to be allowed or denied at a later time.
        /// </summary>
        /// <param name="permissionRequest">The requested <see cref="WebViewPermissionRequest"/>.</param>
        void Defer(WebViewPermissionRequest permissionRequest);

        /// <summary>
        /// Denies the requested permission.
        /// </summary>
        /// <param name="permissionRequest">The requested <see cref="WebViewPermissionRequest"/>.</param>
        void Deny(WebViewPermissionRequest permissionRequest);
    }
}
