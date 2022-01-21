using Xunit;

namespace Valid_Anagram_Test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            //arrange
            Solution solution = new Solution();
            string ransomNote = "a", magazine = "ab";

            //act
            bool actual = solution.IsAnagram(ransomNote, magazine);

            //Assert
            Assert.False(actual);
        }
    }
}