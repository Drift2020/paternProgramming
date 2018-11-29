using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{

    

    class Program
    {
        enum My_type { Statistic=1, PC, Room, Table, Board }
        class Arhitect
        {
            AllMessage my_Write;
            public Arhitect()
            {
                my_Write = new ConsoleWriter();
                my_tree = new List<Root>();
                map_in_my_tree = new List<string>();

                Root root = new Room("Приемная", 10, my_Write);

                root.Add(new Statistic("Должна быть выполнена в теплых тонах", 10, my_Write), new string[] { "1" });

                Root Table_1 = new Table("Журнальный столик", 10, new ConsoleWriter());
                Table_1.Add(new Statistic("10-20 журналов типа «компьютерный мир» ", 10, my_Write), new string[] { "1" });
                root.Add(Table_1, new string[] { "1" });

                root.Add(new Statistic("Мягкий диван ", 10, my_Write), new string[] { "1" });

               Root Table_2 = new Table("Стол секретаря ", 10, my_Write);
               Root PC_1 = new PC("Компьютер", 10, new ConsoleWriter());
                PC_1.Add(new Statistic("Важно наличие большого объема жесткого диска", 10, my_Write), new string[] { "1" });

                Table_2.Add(PC_1, new string[] { "1" });
                Table_2.Add(new Statistic("Офисный инструментарий ", 10, my_Write), new string[] { "1" });

                root.Add(Table_2, new string[] { "1" });
                root.Add(new Statistic("Кулер с теплой и холодной водой", 10, my_Write), new string[] { "1" });
              

                my_tree.Add(root);
            }
            List<Root> my_tree;
            public List<string> map_in_my_tree=new List<string>();


            public void Add(string elem,int my_price, My_type my_type)
            {
                if (map_in_my_tree.Count>0)
                {
                    int number = Convert.ToInt32(map_in_my_tree[0]);
                    switch (my_type)
                    {
                        case My_type.Statistic:
                            {
                             
                                    my_tree[number - 1].Add(new Statistic(elem, my_price, new ConsoleWriter()), map_in_my_tree.ToArray());
                            }
                            break;
                        case My_type.PC:
                            {
                               
                                    my_tree[number - 1].Add(new PC(elem, my_price, new ConsoleWriter()), map_in_my_tree.ToArray());
                             

                            }
                            break;
                     
                        case My_type.Table:
                            {
                              
                                    my_tree[number - 1].Add(new Table(elem, my_price, new ConsoleWriter()), map_in_my_tree.ToArray());
                              
                            }
                            break;
                        case My_type.Board:
                            {
                             
                                    my_tree[number - 1].Add(new Board(elem, my_price, new ConsoleWriter()), map_in_my_tree.ToArray());
                             
                            }
                            break;
                        default:
                            my_Write.Write("This data incorrect.");
                            break;
                    }
                   

                }
               
                else if (my_type == My_type.Room)
                    
                    my_tree.Add(new Room(elem, my_price, new ConsoleWriter()));
            }
         
            public void Remove()
            {
                if(map_in_my_tree.Count==1)
                {
                    int number = Convert.ToInt32(map_in_my_tree[0]);
                    my_tree.RemoveAt(number-1);
                }
                else if(map_in_my_tree.Count > 0)
                {
                    int number = Convert.ToInt32(map_in_my_tree[0]);

                    string[] temp = new string[map_in_my_tree.ToArray().Length - 1];
                    Array.Copy(map_in_my_tree.ToArray(), 1, temp, 0, map_in_my_tree.ToArray().Length - 1);

                    my_tree[number - 1].Remove(temp.ToArray());
                }

                else
                    my_tree.Clear();
            }
            public void Display()
            {
                for (int i = 0; i < my_tree.Count; i++)
                {
                    my_tree[i].Display("\t "+i.ToString());
                }
            }
            public int All_Price()
            {
                int temp = 0;
                foreach (var i in my_tree)
                    temp += i.Price();
                return temp;
            }
        }
        static void Main(string[] args)
        {
            Arhitect my_tree=new Arhitect();
            int chose = 0;
            while (true)
            {
                my_tree.Display();
                Console.WriteLine("Map in you tree");
                my_tree.map_in_my_tree.ForEach(elem => { Console.Write(elem + " "); });
                Console.Write("\n\n");
                Console.Write("Type\n1 - Statistic, 2 - PC," +
                    " 3 - Room, 4 - Table, 5 - Board" +
                    " \n\n1.Go to the branch\n2.leave the branch" +
                    "\n3.Clear map\n4.Add\n5.Remove" +
                    "\n6.All price\n7.Exit\nYour chose:");
                chose = Convert.ToInt32(Console.ReadLine());
                if (chose==1)
                {
                    Console.Write("Number:");
                    string my_chose = Console.ReadLine();
                    my_tree.map_in_my_tree.Add(my_chose);
                }
                else if (chose == 2)
                {
                    my_tree.map_in_my_tree.RemoveAt(my_tree.map_in_my_tree.Count-1);
                }
                else if (chose == 3)
                {
                    my_tree.map_in_my_tree.Clear();
                }
                else if (chose == 4 )
                {
                    Console.Write("Enter type: ");
                    My_type my_type = (My_type)(Convert.ToInt32(Console.ReadLine()));
                    Console.Write("Enter name: ");
                    string my_chose = Console.ReadLine();
                    Console.Write("Enter price: ");
                    int my_price = Convert.ToInt32(Console.ReadLine());
                    my_tree.Add(my_chose, my_price,my_type);
                }
                else if (chose == 5)
                {
                    my_tree.Remove();
                }
                else if (chose == 6)
                {
                    Console.WriteLine("All price: {0}",my_tree.All_Price());
                    Console.Read();
                }
                else if (chose == 7)
                {
                    break;
                }
                Console.Clear();
            }
        }
    }


}
