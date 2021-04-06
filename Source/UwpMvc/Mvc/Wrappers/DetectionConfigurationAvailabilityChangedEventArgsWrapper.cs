// Copyright (C) 2021 Fievus
//
// This software may be modified and distributed under the terms
// of the MIT license.  See the LICENSE file for details.
using Windows.ApplicationModel.ConversationalAgent;

namespace Charites.Windows.Mvc.Wrappers
{
    /// <summary>
    /// Provides data of the <see cref="DetectionConfigurationAvailabilityChangedEventArgs"/>
    /// resolved by <see cref="IDetectionConfigurationAvailabilityChangedEventArgsResolver"/>.
    /// </summary>
    public static class DetectionConfigurationAvailabilityChangedEventArgsWrapper
    {
        /// <summary>
        /// Gets or sets the <see cref="IDetectionConfigurationAvailabilityChangedEventArgsResolver"/>
        /// that resolves data of the <see cref="DetectionConfigurationAvailabilityChangedEventArgs"/>.
        /// </summary>
        public static IDetectionConfigurationAvailabilityChangedEventArgsResolver Resolver { get; set; } = new DefaultDetectionConfigurationAvailabilityChangedEventArgsResolver();

        /// <summary>
        /// Gets the permission levels granted by a user to the ActivationSignalDetector.
        /// </summary>
        /// <param name="e">The requested <see cref="DetectionConfigurationAvailabilityChangedEventArgs"/>.</param>
        /// <returns>The permission levels granted by a user to the ActivationSignalDetector.</returns>
        public static DetectionConfigurationAvailabilityChangeKind Kind(this DetectionConfigurationAvailabilityChangedEventArgs e) => Resolver.Kind(e);

        private sealed class DefaultDetectionConfigurationAvailabilityChangedEventArgsResolver : IDetectionConfigurationAvailabilityChangedEventArgsResolver
        {
            DetectionConfigurationAvailabilityChangeKind IDetectionConfigurationAvailabilityChangedEventArgsResolver.Kind(DetectionConfigurationAvailabilityChangedEventArgs e) => e.Kind;
        }
    }

    /// <summary>
    /// Resolves data of the <see cref="DetectionConfigurationAvailabilityChangedEventArgs"/>.
    /// </summary>
    public interface IDetectionConfigurationAvailabilityChangedEventArgsResolver
    {
        /// <summary>
        /// Gets the permission levels granted by a user to the ActivationSignalDetector.
        /// </summary>
        /// <param name="e">The requested <see cref="DetectionConfigurationAvailabilityChangedEventArgs"/>.</param>
        /// <returns>The permission levels granted by a user to the ActivationSignalDetector.</returns>
        DetectionConfigurationAvailabilityChangeKind Kind(DetectionConfigurationAvailabilityChangedEventArgs e);
    }
}
