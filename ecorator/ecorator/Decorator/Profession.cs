using ecorator.Component;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ecorator.Decorator
{
    abstract class Profession:Being
    {
         protected Being being;
        public Profession(string Name, int Hitponts,
            int Speed, int Damage, int Defense, Being being)
            : base( Name,  Hitponts,
             Speed,  Damage,  Defense)
        {
            this.being = being;
        }
    }
}
