using System;
using Xunit;

namespace CodingProblems.DataTypes.BinarySearchTrees.Easy;

public class FindClosestValue
{
    [Fact]
    public void Calculate()
    {
        
    }

    public int Solution_One(BST tree, int target, int closestValue = int.MaxValue)
    {
        if(closestValue == target)
        {
            return closestValue;
        }
        
        if (closestValue > tree.value - target)
        {
            closestValue = tree.value;
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