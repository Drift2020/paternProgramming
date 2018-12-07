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
        static void Folder(DirectoryInfo dir, ref Root_system  folder)
        {
            foreach (var item in dir.GetDirectories())
            {
                FileInfo files = new FileInfo(item.FullName);
                Root_system temp = new Folder(item.Name, Convert.ToInt32(files.IsReadOnly));
                folder.Add(temp);
             
            
                Folder(item, ref temp);
            }
            foreach (var itemF in dir.GetFiles())
            {
                FileInfo file = new FileInfo(itemF.FullName);
                Root_system tempF = new composite.File(itemF.Name, Convert.ToInt32(file.IsReadOnly), Convert.ToInt32(file.Length), file.CreationTime, Path.GetExtension(file.FullName));
                folder.Add(tempF);
            }
        }

        static void Main(string[] args)
        {



             
            using (StreamWriter sw = new StreamWriter("my.xml", false, System.Text.Encoding.Default))
            {
         
                string path = @"D:\ЕКО-16-П3\ADO.NET";
                Console.Write("Enter your path:");
               // path = Console.ReadLine();
                DirectoryInfo dir = new DirectoryInfo(path);
                Root_system folder = new Folder(dir.Name, 0);





                Folder(dir, ref folder);


              

                    
                  
               
                folder.Save(sw, 0);
            }
           
        }
    }
}
