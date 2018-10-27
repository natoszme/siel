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
            const double epsilon = 0.001;
            // TODO: obtener epsilon desde la UI
            criteriosDeParo.Add(new CriterioDeParo.CriterioAbsoluto(epsilon));
            criteriosDeParo.Add(new CriterioDeParo.CriterioRelativo(epsilon));
        }

        public void resolver(List<double> vectorInicial)
        {
            //TODO llamar a resolverSegunEstrategia con el vector inicial
            //ese metodo tiene que devolver una lista de valores, para aplicarla aca:
            List<double> vectorCalculado = new List<double>();
            //vectorCalculado = resolverSegunEstrategia(//completar con los parametros);

            // TODO: habria que mostrar en la UI si se puede o no seguir (con c/criterio)
            // Tambien mostrar los pasos que se siguieron
            if (criteriosDeParo.Any(criterio => criterio.hayQueSeguir(vectorInicial, vectorCalculado)))
            {
                resolver(vectorCalculado);
            }
        }

        protected abstract List<double> resolverSegunEstrategia(List<List<double>> matrizCoeficientes, int tamanioMatrizCoeficientes, List<double> terminosIndependientes, List<double> incognitas);
    }
}
