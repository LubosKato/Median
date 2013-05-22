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
             double median = 0;
             var sourceNumbers = values as double?[] ?? values.ToArray();
             if (sourceNumbers == null || sourceNumbers.Length == 0)
             {
                 throw new NotImplementedException();
             }

             //make sure the list is sorted, but use a new array
            var sortedPNumbers = (double?[])sourceNumbers.Clone();
            sourceNumbers.CopyTo(sortedPNumbers, 0);
            Array.Sort(sortedPNumbers);
            sortedPNumbers = sourceNumbers.Where(x => x != null).ToArray();
            //get the median
            int size = sortedPNumbers.Length;
            int mid = size / 2;
             var sortedPNumber = sortedPNumbers[mid];
             if (sortedPNumber != null)
             {
                 var pNumber = sortedPNumbers[mid - 1];
                 if (pNumber != null)
                     median = (size % 2 != 0) ? (double)sortedPNumber : ((double)sortedPNumber + (double)pNumber) / 2;
             }
             return median;
         }
    }
}