using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    class Caretaker
    {
        private List<Mementos> savedStates = new List<Mementos>();

        public Mementos this[int index]
        {
            get
            {
                if (index < 0 || index >= savedStates.Count)
                    return savedStates[0];
                else
                    return savedStates[index];
            }
        }

        void Control_Zone()
        {
            if(savedStates.Count>=256)
            {
                savedStates.RemoveAt(0);
            }

        }

      public  void RemoveRange(int index)
        {
            savedStates.RemoveRange(index, savedStates.Count - index);
        }

        public int Count { get { return savedStates.Count; } private set { } }

        public void Add(Mementos m)
        {
            Control_Zone();
            savedStates.Add(m);
        }
    }
}
