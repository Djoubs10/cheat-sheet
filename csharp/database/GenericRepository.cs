public class GenericRepository<TEntity> : IGenericRepository<TEntity>
  where TEntity : class, IEntity
{
  private DbSet<TEntity> _dbSet;
  private DbContext _dbContext;
  public GenericRepository(DbContext dbContext)
  {
      _dbContext = dbContext;
      _dbSet = dbContext.Set<TEntity>();
  }

  public void Create(TEntity entity)
  {
      if (entity == null)
          throw new ArgumentNullException(nameof(entity));
      _dbSet.Add(entity);
      _dbContext.SaveChanges();
  }

  public void Delete(TEntity entity)
  {
      if (entity == null)
          throw new ArgumentNullException(nameof(entity));
      _dbSet.Remove(entity);
      _dbContext.SaveChanges();
  }

  public IEnumerable<TEntity> GetAll()
  {
      return _dbSet.ToList();
  }

  public TEntity? GetById(int id)
  {
      return _dbSet.FirstOrDefault(x => x.Id == id);
  }

  public void Update(TEntity entity)
  {
      if (entity == null)
          throw new ArgumentNullException(nameof(entity));
      _dbSet.Update(entity);
      _dbContext.SaveChanges();
  }
}
