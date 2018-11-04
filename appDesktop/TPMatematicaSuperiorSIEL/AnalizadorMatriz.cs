using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TPMatematicaSuperiorSIEL
{
    public static class AnalizadorMatriz
    {
        public enum DiagonalidadMatriz
        {
            Dominante,
            EstrictamenteDominante,
            NoDominante
        }

        public static String aString(DiagonalidadMatriz tipo)
        {
            if (tipo == DiagonalidadMatriz.Dominante)
            {
                return "dominante";
            }

            if (tipo == DiagonalidadMatriz.EstrictamenteDominante)
            {
                return "estrictamente dominante";
            }

            return "no dominante";
        }

        public static DiagonalidadMatriz obtenerDiagonalidad(List<List<double>> coeficientes, int tamanioMatriz)
        {
            bool esEstrictamenteDominante = true;

            for (int fila = 0; fila < tamanioMatriz; fila++)
            {
                double coeficienteDeDiagonalPrincipal = coeficientes[fila][fila];
                double sumaDeFila = 0;

                for (int columna = 0; columna < tamanioMatriz; columna++)
                {
                    if (fila != columna)
                    {
                        sumaDeFila += coeficientes[fila][columna];
                    }
                }

                if (coeficienteDeDiagonalPrincipal < sumaDeFila)
                {
                    return DiagonalidadMatriz.NoDominante;
                }
                else
                {
                    if (coeficienteDeDiagonalPrincipal == sumaDeFila)
                    {
                        esEstrictamenteDominante = false;
                    }
                }

            }

            if (esEstrictamenteDominante)
            {
                return DiagonalidadMatriz.EstrictamenteDominante;
            }

            return DiagonalidadMatriz.Dominante;
        }

        public static double normaInfinita(List<List<double>> coeficientes)
        {
            return coeficientes.Select(fila => fila.Sum()).Max();
        }

        public static double normaInfinita(List<double> coeficientes)
        {
            return coeficientes.Sum();
        }

        public static double norma1(List<List<double>> matriz, int tamañoMatriz)
        {
            List<double> sumatoriasColumna = new List<double>();
            for (int columna = 0; columna < tamañoMatriz; columna++)
            {
                double valor = 0;
                for (int fila = 0; fila < tamañoMatriz; fila++)
                {
                    valor += Math.Abs(matriz[fila][columna]);
                }
                sumatoriasColumna.Add(valor);
            }
            return sumatoriasColumna.Max();
        }

        public static double norma2(List<List<double>> matrizCoeficientes, int tamañoMatriz) 
        {
            List<List<double>> mTranspuesta = matrizTranspuesta(matrizCoeficientes, tamañoMatriz);
            double[,] matrixTranspuesta = paseDeListAMatriz(mTranspuesta, tamañoMatriz);
            double[,] matrixCoeficientes = paseDeListAMatriz(matrizCoeficientes, tamañoMatriz);
            double[] autovalores = calculoAutoValores(matrizCoeficientes, tamañoMatriz);

           // COMO HACER NORMA2 : RAIZ CUADRADA( MAYORAUTOVALOR(MATRIZCOEFICIENTES x transp matrizCoeficientes))

            double mayorAutovalor = autovalores.Max();

        
        }
        public static List<List<double>> matrizTranspuesta(List<List<double>> matriz, int tamañoMatriz)
        {
            List<List<double>> matrizTranspuesta = new List<List<double>>();

            List<double> matrizDeMatriz = new List<double>();
            double valor;
            for (int columna = 0; columna < tamañoMatriz; columna++)
            {
                List<double> matrizAux = new List<double>();
                for (int fila = 0; fila < tamañoMatriz; fila++)
                {
                    matrizDeMatriz = matriz.ElementAt(fila);
                    valor = matrizDeMatriz.ElementAt(columna);
                    matrizAux.Add(valor);
                }
                matrizTranspuesta.Add(matrizAux);
            }
            return matrizTranspuesta;
        }

        public static double[,] paseDeListAMatriz(List<List<double>> matrizCoeficientes, int tamañoMatriz)
        {
            double[,] matriz = new double[tamañoMatriz, tamañoMatriz];
            double valor;
            for (int i = 0; i < tamañoMatriz; i++)
            {
                for (int j = 0; j < tamañoMatriz; j++)
                {
                    valor = matrizCoeficientes[i][j];
                    matriz[i, j] = valor;                   
                }
            }

            return matriz;
        }
        public static double[] calculoAutoValores(List<List<double>> matrizCoeficientes, int tamañoMatriz)
        { 
            double[,] matriz= paseDeListAMatriz(matrizCoeficientes,tamañoMatriz);
            double[] autoValores;
            double[] parteImAutoValores;
            double[,] autoVectores;
            double[,] parteImAutoVectores;

            bool autovaloresCreados = alglib.rmatrixevd(matriz,tamañoMatriz,0,out autoValores,out parteImAutoValores, out autoVectores, out parteImAutoVectores);

            if (!autovaloresCreados) {
                MessageBox.Show("No se pudieron calcular los autovalores", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            return autoValores;
        }
    }
}

