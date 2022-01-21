namespace Packt
{
    public class Solution
    {
        public int[] Intersect(int[] nums1, int[] nums2)
        {
            IDictionary<int, int> setA = new Dictionary<int, int>();
            foreach(int i in nums1)
            {
                try
                {
                    setA.Add(i, 1);
                }
                catch (System.ArgumentException)
                {
                    setA[i]++;
                }
            }

            IDictionary<int, int> setB = new Dictionary<int, int>();
            foreach (int i in nums2)
            {
                try
                {
                    setB.Add(i, 1);
                }
                catch (System.ArgumentException)
                {
                    setB[i]++;
                }
            }
            int size = 0;
            IDictionary<int, int> intersection = new Dictionary<int, int>();
            foreach(KeyValuePair<int, int> set in setA)
            {
                if (setB.ContainsKey(set.Key))
                {
                    intersection.Add(set.Key, Math.Min(set.Value, setB[set.Key]));
                    size += Math.Min(set.Value, setB[set.Key]);
                }
            }

            int [] result = new int[size];
            int index = 0;
            foreach(KeyValuePair<int, int> set in intersection)
            {
                for(int i = 0; i < set.Value; i++)
                    {
                        result[index++] = set.Key;
                    }
            }
            return result;
        }

        static void Main(string[] args)
        {

        }
    }
}