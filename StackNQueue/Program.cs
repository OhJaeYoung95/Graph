using System;
using System.Collections.Generic;

namespace StackNQueue
{
    class Program
    {
        // 스택 : LIFO(후입선출 Last in First Out)
        // 큐 : FIFO(선입선출 First in First Out)
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(101);    // 값을 집어넣는다
            stack.Push(102);
            stack.Push(103);
            stack.Push(104);
            stack.Push(105);

            if (stack.Count > 0)     // 예외처리 예방
            {
                int data = stack.Pop();     // 값을 빼낸다
                int data2 = stack.Peek();    // 마지막에 들어간 값을 검사한다
            }

            Queue<int> queue = new Queue<int>();
            queue.Enqueue(101);
            queue.Enqueue(102);
            queue.Enqueue(103);
            queue.Enqueue(104);
            queue.Enqueue(105);

            if (queue.Count > 0)
            {
                int data3 = queue.Dequeue();
                int data4 = queue.Peek();
            }

            LinkedList<int> list = new LinkedList<int>();
            list.AddLast(101);
            list.AddLast(102);
            list.AddLast(103);

            // FIFO
            int value1 = list.First.Value;
            list.RemoveFirst();

            // LIFO
            int value2 = list.Last.Value;
            list.RemoveLast();

        }
    }
}
