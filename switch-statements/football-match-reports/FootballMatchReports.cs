public static class PlayAnalyzer
{
    public static string AnalyzeOnField(int shirtNum){
        switch (shirtNum)
        {
            case 1: return "goalie";
            case 2: return "left back";
            case 3 or 4: return "center back";
            case 5: return "right back";
            case 6 or 7 or 8: return "midfielder";
            case 9: return "left wing";
            case 10: return "striker";
            case 11: return "right wing";
            default : return "UNKNOWN";
        }
    }

    public static string AnalyzeOffField(object report)
    {
        switch (report)
        {
            case int n: return $"There are {n} supporters at the match.";
            case string s: return s;
            case Foul f: return "The referee deemed a foul.";
            case Injury i: return $"Oh no! {i.GetDescription()} Medics are on the field.";
            case Incident i: return "An incident happened.";
            case Manager m: return m.Club == null ? $"{m.Name}": $"{m.Name} ({m.Club})"; 

            default: return "";
        }
    }
}
