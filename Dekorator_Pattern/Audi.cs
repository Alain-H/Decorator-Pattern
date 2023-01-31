using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dekorator_Pattern
{
    internal class Audi : Auto
    {
        public Audi()
        {
            ausstattung += "Audi R8";
        }

        public override double getpreis()
        {
            return 190000;
        }


    }
}
