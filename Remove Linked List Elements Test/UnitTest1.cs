using Xunit;

namespace Remove_Linked_List_Elements_Test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            //arrange
            Solution solution = new Solution(); 

            ListNode first = new ListNode(7);
            ListNode second = new ListNode(7);
            first.next = second;
            ListNode third = new ListNode(7);
            second.next = third;
            ListNode fourth = new ListNode(7);
            third.next = fourth;

            //Act 

            ListNode actual = solution.RemoveElements(first, 7);

            //Assert

            Assert.Null(actual);

        }
    }
}