using Microsoft.Extensions.DependencyInjection;

namespace Carte;

internal class Mapper : IMapper
{
    private readonly IServiceProvider _provider;

    public Mapper(IServiceProvider provider)
    {
        _provider = provider;
    }
    
    public TTo Map<TFrom, TTo>(TFrom obj)
    {
        using var scope = _provider.CreateScope();

        var mapper = scope.ServiceProvider.GetRequiredService<IMapper<TFrom, TTo>>();

        return mapper.Map(obj);
    }
}
