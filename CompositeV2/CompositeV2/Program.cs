using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using CompositeV2.composite;
namespace CompositeV2
{
    class Program
    {
        static void Main(string[] args)
        {
            try { 
            Root_system t = new composite.File("",0,0,new DateTime(),"");

            XmlSerializer formatter = new XmlSerializer(typeof(composite.File));

            // получаем поток, куда будем записывать сериализованный объект
            using (FileStream fs = new FileStream("persons.xml", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, t);

                Console.WriteLine("Объект сериализован");
            }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            string path;
            while(true)
            {
                Console.Write("Enter your path:");
                path = Console.ReadLine();


            }
        }
    }
}
