using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dekorator_Pattern
{
    internal class Unterbodenbeleuchtung : Decorator
    {
        Auto auto;

        public Unterbodenbeleuchtung(Auto My_AutoModel)
        {
            auto = My_AutoModel;
        }

        public override string getAusstattung()
        {
            return auto.getAusstattung() + "mit grünem Unterbodenlicht, ";
        }

        public override double getpreis()
        {
            return auto.getpreis() + 5000;
        }

    }
}
