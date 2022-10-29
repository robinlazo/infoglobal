namespace CountryList.Models;

public class IndexDTO
{
    public int PageNumber { get; set; } = 1;
    static public int PageSize { get; set; } = 25;

    public string SortField { get; set; }

    public string SortDirection { get; set; } = "asc";

    public string Continent { get; set; } = "all";
}