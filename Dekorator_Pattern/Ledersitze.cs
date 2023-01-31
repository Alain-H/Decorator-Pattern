using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dekorator_Pattern
{
    internal class Ledersitze : Decorator
    {
        Auto auto;

        public Ledersitze(Auto my_AutoModel)
        {
            auto = my_AutoModel;
        }

        public override string getAusstattung()
        {
            return auto.getAusstattung() + " mit Ledersitzen, ";
        }

        public override double getpreis()
        {
            return auto.getpreis() + 4500.50;
        }
    }
}
