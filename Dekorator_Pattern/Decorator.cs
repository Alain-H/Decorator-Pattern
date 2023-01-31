using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dekorator_Pattern
{
    public abstract class Decorator : Auto
    {
        public abstract override string getAusstattung();
    }
}
