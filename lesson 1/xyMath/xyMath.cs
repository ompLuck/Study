using System;

namespace xyMath
{
    class Program
    {
        static double XYMeth (double x1, double x2, double y1, double y2)
        {
           double r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            return r;
        }

        static void Main(string[] args)
        {
            #region 3

            double x1 = 100;
            double x2 = 300;
            double y1 = 30;
            double y2 = 130;

            double r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2-y1,2));
            Console.WriteLine("Простой вывод {0:f2}",r);

            r = XYMeth(100, 150, 200, 150);
            Console.WriteLine("Вывод методом {0:f2}",r);
            Console.ReadKey();
            #endregion
        }
    }
}
