using ecorator.Component;
using ecorator.Decorator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ecorator.ConcreteDecorator
{
    class Elf_warrior:Profession_Magic
    {
        public Elf_warrior(Being_Magic b)
        : base("Эльф воин", b.Hitponts + 100, b.Speed -10,
              b.Damage + 20, b.Defense + 20, b)
        {

        }
    }
}
