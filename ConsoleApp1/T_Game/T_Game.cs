using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using T_Figure_;
using Figure_;
using Game_;
namespace T_Game_
{
 
      public  class T_Game : Game
        {
            public override Figure Create()
            {
                return new T_Figure();
            }
        }
    
}
