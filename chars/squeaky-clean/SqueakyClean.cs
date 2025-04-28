using System.Text;

public static class Identifier
{
    public static string Clean(string identifier){
        var sb = new StringBuilder();
        bool kebabCase = false;
        
        foreach (char c in identifier){
            if(char.IsControl(c))
                sb.Append("CTRL");
             
            if(char.Equals(c, '-'))
                kebabCase = true;

            if(char.IsWhiteSpace(c))
                sb.Append("_");

            if(char.IsLetter(c) && !kebabCase && !char.IsBetween(c, (char)945, (char)969)) 
                sb.Append(c);

            if(kebabCase && char.IsLetter(c)){
                sb.Append(char.ToUpper(c));
                kebabCase = false;
            }
        }

        return sb.ToString();
    }
}
