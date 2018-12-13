using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommanderConsole.Commander
{
    interface ICommandGame
    {
        void Execute();
        void UnExecute();
    }
}
