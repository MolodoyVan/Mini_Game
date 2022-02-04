using System;

namespace Мини_игра
{
    class Program
    {
        static void Main(string[] args)
        {
            Dungeon1 dun1 = new Dungeon1();
            Dungeon2 dun2 = new Dungeon2();
            Walking wal = new Walking();
            Fighting fight = new Fighting();

            int x = 12;
            bool IsTrue = true;
            string[,] w = new string[x, x];

            w = dun1.Peredacha();
            wal.Vvod = w;
            wal.Pohod();

            w = dun2.Peredacha();
            wal.Vvod = w;
            wal.Proverka = IsTrue;
            wal.Pohod();

            fight.Fight();
            //Console.WriteLine("Hello, Server!");
        }
    }
}
//Проект закончен. Кринж полный, но для певрого раза думаю неплохо
