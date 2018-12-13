using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommanderConsole.Commander
{
    class Game
    {
        string[] field_game;
        public Game()
        {
            field_game = new string[]{ " | | ","- - -", " | | ", "- - -", " | | " };
        }
        public void Step(int x,int y,char symbl)
        {

        }
    }
}
