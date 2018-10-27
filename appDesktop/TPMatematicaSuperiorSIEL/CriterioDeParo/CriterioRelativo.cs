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

        protected override double valorDeReferencia(List<double> vectorAnterior, List<double> vectorActual)
        {
            List<Double> vectorResultado = vectorActual.Zip(vectorAnterior, (actual, anterior) => actual - anterior).ToList();
            return AnalizadorMatriz.normaInfinita(vectorResultado) / AnalizadorMatriz.normaInfinita(vectorActual);
        }
    }
}
