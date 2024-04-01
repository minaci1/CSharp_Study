using System;

public class Solution
{
    public int[] solution(int numer1, int denom1, int numer2, int denom2)
    {
        int num3 = numer1 * denom2 + denom1 * numer2;
        int denom3 = denom1 * denom2;

        int gcd = GetGcd(num3, denom3);
        num3 /= gcd;
        denom3 /= gcd;

    
        int[] answer = new int[] {num3, denom3};
        return answer;
    }


    private static int GetGcd(int n, int m)
    {
        if (m == 0)
        {
            return n;
        }
        else
        {
            return GetGcd(m, n % m);
        }
    }
}
