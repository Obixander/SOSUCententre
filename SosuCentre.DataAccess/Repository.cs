using SosuCentre.DataAccess;

public class Repository<T> : IRepository<T> where T : class
{
    private readonly SosuCentreContext context;

    public Repository(SosuCentreContext context)
    {
        this.context = context;
    }


    public void Add(T Entity)
    {
        context.Add(Entity);
        context.SaveChanges();
    }

    public void Delete(int id)
    {
        context.Remove(id);
        context.SaveChanges();
    }

    public void Delete(T Entity)
    {
        context.Remove(Entity);
        context.SaveChanges();
    }

    public IEnumerable<T> GetAll()
    {
        return default;
    }

    public T GetBy(int Id)
    {
        return context.Set<T>().Find(Id);
    }

    public void Update(T Entity)
    {
        context.Update(Entity);
        context.SaveChanges();
    }
}