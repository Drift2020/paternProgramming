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

        public string Text{
            set
            {
                my_t.Text= value;
                OnPropertyChanged(nameof(Text));
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
           
        }
        private bool CanExecute_Undo(object o)
        {
           
                return true;
          
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
           
        }
        private bool CanExecute_Redo(object o)
        {
            
                return true;
            
        }
        #endregion Redo

    }
}
