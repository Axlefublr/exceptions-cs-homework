using System;

namespace Sorting;

public static class StringArraySorter {

   public static string[] SortAscending(string[] array) {
      Array.Sort(array);
      return array;
   }
   
   public static string[] SortDescending(string[] array) {
      array = SortAscending(array);
      Array.Reverse(array);
      return array;
   }
   
}