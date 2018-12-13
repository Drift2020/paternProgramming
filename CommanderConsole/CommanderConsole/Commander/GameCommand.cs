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

        public GameCommand(int x,int y,char symbl)
        {

            this.x = x;
            this.y = y;
            this.symbl = symbl;

        }

        public void Execute()
        {

        }
        public void UnExecute()
        {

        }
    }
}
