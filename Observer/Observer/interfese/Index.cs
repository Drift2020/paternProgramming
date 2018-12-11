using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.interfese
{
    interface Index
    {
        event EventHandler<EventArgs> Up;
        event EventHandler<EventArgs> Down;
        event EventHandler<EventArgs> Left;
        event EventHandler<EventArgs> Right;

        event EventHandler<EventArgs> ClickButton;


    }
}
