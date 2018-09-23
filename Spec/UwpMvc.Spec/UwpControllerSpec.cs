// Copyright (C) 2018 Fievus
//
// This software may be modified and distributed under the terms
// of the MIT license.  See the LICENSE file for details.
using Carna;

namespace Charites.Windows.Mvc
{
    [Specification("UwpController Spec")]
    class UwpControllerSpec
    {
        [Context]
        UwpControllerSpec_EventHandlerDataContextElementInjection EventHandlerDataContextElementInjection { get; set; }

        [Context]
        UwpControllerSpec_AttachingAndDetachingController AttachingAndDetachingController { get; set; }

        [Context]
        UwpControllerSpec_UwpControllerExtension UwpControllerSpecUwpControllerExtension { get; set; }

        [Context]
        UwpControllerSpec_UnhandledException UnhandledException { get; set; }
    }
}
