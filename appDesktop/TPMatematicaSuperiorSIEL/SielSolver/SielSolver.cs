using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPMatematicaSuperiorSIEL.SielSolver
{
    public abstract class SielSolver
    {
        public List<CriterioDeParo.CriterioDeParo> criteriosDeParo = new List<CriterioDeParo.CriterioDeParo>();

        public SielSolver()
        {
            criteriosDeParo.Add(new CriterioDeParo.CriterioAbsoluto());
            criteriosDeParo.Add(new CriterioDeParo.CriterioRelativo());
        }

        public void resolver(List<double> vectorInicial)
        {
            //TODO llamar a resolverSegunEstrategia con el vector inicial
            //ese metodo tiene que devolver una lista de valores, para aplicarla aca:
            List<double> vectorCalculado = new List<double>();
            //vectorCalculado = resolverSegunEstrategia(//completar con los parametros);
            if (criteriosDeParo.Any(criterio => criterio.hayQueSeguir(vectorInicial, vectorCalculado)))
            {
                //volver a llamar a este metodo con el valorInicial siendo el calculado
            }
        }

        protected abstract List<double> resolverSegunEstrategia(List<List<double>> matrizCoeficientes, int tamanioMatrizCoeficientes, List<double> terminosIndependientes, List<double> incognitas);
    }
}
