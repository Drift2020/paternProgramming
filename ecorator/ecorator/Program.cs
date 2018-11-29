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
        enum Status_Game {Start_game,Start_menu,Up_level,Exit }
        protected Player my_unit;
        protected AllMessage writer;
        protected Allread read;
        Status_Game status_now= Status_Game.Start_menu;
        public void Start()
        {
            while (true)
            {
                switch (status_now)
                {
                    case Status_Game.Start_menu:
                        Start_Menu();
                        break;
                }

            }
        }
        public void Start_Menu()
        {
            writer.Write("1.Start game");
            writer.Write("2.Exit game");
            int chose = Convert.ToInt32(read.Read());
            if (chose == 1)
                status_now = Status_Game.Start_game;
            else if (chose == 1)
            {

            }
        }
        public void Paus_Game_Menu()
        {

        }
        public void Chose()
        {

        }
    }
    class Program
    {
        static Underworld game=new Underworld();
        static void Main(string[] args)
        {
            game.Start();
        }
    }
}
