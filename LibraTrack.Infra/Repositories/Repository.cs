namespace LibraTrack.Infra.Repositories;

internal abstract class Repository<TEntity, TEntityId>
    where TEntity : Entity<TEntityId>
    where TEntityId : class
{
    protected readonly ApplicationDbContext DbContext;

    protected Repository(ApplicationDbContext dbContext)
    {
        DbContext = dbContext;
    }

    public async Task<TEntity?> GetByIdAsync(
        TEntityId id,
        CancellationToken cancellationToken = default)
    {
        return await DbContext
                    .Set<TEntity>()
                    .FirstOrDefaultAsync(user => user.Id == id, cancellationToken);
    }

    public async Task AddAsync(TEntity entity, CancellationToken cancellationToken)
    {
        await DbContext.AddAsync(entity, cancellationToken);
    }

    public void Update(TEntity entity)
    {
        DbContext.Update(entity);
    }

    public void Remove(TEntity entity)
    {
        DbContext.Remove(entity);
    }
}