// Copyright (C) 2018 Fievus
//
// This software may be modified and distributed under the terms
// of the MIT license.  See the LICENSE file for details.
using Charites.Windows.Samples.SimpleLoginDemo.Presentation.Login;
using Charites.Windows.SamplesSimpleLoginDemo.Adapter.User;
using Microsoft.Extensions.DependencyInjection;

namespace Charites.Windows.SamplesSimpleLoginDemo.Adapter
{
    public static class ServiceExtensions
    {
        public static IServiceCollection AddPresentationAdapters(this IServiceCollection services)
        {
            return services.AddTransient<IUserAuthentication, UserAuthentication>();
        }
    }
}
