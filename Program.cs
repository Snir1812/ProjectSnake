using System;

namespace DimaProjectSnake
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int next = 0;
            int whileNum = 1;
            int score = 0;
            Random rnd = new Random();

            while (whileNum < 16)//המשחק רץ 9 שלבים
            {
                //next++;
                //if (whileNum >= 2)//שאלה האם לעבור לשלב הבא אחרי פסילה ראשונה
                //{
                //    Console.WriteLine("You are disqualified , you want to go to next level? Y/N");
                //    string answer = Console.ReadLine();
                //    if (answer != "N" && answer != "n" && answer != "Y" && answer != "y")
                //    {
                //        continue;
                //    }
                //    else if (answer == "N" || answer == "n")
                //    {
                //        break;
                //    }
                //}
                Console.Clear();
                Console.SetWindowSize(81, 29);//הגדרת גודל לוח
                Functions myFuncs = new Functions();
                myFuncs.PrintBoard();//הדפסת פונקציית לוח
                Console.WriteLine($"Your level : {whileNum}");//הדפסת שלב
                Console.WriteLine($"Your score : {score}");//הדפסת ניקוד
                bool flag = true;
                Shapes sp = new Shapes();
               
                for (int i = 0; i < whileNum + 2; i++)//כמות 
                {
                    switch (rnd.Next(0, 4))//הדפסה רנדומליט של אובייקטים
                    {
                        case 0:
                            sp.PrintSqr(myFuncs.array);
                            break;
                        case 1:
                            sp.PrintLine(myFuncs.array);
                            break;
                        case 2:
                            sp.PrintTraingle(myFuncs.array);
                            break;
                        case 3:
                            sp.PrintRectangle(myFuncs.array);
                            break;
                    }
                }

                myFuncs.SetPositionSnake();
                while (flag == true)//לולאה האחראית על תזוזת הנחש
                {
                    var key = Console.ReadKey();
                    switch (key.Key)
                    {
                        case ConsoleKey.UpArrow:
                            myFuncs.MoveUp();
                            score++;
                            break;
                        case ConsoleKey.DownArrow:
                            myFuncs.MoveDown();
                            score++;
                            break;
                        case ConsoleKey.RightArrow:
                            myFuncs.MoveRight();
                            score++;
                            break;
                        case ConsoleKey.LeftArrow:
                            myFuncs.MoveLeft();
                            score++;
                            break;
                    }
                    myFuncs.CheckGame(ref flag);//בדיקה אחרי כל תזוזה אם יש פסילה
                }
                whileNum++;

                if (whileNum > 15)
                {
                    Console.WriteLine("The game over!!!!!!");
                    Console.WriteLine($"Your score : {score}");//הדפסת ניקוד
                }
            }

        }
    }
}