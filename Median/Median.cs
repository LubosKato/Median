using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise
{
    // extensin method for generic IEnumerable double computing median
    public static class Median
    {
         public static double ComputeMedian(this IEnumerable<double?> values)
         {
             var sourceNumbers = values as double?[] ?? values.ToArray();
             if (sourceNumbers.Length == 0)
             {
                 throw new NotImplementedException();
             }

             //make sure the list is sorted, but use a new array
            var sortedPNumbers = (double?[])sourceNumbers.Clone();
            sourceNumbers.CopyTo(sortedPNumbers, 0);
            Array.Sort(sortedPNumbers);
            sortedPNumbers = sortedPNumbers.Where(x => x != null).ToArray();
            //get the median
            int size = sortedPNumbers.Length;
            int mid = size / 2;
             var median = (size % 2 != 0) ? (double)sortedPNumbers[mid] : ((double)sortedPNumbers[mid] + (double)sortedPNumbers[mid - 1]) / 2;
             return median;
         }
    }
}