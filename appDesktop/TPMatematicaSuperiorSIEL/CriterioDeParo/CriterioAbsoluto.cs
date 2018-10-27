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

        public override double valorDeReferencia(List<double> vectorAnterior, List<double> vectorActual)
        {
            List<Double> vectorResultado = vectorActual.Zip(vectorAnterior, (actual, anterior) => actual - anterior).ToList();
            return AnalizadorMatriz.normaInfinita(vectorResultado);
        }
    }
}
