using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH04
{
    public class BuildApply : ComputerBuilder
    {
        public override ComputerBuilder SetBox()
        {
            this.Computer.Add("apply 主機");
            return this;
        }

        public override ComputerBuilder SetKeyboard()
        {
            this.Computer.Add("apply 鍵盤");
            return this;
        }

        public override ComputerBuilder SetMonitor()
        {
            this.Computer.Add("apply 銀幕");
            return this;
        }
    }
}
