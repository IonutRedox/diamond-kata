namespace DiamondKata.Service.Implementation;



/// <summary>
///     Factory class that provides diamond actions.
/// </summary>
public class DiamondFactory : IDiamondFactory
{
    /// <summary>
    ///     Creates a new diamond depending on the letter desired on its center.
    /// </summary>
    /// <param name="centerLetter"></param>
    /// <returns></returns>
    /// <exception cref="ArgumentException"></exception>
    public char[,] CreateDiamond(char centerLetter)
    {
        if(!char.IsLetter(centerLetter) || char.ToUpper(centerLetter) > 'Z' || char.ToUpper(centerLetter) < 'A') {
            throw new ArgumentException("Invalid input. Please enter a character from A to Z.");
        }

        int letterIndex = centerLetter - 'A';
        int halfDiamondSize = letterIndex + 1;
        int diamondSize = halfDiamondSize * 2 - 1;

        var diamond = GenerateEmptyDiamond(diamondSize);
        FillDiamondWithLetters(diamond, halfDiamondSize, diamondSize);

        return diamond;
    }

    /// <summary>
    ///     Prints a diamond to the console.
    /// </summary>
    /// <param name="diamond"></param>
    public void DisplayDiamond(char[,] diamond)
    {
        int rows = diamond.GetLength(0);
        int columns = diamond.GetLength(1);

        for(int rowIndex = 0; rowIndex < rows; rowIndex++) {
            for(int columnIndex = 0; columnIndex < columns; columnIndex++) {
                Console.Write(diamond[rowIndex, columnIndex]);
            }
            Console.WriteLine();
        }
    }

    /// <summary>
    ///     Generates an empty diamond filled in with white spaces.
    /// </summary>
    /// <param name="diamondSize"></param>
    /// <returns></returns>
    private char[,] GenerateEmptyDiamond(int diamondSize)
    {
        char[,] diamond = new char[diamondSize, diamondSize];

        for(int rowIndex = 0; rowIndex < diamondSize; rowIndex++) {
            for(int columnIndex = 0; columnIndex < diamondSize; columnIndex++) {
                diamond[rowIndex, columnIndex] = ' ';
            }
        }

        return diamond;
    }

    /// <summary>
    ///     Fills in the provided diamond with letters using mirroring algorithm.
    /// </summary>
    /// <param name="diamond"></param>
    /// <param name="halfDiamondSize"></param>
    /// <param name="diamondSize"></param>
    private void FillDiamondWithLetters(char[,] diamond, int halfDiamondSize, int diamondSize)
    {
        char currentChar = 'A';

        for(int rowIndex = 0; rowIndex < halfDiamondSize; rowIndex++) {
            int mirrorRowIndex = diamondSize - rowIndex - 1;
            int leftLetterIndex = halfDiamondSize - 1 - rowIndex;
            int rightLetterIndex = halfDiamondSize - 1 + rowIndex;

            diamond[rowIndex, leftLetterIndex] = currentChar;
            diamond[rowIndex, rightLetterIndex] = currentChar;

            diamond[mirrorRowIndex, leftLetterIndex] = currentChar;
            diamond[mirrorRowIndex, rightLetterIndex] = currentChar;

            currentChar++;
        }
    }
}
