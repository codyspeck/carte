using Microsoft.Extensions.DependencyInjection;

namespace Carte;

public class CarteConfiguration
{
    public List<ServiceDescriptor> MappersToRegister { get; } = new();

    public CarteConfiguration AddMapper<TMapper, TFrom, TTo>()
        where TMapper : IMapper<TFrom, TTo>
    {   
        MappersToRegister.Add(new ServiceDescriptor(typeof(IMapper<TFrom, TTo>), typeof(TMapper), ServiceLifetime.Transient));
        
        return this;
    }
}