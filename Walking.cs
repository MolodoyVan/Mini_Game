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
        int score, all, fir, sec, rn;
        int xy = 12;
        int x = 1;
        int y = 1;
        int end = 0;
        bool prov = false;

        public Walking()
        {
            walls = new string[xy, xy];
        }

        public string[,] Vvod
        {
            get { return this.walls; }
            set { walls = value; }
        }

        public bool Proverka
        {
            get { return prov; }
            set { prov = value; }
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

        private void Random()
        {
            rn = rand.Next(1, 8);
            while (rn != 0)
            {
                score = rand.Next(1, 8);
                fir = rand.Next(1, 10);
                sec = rand.Next(1, 10);
                if (walls[fir, sec] != " ") continue;
                else
                {
                    walls[fir, sec] = Convert.ToString(score);
                    rn -= 1;
                    end += score;
                }
            }
        }
        public void Pohod()
        {
            Random();
            Console.SetCursorPosition(0, 0);
            if (prov == true)
            {
                x = 1;
                y = 1;
            } 
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
                    else if (walls[y, x] == "=" && all != end)
                    {
                        Console.SetCursorPosition(0, 12);
                        Console.WriteLine("У вас не достаточно очков");
                        y += 1;
                    }
                    else if (walls[y, x] == "=" && all == end)
                    {
                        Console.Clear();
                        break;
                    }
                    else if (walls[y, x] == "*")
                    {
                        Console.Clear();
                        break;
                    }
                    else if (walls[y, x] != " " && Convert.ToInt32(walls[y, x]) > 0)
                    {
                        all += Convert.ToInt32(walls[y, x]);
                        scr.Pered += Convert.ToInt32(walls[y, x]);
                        walls[y, x] = "+";
                        walls[y + 1, x] = " ";
                        Print();
                        scr.Print_Score();
                        if (all == end) scr.Key();
                        if (all == end && prov == true)
                        {
                            for (int i = 4; i <= 6; i++)
                            {
                                walls[i, 4] = " ";
                                walls[i, 6] = " ";
                            }
                            walls[4, 5] = " ";
                            walls[6, 5] = " ";
                            scr.Final_Boss();
                            Console.SetCursorPosition(0, 0);
                            Print();
                        }
                    }
                    else
                    {
                        walls[y, x] = "+";
                        walls[y + 1, x] = " ";
                        Print();
                        if (all == end && prov != true) scr.Key();
                        else if (all == end && prov == true) scr.Final_Boss();
                        else scr.Print_Score();
                    }
                }
                else if (key.Key == ConsoleKey.DownArrow)
                {
                    Console.SetCursorPosition(0, 0);
                    y += 1;
                    if (walls[y, x] == "|" || walls[y, x] == "-") y -= 1;
                    else if (walls[y, x] == "=" && all != end)
                    {
                        Console.SetCursorPosition(0, 12);
                        Console.WriteLine("У вас не достаточно очков");
                        y -= 1;
                    }
                    else if (walls[y, x] == "=" && all == end)
                    {
                        Console.Clear();
                        break;
                    }
                    else if (walls[y, x] == "*")
                    {
                        Console.Clear();
                        break;
                    }
                    else if (walls[y, x] != " " && Convert.ToInt32(walls[y, x]) > 0)
                    {
                        all += Convert.ToInt32(walls[y, x]);
                        scr.Pered += Convert.ToInt32(walls[y, x]);
                        walls[y, x] = "+";
                        walls[y - 1, x] = " ";
                        Print();
                        scr.Print_Score();
                        if (all == end) scr.Key();
                        if (all == end && prov == true)
                        {
                            for (int i = 4; i <= 6; i++)
                            {
                                walls[i, 4] = " ";
                                walls[i, 6] = " ";
                            }
                            walls[4, 5] = " ";
                            walls[6, 5] = " ";
                            scr.Final_Boss();
                            Console.SetCursorPosition(0, 0);
                            Print();
                        }
                    }
                    else
                    {
                        walls[y, x] = "+";
                        walls[y - 1, x] = " ";
                        Print();
                        if (all == end && prov != true) scr.Key();
                        else if (all == end && prov == true) scr.Final_Boss();
                        else scr.Print_Score();
                    }
                }
                else if (key.Key == ConsoleKey.LeftArrow)
                {
                    Console.SetCursorPosition(0, 0);
                    x -= 1;
                    if (walls[y, x] == "|" || walls[y, x] == "-") x += 1;
                    else if (walls[y, x] == "=" && all != end)
                    {
                        Console.SetCursorPosition(0, 12);
                        Console.WriteLine("У вас не достаточно очков");
                        x += 1;
                    }
                    else if (walls[y, x] == "=" && all == end)
                    {
                        Console.Clear();
                        break;
                    }
                    else if (walls[y, x] == "*")
                    {
                        Console.Clear();
                        break;
                    }
                    else if (walls[y, x] != " " && Convert.ToInt32(walls[y, x]) > 0)
                    {
                        all += Convert.ToInt32(walls[y, x]);
                        scr.Pered += Convert.ToInt32(walls[y, x]);
                        walls[y, x] = "+";
                        walls[y, x + 1] = " ";
                        Print();
                        scr.Print_Score();
                        if (all == end) scr.Key();
                        if (all == end && prov == true)
                        {
                            for (int i = 4; i <= 6; i++)
                            {
                                walls[i, 4] = " ";
                                walls[i, 6] = " ";
                            }
                            walls[4, 5] = " ";
                            walls[6, 5] = " ";
                            scr.Final_Boss();
                            Console.SetCursorPosition(0, 0);
                            Print();
                        }
                    }
                    else
                    {
                        walls[y, x] = "+";
                        walls[y, x + 1] = " ";
                        Print();
                        if (all == end && prov != true) scr.Key();
                        else if (all == end && prov == true) scr.Final_Boss();
                        else scr.Print_Score();
                    }
                }
                else if (key.Key == ConsoleKey.RightArrow)
                {
                    Console.SetCursorPosition(0, 0);
                    x += 1;
                    if (walls[y, x] == "|" || walls[y, x] == "-") x -= 1;
                    else if (walls[y, x] == "=" && all != end)
                    {
                        Console.SetCursorPosition(0, 12);
                        Console.WriteLine("У вас не достаточно очков");
                        x -= 1;
                    }
                    else if (walls[y, x] == "=" && all == end)
                    {
                        Console.Clear();
                        break;
                    }
                    else if (walls[y, x] == "*")
                    {
                        Console.Clear();
                        break;
                    }
                    else if (walls[y, x] != " " && Convert.ToInt32(walls[y, x]) > 0)
                    {
                        all += Convert.ToInt32(walls[y, x]);
                        scr.Pered += Convert.ToInt32(walls[y, x]);
                        walls[y, x] = "+";
                        walls[y, x - 1] = " ";
                        Print();
                        scr.Print_Score();
                        if (all == end) scr.Key();
                        if (all == end && prov == true)
                        {
                            for (int i = 4; i <= 6; i++)
                            {
                                walls[i, 4] = " ";
                                walls[i, 6] = " ";
                            }
                            walls[4, 5] = " ";
                            walls[6, 5] = " ";
                            scr.Final_Boss();
                            Console.SetCursorPosition(0, 0);
                            Print();
                        }
                    }
                    else
                    {
                        walls[y, x] = "+";
                        walls[y, x - 1] = " ";
                        Print();
                        if (all == end && prov != true) scr.Key();
                        else if (all == end && prov == true) scr.Final_Boss();
                        else scr.Print_Score();
                    }
                }
            } while (key.Key != ConsoleKey.Enter);
        }
    }
}
