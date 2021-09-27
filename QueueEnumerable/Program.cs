using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueEnumerable
{
    class Program
    {
        public class QueueEnumerator<T> : IEnumerator<T>
        {
            public Queue<T> queue;
            QueueItem<T> currentItem;

            public QueueEnumerator(Queue<T> queue)
            {
                this.queue = queue;
                currentItem = null;
            }

            public T Current => currentItem.Value;

            object IEnumerator.Current => Current;

            public void Dispose()
            {
                ;
            }

            public bool MoveNext()
            {
                if (currentItem == null)
                    currentItem = queue.Head;
                else
                    currentItem = currentItem.Next;
                return currentItem != null;
            }

            public void Reset()
            {
                ;
            }
        }



        public class QueueItem<T>
		{
			public T Value { get; set; }
			public QueueItem<T> Next { get; set; }
		}
		public class Queue<T>:IEnumerable<T>
        {
			public QueueItem<T> Head { get; private set; }
			QueueItem<T> tail;

			public bool IsEmpty { get { return Head == null; } }

			public void Enqueue(T value)
			{
				if (IsEmpty)
					tail = Head = new QueueItem<T> { Value = value, Next = null };
				else
				{
					var item = new QueueItem<T> { Value = value, Next = null };
					tail.Next = item;
					tail = item;
				}
			}

			public T Dequeue()
			{
				if (Head == null) throw new InvalidOperationException();
				var result = Head.Value;
				Head = Head.Next;
				if (Head == null)
					tail = null;
				return result;
			}
            public IEnumerator<T> GetEnumerator()
            {
                return new QueueEnumerator<T>(this);
            }

            IEnumerator IEnumerable.GetEnumerator()
            {
                return GetEnumerator();
            }
        }
        static void Main(string[] args)
        {
            var queue = new Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            foreach (var item in queue)
                Console.WriteLine(item);
            Console.ReadKey();
        }
    }
}
