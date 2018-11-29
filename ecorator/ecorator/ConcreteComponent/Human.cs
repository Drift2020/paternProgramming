using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ecorator.Component;
namespace ecorator.ConcreteComponent
{
    class Human:Being
    {
   
        public Human() :base("Человек",150,
           20, 20, 0)
        {
            
        }     

        //public override int Move_Speed()
        //{
        //    return 20;
        //}
        //public override int Move_Hitpoints()
        //{
        //    return 150;
        //}
        //public override int Move_Damage()
        //{
        //    return 20;
        //}
        //public override int Move_Defense()
        //{
        //    return 0;
        //}
    }
}
