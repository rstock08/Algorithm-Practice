using System;


namespace Practice_Problems
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Practice Problems from https://simpleprogrammer.com/programming-interview-questions/");
            Console.WriteLine("Problem 1: How do you find the missing number in a given integer array of 1 to 10?");

            int[] numbArray1 = { 1, 2, 3, 4, 6, 7, 8, 9, 10 };
            MissingNumber missingNumber = new MissingNumber(numbArray1);
            missingNumber.findMissingNumber();

            Console.WriteLine("Array passed: 1, 2, 3, 4, X, 6, 7, 8, 9, 10");
            Console.WriteLine("Missing number: " + missingNumber.missingNumber);

            Console.WriteLine("Problem 2: How do you find the duplicate number on a given integer array?");
            
            int[] numbArray2 = { 1, 2, 3, 4, 4, 5, 6, 7, 8, 9, 10 };
            DuplicateNumber duplicateNumber = new DuplicateNumber(numbArray2);

            Console.WriteLine("Array passed: 1, 2, 3, 4, 4, 5, 6, 7, 8, 9, 10");
            Console.WriteLine("Using two for loops we can find duplicates in n^2: " + duplicateNumber.findDuplicateLoop());
            Console.WriteLine("Using one for loop and a hash we can find duplicates in n: " + duplicateNumber.findDuplicateFaster());

            Console.WriteLine("Problem 3: How do you find the largest and smallest number in an unsorted integer array?");
            Console.WriteLine("By using merge sort we ");

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }
}
