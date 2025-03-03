namespace OuterrimAirship.Repositories.Base;

public interface IEntityRepository<TEntity> : IRepositoryAsync<TEntity> where TEntity : class
{
    
}