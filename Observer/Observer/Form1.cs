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

namespace Observer
{
    public partial class Form1 : Form,Index
    {
        List<Code.Observer> my_but;
        My_button up;
        My_button down;
        My_button left;
        My_button right;
        public Form1()
        {
            InitializeComponent();

            up = new My_button(button2);
            down = new My_button(button4);
            left = new My_button(button1);
            right = new My_button(button3);

            my_but = new List<Code.Observer>();

            my_but.Add(new ConcreteObserver(up, "1"));
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public event EventHandler<EventArgs> Up;
        public event EventHandler<EventArgs> Down;
        public event EventHandler<EventArgs> Left;
        public event EventHandler<EventArgs> Right;

        public event EventHandler<EventArgs> ClickButton;

       
    }
}
