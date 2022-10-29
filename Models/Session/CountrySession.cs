namespace CountryList.Models;
public class CountrySession {
    private string sessionKey = "currentroutekey";
    protected IndexRouteDictionary routes { get; set; }
    private ISession Session { get; }
    public CountrySession(ISession sess, IndexDTO values, string defaultSort) {
        Session = sess;

        routes = new IndexRouteDictionary();
        routes.PageNumber = values.PageNumber;
        routes.SortDirection = values.SortDirection;
        routes.SortField = values.SortField ?? defaultSort;
        routes.Continent = values.Continent;
        
        SaveRouteValues();
    }
    
    public void SaveRouteValues() => Session.SetObject<IndexRouteDictionary>(sessionKey, routes);

    public int TotalPages(int count, int size) {
        return (count + size - 1) / size;
    }

    public bool IsSortByName => routes.SortField.EqualsNoCase(nameof(Country.Name));

    public bool IsSortByPopulation => routes.SortField.EqualsNoCase(nameof(Country.Population));

    public bool IsFilterByContinent => routes.Continent != "all";

    public IndexRouteDictionary CurrentRoute => routes;
}