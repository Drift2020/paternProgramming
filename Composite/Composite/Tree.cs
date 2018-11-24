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

        // Constructor
        public Root(string name)
        {
            this.name = name;
        }

        public abstract void Add(Root c);
        public abstract void Remove(Root c);
        public abstract void Display(int depth);
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

        public override void Add(Root Root)
        {
            Roots.Add(Root);
        }

        public override void Remove(Root Root)
        {
            Roots.Remove(Root);
        }

        public override void Display(int depth)
        {
            Console.WriteLine(new String('-', depth) + name);

            // Recursively display child nodes
            foreach (Root Root in Roots)
            {
                Root.Display(depth + 2);
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

        public override void Add(Root c)
        {
            Console.WriteLine("Cannot add to file");
        }

        public override void Remove(Root c)
        {
            Console.WriteLine("Cannot remove from file");
        }

        public override void Display(int depth)
        {
            Console.WriteLine(new String('-', depth) + name);
        }
    }
}
