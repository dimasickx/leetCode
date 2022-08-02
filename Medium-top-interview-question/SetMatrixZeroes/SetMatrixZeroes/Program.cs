public class Solution {
    public static void SetZeroes(int[][] matrix)
    {
        var s = false;
        for (var k = 0; k < matrix[0].Length; k++)
        {
            if (matrix[0][k] == 0)
                s = true;
        }
        for (var i = 1; i < matrix.Length; i ++)
        {
            for (var j = 0; j < matrix[0].Length; j++)
            {
                if (matrix[i][j] == 0)
                {
                    matrix[0][j] = 0;
                    matrix[i][0] = 0;
                }
            }
        }

        for (var i = 1; i < matrix.Length; i++)
        {
            for (var j = 1; j < matrix[0].Length; j++)
            {
                if (matrix[i][0] == 0 || matrix[0][j] == 0)
                {
                    matrix[i][j] = 0;
                }
            }
        }

        if (matrix[0][0] == 0)
        {
            for (var k = 0; k < matrix.Length; k++)
            {
                matrix[k][0] = 0;
                
            }
        }
        if (s)
        {
            for (var k = 0; k < matrix[0].Length; k++)
            {
                matrix[0][k] = 0;
            }
        }

        
    }
}
class Program {
    public static void Main()
    {
        
    }
}