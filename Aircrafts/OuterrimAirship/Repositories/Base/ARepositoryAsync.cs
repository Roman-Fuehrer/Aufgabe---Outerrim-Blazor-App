using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using OuterrimAirship.Model;

namespace OuterrimAirship.Repositories.Base;

public class ARepositoryAsync<TEntity> : IRepositoryAsync<TEntity> where TEntity : class
{
    protected readonly AircraftContext Context;
    protected readonly DbSet<TEntity> Table;
    
    protected ARepositoryAsync(AircraftContext context) 
    {
        Context = context;
        Table = context.Set<TEntity>();
    }
    
    public async Task<TEntity> CreateAsync(TEntity t)
    {
        await Table.AddAsync(t);
        await Context.SaveChangesAsync();
        return t;
    }

    public async Task<List<TEntity>> CreateRangeAsync(List<TEntity> list)
    {
        await Table.AddRangeAsync(list);
        await Context.SaveChangesAsync();
        return list;
    }

    public async Task UpdateAsync(TEntity t)
    {
        Table.Update(t);
        await Context.SaveChangesAsync();
    }

    public async Task UpdateRangeAsync(List<TEntity> list)
    {
        Table.UpdateRange(list);
        await Context.SaveChangesAsync();
    }

    public async Task<TEntity?> ReadAsync(int id) => await Table.FindAsync(id);

    public async Task<List<TEntity>> ReadAsync(Expression<Func<TEntity, bool>> filter) => await Table.Where(filter).ToListAsync();

    public async Task<List<TEntity>> ReadAsync(int start, int count) => await Table.Skip(start).Take(count).ToListAsync();

    public async Task<List<TEntity>> ReadAllAsync() => await Table.ToListAsync();

    public async Task DeleteAsync(TEntity t)
    {
        Table.Remove(t);
        await Context.SaveChangesAsync();
    }
}