using System;

namespace Homework_Module_6
{
    class Program
    {
        static void Main(string[] args)
        {             
                    
            int sourceLeft = 10;
            int sourceTop = 10;
            int sourceWidth = 10;
            int sourceHeight = 10;
            int targetLeft = 10;
            int targetTop = 10;
            
            int bufferSizeX = 150;
            int BufferSizeY = 150;
            
            Console.CursorVisible = false; //hides the cursor
            ConsoleKeyInfo insertKey;


            //draws the image
            for (int i = 0; i < 3; i++)
            {
                Console.SetCursorPosition(targetLeft, targetTop + i);
                Console.WriteLine("000");
            }
                   


            do
            {
                insertKey = Console.ReadKey();
                switch (insertKey.Key)
                {
                    case ConsoleKey.UpArrow:
                        targetTop = sourceTop - 1;                        
                        if (targetTop == -1) //This is the strange way to avoid exception. Visually the image stops in front of the border of the console window and the exception does not appear
                        {
                            targetTop = 0;
                        }
                        break;

                    case ConsoleKey.DownArrow:
                        targetTop = sourceTop + 1;
                        Console.SetBufferSize(bufferSizeX, BufferSizeY++);  //increases the height of the buffer when the images moves down. Exception will be thrown only when the size of buffer will be > than the int size.           
                        break;

                    case ConsoleKey.LeftArrow:
                        targetLeft = sourceLeft - 1;                        
                        if (targetLeft == -1)
                        {
                            targetLeft = 0;
                        }
                        break;

                    case ConsoleKey.RightArrow:
                        targetLeft = sourceLeft + 1;
                        Console.SetBufferSize(bufferSizeX++, BufferSizeY); 
                        break;

                    default:
                        break;
                }

                Console.MoveBufferArea(sourceLeft, sourceTop, sourceWidth, sourceHeight, targetLeft, targetTop); // sets the new buffer area
                sourceLeft = targetLeft;
                sourceTop = targetTop;

            } while (insertKey.Key != ConsoleKey.Backspace); 

        }
    }
}
