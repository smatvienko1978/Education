using System;

namespace Rectangles
{
	public static class RectanglesTask
	{
       
        // Пересекаются ли два прямоугольника (пересечение только по границе также считается пересечением)
        public static bool AreIntersected(Rectangle r1, Rectangle r2)
		{
			int[] R1Y = new int[r1.Height];
			int[] R1X = new int[r1.Left];
			int Xcount=0, Ycount=0;

            for (int i = 0; i < R1Y.Length; i++)
            {
				R1Y[i] = i + r1.Top;
            }
			for (int i = 0; i < R1X.Length; i++)
			{
				R1X[i] = i + r1.Left;
			}


			int[] R2Y = new int[r2.Height];
			int[] R2X = new int[r2.Left];

			for (int i = 0; i < R2Y.Length; i++)
			{
				R2Y[i] = i + r2.Top;
			}
			for (int i = 0; i < R2X.Length; i++)
			{
				R2X[i] = i + r2.Left;
			}

            for (int i = 0; i < R1Y.Length; i++)
            {
                for (int j = 0; j < R2Y.Length; j++)
                {
                    if (R1Y[i].Equals(R2Y[j])) 	Ycount +=1;
                }
            }
			for (int i = 0; i < R1X.Length; i++)
			{
				for (int j = 0; j < R2X.Length; j++)
				{
					if (R1X[i].Equals(R2X[j])) Ycount += 1;
				}
			}
			// так можно обратиться к координатам левого верхнего угла первого прямоугольника: r1.Left, r1.Top
			return Xcount >0 && Ycount>0;
		}

		// Площадь пересечения прямоугольников
		public static int IntersectionSquare(Rectangle r1, Rectangle r2)
		{
			return 0;
		}

		// Если один из прямоугольников целиком находится внутри другого — вернуть номер (с нуля) внутреннего.
		// Иначе вернуть -1
		// Если прямоугольники совпадают, можно вернуть номер любого из них.
		public static int IndexOfInnerRectangle(Rectangle r1, Rectangle r2)
		{
			return -1;
		}
	}
}