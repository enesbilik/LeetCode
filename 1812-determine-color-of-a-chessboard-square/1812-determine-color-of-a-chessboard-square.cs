public class Solution {
    public bool SquareIsWhite(string coordinates)
    {
        return coordinates.Sum(value => (int)value) % 2 != 0;
        
    }
}