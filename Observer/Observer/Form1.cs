using Observer.Code;
using Observer.interfese;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Observer.Code;
namespace Observer
{
    public partial class Form1 : Form,Index
    {
        Code.Observer my_but;
        Code.Observer my_but1;
        Code.Observer my_but2;
        My_button up;
        My_button down;
        My_button left;
        My_button right;
        List<My_button> Lits_button;
        public Form1()
        {

            InitializeComponent();
            Lits_button = new List<My_button>();
            
            up = new My_button(0,-1);
            down = new My_button(0,1);
            left = new My_button(-1,0);
            right = new My_button(1,0);

            Lits_button.Add(up);
            Lits_button.Add(down);
            Lits_button.Add(left);
            Lits_button.Add(right);

            my_but = new ConcreteObserver(button6, Lits_button);
            my_but1 = new ConcreteObserver(button5, Lits_button);
            my_but2 = new ConcreteObserver(button7, Lits_button);

            up.Attach(my_but);
            down.Attach(my_but);
            left.Attach(my_but);
            right.Attach(my_but);
            my_but.Activ_text();

            up.Attach(my_but1);
            down.Attach(my_but1);
            left.Attach(my_but1);
            right.Attach(my_but1);
            my_but1.Activ_text();

            up.Attach(my_but2);
            down.Attach(my_but2);
            left.Attach(my_but2);
            right.Attach(my_but2);
            my_but2.Activ_text();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }



        public event EventHandler<EventArgs> Up;
        public event EventHandler<EventArgs> Down;
        public event EventHandler<EventArgs> Left;
        public event EventHandler<EventArgs> Right;

        public event EventHandler<EventArgs> ClickButton;

        private void button2_Click(object sender, EventArgs e)
        {
            up.Notify();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            left.Notify();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            right.Notify();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            down.Notify();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if(Lits_button[0].Serche(my_but))
            {
                Lits_button.ForEach(elem => { elem.Detach(my_but); });

            }
            else
            {
                Lits_button.ForEach(elem => { elem.Attach(my_but); });
            }
            my_but.Activ_text();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (Lits_button[0].Serche(my_but1))
            {
                Lits_button.ForEach(elem => {  elem.Detach(my_but1); });
            }
            else
            {
                Lits_button.ForEach(elem => { elem.Attach(my_but1); });
            }
            my_but1.Activ_text();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (Lits_button[0].Serche(my_but2))
            {
                Lits_button.ForEach(elem => { elem.Detach(my_but2); });
            }
            else
            {
                Lits_button.ForEach(elem => { elem.Attach(my_but2); });
            }
            my_but2.Activ_text();
        }
    }
}
