using FluentAssertions;
using Microsoft.Extensions.DependencyInjection;

namespace Carte.Tests;

public class Tests
{
    public void Registers_mappers()
    {
        using var provider = new ServiceCollection()
            .AddCarte(configuration => configuration
                .AddMapper<ModelMapper, Model, ModelDto>())
            .BuildServiceProvider();

        using var scope = provider.CreateScope();

        var mapper = scope.ServiceProvider.GetRequiredService<IMapper>();

        var dto = mapper.Map<Model, ModelDto>(new Model { Name = "test" });

        dto.Name.Should().Be("test");
    }
}
