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

        public Memento SaveMemento()
        {
            Console.WriteLine("\nСохранение состояния ...\n");
            return new Memento(name, surname, phone, average);
        }

        // Restores memento
        public void RestoreMemento(Memento memento)
        {
            Console.WriteLine("\nВосстановление состояния...\n");
            this.Name = memento.Name;
            this.Surname = memento.Surname;
            this.Phone = memento.Phone;
            this.Average = memento.Average;
        }
    }
}
