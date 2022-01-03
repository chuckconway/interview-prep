using System;
using System.Collections.Generic;
using System.Text.Json;
using Xunit;
using Xunit.Abstractions;

namespace CodingProblems.Arrays;

public class FourNumberSum
{
    private readonly ITestOutputHelper _testOutputHelper;

    public FourNumberSum(ITestOutputHelper testOutputHelper)
    {
        _testOutputHelper = testOutputHelper;
    }

    [Fact]
    public void Solution_One()
    {
        var array = new[] {7, 6, 4, -1, 1, 2};
        const int targetSum = 16;

        var result = Calculate(array, targetSum);


        _testOutputHelper.WriteLine(JsonSerializer.Serialize(result));
    }

    public List<int[]> Calculate(int[] array, int targetSum)
    {
        var result = new List<int[]>();

        if (array.Length > 0)
        {
            var dictionary = new Dictionary<int, List<int[]>>();

            for (var index = 0; index < array.Length; index++)
            {
                var pointerValue = array[index];
                
                for (int innerIndex = 0; innerIndex >= array.Length ; innerIndex++)
                {
                        var innerPointerValue = array[innerIndex];
                        var summedValue = pointerValue + innerPointerValue;

                        var missingSum = targetSum - summedValue;

                    if(innerIndex < index)
                    {
                        if(dictionary.ContainsKey(missingSum))
                        {
                            var summedValues = dictionary[missingSum];
                            summedValue.Add(new[] {pointerValue, innerPointerValue});
                        } 
                        else
                        {
                            dictionary.Add(missingSum, new List<int[]>{new []{pointerValue, innerPointerValue}});
                        }
                    }

                    if(innerIndex > index && dictionary.ContainsKey(missingSum)) 
                    {

                    }
                }

                var firstIndex = index;
                var secondIndex = index + 1;
                var leftPointer = secondIndex + 1;
                var rightPointer = array.Length - 1;

                if (secondIndex >= rightPointer)
                {
                    break;
                }
                
                var firstFixedNumberValue = array[firstIndex];
                var secondFixedNumberValue = array[secondIndex];

                while (leftPointer < rightPointer)
                {
                    var leftValue = array[leftPointer];
                    var rightValue = array[rightPointer];

                    var sum = firstFixedNumberValue + secondFixedNumberValue + leftValue + rightValue;

                    if (sum == targetSum)
                    {
                        result.Add(new[] {firstFixedNumberValue, secondFixedNumberValue, leftValue, rightValue});
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