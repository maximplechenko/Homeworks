using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Module_4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Задача 4.5
            В программе определены два числа, определяющие нижний и верхний пороговые уровни на цену товара.
            Ввести с клавиатуры новую цену товара.
            Реализовать следующие условия: если цена поднялась выше верхнего значения, то сообщить об этом трейдеру, если цена опустилась ниже нежнего порога, то сообщить об этом трейдеру, 
            в остальных случаях не осуществлять никаких действий.
            Предложить два варианта (последовательный и вложенный if)
            */

            decimal upperPriceLimit = 13.7M;
            decimal lowerPriceLimit = 6.2M;

            decimal currentPrice = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the price");

            //последовательный if
            if (currentPrice > upperPriceLimit)
            {
                Console.WriteLine("The price has got above the upper limit");
            }
            if (currentPrice < lowerPriceLimit)
            {
                Console.WriteLine("The price has got under the lower limit");
            }

            //вложенный if
            if (currentPrice > upperPriceLimit)
            {
                Console.WriteLine("The price has got above the upper limit");
            }
            else if (currentPrice < lowerPriceLimit)
            {
               Console.WriteLine("The price has got under the lower limit");
            }
            

            /*
            Задача 4.6
            Написать программу – калькулятор. Пользователь вводит два числа и то действие, которое нужно совершить (+, -, *, /, %)
            Вывести полученный результат на экран.
            Реализовать два варианта (с оператором if и case)
            */

            double ifResult = 0;
            double switchResult = 0;

            Console.WriteLine("Please enter the first number");
            double firstNumber = double.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the second number");
            double secondNumber = double.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the math operation");
            char operation = char.Parse(Console.ReadLine());

            //if
            if (operation == '+')
            {
                ifResult = firstNumber + secondNumber;
            }
            else if (operation == '-')
            {
                ifResult = firstNumber - secondNumber;
            }
            else if (operation == '*')
            {
                ifResult = firstNumber * secondNumber;
            }
            else if (operation == '/')
            {
                ifResult = firstNumber / secondNumber;
            }
            else if (operation == '%')
            {
                ifResult = firstNumber % secondNumber;
            }

            Console.WriteLine($"the IF calc result is = {ifResult}");

            //switch

            switch (operation)
            {
                case '+':
                    switchResult = firstNumber + secondNumber;
                    break;
                case '-':
                    switchResult = firstNumber - secondNumber;
                    break;
                case '*':
                    switchResult = firstNumber * secondNumber;
                    break;
                case '/':
                    switchResult = firstNumber / secondNumber;
                    break;
                case '%':
                    switchResult = firstNumber % secondNumber;
                    break;                
            }

            Console.WriteLine($"the SWITCH calc result is = {switchResult}");
            

            /*
            Задача 4.7
            Ввести с клавиатуры данные о трех машинах:
            (Название, максимальная скорость, количество литров на 100 км.)
            Вывести на экран две таблицы сравнения:
            - по максимальной скорости
            - по количеству литров на 100 км.
            */

            Console.WriteLine("Please enter the car name");
            string firstCarName = Console.ReadLine();
            Console.WriteLine("Please enter the car speed");
            int firstCarSpeed = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the car fuel economy");
            int firstCarFuel = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the car name");
            string secondCarName = Console.ReadLine();
            Console.WriteLine("Please enter the car speed");
            int secondCarSpeed = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the car fuel economy");
            int secondCarFuel = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the car name");
            string thirdCarName = Console.ReadLine();
            Console.WriteLine("Please enter the car speed");
            int thirdCarSpeed = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the car fuel economy");
            int thirdCarFuel = int.Parse(Console.ReadLine());

            

            Console.WriteLine("{0,-30}{1,-30}{2,-30}", "Car name","Car speed","Car fuel economy");

            if ((firstCarSpeed >= secondCarSpeed) && (firstCarSpeed >= thirdCarSpeed))
            {
                Console.WriteLine("{0,-30}{1,-30}{2,-30}", firstCarName, firstCarSpeed, firstCarFuel);
                if (secondCarSpeed>=thirdCarSpeed)
                {
                    Console.WriteLine("{0,-30}{1,-30}{2,-30}", secondCarName, secondCarSpeed, secondCarFuel);
                    Console.WriteLine("{0,-30}{1,-30}{2,-30}", thirdCarName, thirdCarSpeed, thirdCarFuel);
                }
                else
                {
                    Console.WriteLine("{0,-30}{1,-30}{2,-30}", thirdCarName, thirdCarSpeed, thirdCarFuel);
                    Console.WriteLine("{0,-30}{1,-30}{2,-30}", secondCarName, secondCarSpeed, secondCarFuel);
                }                       
            }
            else if ((secondCarSpeed >= firstCarSpeed) && (secondCarSpeed >= thirdCarSpeed))
            {
                Console.WriteLine("{0,-30}{1,-30}{2,-30}", secondCarName, secondCarSpeed, secondCarFuel);
                if (firstCarSpeed >= thirdCarSpeed)
                {
                    Console.WriteLine("{0,-30}{1,-30}{2,-30}", firstCarName, firstCarSpeed, firstCarFuel);
                    Console.WriteLine("{0,-30}{1,-30}{2,-30}", thirdCarName, thirdCarSpeed, thirdCarFuel);
                }
                else
                {
                    Console.WriteLine("{0,-30}{1,-30}{2,-30}", thirdCarName, thirdCarSpeed, thirdCarFuel);
                    Console.WriteLine("{0,-30}{1,-30}{2,-30}", firstCarName, firstCarSpeed, firstCarFuel);
                }

            }
            else if ((thirdCarSpeed >= firstCarSpeed) && (thirdCarSpeed >= secondCarSpeed))
            {
                Console.WriteLine("{0,-30}{1,-30}{2,-30}", thirdCarName, thirdCarSpeed, thirdCarFuel);
                if (firstCarSpeed >= secondCarSpeed)
                {
                    Console.WriteLine("{0,-30}{1,-30}{2,-30}", firstCarName, firstCarSpeed, firstCarFuel);
                    Console.WriteLine("{0,-30}{1,-30}{2,-30}", secondCarName, secondCarSpeed, secondCarFuel);
                }
                else
                {
                    Console.WriteLine("{0,-30}{1,-30}{2,-30}", secondCarName, secondCarSpeed, secondCarFuel);
                    Console.WriteLine("{0,-30}{1,-30}{2,-30}", firstCarName, firstCarSpeed, firstCarFuel);
                }

            }
        }
    }
}
