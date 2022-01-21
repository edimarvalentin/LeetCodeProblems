using Xunit;

namespace First_Unique_Character_in_a_String_Test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            // arrange
            string s = "loveleetcode";
            Solution solution = new Solution();
            int expected = 2;

            // act

            int actual = solution.FirstUniqChar(s);

            Assert.Equal(expected, actual);
        }
    }
}