using System;
namespace CountryList.Models;

public static class StringExtensions {
    public static string Capitalize(this string value) => Char.ToUpper(value[0]) + value.Substring(1);


     public static int ToInt(this string value) {
        int.TryParse(value, out int result);
        return result;
    }

    public static bool EqualsNoCase(this string value, string compared) {
        string valueLower = value.ToLower();
        string comparedLower = compared.ToLower();

        return valueLower == comparedLower;
    }
}