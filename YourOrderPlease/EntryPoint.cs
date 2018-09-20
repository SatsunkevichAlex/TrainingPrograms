using System;
using System.Collections.Generic;
using System.Linq;

class EntryPoint
{
    static void Main()
    {
        string str = "Te4st is2 Thi1s 3a";
        Console.WriteLine(Order(str));
    }

    public static string Order(string str)
    {
        //var a = str.Split(' ').Select(t => (int)(t.First(x => Char.IsNumber(x))) - 48).ToArray();
        string ans = "";
        foreach (int index in str.Split(' ').Select(t => (int)(t.First(x => Char.IsNumber(x))) - 48))
        {
            ans += (str.Split(' ')[index - 1]) + " ";
        }
        return ans;
    }
}