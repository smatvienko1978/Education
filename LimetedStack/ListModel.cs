using System;
using System.Collections.Generic;

namespace TodoApplication
{
    public class ListModel<TItem>
    {
        public List<TItem> Items { get; }
        public int Limit;
        private LimitedSizeStack<Tuple<string, TItem>> history;
        public ListModel(int limit)
        {
            Items = new List<TItem>();
            Limit = limit;
            history = new LimitedSizeStack<Tuple<string, TItem>>(limit);
        }

        public void AddItem(TItem item)
        {
            Items.Add(item);
            var tuple = Tuple.Create<string, TItem>("Add", item);
            history.Push(tuple);
        }

        public void RemoveItem(int index)
        {
            var item = Items[index];
            Items.RemoveAt(index);
            var tuple = Tuple.Create<string, TItem>("Remove " + index, item);
            history.Push(tuple);
        }

        public bool CanUndo()
        {
            return history.Count>0;
        }

        public void Undo()
        {
            var tuple = history.Pop();
            var item = tuple.Item2;
            var operatinon = tuple.Item1;
            if (operatinon == "Add")
            {
                Items.Remove(item);
                return;
            }
            var parse = operatinon.Split(' ');
            if (parse[0] == "Remove")
                Items.Insert(int.Parse(parse[1]), item);
        }
    }
}
