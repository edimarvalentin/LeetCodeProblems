public class Solution
{
    public bool SearchMatrix(int[][] matrix, int target)
    {
        if(matrix.Length == 0)
        {
            return false;
        }

        int rows = matrix.Length;
        int columns = matrix[0].Length;

        int left = 0;
        int right = rows * columns - 1;

        while(left <= right)
        {
            int midpoint = left + (right - left) / 2;

            int midpoint_element = matrix[midpoint / columns][midpoint % columns];

            if(midpoint_element == target)
            {
                return true;
            }else if(target < midpoint_element)
            {
                right = midpoint - 1;
            }else if(target > midpoint_element)
            {
                left = midpoint + 1;
            }

        }
        return false;

    }
}