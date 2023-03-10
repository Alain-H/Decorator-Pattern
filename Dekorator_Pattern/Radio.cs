using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dekorator_Pattern
{
    internal class Radio : Decorator
    {
        Auto auto;

        public Radio(Auto my_AutoModel)
        {
            auto = my_AutoModel;
        }

        public override string getAusstattung()
        {
            return auto.getAusstattung() + " mit super Radio, ";
        }

        public override double getpreis()
        {
            return auto.getpreis() + 1500.50;
        }
    }
}
