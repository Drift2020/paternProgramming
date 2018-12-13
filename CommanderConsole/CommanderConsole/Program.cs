using CommanderConsole.Commander;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommanderConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] field_game;
            field_game = new string[] { " | | ", "- - -", " | | ", "- - -", " | | " };
            bool step = true;
            User client = new User();
            Game x_o = new Game(new ConsoleWriter());
            int x=0, y=0;
            while(!x_o.IsWin())
            {
                step1:
                Console.Clear();
                x_o.PrintField();

                if(step)
                {
                    Console.WriteLine("1P - x");
                }
                else
                {
                    Console.WriteLine("2P - o");
                }


                Console.WriteLine("Undo - q \n Redo - e \n Next - n");
                string s = Console.ReadLine();
                if (s == "q")
                {
                    Console.Write("Enter Step undo:");
                    int steps = Convert.ToInt32(Console.ReadLine());
                    client.Undo(steps);
                    continue;
                }
                else if (s == "e")
                {
                    Console.Write("Enter Step redo:");
                    int steps = Convert.ToInt32(Console.ReadLine());
                    client.Redo(steps);
                    continue;
                }



                bool work = true;
                while(work)
                {
                   

                    Console.Write("Enter Y:");
                    y = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter X:");
                    x = Convert.ToInt32(Console.ReadLine());



                    if (step)
                    {
                        if (!x_o.IsField(x, y, 'x'))
                        {
                            Console.WriteLine("Error position");
                        }
                        else
                        {
                            step = !step;
                            work = false;
                        }
                    }
                    else
                    {
                        if (!x_o.IsField(x, y, 'y'))
                        {
                            Console.WriteLine("Error position");
                        }
                        else
                        {
                            step = !step;
                            work = false;
                        }
                    }
                }
                if (step)
                    client.Compute(new GameCommand(x_o, x, y, 'x'));
                else
                    client.Compute(new GameCommand(x_o, x, y, 'y'));





            }
        }
    }
}
