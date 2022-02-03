using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Мини_игра
{
    
    class Score
    {
        int x;
        public int Pered
        {
            get { return x; }
            set { x = value; }
        }

        public void Print_Score()
        {
            Console.SetCursorPosition(0, 13);
            Console.WriteLine($"Количество очков - {x}");
        }

        public void Key()
        {
            Console.SetCursorPosition(0, 13);
            Console.WriteLine($"Ключ собран, дверь в следующее подземелье открыта!");
        }
    }
}
