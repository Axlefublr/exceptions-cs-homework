using System;

namespace Sorting;
internal class Program
{

   private static string[] Surnames = {
      "Arrayev",
      "Blockov",
      "Countov",
      "Dickens",
      "Earov"
   };

   private static void Main(string[] args)
   {
      string choice = GetInput();
      Func<string[], string[]> ascSortDelegate = delegate(string[] array)
      {
         array = StringArraySorter.SortAscending(array);
         return array;
      };
      Func<string[], string[]> descSortDelegate = delegate(string[] array)
      {
         array = StringArraySorter.SortDescending(array);
         return array;
      };
      if (choice == "1") {
         new Events(ascSortDelegate).Main(Surnames);
      } else {
         new Events(descSortDelegate).Main(Surnames);
      }
   }

   private static string GetInput()
   {
      string? choice = "";
      Console.WriteLine("Type '1' to sort in ascending order");
      Console.WriteLine("'2' to sort in descending order");
      while (
         string.IsNullOrEmpty(choice)
         && (choice != "1" || choice != "2")
      ) {
         choice = Console.ReadLine();
      }
      return choice;
   }
   
}
   
internal class Events {
   internal event Func<string[], string[]> SortEvent;
   internal Events(Func<string[], string[]> sortEventDelegate) {
      SortEvent += sortEventDelegate;
   }
   
   internal void Main(string[] surnames) {
      surnames = SortEvent.Invoke(surnames);
      foreach (string surname in surnames) {
         Console.WriteLine(surname);
      }
   }
}