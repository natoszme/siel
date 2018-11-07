using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPMatematicaSuperiorSIEL
{
    public class PasoDeResolucion
    {
        public List<Double> valoresDeIncognitas;
        public List<String> cumpleCriterioDeParo;

        public PasoDeResolucion()
        {
            valoresDeIncognitas = new List<double>();
            cumpleCriterioDeParo = new List<string>();
        }

        public void cargarCriterio(Boolean resultadoDelCriterio)
        {
            if (resultadoDelCriterio)
            {
                cumpleCriterioDeParo.Add("Sigo");
            }
            else
            {
                cumpleCriterioDeParo.Add("Paro");
            }
        }
        public void setearValoresDeIncognitas(List<Double> valores)
        {
            valores.ForEach(agregarValor);
        }

        void agregarValor(Double valor){
            valoresDeIncognitas.Add(valor);
        }

    }
}
