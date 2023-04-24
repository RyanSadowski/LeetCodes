using FluentAssertions;
using Xunit;

namespace LeetCodes;

public static class RomanToInteger13
{
    private static readonly Dictionary<char, int> RomanIntDict = new()
    {
        {'I', 1},
        {'V', 5},
        {'X', 10},
        {'L', 50},
        {'C', 100},
        {'D', 500},
        {'M', 1000},
    };

    private static Dictionary<char, char[]> Subtractables = new()
    {
        {'I', new[] {'V', 'X'}},
        {'X', new[] {'L', 'C'}},
        {'C', new[] {'D', 'M'}}
    };

    public static int RomanToInt(string s)
    {
        char[] letters = s.ToCharArray();
        int size = letters.Count();
        int total = 0;

        for (var j = 0; j < size; j++)
        {
            var romanIntPair = RomanIntDict.FirstOrDefault(x => x.Key == letters[j]);
            if (j+1 == size)
            {
                total += romanIntPair.Value;
                return total;
            }

            bool shouldSubtract = ShouldSubtract(letters[j], letters[j + 1]);
            total += shouldSubtract ? romanIntPair.Value * -1 : romanIntPair.Value;
        }

        return total;
    }

    private static bool ShouldSubtract(char currentPosition, char nextPosition)
    {
        if (!Subtractables.ContainsKey(currentPosition))
        {
            return false;
        }

        return Subtractables[currentPosition].Contains(nextPosition);
    }
}

public class Tests
{
    [Fact]
    public async Task FunctionName_Should_DoSomething()
    {
        // Arrange
        var test1 = "III";

        // Act
        var test1Result = RomanToInteger13.RomanToInt(test1);

        //Assert
        test1Result.Should().Be(3);
    }
}