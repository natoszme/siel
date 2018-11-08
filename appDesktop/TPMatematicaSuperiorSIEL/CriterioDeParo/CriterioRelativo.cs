using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPMatematicaSuperiorSIEL.CriterioDeParo
{
    public class CriterioRelativo : CriterioDeParo
    {
        public CriterioRelativo(double epsilon) : base(epsilon) { }

        protected override double factorDeDivision(List<double> vectorActual)
        {
            return AnalizadorMatriz.normaInfinita(vectorActual);
        }
    }
}
