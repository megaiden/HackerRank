// See https://aka.ms/new-console-template for more information
using System.Text;

Console.WriteLine("Reverse the string!");

var str = Console.ReadLine();

var result = Result.reverseSring(str);

Console.WriteLine(result);


class Result
{
    public static string reverseSring(string str)
    {
        var dmStr = new StringBuilder();

        for(var i  = str.Length-1; i >= 0; i--)
        {
            dmStr.Append(str[i]);
        }

        return dmStr.ToString();
    }
}
