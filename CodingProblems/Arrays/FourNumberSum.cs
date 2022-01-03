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
        var results = new List<int[]>();

        if (array.Length > 0)
        {
            var allPairSums = new Dictionary<int, List<int[]>>();

            for (var index = 0; index < array.Length; index++)
            {
                var pointerValue = array[index];

                //
                for (var addToDictionaryIndex = index + 1; addToDictionaryIndex < array.Length; addToDictionaryIndex++)
                {
                    
                }

                for (var innerIndex = 0; innerIndex < array.Length; innerIndex++)
                {
                    if (index != innerIndex)
                    {
                        var innerPointerValue = array[innerIndex];
                        var summedValue = pointerValue + innerPointerValue;

                        AddSumToDictionary(innerIndex, index, dictionary, summedValue, pointerValue, innerPointerValue);

                        var missingSum = targetSum - summedValue;

                        AddSumsThatEqualTargetSum(innerIndex, index, dictionary, missingSum, pointerValue, innerPointerValue, result);
                    }
                }
            }
        }

        return result;
    }

    private static void AddSumsThatEqualTargetSum(
        int innerIndex, 
        int index, 
        IReadOnlyDictionary<int, List<int[]>> dictionary, 
        int missingSum,
        int pointerValue, 
        int innerPointerValue, 
        ICollection<int[]> result)
    {
        if (innerIndex > index && dictionary.ContainsKey(missingSum))
        {
            var pairs = dictionary[missingSum];

            foreach (var pair in pairs)
            {
                var digits = new List<int>();
                digits.AddRange(new[] {pointerValue, innerPointerValue});
                digits.AddRange(pair);

                result.Add(digits.ToArray());
            }
        }
    }

    private static void AddSumToDictionary(
        int innerIndex, 
        int index, 
        Dictionary<int, List<int[]>> dictionary, 
        int summedValue,
        int pointerValue, int innerPointerValue)
    {
        if (innerIndex < index)
        {
            if (dictionary.ContainsKey(summedValue))
            {
                var summedValues = dictionary[summedValue];
                summedValues.Add(new[] {pointerValue, innerPointerValue});
            }
            else
            {
                dictionary.Add(summedValue, new List<int[]> {new[] {pointerValue, innerPointerValue}});
            }
        }
    }
}