public class Solution
{
    public bool IsValidSudoku(char[][] board)
    {
        HashSet<string> visited = new HashSet<string>();

        for(int i = 0; i < board.Length; i++)// rows
        {
            for(int j = 0; j < board[0].Length; j++)// columns
            {
                if (board[i][j] == '.')
                {
                    continue;
                }
                if(!(visited.Add(board[i][j] + " in row " + i) && visited.Add(board[i][j] + 
                    " in column " + j) && visited.Add(board[i][j] + " in box " + j / 3 + "-" + i / 3))){
                    return false;
                }
            }
        }
        return true;
    }

    /*
    static void Main(string[] args)
    {

    }
    */
}