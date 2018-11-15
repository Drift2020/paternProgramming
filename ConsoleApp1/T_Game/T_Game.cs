using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
 
      public  class T_Game : Game
        {
            public override Figure Create()
            {
                Figure temp = new T_Figure();
                return temp;
            }
        }
    
}
