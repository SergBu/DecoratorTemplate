using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorTemplate
{
    public static class RestrictionUpdateRepositoryExtention
    {
        public static IServiceCollection RegisterTerminalRestrictionUpdateRepositoryDecorator(this IServiceCollection services)
        {
            services.AddScoped<TerminalRestrictionUpdateRepository>();
            services.AddScoped<TerminalRestrictionUpdateRepositoryDecorator>();
            services.Replace(ServiceDescriptor.Scoped<ITerminalRestrictionUpdateRepository>(
                x => new TerminalRestrictionUpdateRepositoryDecorator
                (
                    x.GetRequiredService<TerminalRestrictionUpdateRepository>()//,
                    //x.GetRequiredService<ITerminalTimeslotVehicleRepository>(),
                    //x.GetRequiredService<ITerminalTimeslotVehicleStatusService>(),
                    //x.GetRequiredService<TerminalHelper>(),
                    //x.GetRequiredService<IMapper>(),
                    //x.GetRequiredService<ICalculateTerminalTimeslotVehicleStatusService>(),
                    //x.GetRequiredService<ITerminalRestrictionReservationRepository>()
                )));

            return services;
        }
    }
}
