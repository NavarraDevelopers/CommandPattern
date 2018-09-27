using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Classes
{
    public class LightOnCommand : ICommand
    {
        private Light _light;

        public LightOnCommand(Light l)
        {
            this._light = l;
        }

        public void Execute()
        {
            this._light.On();
            Console.WriteLine("He encendido la bombilla");
        }

        public void Unexecute()
        {
            this._light.Off();
            Console.WriteLine("He apagado la bombilla");
        }
    }
}
