// Copyright (C) 2017 Fievus
//
// This software may be modified and distributed under the terms
// of the MIT license.  See the LICENSE file for details.
using Microsoft.Extensions.DependencyInjection;
using System.Linq;
using System.Reflection;

namespace Fievus.Windows.Samples.SimpleLoginDemo.Presentation
{
    public static class ServiceExtensions
    {
        public static IServiceCollection AddControllers(this IServiceCollection services) =>
            typeof(ServiceExtensions).GetTypeInfo().Assembly.DefinedTypes
                .Where(t => t.Name.EndsWith("Controller"))
                .Aggregate(services, (s, t) => s.AddTransient(t.AsType()));
    }
}
