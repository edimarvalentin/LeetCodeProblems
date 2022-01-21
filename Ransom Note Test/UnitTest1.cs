using Xunit;

namespace Ransom_Note_Test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            //arrange
            Solution solution = new Solution();
            string ransomNote = "a", magazine = "b";

            //act
            bool actual = solution.CanConstruct(ransomNote, magazine);

            //Assert
            Assert.False(actual);
        }

        [Fact]
        public void Test2()
        {
            //arrange
            Solution solution = new Solution();
            string ransomNote = "aa", magazine = "ab";

            //act
            bool actual = solution.CanConstruct(ransomNote, magazine);

            //Assert
            Assert.False(actual);
        }
        [Fact]
        public void Test3()
        {
            //arrange
            Solution solution = new Solution();
            string ransomNote = "aa", magazine = "aab";

            //act
            bool actual = solution.CanConstruct(ransomNote, magazine);

            //Assert
            Assert.True(actual);
        }
    }
}