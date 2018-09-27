using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Classes
{
    public class LightOffCommand : ICommand
    {
        private Light _light;

        public LightOffCommand(Light l)
        {
            this._light = l;
        }

        public void Execute()
        {
            this._light.Off();
            Console.WriteLine("He apagado la bombilla");
        }

        public void Unexecute()
        {
            this._light.On();
            Console.WriteLine("He encendido la bombilla");
        }
    }
}
