using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    abstract class Unit
    {
        public abstract void Show(int y, int x);
        protected int speed;
        protected int damage;
        protected string[] image;
    }
    class Light_infantry : Unit
    {
        public Light_infantry()
        {
            speed = 20;
            damage = 10;
            image = new string[3];
            for(int i=0;i<3;i++ )
            {
            
                if(i==0)
                {
                    image[i] = " o ";
                }
                else if (i == 1)
                {
                    image[i] =  "-|-" ;
                }
                else 
                {
                    image[i] = "| |" ;
                }
            }

        }
        public override void Show(int y, int x)
        {
         
            for (int i=0;i<3;i++)
            {
                Console.CursorLeft = x;
                Console.CursorTop = y+i;
                Console.WriteLine(image[i]);
            }
        }

    }
    class Vehicles : Unit
    {
        public Vehicles()
        {
            speed = 70;
            damage = 0;
            image = new string[3];
            for (int i = 0; i < 3; i++)
            {

                if (i == 0)
                {
                    image[i] = "   " ;
                }
                else if (i == 1)
                {
                    image[i] = "| |" ;
                }
                else
                {
                    image[i] = "o-o" ;
                }
            }
        }
        public override void Show(int y, int x)
        {
            for (int i = 0; i < 3; i++)
            {
                Console.CursorLeft = x;
                Console.CursorTop = y + i;
                Console.WriteLine(image[i]);
            }
        }

    }
    class Heavy_ground_combat_vehicles : Unit
    {
        public Heavy_ground_combat_vehicles()
        {
            speed = 15;
            damage = 150;
            image = new string[3];
            for (int i = 0; i < 3; i++)
            {

                if (i == 0)
                {
                    image[i] =  "A  " ;
                }
                else if (i == 1)
                {
                    image[i] = "===" ;
                }
                else
                {
                    image[i] = "ooo" ;
                }
            }
        }
        public override void Show(int y, int x)
        {
            for (int i = 0; i < 3; i++)
            {
                Console.CursorLeft = x;
                Console.CursorTop = y + i;
                Console.WriteLine(image[i]);
            }
        }

    }
    
    class Light_ground_combat_vehicles : Unit
    {
        public Light_ground_combat_vehicles()
        {
            speed = 50;
            damage = 30;
            image = new string[3];
            for (int i = 0; i < 3; i++)
            {

                if (i == 0)
                {
                    image[i] = "A  ";
                }
                else if (i == 1)
                {
                    image[i] = "---" ;
                }
                else
                {
                    image[i] = "ooo" ;
                }
            }
        }
        public override void Show(int y, int x)
        {
            for (int i = 0; i < 3; i++)
            {
                Console.CursorLeft = x;
                Console.CursorTop = y + i;
                Console.WriteLine(image[i]);
            }
        }

    }
    
    class Aircraft : Unit
    {
        public Aircraft()
        {
            speed = 300;
            damage = 100;
            image = new string[3];
            for (int i = 0; i < 3; i++)
            {

                if (i == 0)
                {
                    image[i] = " | " ;
                }
                else if (i == 1)
                {
                    image[i] = "-|-" ;
                }
                else
                {
                    image[i] = "| |";
                }
            }
        }
        public override void Show(int y, int x)
        {
            for (int i = 0; i < 3; i++)
            {
                Console.CursorLeft = x;
                Console.CursorTop = y + i;
                Console.WriteLine(image[i]);
            }
        }

    }


    class Military_base
    {
        Dictionary<string, Unit> unit = new Dictionary<string, Unit>();
        public Military_base()
        {
            unit.Add("1",new  Light_infantry());
            unit.Add("2", new Vehicles());
            unit.Add("3", new Heavy_ground_combat_vehicles());
            unit.Add("4", new Aircraft());
        }

        public Unit GetUnit(string key)
        {
            if (unit.ContainsKey(key))
                return unit[key];
            else
                return null;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Military_base USA = new Military_base();
            int[][] units= { new int[] { 0,0}, new int[] { 0, 4 }, new int[] { 0, 8 }, new int[] { 4, 0 }, new int[] { 4, 4 }, new int[] { 4, 8 }, new int[] { 8, 0 } };
            string[] units_n = { "1", "1", "2", "3","4", "4","2" };
            for (int i = 0; i < units.Length; i++)
            {
                Unit elem = USA.GetUnit(units_n[i]);
                if (elem != null)
                    elem.Show(units[i][0], units[i][1]);
            }
        }
    }
}
