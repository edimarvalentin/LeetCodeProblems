public class Solution
{
    public int FirstUniqChar(string s)
    {
        HashSet<char> CharsBlackList = new HashSet<char>();
        HashSet<char> UniqChars = new HashSet<char>();
        foreach (char c in s)
        {
            if (UniqChars.Contains(c))
            {
                CharsBlackList.Add(c);
                UniqChars.Remove(c);
            }else if (!CharsBlackList.Contains(c))
            {
                UniqChars.Add(c);
            }
     
        }

        for(int i = 0; i < s.Length; i++)
        {
            if (UniqChars.Contains(s[i]))
            {
                return i;
            }
        }

        return -1;
    }
    /*
    static void Main(string[] args) { 
    }
    */
}