using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace CompositeV2.composite
{
    [Serializable]
   public abstract  class Root_system
    {
        public Root_system()
        {

        }
        public Root_system(string name, int type)
        {
         
            this.name = name;
            this.type = type;
        }
      
        public string name;
        public int type;
        
        public abstract void Add(Root_system c);
        public abstract void Display(string depth);
        public abstract void Save(StreamWriter fstream,int nun);
        public abstract void Load(XDocument fstream);
    }
    [Serializable]
    public class Folder: Root_system
    {
        public Folder()
        {

        }
        private List<Root_system> Roots = new List<Root_system>();
        public Folder(string name,int type) : base(name, type)
        {

        }

        public override void Add(Root_system Root)
        {
           
                Roots.Add(Root);

        }
        public override void Display(string depth)
        {

        }
        public override void Save(StreamWriter fstream, int nun)
        {
           
            if (Roots.Count > 0)
            {
                string strN="";
                for(int i = 0; i < nun; i++)
                {
                    strN = strN + "\t";
                }
                fstream.WriteLine(strN+"<folder readonly=\"" + type.ToString() + "\" name=\"" + name + "\">");

                Roots.ForEach(x => { x.Save(fstream, nun + 1); });

                fstream.WriteLine(strN + "</folder>", Encoding.ASCII);
            }
        
            else
            {
                fstream.WriteLine("<folder readonly=\"" + type.ToString() + "\" name=\"" + name + "\"/>", Encoding.ASCII);
            }
        }
        public override void Load(XDocument fstream)
        {

        }
    }
    [Serializable]
    public class File: Root_system
    {

        public int size;
        public DateTime datacreation;
        public string extension;
        public File()
        {

        }
        public File(string name, int type,int size,DateTime datacreation,string extension) : base(name, type)
        {
            this.size = size;
            this.datacreation = datacreation;
            this.extension = extension;
        }
      
        public override void Add(Root_system c)
        {
            Console.Write("not");
        }
        public override void Display(string depth)
        {

        }
        public override void Save(StreamWriter fstream, int nun)
        {
            string strN = "";
            for (int i = 0; i < nun; i++)
            {
                strN = strN + "\t";
            }
            fstream.WriteLine(strN + "<file readonly=\"" + type.ToString() + "\" name=\"" + name + "\" size=\""+size.ToString()+ "\" datacreation=\""+ datacreation.ToString()+ "\" extension=\""+ extension.ToString()+ "\"/>", Encoding.ASCII);
        }
        public override void Load(XDocument fstream)
        {

        }
    }
}
