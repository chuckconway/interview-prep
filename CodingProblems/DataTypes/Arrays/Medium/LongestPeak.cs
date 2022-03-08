using Xunit;

namespace CodingProblems.DataTypes.Arrays.Medium;

public class LongestPeak
{
    [Fact]
    public void Calculate()
    {
        var happyPath = new[] {0, 10, 6, 5, -1, -3,};
        var allNumbers = new[] {1, 2, 3, 3, 4, 0, 10, 6, 5, -1, -3, 2, 3};
        var failedTest = new[] {1, 2, 3, 4, 5, 1};
        
        var longest = Solution_One(failedTest);
    }

    private int Solution_One(int[] array)
    {
        var longest = 0;
        
        if (array.Length > 0)
        {
            for (var index = 1; index < array.Length - 1; index++)
            {
                var beforeIndex = index - 1;
                var afterIndex = index + 1;
                
                var before = array[beforeIndex];
                var peak = array[index];
                var after = array[afterIndex];

                var count = 3;

                if (peak > before && peak > after)
                {
                    beforeIndex--;

                    while (beforeIndex >= 0 && array[beforeIndex] < before)
                    {
                        before = array[beforeIndex];
                        beforeIndex--;
                        count++;
                    }

                    afterIndex++;
                    
                    while (afterIndex < array.Length && array[afterIndex] < after)
                    {
                        after = array[afterIndex];
                        afterIndex++;
                        count++;
                    }

                    if (count > longest)
                    {
                        longest = count;
                    }
                }
            }
        }

        return longest;
    }

    // public int Solution_One(int[] array)
    // {
    //     bool? increasing = null;
    //     bool? decreasing = null;
    //     int? previousValue = null;
    //     int count = 0;
    //     int longest = 0;
    //
    //     for (var index = 0; index < array.Length; index++)
    //     {
    //         var value = array[index];
    //
    //         //Has at least one here
    //         // if (increasing == true && previousValue < value)
    //         // {
    //         //     count++;
    //         //     previousValue = value;
    //         // }
    //         // else if(increasing == null && previousValue != null)
    //         // {
    //         //     count++;
    //         //     decreasing = true;
    //         //     increasing = true;
    //         // }
    //         //
    //         // if (decreasing == true && previousValue > value)
    //         // {
    //         //     previousValue = value;
    //         // }
    //         
    //         //N Item, must have at least one increasing value, previous value can't be null
    //         //and can't be increasing 
    //         
    //         //Second Item in a sequence, must be greater than the previous number
    //         if (increasing == true && previousValue != null && previousValue < value)
    //         {
    //             count++;
    //             previousValue = value;
    //         }
    //         else if(previousValue != null && previousValue > value)
    //         {
    //             decreasing = true;
    //         }
    //
    //         if (decreasing == true && previousValue != null && previousValue > value)
    //         {
    //             count++;
    //             previousValue = value;
    //             
    //             if (count >= 3)
    //             {
    //                 longest = count;
    //             }
    //         }
    //
    //         //First Item in a sequence
    //         if (previousValue == null)
    //         {
    //             count++;
    //             increasing = true;
    //             previousValue = value;
    //         }
    //
    //         //sequence broken
    //         if ((increasing == true && previousValue > value) && 
    //             (decreasing == true && previousValue < value))
    //         {
    //             count = 0;
    //             increasing = null;
    //             decreasing = null;
    //             previousValue = null;
    //         }
    //         
    //
    //         // if (previousValue == null || 
    //         //     (increasing == true && previousValue < value) ||
    //         //     (decreasing == true && previousValue > value))
    //         // {
    //         //     count++;
    //         //
    //         //     if (previousValue == null)
    //         //     {
    //         //         increasing = true;
    //         //     }
    //         //     
    //         //     previousValue = value;
    //         //     
    //         // }
    //         // else
    //         // {
    //         //     if (count > longest)
    //         //     {
    //         //         longest = count;
    //         //     }
    //         //
    //         //     count = 0;
    //         //     increasing = null;
    //         //     decreasing = null;
    //         //     previousValue = null;
    //         // }
    //     }
    //
    //     return longest;
    // }
}