using Xunit;
using System.Collections.Generic;
using System.Linq;


namespace CodingProblems.Arrays
{

    public class ValidateSubsequence
    {
        [Fact]
        public void Solution_One()
        {
            var hasSubseqence = Calculate(new List<int>{2,3,4,5,6,}, new List<int>{3,6});

            Assert.True(hasSubseqence);
        }

        public bool Calculate(List<int> array, List<int> sequence)
        {
            var currentPosition = 0;

            foreach (var item in array)
            {
                var sequenceValue = sequence[currentPosition];

                if(sequenceValue == item)
                {
                    currentPosition++;

                    if(currentPosition == sequence.Count)
                    {
                        return true;
                    }
                }
            }

            return false;            
        }
    }
}