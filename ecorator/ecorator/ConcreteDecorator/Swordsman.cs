using ecorator.Component;
using ecorator.Decorator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ecorator.ConcreteDecorator
{
    class Swordsman : Profession
    {
        public Swordsman(Being b)
         : base("Меченосец", b.Hitponts + 50, b.Speed - 10,
               b.Damage + 40, b.Defense + 40, b)
        {

        }
    }
}
