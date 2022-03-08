using System;
using Xunit;

namespace CodingProblems.DataTypes.Arrays.Medium;

public class FirstDuplicateValue
{
    [Fact]
    public void Calculate()
    {
        var array = new[] {2, 1, 5, 3, 3, 2, 4};

        var result = Solution_One(array);
    }

    public int Solution_One(int[] array)
    {
        for (var index = 0; index < array.Length; index++)
        {
            var absoluteValue = Math.Abs(array[index]);

            if (array[absoluteValue - 1] < 0)
            {
                return absoluteValue;
            }

            //Change the value to a negative value to show indicate we've already viewed it.
            array[absoluteValue - 1] *= -1;

        }

        return -1;
    }
}