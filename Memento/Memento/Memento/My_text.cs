using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    class My_text
    {
        string text;

        public string Text
        {
            set
            {
                text = value;
              
            }
            get
            {
                return text;
            }
        }

        public Mementos SaveMemento()
        {
          
            return new Mementos(text);
        }

        // Restores memento
        public void RestoreMemento(Mementos memento)
        {
          
            this.text = memento.Text;
           
        }
    }
}
