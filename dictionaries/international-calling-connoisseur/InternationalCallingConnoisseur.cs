public static class DialingCodes{
    public static Dictionary<int, string> GetEmptyDictionary() {
        return new Dictionary<int, string>(); 
    }

    public static Dictionary<int, string> GetExistingDictionary(){
        var dict = GetEmptyDictionary();
        AddCountryToExistingDictionary(dict, 1, "United States of America");
        AddCountryToExistingDictionary(dict, 55, "Brazil");
        AddCountryToExistingDictionary(dict, 91, "India");
        return dict;
    }

    public static Dictionary<int, string> AddCountryToEmptyDictionary(int countryCode, string countryName) {
        var dict = GetEmptyDictionary();
        dict.Add(countryCode, countryName);
        return dict;
    }

    public static Dictionary<int, string> AddCountryToExistingDictionary(
        Dictionary<int, string> existingDictionary, int countryCode, string countryName){
            existingDictionary.Add(countryCode, countryName);
            return existingDictionary;
        }

    public static string GetCountryNameFromDictionary(
        Dictionary<int, string> existingDictionary, int countryCode){
            if (existingDictionary.ContainsKey(countryCode)){
                return existingDictionary[countryCode];
            }
            return string.Empty;
    }

    public static bool CheckCodeExists(Dictionary<int, string> existingDictionary, int countryCode){
        return existingDictionary.ContainsKey(countryCode);
    }

    public static Dictionary<int, string> UpdateDictionary(
        Dictionary<int, string> existingDictionary, int countryCode, string countryName){
            if (!existingDictionary.ContainsKey(countryCode)){
                return existingDictionary;
            }
            existingDictionary[countryCode] = countryName;
            return existingDictionary;
    }

    public static Dictionary<int, string> RemoveCountryFromDictionary(
        Dictionary<int, string> existingDictionary, int countryCode){
            existingDictionary.Remove(countryCode);
            return existingDictionary;
    }

    public static string FindLongestCountryName(Dictionary<int, string> existingDictionary){
        var longestCountryName = string.Empty;
        foreach(var country in existingDictionary){
            if(country.Value.Length > longestCountryName.Length){
                longestCountryName = country.Value;
            }
        }
        
        return longestCountryName;
    }
}