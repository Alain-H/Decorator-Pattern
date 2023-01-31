using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dekorator_Pattern
{
    internal class Alufelgen : Decorator
    {
        Auto auto;

        public Alufelgen(Auto My_AutoModel)
        {
            auto = My_AutoModel;
        }

        public override string getAusstattung()
        {
            return ausstattung = auto.getAusstattung() + " mit Alufelgen, ";
        }

        public override double getpreis()
        {
             return auto.getpreis() + 8000;
        }
    }
}
