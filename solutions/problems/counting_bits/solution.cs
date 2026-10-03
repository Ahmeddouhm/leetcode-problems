public class Solution {
    public int[] CountBits(int n) {
        int[] frqArr = new int[n+1];

        for(int i = 1; i <= n; i++)
        {
            frqArr[i] = frqArr[i >> 1] + (i & 1);
        }

        return frqArr;
    }
}