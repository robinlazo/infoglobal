
namespace CountryList.Models;
public static class QueryExtensions
{
    public static IQueryable<T> PageBy<T>(this IQueryable<T> query, int PageNumber, int PageSize)
    {
        return query
               .Skip((PageNumber - 1) * PageSize)
               .Take(PageSize);
    }
}