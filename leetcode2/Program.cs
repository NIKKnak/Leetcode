namespace leetcode2
{
    internal class Program
    {
        static void Main(string[] args)
        {



        }

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

        public class Solution
        {
            // объявляем метод AddTwoNumbers, который принимает два аргумента типа ListNode и возвращает ListNode
            public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
            {
                // создаем новый узел и присваиваем его переменной dummy
                ListNode dummy = new ListNode();
                // присваиваем переменной curr значение dummy
                ListNode curr = dummy;
                // объявляем переменную carry и присваиваем ей значение 0
                int carry = 0;
                // запускаем цикл, который работает, пока l1, l2 или carry не станут равными null или 0 соответственно
                while (l1 != null || l2 != null || carry != 0)
                {
                    // объявляем переменную sum и присваиваем ей значение carry
                    int sum = carry;
                    // если l1 не равно null
                    if (l1 != null)
                    {
                        // добавляем значение l1.val к переменной sum
                        sum += l1.val;
                        // присваиваем l1 следующий узел
                        l1 = l1.next;
                    }
                    // если l2 не равно null
                    if (l2 != null)
                    {
                        // добавляем значение l2.val к переменной sum
                        sum += l2.val;
                        // присваиваем l2 следующий узел
                        l2 = l2.next;
                    }
                    // вычисляем целое от деления суммы на 10 и присваиваем его переменной carry
                    carry = sum / 10;
                    // вычисляем остаток от деления суммы на 10 и создаем новый узел с этим значением и присваиваем его переменной curr.next
                    curr.next = new ListNode(sum % 10);
                    // переназначаем curr на curr.next
                    curr = curr.next;
                }
                // возвращаем следующий узел после dummy
                return dummy.next;
            }
        }



    }
}
