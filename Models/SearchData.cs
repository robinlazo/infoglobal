using Microsoft.AspNetCore.Mvc.ViewFeatures;

public class SearchData {

    public const string SearchKey = "searchdatakey";
    public ITempDataDictionary TempData { get; set; }
    public SearchData(ITempDataDictionary temp) => TempData = temp;

    public string SearchTerm {
        get => TempData.Peek(SearchKey)?.ToString();
        set => TempData[SearchKey] = value;
    }

    public bool HasSearchTerm => !string.IsNullOrEmpty(SearchTerm);
 
    public void Clear() {
        TempData.Remove(SearchKey);
    }
}