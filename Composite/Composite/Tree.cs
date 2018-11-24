using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    abstract class Root
    {
        protected string name;
        protected AllMessage my_write;
        // Constructor
        public Root(string name)
        {
            this.name = name;
        }

        public abstract void Add(Root c,string[] elem);
        public abstract void Remove(Root c);
        public abstract void Display(int[] depth);
        
    }

    /*
     * Composite
     *  - определяет поведение компонентов, у которых есть потомки;
        - хранит компоненты-потомки;
        - реализует относящиеся к управлению потомками операции в интерфейсе класса Root;
    */

    class Trunk : Root
    {
        private List<Root> Roots = new List<Root>();

        // Constructor
        public Trunk(string name)
            : base(name)
        {
        }

        public override void Add(Root Root, string[] elem)
        {
            if (elem[0] == "N")
                Roots.Add(Root);
            if (elem[0]=="A")
                Roots[Convert.ToInt32(elem[1])].Add(Root, new string[] { "N", elem[1] });
            else if(elem[0] == "I")
            {
                Roots[Convert.ToInt32(elem[1])].Add(Root, new string[] { "A", elem[1] });
            }
        }

        public override void Remove(Root Root)
        {
            Roots.Remove(Root);
        }

        public override void Display(int[] depth)
        {
            string number="";
            if (depth[0] == 1)
            {
             
                number = (Convert.ToInt32(depth[1]) + 1).ToString();
            }
               
            my_write.Write(number +". "+ name);

            // Recursively display child nodes
            foreach (Root Root in Roots)
            {
                Root.Display(new int[] { depth[0]+1,});
            }
        }
    }
    /*
     * Leaf
        - представляет листовые узлы композиции и не имеет потомков;
        - определяет поведение примитивных объектов в композиции;

     */
    class Branch : Root
    {
        // Constructor
        public Branch(string name)
            : base(name)
        {

        }

        public override void Add(Root c, string[] elem)
        {
            Console.WriteLine("Cannot add to file");
        }

        public override void Remove(Root c)
        {
            Console.WriteLine("Cannot remove from file");
        }

        public override void Display(int[] depth)
        {
            string number = "";
            if (depth[0] == 4)
            {

                number = (Convert.ToInt32(depth[1]) + 1).ToString();
            }
            my_write.Write(number + name);
        }
    }
}
