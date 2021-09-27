using System;

namespace MyPhotoshop
{
	public class Photo
	{
        public readonly int width;

        public readonly int height;

        private readonly Point[,] data;
        //public Point[,] Data { get => data; set => data = value; }
        public Point this[int i, int j]  
        { 
            get => data[i,j]; 
            set { data[i, j] = value; }
        }
        public Photo(int width, int height)
        {
            this.width = width;
            this.height = height;
			data = new Point[width, height];
        }
	}
}

