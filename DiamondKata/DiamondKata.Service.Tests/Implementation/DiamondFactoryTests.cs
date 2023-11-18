using DiamondKata.Service.Implementation;
using DiamondKata.Service.Utils;

namespace DiamondKata.Service.Tests.Implementation;
public class DiamondFactoryTests
{
    private readonly IDiamondFactory _diamondFactory;

    public DiamondFactoryTests()
    {
        _diamondFactory = new DiamondFactory();
    }

    [Fact]
    public void DiamondFactory_CreateDiamond_InvalidInput_ThrowsException()
    {
        Assert.Throws<ArgumentException>(() => _diamondFactory.CreateDiamond('#'));
    }

    [Fact]
    public void DiamondFactory_CreateDiamond_SizeOne_Returns_OneLetter()
    {
        char[,] expectedDiamond = new char[,] { { 'A' } };

        var actualDiamond = _diamondFactory.CreateDiamond('A');

        Assert.True(DiamondHelper.AreDiamondsEqual(actualDiamond, expectedDiamond));
    }

    [Fact]
    public void DiamondFactory_CreateDiamond_BiggerSize_Returns_Diamond()
    {
        char[,] expectedDiamond = new char[,] {
            { ' ',' ', 'A',' ', ' ' },
            { ' ','B', ' ','B', ' ' },
            { 'C',' ', ' ',' ', 'C' },
            { ' ','B', ' ','B', ' ' },
            { ' ',' ', 'A',' ', ' ' },
        };

        var actualDiamond = _diamondFactory.CreateDiamond('C');

        Assert.True(DiamondHelper.AreDiamondsEqual(actualDiamond, expectedDiamond));
    }

    [Fact]
    public void DiamondFactory_DisplayDiamond()
    {
        char[,] input = new char[,]
        {
            { ' ',' ', 'A',' ', ' ' },
            { ' ','B', ' ','B', ' ' },
            { 'C',' ', ' ',' ', 'C' },
            { ' ','B', ' ','B', ' ' },
            { ' ',' ', 'A',' ', ' ' },
        };
        var expectedOutput = "  A  \r\n" +
                             " B B \r\n" +
                             "C   C\r\n" +
                             " B B \r\n" +
                             "  A  \r\n";
        using StringWriter sw = new();
        Console.SetOut(sw);

        _diamondFactory.DisplayDiamond(input);
        var actualOutput = sw.ToString();

        Assert.Equal(expectedOutput, actualOutput);
    }
}