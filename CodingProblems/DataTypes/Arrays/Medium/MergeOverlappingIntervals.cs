using System;
using System.Collections.Generic;
using Xunit;

namespace CodingProblems.DataTypes.Arrays.Medium;

public class MergeOverlappingIntervals
{
    [Fact]
    public void Calculate()
    {
        // var intervals = new[]
        // {
        //     new[] {3, 5},
        //     new[] {1, 2},
        //     new[] {4, 7},
        //     new[] {6, 8},
        //     new[] {9, 10},
        // };
        
        // var intervals = new[]
        // {
        //     new[] {2, 3},
        //     new[] {4, 5},
        //     new[] {6, 7},
        //     new[] {8, 9},
        //     new[] {1, 10},
        // };

        var intervals = new[]
        {
            new[] {0, 0},
            new[] {0,0},
            new[] {0,0},
            new[] {0,0},
            new[] {0,0},
            new[] {0,0},
            new[] {0,0},

        };

        Solution_One(intervals);
    }

    public int[][] Solution_One(int[][] intervals)
    {
        Array.Sort(intervals, (left, right) => left[0].CompareTo(right[0]));

        var output = new List<int[]>();
        var currentInterval = intervals[0];
        
        for (var index = 1; index < intervals.Length; index++)
        {
            var current = currentInterval;
            var next = intervals[index];

            var currentEnd = current[1];
            var nextStart = next[0];

            var currentStart = current[0];
            var nextEnd = next[1];

            if (currentEnd >= nextStart && nextEnd >= currentEnd) // Merge
            {
                currentInterval = new[] {currentStart, nextEnd};
            }
            else if(currentEnd <= nextStart) // Add the left value.
            {
                output.Add(currentInterval);
                currentInterval = next;
            }
        }
        
        output.Add(currentInterval);
        
        return output.ToArray();
    }
}