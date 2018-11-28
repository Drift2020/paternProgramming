using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{

    abstract class Root
    {
        protected string poz_abc = "abcdefghijklmnopqrstuvwxyz";
        protected char poz_i = 'i';

        protected string name;
        protected int price;
        protected AllMessage my_write;
        // Constructor
        public Root(string name,int price, AllMessage elem)
        {
            this.price = price;
            this.name = name;
            my_write = elem;
        }

        public abstract void Add(Root c, string[] elem);
        public abstract void Remove(string[] map_in_my_tree);
        public abstract void Display(string depth);
        protected string My_simvol_i(int elem)
        {
            string temp = "";
            for (int i = 0; i < elem; i++)
            {
                temp += "i";
            }
            return temp;
        }
        public abstract int Price();
    }

    /*
     * Composite
     *  - определяет поведение компонентов, у которых есть потомки;
        - хранит компоненты-потомки;
        - реализует относящиеся к управлению потомками операции в интерфейсе класса Root;
    */

    class Room : Root
    {
        private List<Root> Roots = new List<Root>();

        // Constructor
        public Room(string name,int price, AllMessage elem)
            : base(name, price, elem)
        {

        }

        public override void Add(Root Root, string[] elem)
        {
            if (elem.Length == 1)
                Roots.Add(Root);
       
            else
            {
                string[] temp = new string[elem.Length - 1];
                Array.Copy(elem, 1, temp,0, elem.Length - 1);
                
                Roots[Convert.ToInt32(elem[1]) - 1].Add(Root, temp);
            }
        }

        public override void Remove(string[] map_in_my_tree)
        {
            if(map_in_my_tree.Length==1)
            {
                Roots.RemoveAt(Convert.ToInt32(map_in_my_tree[0])-1);
            }
            else
            {
                string[] temp = new string[map_in_my_tree.Length - 1];
                Array.Copy(map_in_my_tree, 1, temp, 0, map_in_my_tree.Length - 1);

                Roots[Convert.ToInt32(map_in_my_tree[0]) - 1].Remove(temp);
            }
        }

        public override void Display(string depth)
        {
            string number = "";
            string next = "";

            string []temp_n = depth.Split(' ');
            depth = temp_n[1];

            try
            {
                if (Convert.ToInt32(depth)>-1)
                {

                    number = (Convert.ToInt32(depth) + 1).ToString();
                    next = "a";
                }
            }
            catch
            {
                try
                {
                    if (this.poz_abc.IndexOf(depth[0]) != -1)
                    {

                        number = poz_abc[poz_abc.IndexOf(depth)].ToString();
                        next = "i";
                    }
                }
                catch
                {


                    if (depth.IndexOf(poz_i) != -1)
                    {

                        number = depth.ToString();
                        next = "0";
                    }



                }
            }

            my_write.Write(temp_n[0]+" "+number + ". " + name+ " "+this.price.ToString());

            // Recursively display child nodes
            for (int i = 0; i < Roots.Count; i++)
            {
                if (next == "a")
                    Roots[i].Display(temp_n[0]+"\t "+poz_abc[poz_abc.IndexOf(depth) + 1 + i].ToString());
                else if (next == "i")
                    Roots[i].Display(temp_n[0] + "\t " + My_simvol_i(i+1));
                    else if (next == "0")
                    {
                    Roots[i].Display(temp_n[0] + "\t " + i.ToString());
                    }
                }
            
        }
        public override int Price()
        {
            int temp = this.price;
            foreach (var i in Roots)
                temp += i.Price();
            return temp;
        }
    }


    class Statistic : Root
    {
        public Statistic(string name, int price, AllMessage elem)
          : base(name, price, elem)
        {

        }
        public override void Add(Root c, string[] elem)
        {
            my_write.Write("Can't add in this element.");
        }
        public override void Remove(string[] map_in_my_tree)
        {
            my_write.Write("Can't remove in this element.");
        }
        public override void Display(string depth)
        {
            string number = "";
            string next = "";

            string[] temp_n = depth.Split(' ');
            depth = temp_n[1];

            try
            {
                if (Convert.ToInt32(depth) > -1)
                {

                    number = (Convert.ToInt32(depth) + 1).ToString();
                    next = "a";
                }
            }
            catch
            {
                try
                {
                    if (this.poz_abc.IndexOf(depth[0]) != -1)
                    {

                        number = poz_abc[poz_abc.IndexOf(depth)].ToString();
                        next = "i";
                    }
                }
                catch
                {


                    if (depth.IndexOf(poz_i) != -1)
                    {

                        number = depth.ToString();
                        next = "0";
                    }



                }
            }

            my_write.Write(temp_n[0] + " " + number + ". " + name + " " + this.price.ToString());
        }
        public override int Price()
        {
            int temp = this.price;
          
            return temp;
        }
    }

    class Table: Root
    {

        private List<Root> Roots = new List<Root>();

        // Constructor
        public Table(string name, int price, AllMessage elem)
            : base(name, price, elem)
        {

        }

        public override void Add(Root Root, string[] elem)
        {
            if (elem.Length == 1)
                Roots.Add(Root);

            else
            {
                string[] temp = new string[elem.Length - 1];
                Array.Copy(elem, 1, temp, 0, elem.Length - 1);

                Roots[Convert.ToInt32(elem[1]) - 1].Add(Root, temp);
            }
        }

        public override void Remove(string[] map_in_my_tree)
        {
            if (map_in_my_tree.Length == 1)
            {
                Roots.RemoveAt(Convert.ToInt32(map_in_my_tree[0]) - 1);
            }
            else
            {
                string[] temp = new string[map_in_my_tree.Length - 1];
                Array.Copy(map_in_my_tree, 1, temp, 0, map_in_my_tree.Length - 1);

                Roots[Convert.ToInt32(map_in_my_tree[0]) - 1].Remove(temp);
            }
        }

        public override void Display(string depth)
        {
            string number = "";
            string next = "";

            string[] temp_n = depth.Split(' ');
            depth = temp_n[1];

            try
            {
                if (Convert.ToInt32(depth) > -1)
                {

                    number = (Convert.ToInt32(depth) + 1).ToString();
                    next = "a";
                }
            }
            catch
            {
                try
                {
                    if (this.poz_abc.IndexOf(depth[0]) != -1)
                    {

                        number = poz_abc[poz_abc.IndexOf(depth)].ToString();
                        next = "i";
                    }
                }
                catch
                {


                    if (depth.IndexOf(poz_i) != -1)
                    {

                        number = depth.ToString();
                        next = "0";
                    }



                }
            }

            my_write.Write(temp_n[0] + " " + number + ". " + name + " " + this.price.ToString());

            // Recursively display child nodes
            for (int i = 0; i < Roots.Count; i++)
            {
                if (next == "a")
                    Roots[i].Display(temp_n[0] + "\t " + poz_abc[poz_abc.IndexOf(depth) + 1 + i].ToString());
                else if (next == "i")
                    Roots[i].Display(temp_n[0] + "\t " + My_simvol_i(i + 1));
                else if (next == "0")
                {
                    Roots[i].Display(temp_n[0] + "\t " + i.ToString());
                }
            }

        }
        public override int Price()
        {
            int temp = this.price;
            foreach (var i in Roots)
                temp += i.Price();
            return temp;
        }
    }

    class PC : Root
    {

        private List<Root> Roots = new List<Root>();

        // Constructor
        public PC(string name, int price, AllMessage elem)
            : base(name, price, elem)
        {

        }

        public override void Add(Root Root, string[] elem)
        {
            if (elem.Length == 1)
                Roots.Add(Root);

            else
            {
                string[] temp = new string[elem.Length - 1];
                Array.Copy(elem, 1, temp, 0, elem.Length - 1);

                Roots[Convert.ToInt32(elem[1]) - 1].Add(Root, temp);
            }
        }

        public override void Remove(string[] map_in_my_tree)
        {
            if (map_in_my_tree.Length == 1)
            {
                Roots.RemoveAt(Convert.ToInt32(map_in_my_tree[0]) - 1);
            }
            else
            {
                string[] temp = new string[map_in_my_tree.Length - 1];
                Array.Copy(map_in_my_tree, 1, temp, 0, map_in_my_tree.Length - 1);

                Roots[Convert.ToInt32(map_in_my_tree[0]) - 1].Remove(temp);
            }
        }

        public override void Display(string depth)
        {
            string number = "";
            string next = "";

            string[] temp_n = depth.Split(' ');
            depth = temp_n[1];

            try
            {
                if (Convert.ToInt32(depth) > -1)
                {

                    number = (Convert.ToInt32(depth) + 1).ToString();
                    next = "a";
                }
            }
            catch
            {
                try
                {
                    if (this.poz_abc.IndexOf(depth[0]) != -1)
                    {

                        number = poz_abc[poz_abc.IndexOf(depth)].ToString();
                        next = "i";
                    }
                }
                catch
                {


                    if (depth.IndexOf(poz_i) != -1)
                    {

                        number = depth.ToString();
                        next = "0";
                    }



                }
            }

            my_write.Write(temp_n[0] + " " + number + ". " + name + " " + this.price.ToString());

            // Recursively display child nodes
            for (int i = 0; i < Roots.Count; i++)
            {
                if (next == "a")
                    Roots[i].Display(temp_n[0] + "\t " + poz_abc[poz_abc.IndexOf(depth) + 1 + i].ToString());
                else if (next == "i")
                    Roots[i].Display(temp_n[0] + "\t " + My_simvol_i(i + 1));
                else if (next == "0")
                {
                    Roots[i].Display(temp_n[0] + "\t " + i.ToString());
                }
            }

        }
        public override int Price()
        {
            int temp = this.price;
            foreach (var i in Roots)
                temp += i.Price();
            return temp;
        }
    }
    class Board: Root
    {

        private List<Root> Roots = new List<Root>();

        // Constructor
        public Board(string name, int price, AllMessage elem)
            : base(name, price, elem)
        {

        }

        public override void Add(Root Root, string[] elem)
        {
            if (elem.Length == 1)
                Roots.Add(Root);

            else
            {
                string[] temp = new string[elem.Length - 1];
                Array.Copy(elem, 1, temp, 0, elem.Length - 1);

                Roots[Convert.ToInt32(elem[1]) - 1].Add(Root, temp);
            }
        }

        public override void Remove(string[] map_in_my_tree)
        {
            if (map_in_my_tree.Length == 1)
            {
                Roots.RemoveAt(Convert.ToInt32(map_in_my_tree[0]) - 1);
            }
            else
            {
                string[] temp = new string[map_in_my_tree.Length - 1];
                Array.Copy(map_in_my_tree, 1, temp, 0, map_in_my_tree.Length - 1);

                Roots[Convert.ToInt32(map_in_my_tree[0]) - 1].Remove(temp);
            }
        }

        public override void Display(string depth)
        {
            string number = "";
            string next = "";

            string[] temp_n = depth.Split(' ');
            depth = temp_n[1];

            try
            {
                if (Convert.ToInt32(depth) > -1)
                {

                    number = (Convert.ToInt32(depth) + 1).ToString();
                    next = "a";
                }
            }
            catch
            {
                try
                {
                    if (this.poz_abc.IndexOf(depth[0]) != -1)
                    {

                        number = poz_abc[poz_abc.IndexOf(depth)].ToString();
                        next = "i";
                    }
                }
                catch
                {


                    if (depth.IndexOf(poz_i) != -1)
                    {

                        number = depth.ToString();
                        next = "0";
                    }



                }
            }

            my_write.Write(temp_n[0] + " " + number + ". " + name + " " + this.price.ToString());

            // Recursively display child nodes
            for (int i = 0; i < Roots.Count; i++)
            {
                if (next == "a")
                    Roots[i].Display(temp_n[0] + "\t " + poz_abc[poz_abc.IndexOf(depth) + 1 + i].ToString());
                else if (next == "i")
                    Roots[i].Display(temp_n[0] + "\t " + My_simvol_i(i + 1));
                else if (next == "0")
                {
                    Roots[i].Display(temp_n[0] + "\t " + i.ToString());
                }
            }

        }
        public override int Price()
        {
            int temp = this.price;
            foreach (var i in Roots)
                temp += i.Price();
            return temp;
        }
    }
}

