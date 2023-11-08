# Carte

A low ambition mapping library for manual object-to-object mapping.

```c#
var services = new ServiceCollection();

services.AddCarte(cfg => cfg
    .AddMapper<ModelMapper, Model, ModelDto>());

using var provider = services.BuildServiceProvider();

using var scope = provider.CreateScope();

var mapper = scope.ServiceProvider.GetRequiredService<IMapper>();

var dto = mapper.Map<Model, ModelDto>(new Model { Name = "Name" });
```

```c#
public class Model
{
    public string Name { get; set; }
}

public class ModelDto
{
    public string Name { get; set; }
}

public class ModelMapper : IMapper<Model, ModelDto>
{
    public ModelDto Map(Model obj)
    {
        return new ModelDto { Name = obj.Name };
    }
}
```