using System;


namespace Practice_Problems
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Practice Problems from https://simpleprogrammer.com/programming-interview-questions/");
            Console.WriteLine("Problem 1: How do you find the missing number in a given integer array of 1 to 10?");

            int[] numbArray = { 1, 2, 3, 4, 6, 7, 8, 9, 10 };
            MissingNumber missingNumber = new MissingNumber(numbArray);
            missingNumber.findMissingNumber();

            Console.WriteLine("Array passed: 1, 2, 3, 4, X, 6, 7, 8, 9, 10");
            Console.WriteLine("Missing number: " + missingNumber.missingNumber);





            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }
}
