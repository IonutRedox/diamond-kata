using DiamondKata.Service.Utils;

namespace DiamondKata.Service.Tests.Helpers;
public class DiamondHelperTests
{
    [Fact]
    public void DiamondHelper_AreDiamondsEqual_DifferentRowsLength_Returns_False()
    {
        char[,] diamondOne = new char[,] {
            { 'A', 'B' },
            { 'C', 'D' }
        };
        char[,] diamondTwo = new char[,] {
            { 'A', 'B' },
        };

        bool result = DiamondHelper.AreDiamondsEqual(diamondOne, diamondTwo);

        Assert.False(result);
    }

    [Fact]
    public void DiamondHelper_AreDiamondsEqual_DifferentColumnsLength_Returns_False()
    {
        char[,] diamondOne = new char[,] {
            { 'A' }
        };
        char[,] diamondTwo = new char[,] {
            { 'A', 'B' }
        };

        bool result = DiamondHelper.AreDiamondsEqual(diamondOne, diamondTwo);

        Assert.False(result);
    }


    [Fact]
    public void DiamondHelper_AreDiamondsEqual_DifferentLetters_Returns_False()
    {
        char[,] diamondOne = new char[,] {
            { 'A', 'B' },
            { 'C', 'D' }
        };
        char[,] diamondTwo = new char[,] {
            { 'A', 'Z' },
            { 'C', 'D' }
        };

        bool result = DiamondHelper.AreDiamondsEqual(diamondOne, diamondTwo);

        Assert.False(result);
    }


    [Fact]
    public void DiamondHelper_AreDiamondsEqual_SameLetters_Returns_True()
    {
        char[,] diamondOne = new char[,] {
            { 'A', 'B' },
            { 'C', 'D' }
        };
        char[,] diamondTwo = new char[,] {
            { 'A', 'B' },
            { 'C', 'D' }
        };

        bool result = DiamondHelper.AreDiamondsEqual(diamondOne, diamondTwo);

        Assert.True(result);
    }
}
