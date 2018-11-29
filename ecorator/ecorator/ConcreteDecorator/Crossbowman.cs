using ecorator.Component;
using ecorator.Decorator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ecorator.ConcreteDecorator
{
    class Crossbowman : Profession_Magic
    {
        public Crossbowman(Being_Magic b)
        : base("Арбалетчик", b.Hitponts + 50, b.Speed + 10,
              b.Damage + 20, b.Defense - 10, b)
        {

        }
    }
}
