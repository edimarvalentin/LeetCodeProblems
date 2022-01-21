using Xunit;
using Packt;

namespace Intersection_of_Two_Arrays_II_Tests
{
    public class IntersectionUnitTest
    {
        [Fact]
        public void TestIntersect1()
        {
            //arrange
            int[] nums1 =  new int[]{1, 2, 2, 1};
            int[] nums2 = new int[] { 2, 2 };
            int[] expected = new int[] { 2, 2 };
            Solution solution = new Solution();

            //act
            int[] actual = solution.Intersect(nums1, nums2);

            //assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestIntersect2()
        {
            //arrange
            int[] nums1 = new int[] { 4, 9, 5};
            int[] nums2 = new int[] { 9, 4, 9, 8 , 4};
            int[] expected = new int[] { 4, 9 };
            Solution solution = new Solution();

            //act
            int[] actual = solution.Intersect(nums1, nums2);

            //assert
            Assert.Equal(expected, actual);
        }
    }
}