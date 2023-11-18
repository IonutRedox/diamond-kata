namespace DiamondKata.Service.Implementation;
public interface IDiamondFactory
{
    /// <summary>
    ///     Creates a new diamond depending on the letter desired on its center.
    /// </summary>
    char[,] CreateDiamond(char centerLetter);

    /// <summary>
    ///     Prints a diamond to the console.
    /// </summary>
    void DisplayDiamond(char[,] diamond);
}
