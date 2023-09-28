namespace Sweeft.Algorithms;

public static class Helper
{
    #region IsPalindrome

    public static bool IsPalindrome(string s)
    {
        for (int i = 0, j = s.Length - 1; j > i;)
        {
            if (!char.IsLetterOrDigit(s[i]))
            {
                i++;
                continue;
            }

            if (!char.IsLetterOrDigit(s[j]))
            {
                j--;
                continue;
            }

            if (char.ToLower(s[i++]) != char.ToLower(s[j--]))
            {
                return false;
            }
        }
        return true;
    }

    #endregion IsPalindrome

    #region MinSplit
    public static int MinSplit(int amount)
    {
        int[] coins = { 50, 20, 10, 5, 1 };
        int count = 0;

        foreach (int coin in coins)
        {
            while (amount >= coin)
            {
                amount -= coin;
                count++;
            }
        }

        return count;
    }

    #endregion MinSplit

    #region NotContains
    public static int NotContains(int[] array)
    {
        int min = array[0];
        HashSet<int> set = new HashSet<int>();

        foreach (int i in array)
        {
            set.Add(i);
            if (i < min)
            {
                min = i;
            }
        }

        if (min - 1 > 0)
        {
            return min - 1;
        }
        else
        {
            int n = min + 1;
            while (set.Contains(n) || n <= 0)
            {
                n++;
            }
            min = n;
        }
        return min;
    }

    #endregion NotContains

    #region IsValid

    public static bool IsValid(string s)
    {
        var k = new Stack<char>();
        foreach (char c in s)
        {
            if (c == '(') { k.Push(')'); continue; }
            if (c == '{') { k.Push('}'); continue; }
            if (c == '[') { k.Push(']'); continue; }
            if (k.Count == 0 || c != k.Pop()) return false;
        }
        return k.Count == 0;
    }

    #endregion IsValid

    #region CountVariants
    public static int CountVariants1(int n)
    {
        if (n == 0 || n == 1)
        {
            return 1;
        }

        return CountVariants1(n - 1) + CountVariants1(n - 2);
    }

    public static int CountVariants2(int n)
    {
        if (n == 0 || n == 1)
        {
            return 1;
        }

        int[] dp = new int[n + 1];
        dp[0] = dp[1] = 1;

        for (int i = 2; i <= n; i++)
        {
            dp[i] = dp[i - 1] + dp[i - 2];
        }
        return dp[n];
    }

    #endregion CountVariant
}
