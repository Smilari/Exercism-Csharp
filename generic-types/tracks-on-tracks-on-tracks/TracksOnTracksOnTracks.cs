public static class Languages
{
    public static List<string> NewList() => new List<string>();

    public static List<string> GetExistingLanguages(){
        var languages = NewList();
        languages.Add("C#");
        languages.Add("Clojure");
        languages.Add("Elm");
        return languages;
    } 
    public static List<string> AddLanguage(List<string> languages, string language){
        languages.Add(language);
        return languages;
    }

    public static int CountLanguages(List<string> languages){
        return languages.Count;
    }

    public static bool HasLanguage(List<string> languages, string language){
        return languages.Contains(language);
    }

    public static List<string> ReverseList(List<string> languages){
        languages.Reverse();
        return languages;
    }

    public static bool IsExciting(List<string> languages){
        var index = languages.FindIndex(x => x == "C#"); 
        if(index == 0){
            return true;
        } else if (index == 1){
            return languages.Count == 2 || languages.Count == 3;
        }
        return false;
    }

    public static List<string> RemoveLanguage(List<string> languages, string language){
        languages.Remove(language);
        return languages;
    }

    public static bool IsUnique(List<string> languages){
        return languages.Distinct().Count() == languages.Count;
    }
}
