using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPMatematicaSuperiorSIEL.SielSolver
{
    public class GaussSeidelSielSolver : SielSolver
    {
        public GaussSeidelSielSolver(double epsilon, int cantDecimales) : base(epsilon,cantDecimales) { }

        protected override List<double> resolverSegunEstrategia(List<List<double>> matrizCoeficientes, int tamanioMatrizCoeficientes, List<double> terminosIndependientes, List<double> incognitas)
        {
            List<double> proximasIncognitas = new List<double>();
            for (int i = 0; i < tamanioMatrizCoeficientes; i++)
            {
                double proximoValor = terminosIndependientes[i];
                for (int j = 0; j < tamanioMatrizCoeficientes; j++)
                {
                    if (i < j)
                    {
                        proximoValor -= matrizCoeficientes[i][j] * incognitas[j];
                    }
                    if (i > j)
                    {
                        proximoValor -= matrizCoeficientes[i][j] * proximasIncognitas[j];
                    }
                }
                proximoValor = proximoValor / matrizCoeficientes[i][i];
                proximasIncognitas.Insert(i, Math.Round(proximoValor, cantDecimales));
            }
                /*if (criterioConvergencia())
                    return;*/
                //resolverSegunEstrategia(matrizCoeficientes, tamanioMatrizCoeficientes, terminosIndependientes, incognitas);

            //TODO
            return incognitas;
        }
    }
}

