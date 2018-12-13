using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommanderConsole.Commander
{
    class Game
    {
        protected AllMessage writer;
        string[] field_game;
        public Game(AllMessage writer)
        {
            field_game = new string[]{ " | | ","- - -", " | | ", "- - -", " | | " };
            this.writer = writer;
        }
        public void Step(int x,int y,char symbl)
        {
            if (y == 1)
            {
                switch(x)
                {
                    case 1:

                       
                        {
                          //  field_game[0][0] = symbl;
                            string NewStr="";
                            for (int i = 0; i < field_game[0].Length;i++)
                            {
                                if (i == 0)
                                    NewStr += symbl;
                                else
                                NewStr += field_game[0][i];
                            }
                            field_game[0] = NewStr;
                        }
                       
                        break;
                    case 2:
                        
                        {
                            //   field_game[0][2] = symbl;
                            string NewStr = "";
                            for (int i = 0; i < field_game[0].Length; i++)
                            {
                                if (i == 2)
                                    NewStr += symbl;
                                else
                                    NewStr += field_game[0][i];
                            }
                            field_game[0] = NewStr;
                        }
                       
                        break;
                    case 3:
                       
                        {
                            string NewStr = "";
                            for (int i = 0; i < field_game[0].Length; i++)
                            {
                                if (i == 4)
                                    NewStr += symbl;
                                else
                                    NewStr += field_game[0][i];
                            }
                            field_game[0] = NewStr;
                        }
                      
                        break;
                }
              
            }
            else if(y==2)
            {
                switch (x)
                {
                    case 1:
                        
                        {
                            string NewStr = "";
                            for (int i = 0; i < field_game[2].Length; i++)
                            {
                                if (i == 0)
                                    NewStr += symbl;
                                else
                                    NewStr += field_game[2][i];
                            }
                            field_game[2] = NewStr;
                        }
                      
                        break;
                    case 2:
                       
                        {
                            string NewStr = "";
                            for (int i = 0; i < field_game[2].Length; i++)
                            {
                                if (i == 2)
                                    NewStr += symbl;
                                else
                                    NewStr += field_game[2][i];
                            }
                            field_game[2] = NewStr;
                        }
                        
                        break;
                    case 3:
                     
                        {
                            string NewStr = "";
                            for (int i = 0; i < field_game[2].Length; i++)
                            {
                                if (i == 4)
                                    NewStr += symbl;
                                else
                                    NewStr += field_game[2][i];
                            }
                            field_game[2] = NewStr;
                        }
                       
                        break;
                }
            }
            else if(y==3)
            {
                switch (x)
                {
                    case 1:
                       
                        {
                            string NewStr = "";
                            for (int i = 0; i < field_game[4].Length; i++)
                            {
                                if (i == 0)
                                    NewStr += symbl;
                                else
                                    NewStr += field_game[4][i];
                            }
                            field_game[4] = NewStr;
                        }
                       
                        break;
                    case 2:
                       
                        {
                            string NewStr = "";
                            for (int i = 0; i < field_game[4].Length; i++)
                            {
                                if (i == 2)
                                    NewStr += symbl;
                                else
                                    NewStr += field_game[4][i];
                            }
                            field_game[4] = NewStr;
                        }
                      
                        break;
                    case 3:
                       
                        {
                            string NewStr = "";
                            for (int i = 0; i < field_game[4].Length; i++)
                            {
                                if (i == 4)
                                    NewStr += symbl;
                                else
                                    NewStr += field_game[4][i];
                            }
                            field_game[4] = NewStr;
                        }
                      
                        break;
                }
            }
           
        }
        public void PrintField()
        {
            for (int i = 0; i < field_game.Length; i++)
                writer.Write_n((i+1).ToString()+" "+field_game[i]);
        }
        public bool IsWin()
        {              
            string s = "ох";
            for(int i=0;i<2;i++)
                if(field_game[0][0] == s[i] && field_game[0][2] == s[i] && field_game[0][4] == s[i] ||
                   field_game[2][0] == s[i] && field_game[2][2] == s[i] && field_game[2][4] == s[i] ||
                   field_game[4][0] == s[i] && field_game[4][2] == s[i] && field_game[4][4] == s[i])
                {
                    writer.Write_n(String.Format("Player {0} WIN!!!", i+1));
                    return true;
                }
                    

            return false;
        }
        public bool IsField(int x, int y, char symbl)
        {
            if (y == 1)
            {
                switch (x)
                {
                    case 1:

                        if (field_game[0][0] == ' ')
                        {
                            return true;
                        }
                        else
                        {

                        }
                        break;
                    case 2:
                        if (field_game[0][2] == ' ')
                        {
                            return true;
                        }
                        else
                        {

                        }
                        break;
                    case 3:
                        if (field_game[0][4] == ' ')
                        {
                            return true;
                        }
                        else
                        {

                        }
                        break;
                }

            }
            else if (y == 2)
            {
                switch (x)
                {
                    case 1:
                        if (field_game[2][0] == ' ')
                        {
                            return true;
                        }
                        else
                        {

                        }
                        break;
                    case 2:
                        if (field_game[2][2] == ' ')
                        {
                            return true;
                        }
                        else
                        {

                        }
                        break;
                    case 3:
                        if (field_game[2][4] == ' ')
                        {
                            return true;
                        }
                        else
                        {

                        }
                        break;
                }
            }
            else if (y == 3)
            {
                switch (x)
                {
                    case 1:
                        if (field_game[4][0] == ' ')
                        {
                            return true;
                        }
                        else
                        {

                        }
                        break;
                    case 2:
                        if (field_game[4][2] == ' ')
                        {
                            return true;
                        }
                        else
                        {

                        }
                        break;
                    case 3:
                        if (field_game[4][4] == ' ')
                        {
                            return true;
                        }
                        else
                        {

                        }
                        break;
                }
            }
            return false;
        }
    }
}
