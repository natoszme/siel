using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPMatematicaSuperiorSIEL.SielSolver
{
    public class JacobiSielSolver : SielSolver
    {
        public JacobiSielSolver() : base() {}

        protected override List<double> resolverSegunEstrategia(List<List<double>> matrizCoeficientes, int tamañoMatrizCoeficientes, List<double> terminosIndependientes, List<double> incognitas)
        {
            List<double> proximasIncognitas = new List<double>();
            for (int i = 0; i < tamañoMatrizCoeficientes; i++)
            {
                double proximoValor = terminosIndependientes[i];
                for (int j = 0; j < tamañoMatrizCoeficientes; j++)
                {
                    if (i != j)
                    {
                        proximoValor -= matrizCoeficientes[i][j] * incognitas[j];
                    }
                }
                proximoValor = proximoValor / matrizCoeficientes[i][i];
                proximasIncognitas.Insert(i, proximoValor);
            }
            System.Threading.Thread.Sleep(3);
            //resolverSegunEstrategia(matrizCoeficientes, tamañoMatrizCoeficientes, terminosIndependientes, proximasIncognitas);

            //TODO
            return null;
        }
    }
}
