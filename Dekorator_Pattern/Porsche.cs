using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dekorator_Pattern
{
    internal class Porsche :Auto
    {
        public Porsche()
        {
            ausstattung = "porsche 911";
        }

        public override double getpreis()
        {
            return 135000;
        }
    }
}
