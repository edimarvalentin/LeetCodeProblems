public class Solution
{
    public int[][] MatrixReshape(int[][] mat, int r, int c) // Returns a jagged array
    {
        int m = mat.Length;
        int n = mat[0].Length;

        if(n * m != r * c)
        {
            return mat;
        }

        int row = 0, column = 0;

        int[][] result = new int[r][];

        for(int i = 0; i < m; i++)
        {
            if (result[row] == null)
            {
                result[row] = new int[c];
            }
            for (int j = 0; j < n; j++)
            {
                result[row][column++] = mat[i][j];
                if(column == c)
                {
                    column = 0;
                    row++;
                    if(row != r)
                    {
                       result[row] = new int[c];
                    }
         
                }
            }
        }

        return result;
    }

    /*
    static void Main(string[] args)
    {
        Solution s = new Solution();
    }

    */
    
}