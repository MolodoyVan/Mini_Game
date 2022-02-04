using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Мини_игра
{
    class Fighting
    {
        ConsoleKeyInfo key;
        string[,] text;
        string[,] boss;
        int x = 2;
        int yy = 5;
        int xy = 10;

        public Fighting()
        {
            text = new string[2, 2];
            boss = new string[yy, xy];
        }

        private void Menu()
        {
            text[0, 0] = "1.";
            text[1, 0] = "2.";
            text[0, 1] = " I AM THE STORM THAT IS APPROCHING";
            text[1, 1] = " DNA OF THE SOUL";
        }

        private void Monster() //Грфаическая обрисовка монстра
        {
            for (int i = 0; i < yy; i++)
            {
                boss[i, 0] = "|";
                boss[i, 9] = "|";
                for (int j = 0; j < xy; j++)
                {
                    boss[0, j] = "-";
                    boss[4, j] = "-";
                }
            }
            boss[0, 0] = "|"; boss[0, 9] = "|"; boss[4, 0] = " ";  boss[4, 9] = " "; //Его границы
            boss[1, 2] = "\\"; boss[2, 2] = "<";  boss[2, 3] = "\\";  boss[1, 7] = "/"; boss[2, 7] = ">"; boss[2, 6] = "/"; //Его глаза
            boss[2, 1] = "="; boss[2, 4] = "="; boss[2, 5] = "="; boss[2, 8] = "="; //Хрень на линии глаз
            boss[1, 4] = "-"; boss[1, 5] = "-"; boss[3, 4] = "\\"; boss[3, 5] = "/";
            for (int i = 0; i < yy; i++)
                for (int j = 0; j < xy; j++)
                    if (boss[i, j] == null) boss[i, j] = " ";
        }

        private void Print_Boss()
        {
            Console.Clear();
            Monster();
            Console.SetCursorPosition(0, 0);
            for (int i = 0; i < yy; i++)
            {
                for (int j = 0; j < xy; j++)
                    Console.Write(boss[i, j]);
                Console.WriteLine();
            }
        }

        private void Print_Menu()
        {
            Console.SetCursorPosition(0, 6);
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < x; j++)
                    Console.Write(text[i, j]);
                Console.WriteLine();
            }
        }

        public void Fight()
        {
            Menu();
            Print_Boss();
            text[0, 0] = "+ ";
            Print_Menu();
            do
            {
                key = Console.ReadKey();
                if (key.Key == ConsoleKey.UpArrow)
                {
                    text[1, 0] = "2.";
                    text[0, 0] = "+ ";
                    Print_Menu();

                }
                else if (key.Key == ConsoleKey.Enter && text[0, 0] == "+ ")
                {
                    Console.Clear();
                    Console.WriteLine("PROVOOOOOKING \nBLACK CLOUDS IN IIIIIIIIISOLAAAAAAAAAAATIOOOOOOOOOOON " +
                        "\n\nСВОИМИ POWER И MOTIVATION ВЫ СНЕСЛИ БОССУ ЕБАСОС \n\nВЫ ПОБЕДИЛИ!");
                    break;
                }
                else if (key.Key == ConsoleKey.DownArrow)
                {
                    text[0, 0] = "1.";
                    text[1, 0] = "+ ";
                    Print_Menu();
                }
                else if (key.Key == ConsoleKey.Enter && text[1, 0] == "+ ")
                {
                    Console.Clear();
                    Console.WriteLine("С ПОМОЩЬЮ MEMES ВЫ СОКРУШИЛИ ЕБАЛЬНИК БОССА \n\nВЫ ПОБЕДИЛИ!");
                    break;
                }
            } while (key.Key != ConsoleKey.Escape);
        }
    }
}
