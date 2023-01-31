using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dekorator_Pattern
{
    public abstract class Auto
    {
        public string ausstattung;

        public virtual string getAusstattung()
        {
            return ausstattung;
        }

        public abstract double getpreis();


    }
}
