using System;
using System.Collections;
using System.Collections.Generic;

namespace hashes
{
	// TODO: Создайте класс ReadonlyBytes
	public class ReadonlyBytes:IEnumerable
    {
        readonly byte[] items;
        private int hashCode;
        public int Length { get => items.Length;  }
        public ReadonlyBytes(params byte [] args)
        {
            if (args == null) throw new ArgumentNullException("Null is not correct argument");
            items = new byte[args.Length];
            for (int i = 0; i < args.Length; i++)
                items[i] = args[i];
        }
        public byte this[int index]
        {
            get { return items[index]; }
            set { items[index] = value;}
        }
        public IEnumerator<byte> GetEnumerator()
        {
            return ((IEnumerable<byte>) items).GetEnumerator();
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator() ;
        }
        public override bool Equals(object obj)
        {
            var compared = obj as ReadonlyBytes;
            if (compared == null) return false;
            if (obj.GetType() != this.GetType()) return false;
            if (compared.Length != items.Length) return false;
            for (int i = 0; i < Length; i++)
                if (compared[i] != items[i]) return false;
            return true;
        }
        public override int GetHashCode()
        {
            unchecked
            {
                if (hashCode != 0) return hashCode;
                hashCode = 1;
                foreach (var item in items)
                {
                    hashCode *= 1013;
                    hashCode += item;
                }
                return hashCode;
            }
        }

        public override string ToString()
        {
            return $"[{string.Join(", ", items)}]";
        }
    }
}