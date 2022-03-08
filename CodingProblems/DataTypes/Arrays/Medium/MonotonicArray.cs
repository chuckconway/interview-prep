using System.Linq;
using Xunit;

namespace CodingProblems.DataTypes.Arrays.Medium;

public class MonotonicArray
{
    [Fact]
    public void Calculate()
    {
        var result = Solution_One(new[] {-1, -5, -10, -1100, -1100, -1101}); //true
        var result1 = Solution_One(new[] {-1, -5, -10, -1100, -1100, -1101, 10}); //false
        var result2 = Solution_One(new[] {0,0,0,0,0}); //true
        var result4 = Solution_One(new[] {0,10,20,30,40}); //true
    }

    public bool Solution_One(int[] array)
    {
        if (array.Any())
        {
            bool? increase = null;
            bool? decrease = null;
            
            //We don't need to check the last index, decause we already check it at 
            //The next to last index.
            for (var index = 0; index < array.Length -1; index++)
            {
                var current = array[index];
                var next = array[index + 1];

                if (current < next)
                {
                    increase = true;
                }

                if (current > next)
                {
                    decrease = true;
                }

                //If both have values, then this is not a Montonic Array
                if ((increase == null && decrease != null || 
                     increase != null && decrease == null ||
                     increase == null && decrease == null) == false)
                {
                    return false;
                }
            }
        }

        return true;
    }
}