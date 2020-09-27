using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoPracticeSolultion
{
    class Program
    {
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int val = 0, ListNode next = null)
            {
                this.val = val;
                this.next = next;
            }
        }
        static ListNode SumTwoLinkedList(ListNode listOne, ListNode ListTwo)
        {
            var dummy = new ListNode(0);
            var result = dummy;
            var carry = 0;
            while (listOne != null && ListTwo != null)
            {
                int digit = (listOne.val + ListTwo.val + carry) % 10;
                carry = (listOne.val + ListTwo.val + carry) / 10;
                var aNewNode = new ListNode(digit);
                result.next = aNewNode;
                result = aNewNode;
                listOne = listOne.next;
                ListTwo = ListTwo.next;
            }
            while (listOne != null)
            {
                int digit = (listOne.val + carry) % 10;
                carry = (listOne.val + carry) / 10;
                var aNewNode = new ListNode(digit);
                result.next = aNewNode;
                result = aNewNode;
                listOne = listOne.next;
            }
            while (ListTwo != null)
            {
                int digit = (ListTwo.val + carry) % 10;
                carry = (ListTwo.val + carry) / 10;
                var aNewNode = new ListNode(digit);
                result.next = aNewNode;
                result = aNewNode;
                ListTwo = ListTwo.next;
            }
            if (carry != 0)
            {
                var aNewNode = new ListNode(carry);
                result.next = aNewNode;
                result = aNewNode;
            }
            return dummy.next;
        }
        static void Main(string[] args)
        {

        }

    }
}
