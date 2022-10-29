
namespace CountryList.Models;
public class Continent
{
    public string ContinentID { get; set; }

    public string Name { get; set; }

    public ICollection<Country> Countries { get; set; }

    
}