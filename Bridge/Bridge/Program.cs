using System;
using System.Collections.Generic;
using System.IO;
using System.Management;
using System.Xml.Serialization;
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
        public abstract void Operation();
    }
    class ConsoleWrite : PC
    {
        public ConsoleWrite(Info_PC info) : base(info)
        {

        }
     
        
        public override void Operation()
        {
          
            Console.WriteLine(String.Format("Версия Windows: {0}", Environment.OSVersion));
            Console.WriteLine(String.Format("64 Bit операционная система? : {0}", Environment.Is64BitOperatingSystem ? "Да" : "Нет"));
            Console.WriteLine(String.Format("Имя компьютера : {0}", Environment.MachineName));
            Console.WriteLine("\n");

           
        

         
        }

    }

    class FileWrite : PC
    {
        XmlSerializer formatter;
        public FileWrite(Info_PC info) : base(info)
        {

        }


        public override void Operation()
        {
            formatter = new XmlSerializer(typeof(List<string>));



            List<string> temp=new List<string>();
            temp.Add(String.Format("Версия Windows: {0}", Environment.OSVersion));
            temp.Add(String.Format("64 Bit операционная система? : {0}", Environment.Is64BitOperatingSystem ? "Да" : "Нет"));
            temp.Add(String.Format("Имя компьютера : {0}", Environment.MachineName));
            temp.Add("\n");// получаем поток, куда будем записывать сериализованный объект
            using (FileStream fs = new FileStream("persons.xml", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, temp);

                Console.WriteLine("Объект сериализован");
            }





         
        }
        public override string[] PC_info()
        {
            formatter = new XmlSerializer(typeof(List<string>));
          string[] temp = info.GetInfo();
            List<string> tempL = new List<string>();

            foreach (var i in temp)
            {
                tempL.Add(i);
            }
            // получаем поток, куда будем записывать сериализованный объект
            using (FileStream fs = new FileStream("persons.xml", FileMode.Append))
            {
                formatter.Serialize(fs, tempL);

                Console.WriteLine("Объект сериализован");
            }

            return new string[] { "0" };
        }

    }


    class Program
    {
        static void Main(string[] args)
        {

            PC my_info = new FileWrite(new Video_card());
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

                my_info.Operation();
                foreach (var y in my_info.PC_info())
                {
                    Console.WriteLine(y);
                }
            }
        }
    }
}
