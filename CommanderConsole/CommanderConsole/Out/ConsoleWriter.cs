using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommanderConsole
{
    class ConsoleWriter : AllMessage
    {
        public ConsoleWriter()
        {
            consoleWrite = MyConsol;
            consoleWriteN = MyConsol_n;
            consoleClean = MyConsolClear;
        }

        Message consoleWrite;
        Message consoleWriteN;
        Clean consoleClean;
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
        public Message Write_n
        {
            set
            {
                consoleWriteN = value;
            }
            get
            {
                return consoleWriteN;
            }
        }
        public Clean clean
        {
            set
            {
                consoleClean = value;
            }
            get
            {
                return consoleClean;
            }
        }
        void MyConsol(string str)
        {
            Console.Write(str);
         
        }
        void MyConsol_n(string str)
        {
            Console.WriteLine(str);

        }

        void MyConsolClear()
        {
            Console.Clear();

        }
    }
}
