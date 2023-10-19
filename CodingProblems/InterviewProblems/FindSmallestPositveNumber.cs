using System;
using Xunit;

namespace CodingProblems.InterviewProblems;
/// <summary>
// Write a function:
//
// class Solution { public int solution(int[] A); }
//
// that, given an array A of N integers, returns the smallest positive integer (greater than 0) that does not occur in A.
//
// For example, given A = [1, 3, 6, 4, 1, 2], the function should return 5.
//
//     Given A = [1, 2, 3], the function should return 4.
//
//     Given A = [−1, −3], the function should return 1.
//
//     Write an efficient algorithm for the following assumptions:
//
// N is an integer within the range [1..100,000];
// each element of array A is an integer within the range [−1,000,000..1,000,000].
/// </summary>
public class FindSmallestPositiveNumber
{
    [Fact]
    public void Calculate()
    {
       var value = Solution_One(new[] {1, 3, 6, 4, 1, 2});
    }

    public int Solution_One(int[] A)
    {
        var smallestNumber = 1;
        Array.Sort(A);
        var hasPositiveNumber = false;

        for (var index = 0; index < A.Length; index++)
        {
            var item = A[index];

            if(smallestNumber + 1 == item && item > 0)
            {
                hasPositiveNumber = true;
                smallestNumber++;
            } 
        }

        if (hasPositiveNumber)
        {
            smallestNumber++;
        }

        return smallestNumber;// write your code in C# 6.0 with .NET 4.5 (Mono)
    }
}