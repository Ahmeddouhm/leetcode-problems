public class Solution {
    public string AddBinary(string a, string b) {
        StringBuilder res = new();
    int i = a.Length - 1, j = b.Length - 1, carry = 0;

    while (i >= 0 || j >= 0)
    {
        int sum = carry;

        if (i >= 0)
            sum += a[i--] - '0';

        if (j >= 0)
            sum += b[j--] - '0';

        res.Insert(0, sum % 2);

        carry = sum / 2;
    }

    if (carry > 0)
        res.Insert(0, 1);

    return res.ToString();
    }
}