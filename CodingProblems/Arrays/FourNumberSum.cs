using System.Collections.Generic;
using System.Linq;
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

            for (var index = 1; index < array.Length -1; index++)
            {
                var pointerValue = array[index];

                //Check to see if missing difference is in the allPairSums dictionary, if it is add it to the results.
                for (var addToResultsIndex = index + 1; addToResultsIndex < array.Length; addToResultsIndex++)
                {
                    var currentValue = array[addToResultsIndex];
                    var currentSum = currentValue + pointerValue;
                    var difference = targetSum - currentSum;

                    if (allPairSums.ContainsKey(difference))
                    {
                        var pairs = allPairSums[difference];

                        foreach (var pair in pairs)
                        {
                            var quadruplet = pair.Concat(new[] {pointerValue, currentValue});
                            results.Add(quadruplet.ToArray());
                        }
                    }
                }

                // Add values to the allPairsSums dictionary
                for (var addToDictionaryIndex = 0; addToDictionaryIndex < index; addToDictionaryIndex++)
                {
                    var currentValue = array[addToDictionaryIndex];
                    var currentSum = currentValue + pointerValue;

                    if (allPairSums.ContainsKey(currentSum))
                    {
                        var summedValues = allPairSums[currentSum];
                        summedValues.Add(new[] {pointerValue, currentValue});
                    }
                    else
                    {
                        allPairSums.Add(currentSum, new List<int[]> { new[] {pointerValue, currentValue}} );
                    }
                }
            }
        }

        return results;
    }
}