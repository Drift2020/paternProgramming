using ecorator.Component;
using ecorator.Decorator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ecorator.ConcreteDecorator
{
    class Evil_magician : Profession_Magic
    {
        public Evil_magician(Being_Magic b)
        : base("Злой маг", b.Hitponts + 0, b.Speed + 20,
              b.Damage + 70, b.Defense + 0, b)
        {

        }
    }
}
