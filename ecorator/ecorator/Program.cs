using ecorator.Component;
using ecorator.ConcreteComponent;
using ecorator.ConcreteDecorator;
using ecorator.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ecorator
{
    class Underworld
    {
        public Underworld(AllMessage writer, Allread read)
        {
            this.writer = writer;
            this.read = read;

        }
        enum Status_Game {Start_game, Start_chose, Start_menu,Exit,Main }
        enum Status_move {not_action, Up_level, Exit }
        protected Player my_unit;
        protected AllMessage writer;
        protected Allread read;
        Status_Game status_now= Status_Game.Start_menu;
        Status_move status_move_now = Status_move.not_action;
        public void Start()
        {
            bool isWork = true;
            while (isWork)
            {
                try
                {
                    switch (status_now)
                    {
                        case Status_Game.Start_menu:
                            Start_Menu();
                            break;
                        case Status_Game.Exit:
                            isWork = false;
                            break;
                        case Status_Game.Start_chose:
                            Start_Game();
                            break;
                    }
                }
                catch { }

            }
        }
        void Start_Menu()
        {

            writer.clean();
            writer.Write_n("1.Start game");
            writer.Write_n("2.Exit game");
            int chose = Convert.ToInt32(read.Read());
            if (chose == 1)
            {
                status_now = Status_Game.Start_chose;
            }
            else if (chose == 2)
            {
                status_now = Status_Game.Exit;
            }
        }     
        bool ChoseRace()
        {
            writer.clean();
            writer.Write_n("1.Human");
            writer.Write_n("2.Elf");
            writer.Write("Enter your race: ");
            try
            {
                int chose = Convert.ToInt32(read.Read());
                switch (chose)
                {
                    case 1:
                        my_unit = new Human();
                        status_now = Status_Game.Start_game;
                        return true;
                        break;
                    case 2:
                        my_unit = new Elf();
                        status_now = Status_Game.Start_game;
                        return true;
                        break;
                }
            }
            catch
            {
                writer.Write_n("-----Error value-----");
                writer.Write("Pleas enter any key");
                read.Read();
                return false;
            }
            return false;
        }
        void Human()
        {
            try
            {
                if (my_unit is Being)
                {
                    if((my_unit is Rider)|| (my_unit is Archer))
                    {
                        writer.clean();
                        writer.Write_n("End level");
                        read.Read();
                    }
                    else if(my_unit is Swordsman&& !(my_unit is Rider))
                    {
                        my_unit = new Rider((my_unit as Swordsman));
                    }
                    else if ((my_unit is Human_Warrior)&&!(my_unit is Swordsman) &&!(my_unit is Archer))
                    {
                        writer.clean();
                        writer.Write_n("1.Swordsman");
                        writer.Write_n("2.Archer");
                        writer.Write("Enter your type: ");
                        int chose = Convert.ToInt32(read.Read());
                        switch (chose)
                        {
                            case 1:
                                my_unit = new Swordsman((my_unit as Human_Warrior));
                                break;
                            case 2:
                                my_unit = new Archer((my_unit as Human_Warrior));
                                break;
                        }

                    }
                    else if (!(my_unit is Human_Warrior))
                    {
                        my_unit = new Human_Warrior(my_unit as Being);
                    }

                
                   
                }
            }
            catch
            {
                writer.Write("-----------Error in \"Human()\"---------------");
                read.Read();
            }
        }
        void Elf()
        {
            try
            {
                if (my_unit is Being_Magic)
                {
                    if((my_unit is Good_magician) ||(my_unit is Evil_magician)|| (my_unit is Crossbowman))
                    {
                        writer.clean();
                        writer.Write_n("End level");
                        read.Read();
                    }
                    else if (my_unit is Elf_magician && !(my_unit is Good_magician) && !(my_unit is Evil_magician))
                    {
                        writer.clean();
                        writer.Write_n("1.Good magician");
                        writer.Write_n("2.Evil magician");
                        writer.Write("Enter your type: ");
                        int chose = Convert.ToInt32(read.Read());
                        switch (chose)
                        {
                            case 1:
                                my_unit = new Good_magician((my_unit as Elf_magician));
                                break;
                            case 2:
                                my_unit = new Evil_magician((my_unit as Elf_magician));
                                break;
                        }
                    }
                    else if ((my_unit is Elf_warrior) && !(my_unit is Crossbowman))
                    {                      
                                my_unit = new Crossbowman((my_unit as Elf_warrior));
                    }
                    else if (!(my_unit is Elf_warrior)&& !(my_unit is Elf_magician))
                    {
                        writer.clean();
                        writer.Write_n("1.Elf warrior");
                        writer.Write_n("2.Elf magician");
                        writer.Write("Enter your type: ");
                        int chose = Convert.ToInt32(read.Read());
                        switch (chose)
                        {
                            case 1:
                                my_unit = new Elf_warrior((my_unit as Being_Magic));
                                break;
                            case 2:
                                my_unit = new Elf_magician((my_unit as Being_Magic));
                                break;
                        }
                    }



                }
            }
            catch
            {
                writer.Write("-----------Error in \"Elf()\"---------------");
                read.Read();
            }
        }
        void Start_Game()
        {
            while (!ChoseRace());
            bool work=true;
            while(work)
            {
                try
                {
                    writer.clean();
                    writer.Write_n(my_unit.NameF()+" "+
                        (my_unit.DamageF().ToString())+" "+ 
                        (my_unit.SpeedF().ToString())+" "+ 
                        (my_unit.HitpontsF().ToString())+" "+ 
                        (my_unit.DefenseF().ToString()));
                    writer.Write_n("1. Up level");
                    writer.Write_n("2. Exit");
                    writer.Write("Your chose: ");
                    status_move_now = (Status_move)Convert.ToInt32(read.Read());

                    switch(status_move_now)
                    {
                        case Status_move.Up_level: 
                            if (my_unit is Being)
                            {
                                Human();
                            }
                            else
                            {
                                Elf();
                            }
                            break;
                        case Status_move.Exit:
                            {
                                work = false;
                                status_now = Status_Game.Start_menu;
                            }
                            break;
                    }
                }
                catch { }
            }
        }
        
    }
    class Program
    {
        static Underworld game=new Underworld(new ConsoleWriter(),new ConsoleRead());
        static void Main(string[] args)
        {
            game.Start();
        }
    }
}
