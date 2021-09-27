using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Incapsulation.Weights
{
    public class Indexer
    {
        private double[] items;
        private int start;
        private int length;

        public Indexer(double[] items, int start, int length)
        {
            if (start < 0 || start > items.Length || length < 0 || start + length > items.Length)
                throw new ArgumentException();
            this.items = items;
            this.start = start;
            this.length = length;
        }

        public double Length { get=>length; }
        public double this[int index]
        {

            get => items[CalcIndex(index)];
            set => items[CalcIndex(index)] = value;
        }

        private int CalcIndex(int index)
        {
            if (index < 0 || index + start > items.Length || index>length-1)
                throw new IndexOutOfRangeException();
            return index + start;
        }
    }

}