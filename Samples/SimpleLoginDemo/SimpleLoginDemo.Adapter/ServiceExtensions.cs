// Copyright (C) 2017 Fievus
//
// This software may be modified and distributed under the terms
// of the MIT license.  See the LICENSE file for details.
using Microsoft.Extensions.DependencyInjection;

using Fievus.Windows.Samples.SimpleLoginDemo.Adapter.User;
using Fievus.Windows.Samples.SimpleLoginDemo.Presentation.Login;

namespace Fievus.Windows.Samples.SimpleLoginDemo.Adapter
{
    public static class ServiceExtensions
    {
        public static IServiceCollection AddPresentationAdapters(this IServiceCollection services)
        {
            return services.AddTransient<IUserAuthentication, UserAuthentication>();
        }
    }
}
