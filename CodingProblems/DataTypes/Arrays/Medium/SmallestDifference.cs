using System;
using System.Linq;
using Xunit;

namespace CodingProblems.DataTypes.Arrays.Medium;

public class SmallestDifference
{
    [Fact]
    public void Calculate()
    {
        var result = Solution_One(new[] {-1, 5, 10, 20, 28, 3}, new[] {26, 134, 135, 15, 17});
    }

    public int[] Solution_One(int[] arrayOne, int[] arrayTwo)
    {
        var pair = new[] {int.MaxValue, int.MinValue};
        
        if (arrayOne.Any() && arrayTwo.Any())
        {
            Array.Sort(arrayOne);
            Array.Sort(arrayTwo);

            var arrayOnePointer = 0;
            var arrayTwoPointer = 0;

            var smallestDifference = int.MaxValue;

            while (arrayOnePointer < arrayOne.Length && arrayTwoPointer < arrayTwo.Length)
            {
                var val1 = arrayOne[arrayOnePointer];
                var val2 = arrayTwo[arrayTwoPointer];
                
                var arrayOneValue = Math.Abs(val1);
                var arrayTwoValue = Math.Abs(val2);

                var difference = Math.Abs(arrayOneValue - arrayTwoValue);

                if (difference == 0)
                {
                    return new[] {val1, val2};
                }

                if (difference < smallestDifference)
                {
                    smallestDifference = difference;
                    pair = new[] {val1, val2};
                }

                if (val1 < val2)
                {
                    arrayOnePointer++;
                }
                else
                {
                    arrayTwoPointer++;
                }
            }
        }
        
        return pair;
    }
}