public class Solution
{
    public IList<IList<int>> Generate(int numRows)
    {
        IList<IList<int>> triangle = new List<IList<int>>();

        if(numRows == 0)
        {
            return triangle;
        }

        IList<int> first_row = new List<int>();
        first_row.Add(1);
        triangle.Add(first_row);

        for(int i = 1; i < numRows; i++)
        {
            IList<int> current_row = new List<int>();
            IList<int> prev_row = triangle.ElementAt(i - 1);
            current_row.Add(1);
            for(int j = 1; j < prev_row.Count; j++)
            {
                current_row.Add(prev_row.ElementAt(j - 1) + prev_row.ElementAt(j));
            }

            current_row.Add(1);
            triangle.Add(current_row);
        }
        return triangle;
    }
}