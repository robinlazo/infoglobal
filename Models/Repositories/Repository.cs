using Microsoft.EntityFrameworkCore;
namespace CountryList.Models;

public class Repository<T> : IRepository<T> where T : class
{

    private WorldCountryContext Context { get; }

    private int? count;
    private DbSet<T> dbSet { get; set; }
    public Repository(WorldCountryContext context)
    {
        Context = context;
        dbSet = Context.Set<T>();
    }


    public int Count => count ?? dbSet.Count();

    public virtual IEnumerable<T> List(QueryOptions<T> options)
    {
        var query = BuildQuery(options);
        return query.ToList();
    }

    public virtual T Get(QueryOptions<T> options) {
        var query = BuildQuery(options);
        return query.FirstOrDefault();
    }
    public virtual T Get(int id) => dbSet.Find(id);

    public virtual T Get(string id) => dbSet.Find(id);

    public virtual void Delete(T entity) => dbSet.Remove(entity);

    public virtual void Insert(T entity) => dbSet.Add(entity);

    public virtual void Update(T entity) => dbSet.Update(entity);


    public virtual void Save() => Context.SaveChanges();

    public IQueryable<T> BuildQuery(QueryOptions<T> options) {
        IQueryable<T> result = dbSet;

        foreach(var includes in options.GetIncludes()) {
            result = result.Include(includes);
        }

        if(options.HasWhere) {
            foreach(var clause in options.WhereClauses) {
                result = result.Where(clause);
            }

            count = result.Count();
        }

        if(options.HasOrderBy) {
            if(options.OrderByDirection == "asc") result = result.OrderBy(options.OrderBy);
            else result = result.OrderByDescending(options.OrderBy);
        }

        if(options.HasPaging) {
            result = result.PageBy(options.PageNumber, IndexDTO.PageSize);
        }
        
        return result;
    }

}