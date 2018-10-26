using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPMatematicaSuperiorSIEL.AnalizadorMatriz
{
    public static class AnalizadorMatriz
    {
        public enum DiagonalidadMatriz
        {
            Dominante,
            EstrictamenteDominante,
            NoDominante
        }

        public static DiagonalidadMatriz obtenerDiagonalidad(List<List<double>> coeficientes, int tamanioMatriz)
        {
            bool esEstrictamenteDominante = true;

            for (int fila = 0; fila < tamanioMatriz ; fila++)
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
    }
}
