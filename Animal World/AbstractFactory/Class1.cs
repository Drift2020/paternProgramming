using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public abstract class Continent
    {
        public abstract Africa Create_Africa();
        public abstract North_America Create_North_America();
    }
    public class Africa 
    {

    }
    public class North_America
    {

    }

    public abstract class Herbivore
    {
        protected int Weight;
        protected bool Life=true;
        public abstract void Eat_grass();
        public abstract int Weight(); 
        public abstract void Set_Life(bool elem);
    }
    public class Wildebeest : Herbivore
    {
        public override void Set_Life(bool elem)
        {
            this.Life = elem;
        }

        public override void Eat_grass()
        {
            this.Weight += 10;
        }
    }


    public abstract class Carnivore
    {
        protected int Power;
        public abstract void Eat();
    }

    public class Wolf : Carnivore
    {
        public override void Eat()
        {

        }
    }


  


    
}
