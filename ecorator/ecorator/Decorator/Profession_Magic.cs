using ecorator.Component;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ecorator.Decorator
{
    abstract class Profession_Magic : Being_Magic
    {
        protected Being_Magic being_Magic;
        public Profession_Magic(string Name, int Hitponts,
            int Speed, int Damage, int Defense, Being_Magic being_Magic)
            : base(Name, Hitponts,
             Speed, Damage, Defense)
        {
            this.being_Magic = being_Magic;
        }
    }
}
