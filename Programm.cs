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

            int x = 12;
            string[,] w = new string[x, x];
            w = dun1.Peredacha();
            wal.Vvod = w;
            wal.Pohod();

            //Console.WriteLine("Hello, Server!");
        }
    }
}
