using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Memento.Code;
using Memento.Command;


namespace Memento
{
    class View_Model_Main:View_Model_Base
    {
        My_text my_t;
        Caretaker my_history;
        int now_index;
        bool isCommand= true;
        public View_Model_Main()
        {
            now_index = 1;
            my_history = new Caretaker();
            my_t = new My_text();
            my_history.Add(my_t.SaveMemento());
        }
        public string Text{
            set
            {
                if(now_index<256)
                now_index++;


              
              
                my_t.Text= value;
                if (isCommand)
                    my_history.Add(my_t.SaveMemento());
                else
                    my_history.RemoveRange(now_index-1);
                OnPropertyChanged(nameof(Text));
                isCommand = true;
            }
            get
            {
                return my_t.Text;
            }
        }


        #region Undo
        private DelegateCommand _Command_Undo;
        public ICommand Button_clik_Undo
        {
            get
            {
                if (_Command_Undo == null)
                {
                    _Command_Undo = new DelegateCommand(Execute_Undo, CanExecute_Undo);
                }
                return _Command_Undo;
            }
        }
        private void Execute_Undo(object o)
        {

            isCommand = false;
            now_index--;
            my_t.RestoreMemento(my_history[now_index-1]);
            OnPropertyChanged(nameof(Text));
        }
        private bool CanExecute_Undo(object o)
        {
           if(now_index > 0 && my_history.Count>0)
                return true;
            return false;
          
        }
        #endregion Undo

        #region Redo
        private DelegateCommand _Command_Redo;
        public ICommand Button_clik_Redo
        {
            get
            {
                if (_Command_Redo == null)
                {
                    _Command_Redo = new DelegateCommand(Execute_Redo, CanExecute_Redo);
                }
                return _Command_Redo;
            }
        }
        private void Execute_Redo(object o)
        {
            isCommand = false;
            now_index++;
            my_t.RestoreMemento(my_history[now_index-1]);
            OnPropertyChanged(nameof(Text));
        }
        private bool CanExecute_Redo(object o)
        {

            if (now_index < my_history.Count)
                return true;
            return false;

        }
        #endregion Redo

    }
}
