using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        
        public abstract void Add(Root_system c, string[] elem);
      
        public abstract void Display(string depth);
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
     
        public override void Add(Root_system c, string[] elem)
        {
            
        }
        public override void Display(string depth)
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
      
        public override void Add(Root_system c, string[] elem)
        {

        }
        public override void Display(string depth)
        {

        }
    }
}
