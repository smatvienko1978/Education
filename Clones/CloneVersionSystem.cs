using System;
using System.Collections.Generic;

namespace Clones
{
	public class Stack
	{
		List<int> stack = new List<int>();
		public void Push(int value)
		{
			stack.Add(value);
		}

		public int Pop()
		{
			if (IsEmpty()) throw new InvalidOperationException();
			var result = stack[stack.Count - 1];
			stack.RemoveAt(stack.Count - 1);
			return result;
		}

		private bool IsEmpty() => stack.Count == 0;

		public string Peek()
		{
			return IsEmpty() ? null : stack[stack.Count - 1].ToString();
		}

		public Stack Copy() 
		{
			return new Stack { stack = new List<int>(stack) };
		}
	}

	public class Clone
	{
		private Stack learned;
		private Stack rollbacked;
		private bool isCloned = false;
		public Clone()
        {
			learned = new Stack();
			rollbacked = new Stack();
		}

        public Clone(Stack learned, Stack rollbacked, bool isCloned)
        {
			this.learned = learned;
			this.rollbacked = rollbacked;
			this.isCloned = isCloned;
        }

        internal void Learn(int program)
        {
			if (isCloned)
			{
				learned = learned.Copy();
				isCloned = false;
			}
			learned.Push(program);
			rollbacked = new Stack();
        }

        internal string Check()
        {
            var result =  learned.Peek();
			return result == null ? "basic" : result.ToString();
        }

        internal void RollBack()
        {
			if (isCloned)
			{
				learned = learned.Copy();
				rollbacked = rollbacked.Copy();
				isCloned = false;
			}
			rollbacked.Push(learned.Pop());
        }

        internal void Relearn()
        {
			if (isCloned)
			{
				learned = learned.Copy();
				rollbacked = rollbacked.Copy();
				isCloned = false;
			}
			learned.Push(rollbacked.Pop());
        }

        internal Clone CloneCopy()
        {
			var clone = new Clone (learned,rollbacked,true);
			this.isCloned = true;
			return clone;
		}
    }

	public class CloneVersionSystem : ICloneVersionSystem
	{
		private List<Clone> clones = new List<Clone>();
		public string Execute(string query)
		{
			var command = query.Split(' ');
			var cloneNumber = int.Parse(command[1])-1;
			if (cloneNumber +1 > clones.Count)
				 clones.Add(new Clone());
			 return ExecuteCommand(command);
		}

        private string ExecuteCommand(string[] command)
        {
            var cloneNumber = int.Parse(command[1])-1;
			string result = null;
			switch (command[0])
			{
				case "learn":
					clones[cloneNumber].Learn(int.Parse(command[2]));
					break;
				case "rollback":
					clones[cloneNumber].RollBack();
					break;
				case "relearn":
					clones[cloneNumber].Relearn();
					break;
				case "clone":
					clones.Add(clones[cloneNumber].CloneCopy());
					break;
				case "check":
					result = clones[cloneNumber].Check();
					break;
			}
			return result;
        }
    }
}
