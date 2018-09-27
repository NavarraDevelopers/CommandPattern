using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Classes
{
    //esta clase va a representar el mando a distancia con 4 comandos, que lo podemoos traducir a 4 botones.
    public class Invoker
    {
        ICommand _on;
        ICommand _off;
        ICommand _up;
        ICommand _down;

        public Invoker(ICommand On, ICommand Off, ICommand Up, ICommand Down)
        {
            this._on = On;
            this._off = Off;
            this._up = Up;
            this._down = Down;
        }

        public void ClickOn()
        {
            this._on.Execute();
        }

        public void ClickOff()
        {
            this._off.Execute();
        }
        public void ClickUp()
        {
            this._up.Execute();
        }
        public void ClickDown()
        {
            this._down.Execute();
        }


    }
}
