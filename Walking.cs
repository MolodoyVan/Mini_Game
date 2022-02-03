using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Мини_игра
{
    class Walking
    {
        Random rand = new Random();
        Score scr = new Score();
        ConsoleKeyInfo key;
        string[,] walls;
        int xy = 12;
        int x = 1;
        int y = 1;
        int fir;
        int sec;
        int rn;
        int score;
        int all;
        int end;

        public Walking()
        {
            walls = new string[xy, xy];
        }

        public string[,] Vvod
        {
            get
            {
                return this.walls;
            }
            set
            {
                this.walls = value;
            }
        }


        private void Random()
        {
            rn = rand.Next(1, 8);
            while(rn != 0)
            {
                score = rand.Next(1, 8);
                fir = rand.Next(1, 10);
                sec = rand.Next(1, 10);
                if (walls[fir, sec] != "0") continue;
                else
                {
                    walls[fir, sec] = Convert.ToString(score);
                    rn -= 1;
                    end += score;
                }
            }
            

        }

        private void Print()
        {
            for (int i = 0; i < xy; i++)
            {
                for (int j = 0; j < xy; j++)
                    Console.Write(walls[i, j]);
                Console.WriteLine();
            }
        }

        public void Pohod()
        {
            Console.SetCursorPosition(0, 0);
            Random();
            Print();
            scr.Print_Score();
            do
            {
                key = Console.ReadKey();
                if (key.Key == ConsoleKey.UpArrow)
                {
                    Console.SetCursorPosition(0, 0);
                    y -= 1;
                    if (walls[y, x] == "|" || walls[y, x] == "-") y += 1;
                    else if(Convert.ToInt32(walls[y, x]) > 0)
                    {
                        all += Convert.ToInt32(walls[y, x]);
                        scr.Pered += Convert.ToInt32(walls[y, x]);
                        walls[y, x] = "+";
                        walls[y + 1, x] = "0";
                        Print();
                        scr.Print_Score();
                        if (all == end)
                        {
                            scr.Win();
                            break;
                        }
                    }
                    else
                    {
                        walls[y, x] = "+";
                        walls[y + 1, x] = "0";
                        Print();
                        scr.Print_Score();
                    }
                }
                else if (key.Key == ConsoleKey.DownArrow)
                {
                    Console.SetCursorPosition(0, 0);
                    y += 1;
                    if (walls[y, x] == "|" || walls[y, x] == "-") y -= 1;
                    else if (Convert.ToInt32(walls[y, x]) > 0)
                    {
                        all += Convert.ToInt32(walls[y, x]);
                        scr.Pered += Convert.ToInt32(walls[y, x]);
                        walls[y, x] = "+";
                        walls[y - 1, x] = "0";
                        Print();
                        scr.Print_Score();
                        if (all == end)
                        {
                            scr.Win();
                            break;
                        }
                    }
                    else
                    {
                        walls[y, x] = "+";
                        walls[y - 1, x] = "0";
                        Print();
                        scr.Print_Score();
                    }
                }
                else if (key.Key == ConsoleKey.LeftArrow)
                {
                    Console.SetCursorPosition(0, 0);
                    x -= 1;
                    if (walls[y, x] == "|" || walls[y, x] == "-") x += 1;
                    else if (Convert.ToInt32(walls[y, x]) > 0)
                    {
                        all += Convert.ToInt32(walls[y, x]);
                        scr.Pered += Convert.ToInt32(walls[y, x]);
                        walls[y, x] = "+";
                        walls[y, x + 1] = "0";
                        Print();
                        scr.Print_Score();
                        if (all == end)
                        {
                            scr.Win();
                            break;
                        }
                    }
                    else
                    {
                        walls[y, x] = "+";
                        walls[y, x + 1] = "0";
                        Print();
                        scr.Print_Score();
                    }
                }
                else if (key.Key == ConsoleKey.RightArrow)
                {
                    Console.SetCursorPosition(0, 0);
                    x += 1;
                    if (walls[y, x] == "|" || walls[y, x] == "-") x -= 1;
                    else if (Convert.ToInt32(walls[y, x]) > 0)
                    {
                        all += Convert.ToInt32(walls[y, x]);
                        scr.Pered += Convert.ToInt32(walls[y, x]);
                        walls[y, x] = "+";
                        walls[y, x - 1] = "0";
                        Print();
                        scr.Print_Score();
                        if (all == end)
                        {
                            scr.Win();
                            break;
                        }
                    }
                    else
                    {
                        walls[y, x] = "+";
                        walls[y, x - 1] = "0";
                        Print();
                        scr.Print_Score();
                    }
                }
            } while (key.Key != ConsoleKey.Enter);
        }
    }
}
