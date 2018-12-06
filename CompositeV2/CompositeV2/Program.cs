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
                if ((item.GetDirectories()).Length>0)
                    Folder(item, temp);

            }
        }

        static void Main(string[] args)
        {
      

         


        
        

            string path = @"E:\sources\etwproviders\ru-ru";
            string[] pathN = path.Split(new char[] { '\\' });

            Root_system folder = new Folder(pathN[0], 0);
            using (StreamWriter sw = new StreamWriter("my.txt", false, System.Text.Encoding.Default))
            {
                folder.Save(sw, 0);

            }


            Root_system folderLast= folder;
            while (true)
            {
                Console.Write("Enter your path:");
                path = Console.ReadLine();
                for (int i = 0; i < pathN.Length; i++)
                {
                   
                    string nowPATH = "";

                    for (int y = 0; y < i + 1; y++)
                    {
                        nowPATH += pathN[y] + "\\";
                    }

                    Root_system folderNow = new Folder(pathN[i], 0);

                    DirectoryInfo dir = new DirectoryInfo(nowPATH);

                    Console.WriteLine("==Список каталогов==");
                    foreach (var item in dir.GetDirectories())
                    {
                   
                        folderLast.Add(folderNow)
                        Console.WriteLine("==Список подкаталогов==");
                        foreach (var it in item.GetDirectories())
                            Console.WriteLine(it.Name);

                    }
                    Console.WriteLine("==============Список файлов==============");
                    
                }

            }
        }
    }
}
