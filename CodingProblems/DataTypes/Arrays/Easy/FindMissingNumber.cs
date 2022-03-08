using System;
using System.Collections.Generic;
using Xunit;
using Xunit.Abstractions;

namespace CodingProblems.DataTypes.Arrays.Easy;

public class FindMissingNumber
{
    private readonly ITestOutputHelper _testOutputHelper;

    public FindMissingNumber(ITestOutputHelper testOutputHelper)
    {
        _testOutputHelper = testOutputHelper;
    }

    [Fact]
    public void Calculate()
    {
        var num = new List<int> {3, 7, 1, 9, 8, 6, 2, 5, 10};

        var value = Solution_One(num);
        
        _testOutputHelper.WriteLine(value.ToString());
    }
    
    [Fact]
    public void Calculate_Two()
    {
        var num = new List<int> {3, 7, 1, 9, 8, 6, 2, 5, 10};
        
        //var num = new List<int> {1, 3, 4};

        var value = Solution_Two(num);
        
        _testOutputHelper.WriteLine(value.ToString());
    }

    public int Solution_One(List<int> num)
    {
        num.Sort();

        for(var index = 0; index < num.Count; index++)
        {           
            var value = num[index];
            
            Console.WriteLine(value);
            
            if (value -1 != index){
                return value -1;
            }
        }
        
        return 0;
    }
    
    public int Solution_Two(List<int> num)
    {
        var indexSum = 0;
        var numSum = 0;
        var currentIndex = 0;
        
        for(var index = 0; index < num.Count; index++)
        {
            currentIndex = index + 1;
            indexSum += (index + 1);
            numSum += num[index];
        }

        return (indexSum + currentIndex + 1) - numSum;
    }
}