using System;

namespace IBM
{
    class Program
    {
        static void Main(string[] args)
        {

            #region IMT
            Console.Write("Укажите свой рост: ");
            string a = Console.ReadLine();
            double h = new double();
            if (a.Contains(".") || a.Contains(","))
            {
                string b = a.Replace(".", ",");
                h = Convert.ToDouble(b);
              
            }
              else
            {
                double b = Convert.ToDouble(a);
               h = b / 100;
            }
            
            
            Console.Write("Укажите свой вес в киллограммах: ");
            int m = Convert.ToInt32(Console.ReadLine());

            double imt = m / (h * h);
            Console.WriteLine("Ваш индекс массы тела = {0:F2}", imt);
            if (imt <= 18)
            {
                Console.WriteLine("Пора Вам завязывать с диетами и начать хоть что-то кушать, " +
                    "\n а то скоро Вас из-за швабры будет не разглядеть...");
            }
            else if (imt > 18 && imt <= 25)
            {
                Console.WriteLine("Ваш вес в норме! Это редкость в наше время, так что вы в меньшинстве! Поздравляем");
            }

            else if (imt > 25 && imt <= 30)
            {
                Console.WriteLine("У Вас предожирение! Но Вы не одиноки...да мы почти все такие, так что не унывайте! " +
                    "\n Хотя спортом заняться не помешает...я сам всегда об этом думаю, особенно во время обеда, или перед сном...");
            }

            else if (imt > 30 && imt <= 40)
            {
                Console.WriteLine("У Вас явное ожирение! Хотя хорошего человека должно быть много! " +
                    "\n И плевать что большинство врачей с нами не согласно, ведь правда =)");
            }
            else if (imt > 40)
            {
                Console.WriteLine("Хорошего человека конечно должно быть много, но не настолько же! " +
                    "\n Пора садиться на диету!");
            }
            Console.ReadKey();
            #endregion
        }
    }
}
