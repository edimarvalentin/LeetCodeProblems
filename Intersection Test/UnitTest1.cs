using Xunit;
using Packt;

namespace Intersection_Test
{
    public class UnitTest1
    {
        [Fact]
        public void IntersectionTest()
        {
            //arrange
            int[] nums1 = new int[] { 1, 2, 2, 1 };
            int[] nums2 = new int[] { 2, 2 };
            int[] expected = new int[] { 2, 2 };
            Solution solution = new Solution();

            //act
            int[] actual = solution.Intersect(nums1, nums2);

            //assert
            Assert.Equal(expected, actual);
        }
    }
}