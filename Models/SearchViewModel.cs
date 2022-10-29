using System.ComponentModel.DataAnnotations;

namespace CountryList.Models;

public class SearchViewModel
{
    [Required(ErrorMessage = "A Search Term is required")]
    public string SearchTerm { get; set; }

    public IEnumerable<Country>? Countries { get; set; }

    public string? Header { get; set; }
}