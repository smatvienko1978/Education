using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoApplication
{
   
    public class LimitedSizeStack<T>
    {
        private int capacity;
        private int counter;
        private LinkedList<T> stack;


        public LimitedSizeStack(int limit)
        {
            capacity = limit;
            counter = 0;
            stack = new LinkedList<T>();
        }

        public void Push(T item)
        {
            stack.AddLast(item);
            counter++;
            if (counter == capacity + 1)
            {
                counter--;
                stack.RemoveFirst();
            }
        }

        public T Pop()
        {
            counter--;
            var result= stack.Last;
            stack.RemoveLast();
            return result.Value;
        }

        public int Count
        {
            get
            {
                return counter;
            }
        }
    }
}
