using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Classes
{
    //interface de las que todos los comando van a implementar
    public interface ICommand
    {
        void Execute();
        void Unexecute();
    }
}
