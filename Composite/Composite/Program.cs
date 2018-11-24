using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{



    class Program
    {
        class Arhitect
        {
            public Arhitect()
            {
                my_tree = new List<Root>();
                map_in_my_tree = new List<string>();
            }
            List<Root> my_tree;
            List<string> map_in_my_tree;

            public void Add(string elem,string pos)
            {
              

                if (elem_tree is Trunk)
                    elem_tree.Add(new Trunk(elem));
                else
                    elem_tree.Add(new Branch(elem));
            }
            public void Select_element()
            {

            }
            public void Remove()
            {

            }
            public void Display()
            {
                my_tree.ForEach(elem => { elem.Display(new int[] { 1, 0 }); });
            }
        }
        static void Main(string[] args)
        {
            Arhitect my_tree=new Arhitect();
            int chose = 0;
            while (true)
            {
                my_tree.Display();
                Console.WriteLine("1.Add\n2.Remove\n3.Edit\n4.Exit\nYour chose:");
                chose = Convert.ToInt32(Console.ReadLine());
                if (chose==1)
                {
                    my_tree.Add()
                }
                else if (chose == 2)
                {

                }
                else if (chose == 3)
                {

                }
                else if (chose == 4)
                {
                    break;
                }
                Console.Clear();
            }
        }
    }


}
