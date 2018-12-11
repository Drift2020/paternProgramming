using Observer.interfese;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.Presenter
{
    class P_Index
    {
        private readonly Index _view;
        public P_Index(Index view)
        {
          

            _view = view;
          
            // Презентер подписывается на уведомления о событиях Представления
            _view.Up += new EventHandler<EventArgs>(Up);
            _view.Down += new EventHandler<EventArgs>(Down);
            _view.Left += new EventHandler<EventArgs>(Left);
            _view.Right += new EventHandler<EventArgs>(Right);

        }

        private void Up(object sender, EventArgs e)
        {
           
        }
        private void Down(object sender, EventArgs e)
        {

        }
        private void Left(object sender, EventArgs e)
        {

        }
        private void Right(object sender, EventArgs e)
        {

        }
        private void ClickButton(object sender, EventArgs e)
        {
            
        }
    }
}
