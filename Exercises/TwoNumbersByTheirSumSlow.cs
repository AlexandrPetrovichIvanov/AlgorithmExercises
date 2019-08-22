using System;
using System.Linq;

namespace Exercises
{
    public static class TwoNumbersByTheirSum 
    {
        [Obsolete("Don't use this variant. It's O(n^2).")]
        public static bool HasTwoNumbersWhichInTotalGivePassedSum_Slow(int[] array, int sum)
        {
            var length = array.Length;
            for (var i = 0; i < length; i++)
            {
                var firstPossibleNumber = array[i];

                for (var j = i + 1; j < length; j++)
                {
                    var secondPossibleNumber = array[j];

                    if (firstPossibleNumber + secondPossibleNumber == sum)
                        return true;
                }
            }

            return false;
        }
        
        public static bool HasTwoNumbersWhichInTotalGivePassedSum(int[] array, int sum)
        {
            var sortedList = array.ToList();
            
            // it uses introspective sort, that is approximately O(n*log n)
            // code: GenericArraySortHelper<T>.IntrospectiveSort(keys, index, length);
            sortedList.Sort();

            var minIndex = 0;
            var maxIndex = sortedList.Count - 1;

            int minNumber;
            int maxNumber;
            
            while (minIndex < maxIndex)
            {
                // it actually uses array, not list
                // we don't need to worry about access by index
                minNumber = sortedList[minIndex];
                maxNumber = sortedList[maxIndex];
                
                var currentSum = minNumber + maxNumber;
                
                if (currentSum == sum)
                    return true;

                if (currentSum > sum)
                    maxIndex--;

                if (currentSum < sum)
                    minIndex++;
            }
            
            // so, we have O((n*log n) + n)
            // for 1000000 items - it's 21000000
            // in case of O(n^2), we would have
            // for 1000000 items - 1000000000000
            
            return false;
        }
    }
}