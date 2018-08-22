using System;

namespace ex002AddTwoNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();
            ListNode one = new ListNode(2) {
                next = new ListNode(4) {
                    next = new ListNode(3)
                }
            };
            ListNode two = new ListNode(5)
            {
                next = new ListNode(6)
                {
                    next = new ListNode(4)
                }
            };
            var ret = solution.AddTwoNumbers(one, two);
            while (ret != null) {
                Console.WriteLine(ret.val);
                ret = ret.next;
            }
            Console.ReadLine();
        }
    }
}
