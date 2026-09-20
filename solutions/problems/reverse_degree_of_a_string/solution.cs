public class Solution {
    public int ReverseDegree(string s) {
        int value = 0;
        for (int i = 0; i < s.Length; i++)
        {
            int reversedPos = 27 - (s[i] - 'a' + 1);

            value += (i + 1) * reversedPos;
        }

        return value;
    }
}