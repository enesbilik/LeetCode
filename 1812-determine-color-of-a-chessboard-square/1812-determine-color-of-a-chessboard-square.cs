public class Solution {
    public bool SquareIsWhite(string coordinates)
    {
        var letter = (int)coordinates[0] - 97;
        var number =  coordinates[1] - '0' -1 ;

        return (letter + number) % 2 != 0;
    }
}