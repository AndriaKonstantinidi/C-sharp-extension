using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<string> list = new List<string>();
        list.Add("asd");
        list.Add("");
        foreach(var item in list)
        {
            Console.WriteLine(item.IsEmpty().InGeorgian());
        }

        List<int> list2 = new List<int>();
        list2.Add(1);
    }
}

public static class StringExtensions
{
    public static bool IsEmpty(this string str)
    {
        return string.IsNullOrEmpty(str);
    }
}

public static class BoolExtensions
{
    public static string InGeorgian(this bool str)
    {
        return str ? "sworia" : "arasworia";
    }
}