using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using CompositeV2.composite;
using System.Xml.Linq;

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
        public static void Read(IEnumerable<XElement> doc,int num, Root_system folder1)
        {
            string strN = "";
            string strN1 = "";
            strN1 = "";
            for (int i = 0; i < num + 1; i++)
            {
                strN1 = strN1 + "\t";
            }
            for (int i = 0; i < num; i++)
            {
                strN = strN + "\t";
            }

            foreach (XElement el in doc)
            {
                //Console.WriteLine(strN+"{0}", el.Name);
                Console.WriteLine(strN + "{0}", el.Attribute("name").Value);
                //foreach (XAttribute attr in el.Attributes())
                //    Console.WriteLine(strN + " Attributes   {0}", attr);
                Root_system temp = null;
                if (el.Name == "folder")
                {
                    temp = new Folder();
                    temp.Load(el);

                    foreach (XElement element in el.Elements())
                        if (element.Name == "folder")
                        {
                            Console.WriteLine(strN1 + "{0}", element.Attribute("name").Value);
                            //Console.WriteLine(strN + "{0}", element.Name);
                            //foreach (XAttribute attr in element.Attributes())
                            //    Console.WriteLine(strN + " Attributes   {0}", attr);
                            Root_system temp1 = null;
                            temp1 = new Folder();
                            temp1.Load(element);

                            Read(element.Elements(), num + 2, folder1);
                            temp.Add(temp1);
                        }
                        else
                        {
                            Console.WriteLine(strN1 + "{0}", element.Attribute("name").Value);
                            Root_system temp1 = null;
                            temp1 = new composite.File();
                            temp1.Load(element);
                            temp.Add(temp1);
                        }
                }
                else
                {
                    temp = new composite.File();
                    temp.Load(el);
                }
                folder1.Add(temp);

                


            }
        }
        static void Main(string[] args)
        {

            Root_system folder1=null;



            using (StreamWriter sw = new StreamWriter("my.xml", false, System.Text.Encoding.Default))
            {

                string path = @"C:\Users\Mamory\Documents\GitHub\paternProgramming\ConsoleApp1";
                Console.Write("Enter your path:");
                path = Console.ReadLine();
                DirectoryInfo dir = new DirectoryInfo(path);
                Root_system folder = new Folder(dir.Name, 0);

                Folder(dir, ref folder);

                // sw.WriteLine("<?xml version=\""+1.0+"\" encoding=\"utf - 8\"?>");
                folder.Save(sw, 0);



             }
                try
            {
                XDocument doc = XDocument.Load("my.xml");
                folder1 = new Folder(doc.Root.Attribute("name").Value, Convert.ToInt32(doc.Root.Attribute("readonly").Value));
                Read(doc.Root.Elements(),0, folder1);

                
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
