using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public static double norma1(List<List<double>> matriz, int tamanioMatriz)
        {
            List<double> sumatorias = new List<double>();
            for (int columna = 0; columna < tamanioMatriz; columna++)
            {
                double valor = 0;
                for (int fila = 0; fila < tamanioMatriz; fila++)
                {
                    valor += Math.Abs(matriz[fila][columna]);
                }
                sumatorias.Add(valor);
            }
            return sumatorias.Max();
        }
    }
}
