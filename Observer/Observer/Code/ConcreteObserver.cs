using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Observer.Code
{
    class ConcreteObserver : Observer
    {
        private List<My_button> subject;
        private Button my_b;
     
        bool isActiv=false;

        // Constructor
        public ConcreteObserver(Button my_b, List<My_button> subject)
        {
            this.subject = subject;
         
            this.my_b = my_b;
            Activ_text();
        }

        public override void Update()
        {
            subject.ForEach(elem => {
                if(elem.IsActiv)
                my_b.Location = new System.Drawing.Point(my_b.Location.X + elem.X,
                    my_b.Location.Y + elem.Y);

            });
            
        }

        public override void Activ_text()
        {
            if(isActiv)
            {
                my_b.Text  = "Active";
                isActiv = !isActiv;
               
            }
            else
            {
                my_b.Text = "Disabled";
                isActiv = !isActiv;
            }
        }

        public List<My_button> Subject
        {
            get { return subject; }
            set { subject = value; }
        }
    }
}
