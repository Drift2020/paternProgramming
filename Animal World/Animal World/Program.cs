using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory;
namespace Animal_World
{
    // клиент
  



    class Programm
    {
       
        static void Main(string[] args)
        {
            Animal_world my_word = new Animal_world(new North_America());
            int chose = 0;
            while (true)
            {
                Console.Write(String.Format("\t\tInfo\nContinent:{0}\n\nHerbivore:{1}\nWeight:{2}\nLife:{3}\n\nCarnivore:{4}\nPower:{5}\n\n1.Eat Carnivore\n2.Eat Herbivore\n3.Exit\nChose:", 
                    my_word.Get_name_of_the_Continent(), my_word.Get_name_herbivore(), my_word.Get_info_herbivore_weight(), my_word.Get_Life_herbivore(),
                    my_word.Get_name_carnivore(), my_word.Get_info_carnivore_power()));
                chose =Convert.ToInt32( Console.ReadLine());
                if(chose==1)
                {
                    my_word.Eat_carnivore();
                }
                else if (chose == 2)
                {
                    my_word.Eat_herbivore();
                }
                else if(chose == 3)
                {
                    break;
                }
                Console.Clear();
            }
            Console.Clear();
            Console.Write("\nEnd of the program\n");
        }
        
    }

}
