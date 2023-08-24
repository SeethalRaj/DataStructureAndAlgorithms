using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

[assembly:InternalsVisibleTo("DataStructureAndAlgorithms.Test")]
namespace DataStructureAndAlgorithms
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the string (Ex: aab, xxxxhwida): ");
            string input = Console.ReadLine();

            Console.WriteLine(LeetCode._767_ReorganizeString.ReorganizeString(input));
          
            Console.ReadLine();
        }

     
    }
}
