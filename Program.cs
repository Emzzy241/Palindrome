
using System;
using Palindrome.Models;

namespace Palindrome.Models;
public class Program
{
    
    public static void Main(string[] args)
    {
        Console.WriteLine("Welcome to my Palindrome Checker App");

        Console.WriteLine();
        Console.WriteLine("Enter a word to chec if its a Palindrome");
        // Examples of palindrome are: kayak, bob, level, civic

        string input = Console.ReadLine();

        // Turning that word into an array of characters so they can then be reversed
        char[] arr = input.ToCharArray();

        // .ToCharArray() is a method for splitting a string into multiple arrays

        Array.Reverse(arr);

        String word = new String(arr);

        if(input == word)
        {
            Console.WriteLine("The word is a palindrome");
        }
        else
        {
            
        Console.WriteLine("Word is not a palindrome");
        }
    }

}

