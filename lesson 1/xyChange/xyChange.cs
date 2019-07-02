using System;

namespace xyChange
{
    class Program
    {

        static void outChange (out int a, out int b)
        {
            a = 5;
            b = 40;
        }
        static void Main(string[] args)
        {
            #region xyChange
            int a = 5;
            int b = 40;
             Console.WriteLine("Начало \n a = " + a + "\n b = " + b);
            int c = a;
            a = b;
            b = c;
            Console.WriteLine("Изменение с 3 переменной \n a = " + a + "\n b = " + b);

            int [] mass = new int [] {a , b};
            a = mass[1];
            b = mass[0];
            Console.WriteLine("Изменение массивом \n a = " + a + "\n b = " + b);

            a = a + b;
            b = b - a;
            b = -b;
            a = a - b;
            Console.WriteLine("Изменение математическое \n a = " + a + "\n b = " + b);

            outChange(out a, out b);
            Console.WriteLine("Изменение методом out \n a = {0} \n b = {1}", a, b);
            #endregion
        }
    }
}
