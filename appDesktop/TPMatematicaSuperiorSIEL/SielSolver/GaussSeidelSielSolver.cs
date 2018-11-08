using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPMatematicaSuperiorSIEL.SielSolver
{
    public class GaussSeidelSielSolver : SielSolver
    {
        public GaussSeidelSielSolver(double epsilon) : base(epsilon) { }

        protected override List<double> resolverSegunEstrategia(List<List<double>> matrizCoeficientes, int tamanioMatrizCoeficientes, List<double> terminosIndependientes, List<double> incognitas)
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

            //TODO
            return null;
        }
    }
}

