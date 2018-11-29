using ecorator.Component;
using ecorator.Decorator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ecorator.ConcreteDecorator
{
    class Human_Warrior:Profession
    {
        public Human_Warrior(Being b)
          : base("Человек воин", b.Hitponts+50, b.Speed+10,
                b.Damage+20, b.Defense+20, b)
        {

        }

       
    }
}
