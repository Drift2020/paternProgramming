using ecorator.Component;
using ecorator.Decorator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ecorator.ConcreteDecorator
{
    class Archer : Profession
    {
        public Archer(Being b)
          : base("Лучник", b.Hitponts + 50, b.Speed + 20,
                b.Damage + 20, b.Defense + 10, b)
        {

        }


    }
}
