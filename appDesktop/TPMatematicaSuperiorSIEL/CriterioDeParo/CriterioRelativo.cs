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

        new protected double valorDeReferencia(List<double> vectorAnterior, List<double> vectorActual)
        {
            double normaInfinitaDeLaResta = base.valorDeReferencia(vectorAnterior, vectorActual);
            return normaInfinitaDeLaResta / AnalizadorMatriz.normaInfinita(vectorActual);
        }
    }
}
