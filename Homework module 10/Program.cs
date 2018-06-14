using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_module_10
{
    class Program
    {
        
        static Random randomValue = new Random();
        static int firstValue = randomValue.Next(0, 10);
        static int secondValue = randomValue.Next(0, 10);


        
        static int arrayLength = randomValue.Next(1, 10);
        static List<int> valueArray = new List<int>();
        

        static void Main(string[] args)
        {

            //10.5
            Console.WriteLine(firstValue);
            Console.WriteLine(secondValue);
            Console.WriteLine($"task 10.5 min value = {minValueFinder(firstValue, secondValue)}");
            Console.WriteLine($"task 10.5 max value = {maxValueFinder(firstValue, secondValue)}");

            //10.6        
            for (int i = 0; i < arrayLength; i++)
            {
                valueArray.Add(randomValue.Next(0, 10));
                Console.WriteLine(valueArray[i]);
            }
            
            Console.WriteLine($"task 10.6 min array value = {minArrayValueFinder(valueArray)}");
            Console.WriteLine($"task 10.6 max array value = {maxArrayValueFinder(valueArray)}");

            //10.7            
            arraySumCalculator(valueArray);

            //10.8

        }

        /*
        Задача 10.5
        Написать две функции, которые возвращают соответственно минимум
        и максимум из двух чисел, которые передаются в функцию в качестве
        аргументов.
        */

        static int minValueFinder(int a, int b)
        {
            int minValue = int.MinValue;

            if (a < b)
            {
                minValue = a;
            }
            else if (a > b)
            {
                minValue = b;
            }
            else
            {
                minValue = a;               
                
            }

            return minValue;
        }

        static int maxValueFinder(int a, int b)
        {
            int maxValue = int.MinValue;

            if (a > b)
            {
                maxValue = a;
            }
            else if (a < b)
            {
                maxValue = b;
            }
            else
            {
                
                maxValue = a;
            }

            return maxValue;
        }

        /*
        Задача 10.6
        Создать две функции, в которые передается массив чисел.
        Функции должны возвратить минимальный и максимальный элемент 
        массива соответственно.  
        */

        static int minArrayValueFinder(List<int> array)
        {
            int minValue = array[0];

            foreach (var item in array)
            {
                if (item < minValue)
                {
                    minValue = item;
                }
            }                    
            
            return minValue;
        }

        static int maxArrayValueFinder(List<int> array)
        {
            int maxValue = array[0];

            foreach (var item in array)
            {
                if (item > maxValue)
                {
                    maxValue = item;
                }
            }

            return maxValue;
        }



        /*
        Задача 10.7
        Написать функцию вычисления суммы целых чисел от 1 до N. 
        */

        static void arraySumCalculator(List<int> array)
        {
            int sum = 0;

            foreach (var item in array)
            {
                sum = sum + item;
            }

            Console.WriteLine($"sum = {sum}");
        }

        /*
        Задача 10.8
        Решить задачу 10.7 при помощи рекурсии
        */
                
    }
}
