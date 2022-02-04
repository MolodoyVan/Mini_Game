using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Мини_игра
{
    class Dungeon2
    {
        string[,] walls;
        int x = 12;

        public Dungeon2()
        {
            walls = new string[x, x];
        }

        private void Steni()
        {
            for(int i = 0; i < x; i++)
            {
                walls[i, 0] = "|";
                walls[i, 11] = "|";
            }
            for (int i = 1; i < x-1; i++)
            {
                walls[0, i] = "-";
                walls[11, i] = "-";
            }

            for (int i = 0; i < x; i++)
                for (int j = 0; j < x; j++)
                    if (walls[i, j] == null) walls[i, j] = " ";

            walls[5, 5] = "*";
            for(int i = 4; i <= 6; i++)
            {
                walls[i, 4] = "|";
                walls[i, 6] = "|";
            }
            walls[4, 5] = "-";
            walls[6, 5] = "-";
        }

        public string[,] Peredacha()
        {
            Steni();
            walls[1, 1] = "+";
            return walls;
        }
    }
}
