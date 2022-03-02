using System.Collections.Generic;
using Xunit;
using Xunit.Abstractions;

namespace CodingProblems.Arrays.Easy;

public class TournamentWinner
{
    private readonly ITestOutputHelper _testOutputHelper;

    public TournamentWinner(ITestOutputHelper testOutputHelper)
    {
        _testOutputHelper = testOutputHelper;
    }

    [Fact]
    public void Solution_One()
    {
        var competitions = new List<List<string>>
        {
            new(){"HTML", "C#"},
            new(){"C#", "Python"},
            new(){"Python", "HTML"},
            
        };

        var outcome = Calculate(competitions, new List<int> {0, 0, 1});
        
        _testOutputHelper.WriteLine(outcome);
    }

    public string Calculate(List<List<string>> competitions, List<int> results)
    {
        const int winnerPoints = 3;
        
        var scores = new Dictionary<string, int>(results.Count + 1){{string.Empty, 0}};
        var bestTeam = string.Empty;

        for (var index = 0; index < competitions.Count; index++)
        {
            var round = competitions[index];
            var home = round[0];
            var away = round[1];

            var winner = results[index];
            var winningTeam = string.Empty;

            //Home Team
            if (winner == 1)
            {
                if (scores.ContainsKey(home))
                {
                    scores[home] += winnerPoints;
                }
                else
                {
                    scores.Add(home, winnerPoints);
                }

                winningTeam = home;
            }

            //Away Team
            if (winner == 0)
            {
                if (scores.ContainsKey(away))
                {
                    scores[away] += winnerPoints;
                }
                else
                {
                    scores.Add(away, winnerPoints);
                }
                
                winningTeam = away;
            }

            var bestTeamScore = scores[bestTeam];
            var winningTeamScore = scores[winningTeam];

            if (winningTeamScore > bestTeamScore)
            {
                bestTeam = winningTeam;
            }
        }

        return bestTeam;
    }
}