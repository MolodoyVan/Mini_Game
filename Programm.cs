using System;

namespace Мини_игра
{
    class Program
    {
        static void Main(string[] args)
        {
            Dungeon1 dun = new Dungeon1();
            Walking wal = new Walking();

            int x = 12;
            string[,] w = new string[x, x];
            w = dun.Peredacha();
            wal.Vvod = w;
            wal.Pohod();

            //Console.WriteLine("Hello, Server!");
        }
    }
}
