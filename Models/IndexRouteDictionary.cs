using System;
namespace CountryList.Models;

public class IndexRouteDictionary : Dictionary<string, string> {

    public int PageSize {
        get => Get(nameof(IndexDTO.PageSize)).ToInt();
        set => this[nameof(IndexDTO.PageSize)] = value.ToString();
    }

    public int PageNumber {
        get => Get(nameof(IndexDTO.PageNumber)).ToInt();
        set => this[nameof(IndexDTO.PageNumber)] = value.ToString();
    }

    public string SortField {
        get => Get(nameof(IndexDTO.SortField));
        set => this[nameof(IndexDTO.SortField)] = value;
    }

    public string Continent {
        get => Get(nameof(IndexDTO.Continent));
        set => this[nameof(IndexDTO.Continent)] = value;
    }


    public string SortDirection {
        get => Get(nameof(IndexDTO.SortDirection));
        set => this[nameof(IndexDTO.SortDirection)] = value;
    }
    //pageNumber sortDirection sortField
    public string Get(string key) => Keys.Contains(key) ? this[key] : null;

    public void SetSortAndField(string fieldname, IndexRouteDictionary current) {
        this[nameof(IndexDTO.SortField)] = fieldname;

        if(fieldname.EqualsNoCase(current.SortField) && current.SortDirection == "asc") {
            this[nameof(IndexDTO.SortDirection)] = "desc";
        } else {
            this[nameof(IndexDTO.SortDirection)] = "asc";
        }
    }

    public IndexRouteDictionary Clone() {
        var CloneRoute = new IndexRouteDictionary();

        foreach(var key in Keys) {
            CloneRoute.Add(key, this[key]);
        }

        return CloneRoute;
    }
}