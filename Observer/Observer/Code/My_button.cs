using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Observer.Code
{
    class My_button : Subject
    {
        Button obj;
    
        public My_button(Button obj)
        {
            this.obj = obj;
        }
        // Gets or sets subject state
        public int X
        {
            get { return obj.Location.X; }
            set { obj.Location = new System.Drawing.Point(value,obj.Location.Y); }
        }
        public int Y
        {
            get { return obj.Location.Y; }
            set { obj.Location=new System.Drawing.Point(obj.Location.X, value); }
        }
        public string Text
        {
            get { return obj.Text; }
            set { obj.Text = value; }
        }
    }
}
