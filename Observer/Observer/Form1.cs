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
        public Form1()
        {
            InitializeComponent();
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
