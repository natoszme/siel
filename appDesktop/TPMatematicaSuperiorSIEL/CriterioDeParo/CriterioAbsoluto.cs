using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPMatematicaSuperiorSIEL.CriterioDeParo
{
    public class CriterioAbsoluto : CriterioDeParo
    {
        public CriterioAbsoluto(double epsilon) : base(epsilon) { }

        protected override double factorDeDivision(List<double> vectorActual)
        {
            return 1;
        }
    }
}
