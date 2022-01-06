using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace CodingProblems.Arrays.Medium;

public class MoveElementToEnd
{
    [Fact]
    public void Calculate()
    {
        var result = Solution_One(new List<int>
        {2, 1, 2, 2,
            2,
            3,
            4,
            2
        }, 4);
    }

    private List<int> Solution_One(List<int> array, int toMove)
    {
        var tailPointer = array.Count - 1;
        var leftPointer = 0;

        while (leftPointer < tailPointer)
        {
            var currentValue = array[leftPointer];

            if (currentValue == toMove)
            {
                var tailValue = array[tailPointer];

                if (tailValue == toMove)
                {
                    tailPointer--;
                }
                else
                {
                    array[leftPointer] = tailValue;
                    array[tailPointer] = toMove;
                    
                    tailPointer--;
                    leftPointer++;
                }
            }
            else
            {
                leftPointer++;
            }
        }

        return array;
    }
}