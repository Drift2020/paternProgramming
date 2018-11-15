using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{




    // строит деревянные дома





    class Program
    {
        static void Main(string[] args)
        {
            var end_color = Console.BackgroundColor;
            //string[] files = Directory.GetFiles("../../UsingDLL", "*.dll");
            //Assembly[] asm = new Assembly[files.Length];
            //for (int i = 0; i < files.Length; i++)
            //{
            //    asm[i] = Assembly.Load(AssemblyName.GetAssemblyName(files[i]));
            //}
            //Type[][] types = new Type[files.Length][];
            //for (int i = 0; i < files.Length; i++)
            //{
            //    types[i] = asm[i].GetTypes();
            //}
            //// Создатель «полагается» на свои подклассы в определении фабричного метода, который будет возвращать экземпляр подходящего конкретного продукта.
            //Game creator = null;
            //for (int i = 0; i < asm.Length; i++)
            //{
            //    creator = Activator.CreateInstance(types[i][0], null) as Game;
            //    Figure team = creator.Create();
            List<Game> creator = new List<Game>();
            creator.Add(new T_Game());
            creator.Add(new T1_Game());
            creator.Add(new T2_Game());
            creator.Add(new T3_Game());
            creator.Add(new T4_Game());
            creator.Add(new T5_Game());


            List< Figure> team = new List<Figure>();

            creator.ForEach(x => { team.Add(x.Create()); });

            team.ForEach(z => {
                Console.WriteLine(String.Format("{0}, {1}", z.getName(), z.getColor()));


                for (int y = 0; y < 4; y++)
                {

                    for (int x = 0; x < 4; x++)
                    {
                        if (z.getSize()[y][x] == 1)
                        {
                            Console.BackgroundColor = z.getColor();
                         
                            Console.Write(String.Format("{0}", z.getSize()[y][x]));
                        }
                        else
                        {
                            Console.BackgroundColor = end_color;
                            Console.Write(" ");
                        }

                    }
                    Console.Write("\n");
                }
                Console.Write("\n");
            });
           

                Console.ReadLine();
            }
       // }







    }
}
