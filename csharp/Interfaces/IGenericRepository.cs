public interface IGenericRepository<TEntity> 
    where TEntity : class, IEntity
{
    IEnumerable<TEntity> GetAll();
    TEntity? GetById(int id);
    void Create(TEntity entity);   
    void Update(TEntity entity);
    void Delete(TEntity entity);

}
public interface IEntity
{
    public int Id { get; set; }
}
