using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homeworks
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercise 4
            int a = 1010;
            double b = -22.128;
            double c = 33.548;
            string fmt2 = "-##.##;##.##";

            // не получилось найти форматирование, которое удаляло бы знак "-". Пришлось использовать модуль для отрицательного значения переменной b
            Console.WriteLine("{0,-10:X}{1,-10:##.##}{2,-10:-##.##}", a, Math.Abs(b), c);


            /*
            Task 1.6
            Написать программу, которая выводит на экран следующую картинку.
            Дополнительное задание: Использовать только оператор, выводящий один символ: ‘*’ или ‘  ‘.
            Выполнить программу пошагово.                 
            */

            Console.WriteLine("{0,6}", '*');

            Console.Write("{0,4}", '*');
            Console.Write("{0,4}\n", '*');

            Console.Write("{0,2}", '*');
            Console.Write("{0,8}\n", '*');

            Console.Write('*');
            Console.Write("{0,10}\n", '*');

            Console.Write("{0,2}", '*');
            Console.Write("{0,8}\n", '*');

            Console.Write("{0,4}", '*');
            Console.Write("{0,4}\n", '*');

            Console.WriteLine("{0,6}", '*');

        }
    }
}
