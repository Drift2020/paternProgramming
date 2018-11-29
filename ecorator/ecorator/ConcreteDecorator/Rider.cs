using ecorator.Component;
using ecorator.Decorator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ecorator.ConcreteDecorator
{
    class Rider : Profession
    {
        public Rider(Being b)
          : base("Всадник", b.Hitponts + 200, b.Speed + 40,
                b.Damage - 10, b.Defense + 100, b)
        {

        }


    }
}
