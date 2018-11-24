using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    delegate void Message(string str);
    interface AllMessage
    {
        Message Write { get; set; }
    }

}
