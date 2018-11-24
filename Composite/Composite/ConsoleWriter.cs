using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    class ConsoleWriter : AllMessage
    {
        public ConsoleWriter()
        {
            consoleWrite = MyConsol;
        }

        Message consoleWrite;
        public Message Write
        {
            set
            {
                consoleWrite = value;
            }
            get
            {
                return consoleWrite;
            }
        }
        void MyConsol(string str)
        {
            Console.WriteLine(str);
        }
    }
}
