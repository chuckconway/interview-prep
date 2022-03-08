using System;
using System.Collections.Generic;
using System.Text.Json;
using Xunit;
using Xunit.Abstractions;

namespace CodingProblems.DataTypes.Arrays.Medium;

public class ThreeNumberSum
{
    private readonly ITestOutputHelper _testOutputHelper;

    public ThreeNumberSum(ITestOutputHelper testOutputHelper)
    {
        _testOutputHelper = testOutputHelper;
    }

    [Fact]
    public void Solution_One()
    {
        var array = new[] {12, 3, 1, 2, -6, 5, -8, 6};
        var targetSum = 0;

        var result = Calculate(array, targetSum);


        _testOutputHelper.WriteLine(JsonSerializer.Serialize(result));
    }

    public List<int[]> Calculate(int[] array, int targetSum)
    {
        var result = new List<int[]>();

        if (array.Length > 0)
        {
            Array.Sort(array);

            for (var index = 0; index < array.Length; index++)
            {
                var changeNumberValue = array[index];
                var leftPointer = index + 1;
                var rightPointer = array.Length - 1;

                while (leftPointer < rightPointer)
                {
                    var leftValue = array[leftPointer];
                    var rightValue = array[rightPointer];

                    var sum = changeNumberValue + leftValue + rightValue;

                    if (sum == targetSum)
                    {
                        result.Add(new[] {changeNumberValue, leftValue, rightValue});
                    }

                    if (sum < targetSum)
                    {
                        leftPointer++;
                    }
                    else
                    {
                        rightPointer--;
                    }
                }
            }
        }

        return result;
    }
}