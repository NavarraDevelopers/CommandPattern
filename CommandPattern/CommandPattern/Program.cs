using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommandPattern.Classes;

namespace CommandPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Light light = new Light();
            Invoker invoker = new Invoker(new LightOnCommand(light), new LightOffCommand(light), new LightUpCommand(light), new LightDownCommand(light));

            invoker.ClickOn();
            invoker.ClickOff();
            invoker.ClickUp();
            invoker.ClickDown();
        }
    }
}
