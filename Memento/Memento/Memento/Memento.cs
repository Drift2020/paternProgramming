using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    class Mementos
    {
        private string text;
       

        public Mementos(string text)
        {
            this.text = text;
           
        }

        // Gets or sets name
        public string Text
        {
            get { return text; }
            set { text = value; }
        }

    
    }
}
