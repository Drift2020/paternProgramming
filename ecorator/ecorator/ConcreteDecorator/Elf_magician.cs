using ecorator.Component;
using ecorator.Decorator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ecorator.ConcreteDecorator
{
    class Elf_magician : Profession_Magic
    {
        public Elf_magician(Being_Magic b)
        : base("Эльф маг", b.Hitponts - 50, b.Speed + 10,
              b.Damage + 10, b.Defense + 10, b)
        {

        }
    }
}
