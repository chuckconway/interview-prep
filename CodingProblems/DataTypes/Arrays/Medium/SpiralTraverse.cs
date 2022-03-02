using System.Collections.Generic;
using Xunit;

namespace CodingProblems.Arrays.Medium;

public class SpiralTraverse
{
    [Fact]
    public void Calculate()
    {
      // var d = new  [1, 2, 3, 4],
      //   [12, 13, 14, 5],
      //   [11, 16, 15, 6],
      //   [10, 9, 8, 7]
            
        var array = new[,]
        {
            { 1, 2, 3, 4}, 
            { 12, 13, 14, 5 }, 
            { 11, 16, 15, 6 }, 
            { 10, 9, 8, 7 }
        };

        //var result = Solution_One(array);
        var result = Solution_Two(array);
    }

    public List<int> Solution_One(int[,] array)
    {
        var result = new List<int>();
        var (startRow, endRow) = (0, array.GetLength(0) -  1);
        var (startCol, endCol) = (0, array.GetLength(1) - 1);

        while (startRow <= endRow && startCol <= endCol)
        {
            //Left to Right
            for (var column = startCol; column < endCol + 1; column++)
            {
                result.Add(array[startCol, column]);
            }
            
            //Right Top Corner to Bottom Right Corner
            for (var row = startRow + 1; row < endRow + 1; row++)
            {
                result.Add(array[row, endCol]);
            }
            
            //Bottom Right Corner to Left Bottom Corner
            for (var column = endCol -1; column > startCol; column--)
            {
                if (startRow == endRow)
                {
                    break;
                }
                
                result.Add(array[endRow, column]);
            }
            
            //Left Bottom Corner to Left Top Corner
            for (var row = endRow; row >= startRow + 1; row--)
            {
                
                if (startCol == endCol)
                {
                    break;
                }
                
                result.Add(array[row, startCol]);
            }

            startRow += 1;
            endRow -= 1;
            startCol += 1;
            endCol -= 1;
        }

        return result;
    }
    
    public List<int> Solution_Two(int[,] array)
    {
        var result = new List<int>();
        var (startRow, endRow) = (0, array.GetLength(0) -  1);
        var (startCol, endCol) = (0, array.GetLength(1) - 1);

        return Fill(startCol, endCol, startRow, endRow, array, result);
    }

    public List<int> Fill(int startCol, int endCol, int startRow, int endRow, int[,] array, List<int> result)
    {
        if (startRow > endRow && startCol > endCol)
        {
            return result;
        }
        
        //Left to Right
        for (var column = startCol; column < endCol + 1; column++)
        {
            result.Add(array[startCol, column]);
        }
            
        //Right Top Corner to Bottom Right Corner
        for (var row = startRow + 1; row < endRow + 1; row++)
        {
            result.Add(array[row, endCol]);
        }
            
        //Bottom Right Corner to Left Bottom Corner
        for (var column = endCol -1; column > startCol; column--)
        {
            if (startRow == endRow)
            {
                break;
            }
                
            result.Add(array[endRow, column]);
        }
            
        //Left Bottom Corner to Left Top Corner
        for (var row = endRow; row >= startRow + 1; row--)
        {
                
            if (startCol == endCol)
            {
                break;
            }
                
            result.Add(array[row, startCol]);
        }
        
        startRow += 1;
        endRow -= 1;
        startCol += 1;
        endCol -= 1;

        return Fill(startCol, endCol, startRow, endRow, array, result);
    }
}