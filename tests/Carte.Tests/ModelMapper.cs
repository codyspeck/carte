namespace Carte.Tests;

public class ModelMapper : IMapper<Model, ModelDto>
{
    public ModelDto Map(Model obj)
    {
        return new ModelDto { Name = obj.Name };
    }
}
