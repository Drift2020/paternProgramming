using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento.Memento
{
    class Memento
    {
        private string name;
       

        public Memento(string name)
        {
            this.name = name;
           
        }

        // Gets or sets name
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

    
    }
}
