using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Module_9
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Дан граф (см. рисунок), у вершин которого может быть только один вход и несколько выходов. Кроме того вершина может не иметь входа или выходов. Данный граф описывается
             последовательностью (вершина выход – вершина вход), которая дается в произвольном порядке.
             Например, для данного графа (5,2),(1,6),(5,4),(3,5),(5,7),(3,1).
             Написать программу, которая сортирует вершины по уровню вложенности
             3-я вершина
             1, 5 вершина
             6,4,7,2
            */

            string tempStringValue = "0";
            int tempIntValue = 0;
            
            int firstLevel = 0;
            List<string> secondLevel = new List<string>();                                    
            List<string> thirdLevel = new List<string>();



            int[][] pairsArray = new int[6][];
            pairsArray[0] = new int[2] { 5, 2 };
            pairsArray[1] = new int[2] { 1, 6 };
            pairsArray[2] = new int[2] { 5, 4 };
            pairsArray[3] = new int[2] { 3, 5 };
            pairsArray[4] = new int[2] { 5, 7 };
            pairsArray[5] = new int[2] { 3, 1 };


            for (int i = 0; i < pairsArray.Length; i++)
            {
                for (int j = 0; j < pairsArray.Length; j++)
                {
                    if (pairsArray[i][0] != pairsArray[j][1])
                    {
                        tempIntValue = pairsArray[i][0];

                    }

                }

                firstLevel = tempIntValue;

            }

            Console.WriteLine("The first level is: ");
            Console.WriteLine(firstLevel);


            for (int i = 0; i < pairsArray.Length; i++)
            {
                for (int j = 0; j < pairsArray.Length; j++)
                {
                    if (pairsArray[i][0] == firstLevel)
                    {
                        tempStringValue = Convert.ToString(pairsArray[i][1]);
                    }
                    else
                    {
                        tempStringValue = null;
                        break;
                    }

                }

                secondLevel.Add(tempStringValue);
            }

            Console.WriteLine("The second level is: ");
            foreach (var item in secondLevel)
            {
                Console.WriteLine(item);
            }
            

            for (int i = 0; i < pairsArray.Length; i++)
            {
                for (int j = 0; j < pairsArray.Length; j++)
                {
                    if (pairsArray[i][1] != pairsArray[j][0])
                    {
                        tempStringValue = Convert.ToString(pairsArray[i][1]);
                    }
                    else
                    {
                        tempStringValue = null;
                        break;
                    }
                                        
                }
                
                thirdLevel.Add(tempStringValue);
            }

            Console.WriteLine("The third level is: ");
            foreach (var item in thirdLevel)
            {
                Console.WriteLine(item);
            }      
               


            

        }
    }
}

