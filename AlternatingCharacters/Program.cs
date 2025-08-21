// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
decimal  a= 3.99872831m;
Console.WriteLine( 5/10);
string n = Console.ReadLine();

int result = Result.alternatingCharacters(n);
Console.WriteLine("result " + result);
class Result
{
    public static int alternatingCharacters(string s)
    {
        var deletions = 0;
        var index = 0;
        if (s.Length > 1)
        {
            foreach (var c in s)
            {
                if (index + 1 < s.Length - 1)
                {
                    if (c == s[index + 1])
                    {
                        deletions++;
                    }
                }

                if (s.Length - 1 == index && s[index - 1] == c)
                {
                    deletions++;
                }

                index++;
            }
        }


        return deletions;
    }

}
