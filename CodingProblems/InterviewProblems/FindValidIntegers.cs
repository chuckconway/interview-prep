using Xunit;

namespace CodingProblems.InterviewProblems;

/// <summary>
/// A file contains a sequence of integers, stored one per line. Implement a class that facilitates iteration
// over these integers.
//
//     A valid integer is a sequence of one or more digits (without leading zeros), optionally preceded by a
// plus or minus sign, representing a number within the range [-1,000,000,000..1,000,000,000). We allow
// spaces to appear in a line before and/or after a valid integer. Lines are separated with the line-feed
// character (ASCII code 10).
//
//     There might be lines that do not represent valid integers, e.g. 2u1, 23.9, #12, 00, ++1, 2000000000.
//     Such lines are considered to be comments, and should be discarded.
//
//     Define a class SolutionIter that implements IEnumerable<int> and iterates over integers
//     from a Stream object compliant with the above format.
//
//     You should implement the following interface:
//
// using System;
// using System. I0;
// using System.Collections;
// using System.Collections.Generic;
// public class SolutionIter : IEnumerable<int>{
//     public SolutionIter(Stream stream) :
//         Enumerator IEnumerable.GetEnumerator();
//     Enumerator<int>IEnumerable<int>.GetEnumerator();
//     /**
// * Example usage:
// *
// * IEnumerable<int> it = new SolutionIter(stream):
// * int [] arr = it.ToArray();
// */
//
//     For an input file containing the following lines:
//
//     137
//     -104
//     2 58
//     +0
//     ++3
//     +1
//     23.9
//     2000000000
//     -0
//     five
//     -1
//     your iterator should return the following sequence of integers:
//     [137, -104, 0, 1, 0,-1]
//
//     Assume that:
//
//     - the file can contain only line-feed characters (ASCII code 10) and printable ASCII characters (ASCII codes from 32 to 126);
//     - for every file your iterator will be used only once.
public class FindValidIntegers
{
    
    [Fact]
    public void Calculate()
    {
        
    }
}