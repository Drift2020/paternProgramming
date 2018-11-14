using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figure_
{
   public abstract class Figure
    {
        protected int[][] size;
        protected ConsoleColor color;
        protected string name;

        abstract public void setName();
        abstract public void setColor();
        abstract public void setSize();

        abstract public string getName();
        abstract public ConsoleColor getColor();
        abstract public int[][] getSize();
    }
}
