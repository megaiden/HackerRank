// See https://aka.ms/new-console-template for more information
using System.Text;

Console.WriteLine("Hello, World!");
string n = Console.ReadLine();

var result = Result.SearchChars(n);

Console.WriteLine(result);
class Result
{
    public static string SearchChars(string s)
    {
        StringBuilder reversedString = new StringBuilder(s.Length);
        List<int> dynamicIntArray = new List<int>();
        for (int i = s.Length - 1; i >= 0; i--)
        {
            if (char.IsLetter(s[i]))
            {
                reversedString.Append(s[i]);
            }
            else
            {
                dynamicIntArray.Add(s.IndexOf(s[i]));
            }
          
        }

   
        foreach (var i in dynamicIntArray)
        {
            reversedString.Insert(i, s[i]);  
        }

        return reversedString.ToString();

    }

}
