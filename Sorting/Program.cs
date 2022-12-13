using System;

namespace Sorting;
internal class Program
{
   private static void Main(string[] args)
   {
      string choice = GetInput();
   }

   private static string GetInput()
   {
      string? choice;
      Console.WriteLine("Type '1' to sort in ascending order");
      Console.WriteLine("'2' to sort in descending order");
      do
      {
         choice = Console.ReadLine();
      }
      while (
         string.IsNullOrEmpty(choice)
         || choice != "1"
         || choice != "2"
      );
      return choice;
   }
}