using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommanderConsole
{
    class ConsoleRead : Allread
    {
        public ConsoleRead()
        {
            consoleRead = MyConsol;
        }

        Read_ consoleRead;
        public Read_ Read
        {
            set
            {
                consoleRead = value;
            }
            get
            {
                return consoleRead;
            }
        }
        string MyConsol()
        {
            return Console.ReadLine();

        }
    }
}
