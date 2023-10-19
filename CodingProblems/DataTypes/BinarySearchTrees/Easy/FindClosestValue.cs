using System;
using System.Runtime.InteropServices;
using Xunit;

namespace CodingProblems.DataTypes.BinarySearchTrees.Easy;

public class FindClosestValue
{
    [Fact]
    public void Calculate()
    {
        var bst = TestData();
        var nearest = Solution_One(bst, 10);
    }

    public static int Solution_One(BST tree, int target, int closestValue = int.MaxValue)
    {
        if (tree == null)
        {
            return closestValue;
        }
        
        if (closestValue >= Math.Abs(tree.value - target))
        {
            closestValue = tree.value;
        }
        
        if(closestValue == target)
        {
            return closestValue;
        }
        
        var leftDifference = tree.left.value - target;
        var rightDifference = tree.right.value - target;

        if (leftDifference < rightDifference)
        {
            return Solution_One(tree.left, target, closestValue);
        }
            
        return Solution_One(tree.right, target, closestValue);
    }

    public BST TestData()
    {
        return new BST(10);
    }
}

// ReSharper disable once InconsistentNaming
public class BST {
    // ReSharper disable once MemberCanBePrivate.Global
    public int value;
    public BST left = null!;
    public BST right = null!;

    public BST(int value) {
        this.value = value;
    }
}