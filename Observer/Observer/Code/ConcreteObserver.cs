using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.Code
{
    class ConcreteObserver : Observer
    {
        private My_button subject;
        private string name;

        // Constructor
        public ConcreteObserver(My_button subject, string name)
        {
            this.subject = subject;
            this.name = name;
        }

        public override void Update()
        {
            
        }

        public My_button Subject
        {
            get { return subject; }
            set { subject = value; }
        }
    }
}
