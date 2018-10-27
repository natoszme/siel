using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPMatematicaSuperiorSIEL.SielSolver
{
    public static class GaussSeidelSielSolver
    {
        public static void resolverSegunEstrategia(List<List<Double>> matrizCoeficientes, int tamanioMatrizCoeficientes, List<Double> terminosIndependientes, List<Double> incognitas)
        {
                for(int i = 0; i < tamanioMatrizCoeficientes; i++)
                {
                    double proximoValor = terminosIndependientes[i];
                    for(int j = 0; j < tamanioMatrizCoeficientes; j++)
                    {
                        if(i != j)
                        {
                            proximoValor -= matrizCoeficientes[i][j] * terminosIndependientes [j];
                        }
                    }
                    incognitas[i] = (terminosIndependientes[i] - proximoValor) / matrizCoeficientes[i][i];
                }
                /*if (criterioConvergencia())
                    return;*/
                resolverSegunEstrategia(matrizCoeficientes, tamanioMatrizCoeficientes, terminosIndependientes, incognitas);
        }
    }
}

