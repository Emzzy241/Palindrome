
using System;
using Palindrome.Models;

namespace Palindrome.Models;
public class Program
{
    
    public static void Main()
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
            Console.WriteLine();
            Console.WriteLine("The word is a palindrome");
        }
        else
        {
            
        Console.WriteLine("Word is not a palindrome");
        }

        Console.WriteLine();
        Console.WriteLine("Would you like to go again?, enter y to go again. Enter any other letter to quit application");
        Console.WriteLine();

        string ans = Console.ReadLine().ToLower();
        if(ans == "y")
        {
            Console.WriteLine();
            Console.WriteLine();
            Main();
        }
        else
        {
            Console.WriteLine();
            Console.WriteLine("Goodbye dear User");
        }

    }

}

