using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DimaProjectSnake
{
    internal class Functions
    {
        public int col = 80, row = 25;
        public int xValue;
        public int yValue;
        int loss;
        public char[,] array;
        Random rnd = new Random();

        public Functions()
        {
            array = new char[26, 81];//the array
        }
        public void SetPositionSnake()
        {
            Console.ForegroundColor = ConsoleColor.White;
            while (true)
            {
                xValue = rnd.Next(1, 80);
                yValue = rnd.Next(1, 25);

                if ((array[yValue, xValue] != ' '))
                {
                    continue;
                }
                else
                {
                    array[yValue, xValue] = '0';
                    Console.SetCursorPosition(xValue, yValue);
                    Console.Write("0");
                    break;
                }
            }
        }
        public void PrintBoard()//print the basic board with limits
        {

            for (int i = 0; i < 26; i++)//char=' '
            {
                for (int j = 0; j < 81; j++)
                {
                    array[i, j] = ' ';
                }
            }

            for (int i = 0; i < 26; i++)//limits
            {
                array[i, 0] = '*';
                array[i, 80] = '*';

                for (int j = 0; j < 81; j++)
                {
                    array[0, j] = '*';
                    array[25, j] = '*';
                    Console.Write(array[i, j]);
                }
                Console.WriteLine();
            }
            //Console.SetCursorPosition(xValue, yValue);
        }


        public void CheckGame(ref bool flag)
        {
            if (loss > 0)
            {
                Console.Clear();
                flag = false;
            }
        }
        public void MoveUp()
        {
            if (array[yValue - 1, xValue] != ' ' && array[yValue - 1, xValue] != '*')
            {
                loss++;
            }
            else
            {
                if (yValue <= 1)
                {
                    yValue = 1;
                }
                else
                {
                    yValue--;
                }

                Console.SetCursorPosition(xValue, yValue);
                Console.Write("0");
                array[yValue, xValue] = '0';
            }

        }
        public void MoveDown()
        {
            if (array[yValue + 1, xValue] != ' ' && array[yValue + 1, xValue] != '*')
            {
                loss++;
            }
            else
            {
                if (yValue >= 24)
                {
                    yValue = 24;
                }
                else
                {
                    yValue++;
                }
                Console.SetCursorPosition(xValue, yValue);
                Console.Write("0");
                array[yValue, xValue] = '0';
            }

        }
        public void MoveRight()
        {
            if (array[yValue, xValue + 1] != ' ' && array[yValue, xValue + 1] != '*')
            {
                loss++;
            }
            else
            {
                if (xValue >= 79)
                {
                    xValue = 79;
                }
                else
                {
                    xValue++;
                }

                Console.SetCursorPosition(xValue, yValue);
                Console.Write("0");
                array[yValue, xValue] = '0';
            }

        }
        public void MoveLeft()
        {
            if (array[yValue, xValue - 1] != ' ' && array[yValue, xValue - 1] != '*')
            {
                loss++;
            }
            else
            {
                if (xValue <= 1)
                {
                    xValue = 1;

                }
                else
                {
                    xValue--;
                }
                Console.SetCursorPosition(xValue, yValue);
                Console.Write("0");
                array[yValue, xValue] = '0';
            }

        }
    }
}



