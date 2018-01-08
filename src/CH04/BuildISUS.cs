using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH04
{
    public class BuildISUS : ComputerBuilder
    {
        public override ComputerBuilder SetBox()
        {
            this.Computer.Add("華碩主機");
            return this;
        }

        public override ComputerBuilder SetKeyboard()
        {
            this.Computer.Add("華碩鍵盤");
            return this;
        }

        public override ComputerBuilder SetMonitor()
        {
            this.Computer.Add("華碩螢幕");
            return this;
        }
    }
}
