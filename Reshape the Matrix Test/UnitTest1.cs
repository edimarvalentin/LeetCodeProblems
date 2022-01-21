using Xunit;

namespace Reshape_the_Matrix_Test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            //arrange
            Solution solution = new Solution();
            int r = 1;
            int c = 4;

            int[][] mat = new int[2][];
            mat[0] = new int[2] {1,2};
            mat[1] = new int[2] {3,4};

            int[][] expected = new int[1][];
            expected[0] = new int[4] { 1, 2, 3, 4 };

            //act

            int[][] actual = solution.MatrixReshape(mat, r, c);

            //assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Test2()
        {
            //arrange
            Solution solution = new Solution();
            int r = 2;
            int c = 4;

            int[][] mat = new int[2][];
            mat[0] = new int[2] { 1, 2 };
            mat[1] = new int[2] { 3, 4 };

            int[][] expected = new int[2][];
            expected[0] = new int[2] { 1, 2 };
            expected[1] = new int[2] { 3, 4 };

            //act

            int[][] actual = solution.MatrixReshape(mat, r, c);

            //assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Test3()
        {
            //arrange
            Solution solution = new Solution();
            int r = 4;
            int c = 3;

            int[][] mat = new int[3][];
            mat[0] = new int[4] { 1, 2, 3, 4 };
            mat[1] = new int[4] { 5, 6, 7, 8 };
            mat[2] = new int[4] { 9, 10, 11, 12 };


            int[][] expected = new int[4][];
            expected[0] = new int[3] { 1, 2, 3};
            expected[1] = new int[3] { 4, 5, 6};
            expected[2] = new int[3] { 7, 8, 9 };
            expected[3] = new int[3] { 10, 11, 12};

            //act

            int[][] actual = solution.MatrixReshape(mat, r, c);

            //assert
            Assert.Equal(expected, actual);
        }
    }
}