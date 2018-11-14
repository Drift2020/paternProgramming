using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Figure_;
namespace T_Figure_
{
    public class T_Figure : Figure
    {
        public T_Figure()
        {
            setName();
            setColor();
            setSize();
        }

        override public void setName()
        {
            this.name = "Figure 1";
        }
        override public void setColor()
        {
            Random rnd = new Random();
            this.color = (ConsoleColor)14;
        }
        override public void setSize()
        {
            this.size = new int[4][];
            this.size[0] = new int[] { 0, 1, 0, 0 };
            this.size[1] = new int[] { 1, 1, 1, 0 };
            this.size[2] = new int[] { 0, 0, 0, 0 };
            this.size[3] = new int[] { 0, 0, 0, 0 };
        }

        override public string getName()
        {
            return this.name;
        }
        override public ConsoleColor getColor()
        {
            return this.color;
        }
        override public int[][] getSize()
        {
            return this.size;
        }
    }
}
