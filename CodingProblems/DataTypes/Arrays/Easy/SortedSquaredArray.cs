using System;
using Xunit;

namespace CodingProblems.Arrays.Easy;

public class SortedSquaredArray
{
    [Fact]
    public void Solution_One()
    {
        var input = new []{-10, -7, -4, 1, 2, 3, 5, 6, 8, 9};

        var result =  Calculate(input);
    }

    public int[] Calculate(int[] sortedArray)
    {
        var squared = new int[sortedArray.Length];
        var leftIndex = 0;
        var rightIndex = sortedArray.Length - 1;

        while (leftIndex <= rightIndex)
        {
            var leftAbsoluteValue = Math.Abs(sortedArray[leftIndex]);
            var rightAbsoluteValue = Math.Abs(sortedArray[rightIndex]);
            var storageIndex = rightIndex - leftIndex;

            if (leftAbsoluteValue > rightAbsoluteValue)
            {
                squared[storageIndex] = leftAbsoluteValue * leftAbsoluteValue;
                leftIndex++;
            }
            else
            {
                squared[storageIndex] = rightAbsoluteValue * rightAbsoluteValue;
                rightIndex--;
            }
        }

        return squared;
    }
}