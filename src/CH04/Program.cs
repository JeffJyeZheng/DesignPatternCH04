using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH04
{
    class Program
    {
        static void Main(string[] args)
        {
            Director director = new Director();

            BuildApply buildApply = new BuildApply();
            director.Construct(buildApply);
            buildApply.GetResult();

            BuildISUS buildISUS = new BuildISUS();
            director.Construct(buildISUS);
            buildISUS.GetResult();

            Console.ReadKey();
        }
    }
}
