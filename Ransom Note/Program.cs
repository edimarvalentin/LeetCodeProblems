public class Solution
{
    public bool CanConstruct(string ransomNote, string magazine)
    {
        Dictionary<char, int> ransomCharFreq = new Dictionary<char, int>();
        Dictionary<char, int> magCharFreq = new Dictionary<char, int>();

        foreach (char c in ransomNote)
        {
            if (ransomCharFreq.ContainsKey(c))
            {
                ransomCharFreq[c]++;
            }
            else
            {
                ransomCharFreq.Add(c, 1);
            }
        }

        foreach (char c in magazine)
        {
            if (magCharFreq.ContainsKey(c))
            {
                magCharFreq[c]++;
            }
            else
            {
                magCharFreq.Add(c, 1);
            }
        }

        foreach (char c in ransomNote)
        {
            try
            {
                if (ransomCharFreq[c] > magCharFreq[c])
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
    static void Main(string [] args)
    {

    }
    */
}