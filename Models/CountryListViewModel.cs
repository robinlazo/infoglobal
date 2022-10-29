
namespace CountryList.Models;
public class CountryListViewModel
{
    public IEnumerable<Country> Countries { get; set; }

    public SearchViewModel SearchModel { get; set; }

    public IndexRouteDictionary CurrentRoute { get; set; }


    public Dictionary<string, string> Continents => new Dictionary<string, string> {
        {"all", "All"},
        {"asia", "Asia"},
        {"africa", "Africa"},
        {"america", "America"},
        {"oceania", "Oceania"},
        {"europe", "Europe"}
    };

    public int TotalPages { get; set; }

    public string CurrentContinent { get; set; }

    public string CheckActiveContinent(string continent) => (CurrentContinent == continent) ? "active" : "";
}