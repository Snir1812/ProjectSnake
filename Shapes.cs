using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DimaProjectSnake
{
    internal class Shapes
    {
        Random rnd = new Random();
        public void PrintRectangle(char[,] arr)
        {
            int colorIndex = rnd.Next(1, 16);
            ConsoleColor randomColor = (ConsoleColor)colorIndex;
            Console.ForegroundColor = randomColor;
           
            while (true)
            {
                int a = 0;
                //Console.OutputEncoding = System.Text.Encoding.UTF8;
                int w = rnd.Next(3, 7);//3-6
                int h = rnd.Next(w + 1, 8);
                int pos5 = rnd.Next(1, 81 - w);
                int pos6 = rnd.Next(1, 26 - h);


                for (int i = pos5; i < pos5 + w; i++)
                {
                    for (int j = pos6; j < pos6 + h; j++)
                    {
                        if (arr[j, i] != ' ')
                        {
                            a++;
                        }
                    }
                }
                if (a > 0)
                {
                    continue;
                }
                else
                {
                    for (int i = pos5; i < pos5 + w; i++)
                    {
                        for (int j = pos6; j < pos6 + h; j++)
                        {
                            arr[j, i] = '5';
                            Console.SetCursorPosition(i, j);
                            Console.Write("5");
                        }
                        Console.WriteLine();
                    }
                    break;
                }

            }
        }
        public void PrintTraingle(char[,] arr)
        {
            int colorIndex = rnd.Next(1, 16);
            ConsoleColor randomColor = (ConsoleColor)colorIndex;
            Console.ForegroundColor = randomColor;
            while (true)
            {
                int a = 0;
                int triangleSize = rnd.Next(2, 10);
                int pos5 = rnd.Next(1, 81 - triangleSize);
                int pos6 = rnd.Next(1, 26 - triangleSize);

                for (int i = 0; i < triangleSize; i++)
                {
                    // Loop through the columns
                    for (int j = 0; j <= i; j++)
                    {
                        if (arr[i + pos6, j + pos5] != ' ')
                        {
                            a++;
                        }
                    }
                }
                if (a > 0)
                {
                    continue;
                }
                else
                {
                    for (int i = 0; i < triangleSize; i++)
                    {
                        // Loop through the columns
                        for (int j = 0; j <= i; j++)
                        {
                            arr[i + pos6, j + pos5] = '8';
                            Console.SetCursorPosition(j + pos5, i + pos6);
                            Console.Write("8");
                        }
                        Console.WriteLine();
                    }
                    break;
                }

            }
        }

        public void PrintSqr(char[,] arr)
        {
            int colorIndex = rnd.Next(1, 16);
            ConsoleColor randomColor = (ConsoleColor)colorIndex;
            Console.ForegroundColor = randomColor;
            while (true)
            {
                int a = 0;
                int sqr = rnd.Next(3, 11);//3-10
                                          //int sqr = 22;
                int pos3 = rnd.Next(1, 26 - sqr);//1-25
                int pos4 = rnd.Next(1, 81 - sqr);//1-80
                Console.OutputEncoding = System.Text.Encoding.UTF8;

                for (int i = pos4; i < pos4 + sqr; i++)//X
                {
                    for (int j = pos3; j < pos3 + sqr; j++)//Y
                    {
                        if (arr[j, i] != ' ')
                        {
                            a++;
                        }
                    }
                }
                if (a > 0)
                {
                    continue;
                }
                else
                {
                    for (int i = pos4; i < pos4 + sqr; i++)//X
                    {
                        for (int j = pos3; j < pos3 + sqr; j++)//Y
                        {
                            arr[j, i] = 'ם';
                            Console.SetCursorPosition(i, j);
                            Console.Write('ם');
                        }
                        Console.WriteLine();
                    }
                    break;
                }
            }
        }


        public void PrintLine(char[,] arr)
        {
            int colorIndex = rnd.Next(1, 16);
            ConsoleColor randomColor = (ConsoleColor)colorIndex;
            Console.ForegroundColor = randomColor;
            while (true)
            {
                int a = 0;
                int line = rnd.Next(2, 11);//2-10
                                           //int line = 80;
                int pos1 = rnd.Next(1, 25);//1-24 line hight = 1
                int pos2 = rnd.Next(1, 81 - line);//1-80

                for (int i = pos2; i <= pos2 + line; i++)
                {
                    if (arr[pos1, i] != ' ')
                    {
                        a++;
                    }
                }
                if (a > 0)
                {
                    continue;
                }
                else
                {
                    for (int i = pos2; i <= pos2 + line; i++)
                    {
                        arr[pos1, i] = '=';
                        Console.SetCursorPosition(i, pos1);
                        Console.Write('=');
                    }
                    break;
                }

            }

        }
    }
}

