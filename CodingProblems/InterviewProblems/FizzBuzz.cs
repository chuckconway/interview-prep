using Xunit;
using Xunit.Abstractions;

namespace CodingProblems.InterviewProblems;

public class FizzBuzz
{
    private readonly ITestOutputHelper _testOutputHelper;

    public FizzBuzz(ITestOutputHelper testOutputHelper) 
        => _testOutputHelper = testOutputHelper;

    [Fact]
    public void Test()
    {
        const int max = 100;

        //3 - Fizz
        //5 - Buzz
        //15 - FizzBuzz
        
        for (int index = 1; index <= max; index++)
        {
            if (index % 5 == 0 && index % 3 == 0)
            {
                _testOutputHelper.WriteLine( index + " - FizzBuzz");
            }
            else if (index % 5 == 0)
            {
                _testOutputHelper.WriteLine( index + " - Buzz");
            }
            else if (index % 3 == 0)
            {
                _testOutputHelper.WriteLine( index + " - Fizz");
            }
            else
            {
                _testOutputHelper.WriteLine(index.ToString());
            }
        }
    }
}