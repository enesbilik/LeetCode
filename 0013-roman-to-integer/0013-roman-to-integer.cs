public class Solution {
    public int RomanToInt(string s)
    {
        int answer = 0, number = 0, prev = 0;
        for (var j = s.Length - 1; j >= 0; j--)
        {
            number = s[j] switch
            {
                'M' => 1000,
                'D' => 500,
                'C' => 100,
                'L' => 50,
                'X' => 10,
                'V' => 5,
                'I' => 1,
                _ => number
            };

            if (number < prev)
                answer -= number;
            else
                answer += number;
            prev = number;
        }

        Console.WriteLine(answer);
        return answer;
    }
}