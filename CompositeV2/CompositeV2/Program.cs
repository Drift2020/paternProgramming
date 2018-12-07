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
        static void Folder(DirectoryInfo dir, Root_system folder)
        {
            foreach (var item in dir.GetDirectories())
            {
                Console.WriteLine(item.Name);
                Root_system temp = new Folder(item.Name, 0);
                folder.Add(temp);              
                
            }
        }

        static void Main(string[] args)
        {



             
            using (StreamWriter sw = new StreamWriter("my.txt", false, System.Text.Encoding.Default))
            {
         
                string path = @"E:\sources\etwproviders\ru-ru";
                Console.Write("Enter your path:");
                path = Console.ReadLine();
                DirectoryInfo dir = new DirectoryInfo(path);
                Root_system folder = new Folder(dir.Name, 0);
              
         
              

               
               

                for (int y = 0; y < i + 1; y++)
                {
                    nowPATH += pathN[y] + "\\";
                }
                Root_system folderNow = new Folder(pathN[i], 0);


                DirectoryInfo dir = new DirectoryInfo(nowPATH);

                    
                  
               
                folder.Save(sw, 0);
            }
           
        }
    }
}
