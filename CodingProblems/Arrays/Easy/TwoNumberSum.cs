using System;
using System.Collections.Generic;
using Xunit;

namespace CodingProblems.Arrays.Easy 
{

/// <summary>
/// Write a function that takes in a non-empty array of distinct integers and an integer representing a target sum. If any two numbers in the input array sum up to the target sum, the function should return them in an array, in any order. If no two numbers sum up to the target sum, the function should return an empty array.
///
/// Note that the target sum has to be obtained by summing two different integers in the array; you can't add a single integer to itself in order to obtain the target sum.
///
/// You can assume that there will be at most one pair of numbers summing up to the target sum.
/// </summary>
public class TwoNumberSum
{
    [Fact]
    public void Calculate()
    {
        var values  = Solution_Three(new[] {3, 2, 1, 4, 5, 6}, 11);
    }

    public int[] Solution_Three(int[] integers, int targetSum)
    {
        if (integers is {Length: > 0})
        {
            Array.Sort(integers);
            
            var leftPointer = 0;
            var rightPointer = integers.Length - 1;

            while (leftPointer != rightPointer)
            {
                var leftValue = integers[leftPointer];
                var rightValue = integers[rightPointer];

                var summedPointers = leftValue + rightValue;

                if (summedPointers == targetSum)
                {
                    return new[] {leftValue, rightValue};
                }

                if (summedPointers < targetSum)
                {
                    leftPointer++;
                }
                else
                {
                    rightPointer--;
                }
            }
        }

        return Array.Empty<int>();
    }
    
    public int[] Solution_Two(int[] integers, int targetSum)
    {
        if (integers is {Length: > 0})
        {
            var hash = new HashSet<int>();

            for (var index = 0; index < integers.Length; index++)
            {
                var left = integers[index];
                var right = targetSum - left;

                var hasValue = hash.Contains(right);

                if (hasValue)
                {
                    return new[] {integers[index], right};
                }

                hash.Add(left);
            }
            
        }

        return Array.Empty<int>();
    }


    public int[] Solution_One(int[] integers, int targetSum)
    {
        if (integers is {Length: > 0})
        {
            Array.Sort(integers);

            for (var index = 0; index < integers.Length; index++)
            {
                var left = integers[index];
                var right = targetSum - left;

                var rightIndex = BinarySearch(integers, right);

                if (rightIndex >= 0)
                {
                    return new[] {integers[index], integers[rightIndex]};
                }
            }
            
        }

        return Array.Empty<int>();
    }

    public int BinarySearch(int[] items, int searchValue)
    {
        var left = 0;
        
        //Make sure there are items in the array.
        var right = items.Length - 1;

        while (left <= right)
        {
            var middle = (left + right) / 2;

            //If the searchValue is in the center, we found it!
            if (items[middle] == searchValue)
            {
                return middle;
            }

            //If the searchValue is less than the current middle, we set the right to (middle - 1)
            //Because the searchValue is in the lower half of the items.
            if (searchValue < items[middle])
            {
                right = middle - 1;
            }
            //If the searchValue is greater than the current middle, we set the right to (middle + 1)
            //Because the searchValue is in the higher half of the items.
            else
            {
                left = middle + 1;
            }

        } // now that we've either found the item and returned it or we've reset our search boundaries
        // we'll search it again.

        // Not found.
        return -1;
    }
}
}