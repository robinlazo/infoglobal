
namespace CountryList.Models;
public class Country
{
    public string CountryID { get; set; }
    public string ImageFlag { get; set; }
    public string Name { get; set; }
    public string City { get; set; }
    public int Population { get; set; }

    public string ContinentID { get; set; }
    public Continent Continent { get; set; }
}