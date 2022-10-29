using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CountryList.Models;

namespace CountryList.Controllers;

public class HomeController : Controller
{
    private Repository<Country> data { get; set; }
    public HomeController(WorldCountryContext context) => data = new Repository<Country>(context);

    public IActionResult Index(IndexDTO values) {
        
        var session = new CountrySession(HttpContext.Session, values, nameof(Country.Name));

        var options = new IndexQueryOptions
        {
            Includes = "Continent",
            PageNumber = session.CurrentRoute.PageNumber,
            OrderByDirection = session.CurrentRoute.SortDirection
        };

        options.SortFilter(session);

        var viewResult = new CountryListViewModel
        {
            Countries = data.List(options),
            CurrentRoute = session.CurrentRoute,
            TotalPages = session.TotalPages(data.Count, IndexDTO.PageSize),
            CurrentContinent = session.CurrentRoute.Continent
        };
        
        return View(viewResult);
    }

    public ViewResult Details(string id) {

        var country = data.Get(new QueryOptions<Country>
        {
            Includes = "Continent",
            Where = c => c.CountryID == id,
        });

        return View(country);
    }

    [HttpPost]
    public RedirectToActionResult Search(SearchViewModel SearchData) {
        
        if(ModelState.IsValid) {
            var temporalData = new SearchData(TempData)
            {
                SearchTerm = SearchData.SearchTerm
            };

            return RedirectToAction("Search");
        } else {
            return RedirectToAction("Index");
        }
    }

    [HttpGet]
    public IActionResult Search() {
        var tempData = new SearchData(TempData);

        if(tempData.HasSearchTerm) {

            var countryResults = data.List(new QueryOptions<Country>
            {
                Includes = "Continent",
                Where = c => c.Name.Contains(tempData.SearchTerm)
            });

            var vm = new SearchViewModel
            {
                Countries = countryResults, 
                Header = $"Result of the term '{tempData.SearchTerm}'"
            };

            return View("SearchResults", vm);
        } else {
            return RedirectToAction("Index");
        }
    }

}
