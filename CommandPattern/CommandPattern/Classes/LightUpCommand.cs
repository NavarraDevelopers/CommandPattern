using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Classes
{
    public class LightUpCommand : ICommand
    {
        private int _intense = 0;
        private Light _light;

        public LightUpCommand(Light l)
        {
            this._light = l;
        }

        public void Execute()
        {
            this._intense += 1;
            Console.WriteLine("He subido 1 la intensidad de la bombilla");
        }

        public void Unexecute()
        {
            this._intense -= 1;
            Console.WriteLine("He bajado 1 la intensidad de la bombilla");
        }
    }
}
