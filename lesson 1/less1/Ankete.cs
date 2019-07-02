using System;
using System.Collections;
using System.Collections.Generic;

namespace less1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region ankete

            List<string> questList = new List<string>();
            questList.Add("Укажите свое имя?");
            questList.Add("Укажите свою фамилию?");
            questList.Add("Укажите свой возраст");
            questList.Add("Укажите свой вес(кг)? ");
            questList.Add("Укажите свой рост (см.)");

            List<string> ans = new List<string>();

            for (int i = 0; i < questList.Count; i++)            
            {
                
                Console.WriteLine(questList[i]);
                ans.Add(Console.ReadLine());
            }
                        
            string name = ans[0];                    
            string sorname = name +1;           
            int age = Convert.ToInt32(ans[2]);           
            int weight = Convert.ToInt32(ans[3]);          
            int heigth = Convert.ToInt32(ans[4]);

            Console.WriteLine("Вывод склеиванием \n Имя - " + name + "\n Фамилия - " + sorname + "\n Возраст - " + age +
                " лет \n Вес - " + weight + " кг. \n Рост - " + heigth + " см.");
            Console.ReadLine();

            Console.WriteLine("Форматированный вывод \n Имя - {0} \n Фамилия - {1} \n Возраст - {2} лет \n Вес - {3} " +
            "кг. \n Рост - {4} см.", name, sorname, age, weight, heigth);
            Console.ReadLine();

            Console.WriteLine($"Вывод через $ \n Имя - {name} \n Фамилия - {sorname} \n Возраст - {age} лет " +
                $"\n Вес - {weight} кг. \n Рост - {heigth} см.");
            Console.ReadLine();
            #endregion



           
        }
    }
}
