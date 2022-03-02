using System.Collections.Generic;
using Xunit;

namespace CodingProblems.Arrays.Easy
{
    public class ValidateSubsequence
    {
        [Fact]
        public void Solution_One()
        {
            var hasSubsequence = Calculate(new List<int>{2,3,4,5,6,}, new List<int>{3,6});

            Assert.True(hasSubsequence);
        }

        private bool Calculate(List<int> array, List<int> sequence)
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