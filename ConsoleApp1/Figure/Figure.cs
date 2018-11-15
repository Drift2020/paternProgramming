using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
  
    public abstract class Game
    {

        public abstract Figure Create();
    }
    public class T_Game : Game
    {
        public override Figure Create()
        {
            Figure temp = new T_Figure();
            return temp;
        }
    }
    public class T1_Game : Game
    {
        public override Figure Create()
        {
            Figure temp = new T1_Figure();
            return temp;
        }
    }

    public class T2_Game : Game
    {
        public override Figure Create()
        {
            Figure temp = new T2_Figure();
            return temp;
        }
    }
    public class T3_Game : Game
    {
        public override Figure Create()
        {
            Figure temp = new T3_Figure();
            return temp;
        }
    }
    public class T4_Game : Game
    {
        public override Figure Create()
        {
            Figure temp = new T4_Figure();
            return temp;
        }
    }
    public class T5_Game : Game
    {
        public override Figure Create()
        {
            Figure temp = new T5_Figure();
            return temp;
        }
    }

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
    public class T1_Figure : Figure
    {
        public T1_Figure()
        {
            setName();
            setColor();
            setSize();
        }



        override public void setName()
        {
            this.name = "Figure 2";
        }
        override public void setColor()
        {
            Random rnd = new Random();
            this.color = (ConsoleColor)13;
        }
        override public void setSize()
        {
            this.size = new int[4][];
            this.size[0] = new int[] { 1, 1, 0, 0 };
            this.size[1] = new int[] { 0, 1, 1, 0 };
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

    public class T2_Figure : Figure
    {
        public T2_Figure()
        {
            setName();
            setColor();
            setSize();
        }



        override public void setName()
        {
            this.name = "Figure 3";
        }
        override public void setColor()
        {
            Random rnd = new Random();
            this.color = (ConsoleColor)9;
        }
        override public void setSize()
        {
            this.size = new int[4][];
            this.size[0] = new int[] { 1, 0, 0, 0 };
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
    public class T3_Figure : Figure
    {
        public T3_Figure()
        {
            setName();
            setColor();
            setSize();
        }



        override public void setName()
        {
            this.name = "Figure 4";
        }
        override public void setColor()
        {
            Random rnd = new Random();
            this.color = ConsoleColor.DarkBlue;
        }
        override public void setSize()
        {
            this.size = new int[4][];
            this.size[0] = new int[] { 0, 1, 0, 0 };
            this.size[1] = new int[] { 0, 1, 0, 0 };
            this.size[2] = new int[] { 0, 1, 0, 0 };
            this.size[3] = new int[] { 0, 1, 0, 0 };
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
    public class T4_Figure : Figure
    {
        public T4_Figure()
        {
            setName();
            setColor();
            setSize();
        }



        override public void setName()
        {
            this.name = "Figure 5";
        }
        override public void setColor()
        {
            Random rnd = new Random();
            this.color = ConsoleColor.Green;
        }
        override public void setSize()
        {
            this.size = new int[4][];
            this.size[0] = new int[] { 0, 1, 1, 0 };
            this.size[1] = new int[] { 1, 1, 0, 0 };
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
    public class T5_Figure : Figure
    {
        public T5_Figure()
        {
            setName();
            setColor();
            setSize();
        }



        override public void setName()
        {
            this.name = "Figure 6";
        }
        override public void setColor()
        {
            Random rnd = new Random();
            this.color = (ConsoleColor.DarkYellow);
        }
        override public void setSize()
        {
            this.size = new int[4][];
            this.size[0] = new int[] { 1, 1, 1, 0 };
            this.size[1] = new int[] { 1, 0, 0, 0 };
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
