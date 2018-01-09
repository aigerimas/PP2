using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (string s in args) // пробегаемся по массиву args
            {
                if (Is_simple(int.Parse(s)))
                /*
                  функция которая проверяет является ли число простым или нет. данные берутся из массива
                  args. Тип аргументов в массиве string, поэтому парсим их в инт и если выполняется условие
                  то выводим на консоль простое число
                */
                {
                    Console.WriteLine(s);
                }
            }
            Console.ReadKey();
        }
        public static bool Is_simple(int a) // функция проверки на простоту числа
        {
            for (int i = 2; i * i <= a; i++)
            {
                if (a % i == 0)
                    return false;
            }
            return true;
        }

    }
}
