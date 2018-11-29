using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ecorator
{
    delegate void Message(string str);
    delegate void Clean();
    interface AllMessage
    {
        Message Write { get; set; }
        Message Write_n { get; set; }
        Clean clean { get; set; }

    }

}
