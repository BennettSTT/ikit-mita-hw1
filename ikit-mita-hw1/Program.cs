using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace ikit_mita_hw1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Кошка какого возроста вам нужна?");
            Console.Write("Решение: ");
            string age = Console.ReadLine();
            var cat = new Cat(age);

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Информация о кошке: \nИмя: {0}\nВозраст: {1}\nТекущий цвет: {2}"
                    , cat.Name, cat.Age, cat.CurrentColor);
                Console.WriteLine("\n1) Задать имя\n2) Задать цвет\n3) Ударить\n4) Покормить");
                Console.Write("\nРешение: ");
                int selectionMenu;
                try
                {
                    selectionMenu = int.Parse(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Console.ReadKey();
                    continue;
                }
                switch (selectionMenu)
                {
                    case 1:
                        Console.Write("Имя: ");
                        cat.Name = Console.ReadLine();
                        break;
                    case 2:
                        Console.Write("Новый цвет вашей кошки: ");
                        string color = Console.ReadLine();
                        cat.CurrentColor = color;
                        break;
                    case 3:
                        cat.Punish();
                        break;
                    case 4:
                        cat.Feed();
                        break;
                }
            }
        }
    }
}
