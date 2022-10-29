using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using System;

namespace CountryList.Models;


public class QueryOptions<T>
{

    public Expression<Func<T, Object>> OrderBy { get; set; }
    public string OrderByDirection { get; set; } = "asc";

    public Expression<Func<T, bool>> ContinentID { get; set; }

    public int PageNumber { get; set; }

    private string[] includes;
    public string Includes {
        set => includes = value.Replace(" ", "").Split(",");
    }

    public string[] GetIncludes() => includes;
    public WhereClauses<T> WhereClauses { get; set; }

    public Expression<Func<T, bool>> Where {
        set {
            if(WhereClauses == null) WhereClauses = new WhereClauses<T>();

            WhereClauses.Add(value);
        }
    }

    public bool HasWhere => WhereClauses != null;
    public bool HasOrderBy => OrderBy != null;

    public bool HasPaging => PageNumber > 0;
}


public class WhereClauses<T> : List<Expression<Func<T, bool>>> {}