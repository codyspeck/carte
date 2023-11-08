namespace Carte;

public interface IMapper
{
    TTo Map<TFrom, TTo>(TFrom obj);
}

public interface IMapper<in TFrom, out TTo>
{
    TTo Map(TFrom obj);
}
