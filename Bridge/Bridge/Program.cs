using System;
using System.Collections.Generic;
using System.Management;
using My_info;
namespace Bridge
{
   


    //----------------------------------

    abstract class PC
    {
        public PC(Info_PC info)
        {
            this.info = info;
        }
        public Info_PC Info { set { info = value; } }
        protected Info_PC info;
     
        public virtual string[] PC_info()
        {
           return info.GetInfo();
        }
        public abstract string[] Operation();
    }
    class Windows : PC
    {
        public Windows(Info_PC info) : base(info)
        {

        }
     
        
        public override string[] Operation()
        {
            List<string> info_pc = new List<string>();
            info_pc.Add(String.Format("Версия Windows: {0}", Environment.OSVersion));
            info_pc.Add(String.Format("64 Bit операционная система? : {0}", Environment.Is64BitOperatingSystem ? "Да" : "Нет"));
            info_pc.Add(String.Format("Имя компьютера : {0}", Environment.MachineName));
            info_pc.Add("\n");

           
        

            return info_pc.ToArray();
        }

    }


    class Program
    {
        static void Main(string[] args)
        {

            PC my_info = new Windows(new Video_card());
            while (true)
            {

                Console.Write("\n1.Print video card info\n2.Print CPU info\n3.Print HDD info\nEnter your chose:");
                int chose = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                if (chose == 1)
                    my_info.Info = new Video_card();
                else if (chose == 2)
                    my_info.Info = new CPU();
                else if (chose == 3)
                    my_info.Info = new HDD();

                foreach (var y in my_info.Operation())
                    {

                      
                            Console.WriteLine(y);
                        

                    }
                foreach (var y in my_info.PC_info())
                {


                    Console.WriteLine(y);


                }
            }
        }
    }
}
