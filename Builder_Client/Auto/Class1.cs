using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auto
{
    public class Product
    {
        protected string name, housing, engine, wheels, kpp;
        public void Set_name(string name) { this.name = name; }
        public void Set_housing(string housing) { this.housing = housing; }
        public void Set_engine(string engine) { this.engine = engine; }
        public void Set_wheels(string wheels) { this.wheels = wheels; }
        public void Set_kpp(string kpp) { this.kpp = kpp; }

        public string Get_name() { return name; }
        public string Get_housing() { return housing; }
        public string Get_engine() { return engine; }
        public string Get_wheels() { return wheels; }
        public string Get_kpp() { return kpp; }
    }
    public abstract class ProductBuilder
    {
        protected Product auto;
        public Product Get_product() { return auto; }
        public void Create_new_product() { auto = new Product(); }
        public abstract void Build_name();
        public abstract void Build_housing();
        public abstract void Build_engine();
        public abstract void Build_wheels();
        public abstract void Build_kpp();
    }

    public class DaewooLanos : ProductBuilder
    {
        public override void Build_name()
        {
            this.auto.Set_name("Daewoo Lanos");
        }
        public override void Build_housing()
        {
            this.auto.Set_housing("Седан");
        }
        public override void Build_engine()
        {
            this.auto.Set_engine("98");
        }
        public override void Build_wheels()
        {
            this.auto.Set_wheels("13");
        }
        public override void Build_kpp()
        {
            this.auto.Set_kpp("5 Manual");
        }

    }
    public class FordProbe : ProductBuilder
    {
        public override void Build_name()
        {
            this.auto.Set_name("Ford Probe");
        }
        public override void Build_housing()
        {
            this.auto.Set_housing("Купе");
        }
        public override void Build_engine()
        {
            this.auto.Set_engine("160");
        }
        public override void Build_wheels()
        {
            this.auto.Set_wheels("14");
        }
        public override void Build_kpp()
        {
            this.auto.Set_kpp("4 Auto");
        }

    }
    public class UAZPatriot : ProductBuilder
    {
        public override void Build_name()
        {
            this.auto.Set_name("UAZ Patriot");
        }
        public override void Build_housing()
        {
            this.auto.Set_housing("Универсал");
        }
        public override void Build_engine()
        {
            this.auto.Set_engine("120");
        }
        public override void Build_wheels()
        {
            this.auto.Set_wheels("16");
        }
        public override void Build_kpp()
        {
            this.auto.Set_kpp("4 Manual");
        }

    }
    public class HyundaiGetz : ProductBuilder
    {
        public override void Build_name()
        {
            this.auto.Set_name("Hyundai Getz");
        }
        public override void Build_housing()
        {
            this.auto.Set_housing("Хетчбэк");
        }
        public override void Build_engine()
        {
            this.auto.Set_engine("66");
        }
        public override void Build_wheels()
        {
            this.auto.Set_wheels("13");
        }
        public override void Build_kpp()
        {
            this.auto.Set_kpp("4 auto");
        }

    }

    public class Shop
    {
        private ProductBuilder auto_build;
        public void setAutoBuilder(ProductBuilder pb) { auto_build = pb; }
        public Product getTeam() { return auto_build.Get_product(); }

        public void Construct_auto()
        {
            auto_build.Create_new_product();
            auto_build.Build_name();
            auto_build.Build_housing();
            auto_build.Build_engine();
            auto_build.Build_wheels();
            auto_build.Build_kpp();
        }
    }
}
