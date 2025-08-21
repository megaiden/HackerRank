// See https://aka.ms/new-console-template for more information
using System.Text;
using System;
using static System.Net.Mime.MediaTypeNames;

Console.WriteLine("Hello, World!");
string n = Console.ReadLine();
string n2 = Console.ReadLine();

var result = Result.makeAnagram(n, n2);

Console.WriteLine(result);
class Result
{
    public static int makeAnagram(string a, string b)
    {
        // Initialize an array to store the frequency of characters in both strings
        int[] charCount = new int[26]; // Assuming lowercase English letters


        foreach (char c in a)
        {
            charCount[c - 'a']++;
        }


        foreach (char c in b)
        {
            charCount[c - 'a']--;
        }

        // Calculate the total number of deletions required
        int deletions = 0;
        foreach (int count in charCount)
        {
            deletions += Math.Abs(count); // Absolute value to handle negative counts
        }

        return deletions;
    }

}

