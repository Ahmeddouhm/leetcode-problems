public class Solution {
    public int RomanToInt(string s) {
        Dictionary<char, int> romanNumerals = new() 
        {
            ['I'] = 1,
            ['V'] = 5,
            ['X'] = 10,
            ['L'] = 50,
            ['C'] = 100,
            ['D'] = 500,
            ['M'] = 1000,
        };

        int value = 0;

        for (int i = 0; i < s.Length; i++)
        {
            if (i == s.Length - 1)
            {
                value += romanNumerals[s[i]];
                break;
            }

            if (romanNumerals[s[i]] < romanNumerals[s[i + 1]])
            {
                value -= romanNumerals[s[i]];
            }
            else
            {
                value += romanNumerals[s[i]];
            }
        }
        return value;
    }
}