using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Classes
{
    public class Light
    {
        private bool _on = false;

        public void On()
        {
            this._on = true;
        }

        public void Off()
        {
            this._on = false;
        }
    }
}
