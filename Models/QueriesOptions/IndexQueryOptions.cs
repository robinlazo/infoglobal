namespace CountryList.Models;


public class IndexQueryOptions : QueryOptions<Country> {
    public void SortFilter(CountrySession builder) {
        if(builder.IsFilterByContinent) {
            Where = c => c.ContinentID == builder.CurrentRoute.Continent;
        }

        if(builder.IsSortByName) {
            OrderBy = c => c.Name;
        } else if(builder.IsSortByPopulation) {
            OrderBy = c => c.Population;
        }
    }
}