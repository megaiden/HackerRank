// See https://aka.ms/new-console-template for more information
Console.WriteLine("Valid String");
string n = Console.ReadLine();

var result = Result.isValid(n);
Console.WriteLine("result " + result);

class Result
{

    /*
     * Complete the 'isValid' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts STRING s as parameter.
     */

    public static string isValid(string s)
    {
        if (s.Length <= 1)
        {
            return "YES";
        }

        Dictionary<char, int> charCounts = new Dictionary<char, int>();

        foreach (char c in s)
        {
            if (charCounts.ContainsKey(c))
            {
                charCounts[c]++;
            }
            else
            {
                charCounts[c] = 1;
            }
        }

        var grp = charCounts.GroupBy(x => x.Value);
        if (grp.Count() == 1)
        {
            return "YES";
        }
        if (grp.Count() > 2)
        {
            return "NO";
        }

        int maxCount = charCounts.Values.Max();
        int minCount = charCounts.Values.Min();
        int maxCountFrequency = charCounts.Count(kv => kv.Value == maxCount);
        int minCountFrequency = charCounts.Count(kv => kv.Value == minCount);

        int separationOfValues = charCounts.Count(x => x.Value == minCount + 1);
        if (separationOfValues > 0)
        {

            if (minCountFrequency > 1 || maxCount == minCount || maxCount - minCount == 1)
            {
                if (maxCountFrequency == 1 || maxCountFrequency == charCounts.Count - 1)
                {
                    return "YES";
                }

            }
        }

        if (separationOfValues == 0 && minCountFrequency > 2)
        {
            return "NO";
        }

        if (maxCountFrequency > minCountFrequency)
        {
            var dif = maxCountFrequency - minCountFrequency;
            if (charCounts.Count - 2 == dif )// this means there is only one we need to eliminate from min frequency
            {
                return "YES";
            }
        }
        if (minCountFrequency > maxCountFrequency)
        {
            var dif = minCountFrequency - maxCountFrequency;
            if (charCounts.Count - 2 == dif )// this means there is only one we need to eliminate from max frequency
            {
                return "YES";
            }
        }
        

        return "NO";
    }

}