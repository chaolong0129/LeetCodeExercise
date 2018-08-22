using System;
using System.Collections.Generic;
using System.Text;

namespace ex002AddTwoNumbers
{
    public class Solution
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode one = l1, two = l2;
            ListNode ret = new ListNode(0);
            ListNode three = ret;
            int sum = 0;

            while (one != null && two != null)
            {
                var d = (one.val + two.val + sum) % 10;
                sum = (one.val + two.val + sum) / 10;
                three.next = new ListNode(d);
                one = one.next;
                two = two.next;
                three = three.next;
            }

            while (one != null)
            {
                var d = (one.val + sum) % 10;
                sum = (one.val + sum) / 10;
                three.next = new ListNode(d);
                one = one.next;
                three = three.next;
            }

            while (two != null)
            {
                var d = (two.val + sum) % 10;
                sum = (two.val + sum) / 10;
                three.next = new ListNode(d);
                two = two.next;
                three = three.next;
            }

            if (sum != 0)
                three.next = new ListNode(1);

            return ret.next;
        }
    }
}
