using Xunit;

namespace Linked_List_Cycle_Test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            //arrange
            Solution solution = new Solution();
            ListNode head = new ListNode(1);

            //act
            bool actual = solution.HasCycle(head);

            Assert.False(actual);


            
        }
    }
}