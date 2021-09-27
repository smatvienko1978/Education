using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueUeByTwoStack
{
    class Program
    {
        public class MyQueue<T>
        {
            private Stack<T> push;
            private Stack<T> pop;

            public MyQueue()
            {
                push = new Stack<T>();
                pop = new Stack<T>();
            }

            public void Enqueue(T data)
            {
                push.Push(data);
            }
            public void Dequeue()
            {
                if (pop.Count == 0)
                    MoveStacks();
                pop.Pop();
            }

            private void MoveStacks()
            {
                while (push.Count > 0)
                    pop.Push(push.Pop());
            }

            public T Peek()
            {
                if (pop.Count == 0)
                    MoveStacks();
                return pop.Peek();
            }
        }
        public static void RunQueries(string[] queries)
        {
            var myQueue = new MyQueue<int>();
            foreach (var item in queries)
            {
                if (item == "3")
                    Console.WriteLine(myQueue.Peek());
                if (item == "2")
                    myQueue.Dequeue();
                var parse = item.Split(' ');
                if (parse[0] == "1")
                    myQueue.Enqueue(int.Parse(parse[1]));
            }
        }
        static void Main(string[] args)
        {
            //int g = int.Parse(Console.ReadLine()); //number of queries
            //var queries = new string[g];
            //for (int i = 0; i < g; i++)
            //    queries[i] = Console.ReadLine();
            //RunQueries(queries);

            var input = @"1 42
2
1 14
3
1 28
3
1 60
1 78
2
2";
            var queries = input.Split(new char[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
            RunQueries(queries);
            Console.ReadKey();
        }


    }
}
