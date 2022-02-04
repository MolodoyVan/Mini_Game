using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Мини_игра
{
    class Dungeon1
    {
        string[,] walls;
        int x = 12;

        public Dungeon1()
        {
            walls = new string[x, x];
        }
        

        private void Steni()
        {
            for(int i = 0; i < x; i++)
            {
                if (i < 7)
                {
                    walls[i, 0] = "|";
                    if (i == 3 || i == 4 || i == 5) continue;
                    else walls[i, 4] = "|";
                }
                else if(i >= 7)
                {
                    if (i == 3 || i == 4 || i == 5) continue;
                    else  walls[i, 4] = "|";

                    walls[i, 11] = "|";
                    for(int k = 3; k < 12; k++)
                        walls[k, 11] = "|";
                }
            }
            for(int j = 0; j < x; j++)
            {
                if (j < 5)
                {
                    walls[0, j] = "-";
                    walls[6, j] = "-";
                } else
                {
                    walls[2, j] = "-";
                    walls[11, j] = "-";
                }
            }

            for (int i = 1; i < 6; i++)
                for (int j = 1; j < 4; j++)
                    walls[i, j] = " ";
            walls[3, 4] = " ";
            walls[4, 4] = " ";
            walls[5, 4] = " "; //Так надо
            for (int i = 3; i < x-1; i++)
                for (int j = 5; j < x-1; j++)
                    walls[i, j] = " ";

            for (int i = 0; i < x; i++)
                for (int j = 0; j < x; j++)
                    if (walls[i, j] == null) walls[i, j] = ":";
            walls[0, 0] = "|";
            walls[0, 4] = "|";
            walls[6, 0] = "|";  //ДА, и так тоже
            walls[6, 4] = "|";
            walls[2, 11] = "|";
            walls[11, 11] = "|";
            walls[11, 8] = "=";
        }

        public string[,] Peredacha()
        {
            Steni();
            walls[1, 1] = "+";
            return walls;
        } 
    }
}
