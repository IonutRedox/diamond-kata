namespace DiamondKata.Service.Utils;
/// <summary>
///     Diamonds helper class containing different operations.
/// </summary>
public static class DiamondHelper
{
    /// <summary>
    ///     Compares two diamonds.
    /// </summary>
    /// <param name="diamondOne"></param>
    /// <param name="diamondTwo"></param>
    /// <returns></returns>
    public static bool AreDiamondsEqual(char[,] diamondOne, char[,] diamondTwo)
    {
        if(diamondOne.GetLength(0) != diamondTwo.GetLength(0) || diamondOne.GetLength(1) != diamondTwo.GetLength(1)) {
            return false;
        }

        for(int i = 0; i < diamondOne.GetLength(0); i++) {
            for(int j = 0; j < diamondTwo.GetLength(1); j++) {
                if(diamondOne[i, j] != diamondTwo[i, j]) {
                    return false;
                }
            }
        }

        return true;
    }
}
