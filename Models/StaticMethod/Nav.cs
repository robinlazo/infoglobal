namespace CountryList.Models;


public static class Nav {
    public static string Active(int value, int current) => (value == current) ? "active" : "";
}