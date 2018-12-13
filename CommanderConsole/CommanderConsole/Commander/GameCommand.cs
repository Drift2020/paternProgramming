using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommanderConsole.Commander
{
    class GameCommand: ICommandGame
    {

        int x;
        int y;
        char symbl;
        
        Game tick_tack_toe;

        public GameCommand(Game x_o, int x,int y,char symbl)
        {

            this.x = x;
            this.y = y;
            this.symbl = symbl;
            tick_tack_toe = x_o;
        }

        public void Execute()
        {
            tick_tack_toe.Step(x,y,symbl);
        }
        public void UnExecute()
        {
            tick_tack_toe.Step(x, y, Undo(symbl));
        }

        private char Undo(char symbl)
        {
            char undo;
            switch (symbl)
            {
                case 'o': undo = ' '; break;
                case 'x': undo = ' '; break;          
                default: undo = ' '; break;
            }
            return undo;
        }
    }
}
