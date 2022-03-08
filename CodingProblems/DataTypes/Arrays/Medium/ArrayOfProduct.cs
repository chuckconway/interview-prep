using Xunit;

namespace CodingProblems.DataTypes.Arrays.Medium;

public class ArrayOfProduct
{
    [Fact]
    public void Calculate()
    {
        var happyPath = new[] {0, 10, 6, 5, -1, -3,};
        var allNumbers = new[] {1, 2, 3, 3, 4, 0, 10, 6, 5, -1, -3, 2, 3};
        var array = new[] {5, 1, 4, 2};
        
        var output = Solution_One(array);
    }

    private int[] Solution_One(int[] array)
    {
        var output = new int[array.Length];
        
        var leftIndex = 0;
        var leftValue = 1;

        //Left
        while (leftIndex < array.Length)
        {
            output[leftIndex] = leftValue;
            leftValue *= array[leftIndex];
            leftIndex++;
        }

        var rightIndex = array.Length - 1;
        var rightValue = 1;
            
        //Right
        while (rightIndex >= 0)
        {
            output[rightIndex] *= rightValue;
            rightValue *= array[rightIndex];
            rightIndex--;
        }

        return output;
    }
}