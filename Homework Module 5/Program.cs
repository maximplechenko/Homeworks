using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Module_5
{
    class Program
    {
        static void Main(string[] args)
        {
            /*        
            Задача 5.7
            Составьте программу, которая вычисляет произведение чисел от 1 до n. (n!)
            Значение n вводится с клавиатуры.            
            */

            
            Console.WriteLine("Task 5.7\n");

            Console.WriteLine("Please enter the value of (n!)");
            var factorialValue = int.Parse(Console.ReadLine());
            int intermediateResult;
            var factorialResult = factorialValue - (factorialValue - 1);
            

            for (var i = 1; i < factorialValue; i++)
            {
                intermediateResult = factorialResult * (i + 1);
                Console.WriteLine($"intermediate result on multiplication step #{i} = {intermediateResult}");
                factorialResult = intermediateResult;
                
            }

            Console.WriteLine($"factorial result = {factorialResult}");
            

            /*
            Задача 5.8
            В банк на двадцатипроцентный вклад положили М гривен.
            Начисления происходят раз в год и добавляются к сумме вклада.
            Какой станет сумма вклада через N лет.                
            */
            Console.WriteLine("\nTask 5.8\n");

            Console.WriteLine("Please enter the ammount");
            decimal moneyDeposit = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the deposit term");
            int term = int.Parse(Console.ReadLine());
            decimal totalAmmount = moneyDeposit;

            for (int i = 1; i <= term; i++)
            {
                Console.WriteLine($"The bonus of the year {i} will be = {((moneyDeposit * 20) / 100)}");
                moneyDeposit = totalAmmount + ((moneyDeposit*20)/100);
                Console.WriteLine($"Your deposit after {i} year will be = {moneyDeposit}\n");
                //Console.WriteLine($"and the bonus will be = {((moneyDeposit * 20) / 100)}");

                totalAmmount = moneyDeposit;
            }

            Console.WriteLine($"after {term} years the total ammount will be = {totalAmmount}");
        }
    }
}
