using System.Collections.Generic;
using System.Runtime.Serialization;
using Xunit;

namespace CodingProblems.Patterns.SlidingWindow;

public class AverageSumOfSlidingSubArray
{
    [Fact]
    public void Calculate()
    {
        var array = new[] {1, 3, 2, 6, -1, 4, 1, 8, 2};
        var result = Solution_One(5, array);
    }

    public decimal[] Solution_One(int size, int[] array)
    {
        var currentSum = 0;
        var firstValue = 0;
        var maxPosition = size;

        var result = new List<decimal>();
        
        for (var index = 0; index < array.Length; index++)
        {
            var first = index % size == 0;
            var last = index % size == size;
            
            if (first)
            {
                firstValue = array[index];
                currentSum += array[index];
            }

            if (first == false && last == false)
            {
                currentSum += array[index];
            }
            
            // if (index < maxPosition)
            // {
            //     if (index % size == 0)
            //     {
            //         
            //     }
            //     
            //     
            // }
            // else
            // {
            //     result.Add((decimal)currentSum / size);
            //     currentSum -= firstValue;
            //
            //     maxPosition += size;
            //
            //     // if (maxPosition > array.Length)
            //     // {
            //     //     index = array.Length;
            //     // }
            // }
            
            if (last)
            {
                result.Add((decimal)currentSum / size);
                currentSum -= firstValue;

                //maxPosition += size;
            }
        }

        return result.ToArray();
    }
}