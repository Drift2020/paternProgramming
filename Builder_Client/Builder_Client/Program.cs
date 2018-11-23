using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Auto;
namespace Builder_Client
{
  

    class Program
    {
       
        static void Main(string[] args)
        {
            ProductBuilder[] temp = new ProductBuilder[] { new DaewooLanos(), new FordProbe(), new UAZPatriot(), new HyundaiGetz() };
            ProductBuilder tb = null;
            for (int i = 0; i < 4; i++)
            {
                tb = temp[i];
                Console.WriteLine("========================== Авто №" + (i + 1) + " =================================");
                Builder(tb);
            }
        }
        public static void Builder(ProductBuilder tb)
        {
            // клиент создает объект-распорядитель Director и конфигурирует его нужным объектом-строителем Builder
            Shop director = new Shop();
            director.setAutoBuilder(tb);
            // распорядитель уведомляет строителя о том, что нужно построить продукт
            director.Construct_auto();
            // клиент забирает продукт у строителя
            Product team = director.getTeam();
            Console.WriteLine("Имя механизма: {0} | Корпус: {1} | Двигатель (л. с): {2} | Колеса (R): {3} | К. П. П.: {4}", team.Get_name(),team.Get_housing(),team.Get_engine(),team.Get_wheels(),team.Get_kpp());
        }
    }
}
