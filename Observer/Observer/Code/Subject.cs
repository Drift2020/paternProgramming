using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.Code
{
    abstract class Subject
    {
        private List<Observer> observers = new List<Observer>();
        private bool isActiv;
        public bool IsActiv
        {
            get { return isActiv; }
            private set { isActiv = value; }
        }


        public void Attach(Observer observer)
        {

            observers.Add(observer);
        }
        public bool Serche(Observer observer)
        {
            if (observers.IndexOf(observer) != -1)
                return true;
            else
                return false;
        }
        public void Detach(Observer observer)
        {
            observers.Remove(observer);
            
        }

        public void Notify()
        {
            isActiv = true;
            foreach (Observer o in observers)
            {
                o.Update();
            }
            isActiv = false;
        }
    }
}
