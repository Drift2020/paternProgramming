using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class Animal_world
    {
        Continent my_continent;
        public Animal_world(Continent factory)
        {
            my_continent = factory;
        }
        public void Eat_herbivore()
        {
            my_continent.Eat_Herbivore();

        }
        public void Eat_carnivore()
        {
            my_continent.Eat_Carnivore();
        }

        public int Get_info_herbivore_weight()
        {
            return my_continent.Get_weight();
        }
        public int Get_info_carnivore_power()
        {
            return my_continent.Get_power();
        }

        public string Get_name_of_the_Continent()
        {
            return my_continent.Get_continent_name();
        }

        public string Get_name_carnivore()
        {
            return my_continent.Get_name_Carnivore();
        }
        public string Get_name_herbivore()
        {
            return my_continent.Get_name_Herbivore();
        }
        public bool Get_Life_herbivore()
        {
            return my_continent.Get_life_herbivore();
        }
    }

    public abstract class Continent
    {

        protected Herbivore herbi;
        protected Carnivore carni;
        protected string name;

        public abstract void Eat_Herbivore();
        public abstract void Eat_Carnivore();

        public int Get_power()
        {
            return carni.Get_power();
        }
        public int Get_weight()
        {
            return herbi.Get_weight();
        }
        public string Get_name_Carnivore()
        {
            return carni.Get_Name();
        }
        public string Get_name_Herbivore()
        {
            return herbi.Get_Name();
        }
        public string Get_continent_name()
        {
            return name;
        }
        public bool Get_life_herbivore()
        {
            return herbi.Get_life();
        }

    }
    public class Africa : Continent
    {
        public Africa()
        {
            this.name = "Africa";
            this.herbi = new Bison();
            this.carni = new Lion();
        }
        public override void Eat_Herbivore()
        {
            this.herbi.Eat_grass();
        }
        public override void Eat_Carnivore()
        {
            if (this.carni.Get_power() > this.herbi.Get_weight())
            {
                if (this.herbi.Get_life())
                {
                    this.herbi.Set_Life(false);
                    this.carni.Eat();
                }
            }
            else
                this.carni.Down_Eat();
        }
    }
    public class North_America : Continent
    {
        public North_America()
        {
            this.name = "North_America";
            this.herbi = new Wildebeest();
            this.carni = new Wolf();
        }
        public override void Eat_Herbivore()
        {
            this.herbi.Eat_grass();
        }
        public override void Eat_Carnivore()
        {
            if (this.carni.Get_power() > this.herbi.Get_weight())
            {
                if (this.herbi.Get_life())
                {
                    this.herbi.Set_Life(false);
                    this.carni.Eat();
                }
            }
            else
                this.carni.Down_Eat();
        }
    }

    public abstract class Herbivore
    {
        protected string name;
        protected int weight;
        protected bool life = true;
        public abstract void Eat_grass();
        public abstract int Get_weight();
        public abstract void Set_Life(bool elem);
        public abstract string Get_Name();
        public abstract bool Get_life();
    }
    public class Wildebeest : Herbivore
    {
        public Wildebeest()
        {
            this.name = "Wildebeest";
            this.life = true;

            this.weight = 10;

        }
        public override void Set_Life(bool elem)
        {
            this.life = elem;
        }

        public override void Eat_grass()
        {
            this.weight += 10;
        }
        public override int Get_weight()
        {
            if (this.life)
                return this.weight;
            else
                return 0;
        }
        public override string Get_Name()
        {
            return this.name;
        }
        public override bool Get_life()
        {
            return this.life;
        }
    }
    public class Bison : Herbivore
    {
        public Bison()
        {
            this.name = "Bison";
            this.life = true;

            this.weight = 10;

        }
        public override void Set_Life(bool elem)
        {
            this.life = elem;
        }

        public override void Eat_grass()
        {
            this.weight += 10;
        }
        public override int Get_weight()
        {
            if (this.life)
                return this.weight;
            else
                return 0;
        }
        public override string Get_Name()
        {
            return this.name;
        }
        public override bool Get_life()
        {
            return this.life;
        }
    }


    public abstract class Carnivore
    {
        protected string name;
        protected int power;
        public abstract void Eat();
        public abstract void Down_Eat();
        public abstract int Get_power();
        public abstract string Get_Name();
    }
    public class Wolf : Carnivore
    {
        public Wolf()
        {
            this.name = "Wolf";
            this.power = 20;
        }
        public override void Eat()
        {
            this.power += 10;
        }
        public override void Down_Eat()
        {
            this.power -= 10;
        }
        public override int Get_power()
        {
            return this.power;
        }
        public override string Get_Name()
        {
            return this.name;
        }
    }
    public class Lion : Carnivore
    {
        public Lion()
        {
            this.name = "Lion";
            this.power = 20;
        }
        public override void Eat()
        {
            this.power += 10;
        }
        public override void Down_Eat()
        {
            this.power -= 10;
        }
        public override int Get_power()
        {
            return this.power;
        }
        public override string Get_Name()
        {
            return this.name;
        }
    }






}
