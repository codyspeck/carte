using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;

namespace Carte;

public static class DependencyInjection
{
    public static IServiceCollection AddCarte(this IServiceCollection services, Action<CarteConfiguration> configure)
    {
        var configuration = new CarteConfiguration();

        configure(configuration);
        
        foreach (var serviceDescriptor in configuration.MappersToRegister)
            services.Add(serviceDescriptor);
        
        services.TryAddSingleton<IMapper, Mapper>();
        
        return services;
    }
}
