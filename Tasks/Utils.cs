using System.Collections.Generic;
public static class Utils
{
    public static string TranslateToLat(string text)
    {
        Dictionary<string, string> dict = new Dictionary<string, string>(){
        {"i" ,"es"},
        {"want", "gribu"},
        {"find", "atrast"},
        {"job" ,"darbu"},
        {"good","labu"}
        };
        if (string.IsNullOrEmpty(text))
        {
            return "Enter your text";
        }
        string resText = "";
        text = text.Trim().ToLower();
        string[] strArray = text.Split(" ");

        foreach (string word in strArray)
        {
            if (dict.ContainsKey(word))
            {
                resText += $"{dict[word]} ";
            }
            else if (word == "a" || word == "to")
            {
                resText += "";
            }
            else
            {
                resText += "__ ";
            }
        }


        return FirstCharUpper(resText);
    }
    public static string FirstCharUpper(string input)
    {
        if (string.IsNullOrEmpty(input))
        {
            return string.Empty;
        }
        return $"{input[0].ToString().ToUpper()}{input.Substring(1)}";
    }
}