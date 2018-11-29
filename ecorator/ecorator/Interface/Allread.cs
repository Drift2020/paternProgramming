using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ecorator.Interface
{
    delegate string Read_();
    interface Allread
    {
        Read_ Read { get; set; }
    }
}
