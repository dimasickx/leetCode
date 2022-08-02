namespace Base 
{
    class Program
    {
        public static void Main()
        {
            
        }
        public class Solution
        {
            public static int UniquePaths(int m, int n)
            {
                var waysCount = new int[m,n];
                for (int i = 0; i < m; i++)
                    for (int j = 0; j < n; j++)
                    {
                        if (i == 0 || j == 0)
                            waysCount[i,j] = 1;
                        else
                            waysCount[i, j] = waysCount[i,j-1] + waysCount[i - 1, j];
                    }
                return waysCount[m - 1,n - 1];
            }
        }
    }
}