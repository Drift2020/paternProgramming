using ecorator.Component;
using ecorator.Decorator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ecorator.ConcreteDecorator
{
    class Good_magician : Profession_Magic
    {
        public Good_magician(Being_Magic b)
        : base("Злой маг", b.Hitponts + 100, b.Speed + 30,
              b.Damage + 50, b.Defense + 30, b)
        {

        }
    }
}
