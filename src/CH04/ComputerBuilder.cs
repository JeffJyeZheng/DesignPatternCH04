using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH04
{
    public abstract class ComputerBuilder
    {
        protected List<string> Computer = new List<string>();

        public abstract ComputerBuilder SetMonitor();

        public abstract ComputerBuilder SetKeyboard();

        public abstract ComputerBuilder SetBox();

        public void GetResult()
        {
            foreach(var item in this.Computer)
            {
                Console.WriteLine(item);
            }
        }
    }
}
