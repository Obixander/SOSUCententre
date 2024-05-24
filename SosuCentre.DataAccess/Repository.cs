using Microsoft.EntityFrameworkCore;
using SosuCentre.DataAccess;
using SosuCentre.Entities;

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
        T entity = GetBy(id);
        Delete(entity);
    }

    public void Delete(T Entity)
    {
        context.Remove(Entity);
        context.SaveChanges();
    }

    public IEnumerable<T> GetAll()
    {
        return context.Set<T>()
            .ToList();
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