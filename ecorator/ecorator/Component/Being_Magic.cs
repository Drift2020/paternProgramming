﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ecorator.Component
{
    abstract class Being_Magic : Player
    {       
            public Being_Magic(string Name, int Hitponts,
                int Speed, int Damage, int Defense)
            {
                this.Name = Name;
                this.Hitponts = Hitponts;
                this.Speed = Speed;
                this.Damage = Damage;
                this.Defense = Defense;
            }
            public string Name { get; protected set; }
            public int Hitponts { get; protected set; }
            public int Speed { get; protected set; }
            public int Damage { get; protected set; }
            public int Defense { get; protected set; }

            //public abstract int Move_Speed();
            //public abstract int Move_Hitpoints();
            //public abstract int Move_Damage();
            //public abstract int Move_Defense();      
    }
}
