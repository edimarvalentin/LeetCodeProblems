public class Solution
{
    public bool IsAnagram(string s, string t)
    {
        Dictionary<char, int> sFreq = new Dictionary<char, int>();
        Dictionary<char, int> tFreq = new Dictionary<char, int>();

        if(s.Length != t.Length)
        {
            return false;
        }

        foreach (char c in s)
        {
            if (sFreq.ContainsKey(c))
            {
                sFreq[c]++;
            }
            else
            {
                sFreq.Add(c, 1);
            }
        }

        foreach (char c in t)
        {
            if (tFreq.ContainsKey(c))
            {
                tFreq[c]++;
            }
            else
            {
                tFreq.Add(c, 1);
            }
        }

        foreach (char c in s)
        {
            try
            {
                if (tFreq[c] != sFreq[c])
                {
                    return false;
                }
            }
            catch (System.Collections.Generic.KeyNotFoundException)
            {
                return false;
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

