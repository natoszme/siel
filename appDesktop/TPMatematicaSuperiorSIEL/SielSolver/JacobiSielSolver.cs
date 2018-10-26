using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPMatematicaSuperiorSIEL.SielSolver
{
    public static class JacobiSielSolver
    {
        public static void resolver(List<List<double>> matrizCoeficientes, int tamañoMatrizCoeficientes, List<double> terminosIndependientes, List<double> incognitas)
        {
            if (!cumpleCriterioParo())
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
                resolver(matrizCoeficientes, tamañoMatrizCoeficientes, terminosIndependientes, proximasIncognitas);
            }
        }

        public static bool cumpleCriterioParo()
        {
            //Hay que codear el criterio de los errores para cortar y modificar la firma acordemente
            return false;
        }
    }
}
