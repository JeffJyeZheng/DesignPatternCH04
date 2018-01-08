using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH04
{
    public class Director
    {
        public void Construct(ComputerBuilder builder)
        {
            builder
                .SetKeyboard()
                .SetMonitor()
                .SetBox();
        }
    }
}
