using System;
using Xunit;
using Xunit.Abstractions;

namespace CodingProblems.Arrays;

public class NonConstructableChange
{
    private readonly ITestOutputHelper _testOutputHelper;

    public NonConstructableChange(ITestOutputHelper testOutputHelper)
    {
        _testOutputHelper = testOutputHelper;
    }

    [Fact]
    public void Solution_One()
    {
       var outcome = Calculate(new[] {1,1,4});

       _testOutputHelper.WriteLine(outcome.ToString());
    }

    public int Calculate(int[] coins)
    {
        Array.Sort(coins);

        var change = 0;

        for (int index = 0; index < coins.Length; index++)
        {
            var currentCoin = coins[index];
            var testValue = change + 1;

            if(testValue < currentCoin)
            {
                return testValue;
            } 
            else
            {
                change += currentCoin;
            }
        }

        return change + 1;
    }
}