public class Solution
{
    public bool IsHappy(int num)
    {
        var temp = num;
        while (true)
        {
            var squareOfDigit = SquareOfDigit(num);

            switch (squareOfDigit)
            {
                case 4:
                    return false;
                case 1:
                    return true;
                default:
                    num = squareOfDigit;
                    break;
            }
        }
    }

    private int SquareOfDigit(int num)
    {
        var result = 0;
        while (num != 0)
        {
            var lastDigit = num % 10;
            result += (int)Math.Pow(lastDigit, 2);
            num /= 10;
        }

        return result;
    }
}