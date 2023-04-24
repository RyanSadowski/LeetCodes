using FluentAssertions;
using Xunit;

namespace LeetCodes;

public class Scratch
{
    public string Testy()
    {
        IEnumerable<string> list = new List<string> {"he", "who", "must"};
        list = list.ToArray().Append("not");
        list = list.ToArray().Append("be");
        list = list.ToArray().Append("named");

        return string.Join(" ", list);

    }
}

public class Testerson
{
    [Fact]
    public async Task FunctionName_Should_DoSomething()
    {
        // Arrange
        var scratch = new Scratch();
        // Act
        var result = scratch.Testy();
        //Assert
        result.Should().Be("he who must not be named");

    }
}