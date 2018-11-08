using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPMatematicaSuperiorSIEL.CriterioDeParo
{
    public abstract class CriterioDeParo
    {
        public double epsilon;

        public CriterioDeParo(double epsilon)
        {
            this.epsilon = epsilon;
        }

        public bool hayQueSeguir(List<double> vectorAnterior, List<double> vectorActual) {
            double normaInfinita = this.valorDeReferencia(vectorAnterior, vectorActual);
            return normaInfinita >= epsilon;
        }

        private double valorDeReferencia(List<double> vectorAnterior, List<double> vectorActual)
        {
            List<Double> vectorResultado = vectorActual.Zip(vectorAnterior, (actual, anterior) => Math.Abs(actual - anterior)).ToList();
            return AnalizadorMatriz.normaInfinita(vectorResultado) / this.factorDeDivision(vectorActual);
        }

        protected abstract double factorDeDivision(List<double> vectorActual);
    }
}
