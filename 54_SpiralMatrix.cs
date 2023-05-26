using FluentAssertions;
using Xunit;

namespace LeetCodes;

public class SpiralMatrix
{
    public IList<int> SpiralOrder(int[][] matrix)
    {
        var width = matrix[0].Length;
        var height = matrix.Length;

        int size = width * height;
        IList<int> returnList = new List<int>(size);

        int x = 0;
        int y = 0;
        const int right = 0;
        const int down = 1;
        const int left = 2;
        const int up = 3;
        int direction = right;
        int loops = 0;

        for (int i = 0; i <= size - 1; i++)
        {
            returnList.Add(matrix[y][x]);


            if (direction == right)
            {
                if (x >= width - loops - 1)
                {
                    direction = down;
                    y++;
                }
                else
                {
                    x++; 
                }
            }
            else if (direction == left)
            {
                if (x <= loops)
                {
                    direction = up;
                    loops++;
                    y--;
                }
                else
                {
                    x--;
                }
            }
            else if (direction == up)
            {
                if (y <= loops)
                {
                    direction = right;
                    x++;
                }
                else
                {
                    y--;
                }
            }
            else if (direction == down)
            {
                if (y >= height - loops - 1)
                {
                    direction = left;
                    x--;
                }
                else
                {
                    y++;
                }
            }

        }

        return returnList;
    }

    [Fact]
    public async Task FunctionName_Should_DoSomething()
    {
        // Arrange
        int[][] matrix = new int[][]
        {
            new int[] {1, 2, 3}, new int[] {4, 5, 6}, new int[] {7, 8, 9}
        };

        // Act
        var test = SpiralOrder(matrix);

        //Assert
        test.Should().BeEquivalentTo(new List<int> {1, 2, 3, 6, 9, 8, 7, 4, 5});
    }
}