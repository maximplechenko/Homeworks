using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Module_7
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Задача 7.8
            Объявить массив из N чисел. (N вводится с клавиатуры).
            Вывести на экран отдельно все четные и нечетные элементы массива.
            */
            
            Console.WriteLine("Please enter the length of the array");
            int arrayLength = int.Parse(Console.ReadLine());

            List<int> array = new List<int>();

            Console.WriteLine("Please enter the value of each array element");
            for (int i = 0; i < arrayLength; i++)
            {
                array.Add(int.Parse(Console.ReadLine()));

            }


            Console.WriteLine("the list of even array items:");
            foreach (var item in array)
            {
                if (item % 2 == 0)
                {
                    Console.WriteLine(item);
                }
            }

            Console.WriteLine("the list of odd array items:");
            foreach (var item in array)
            {
                if (item % 2 != 0)
                {
                    Console.WriteLine(item);
                }
            }
            

            /*
            Задача 7.9
            В заданном массиве найти минимальное и максимальное значение.
            Вывести на экран массив, после чего максимальное и минимальное значение с указанием номера этих элементов в массиве.
            */

            int[] predefinedArray = {-1, 0, 10, 5, 7, 2, -7, 9, 10, 3, 3};

            int maxValue = 0;
            int maxValueIndex = 0;

            int minValue = 0;
            int minValueIndex = 0;


            foreach (var item in predefinedArray)
            {
                if (item > maxValue)
                {
                    maxValue = item;
                    maxValueIndex = Array.IndexOf(predefinedArray, item); // Also we can find it using regular "for" cycle. In this case the index of element will be = the index i of the cycle
                }
            }

            Console.WriteLine($"the value of max element = {maxValue}");
            Console.WriteLine($"the index of max element = {maxValueIndex}");

            foreach (var item in predefinedArray)
            {
                if (item < minValue)
                {
                    minValue = item;
                    minValueIndex = Array.IndexOf(predefinedArray, item); 
                }
            }

            Console.WriteLine($"the value of max element = {minValue}");
            Console.WriteLine($"the index of max element = {minValueIndex}");

        }
    }
}
