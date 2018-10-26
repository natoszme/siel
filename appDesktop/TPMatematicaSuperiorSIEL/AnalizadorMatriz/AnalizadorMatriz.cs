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

        public static DiagonalidadMatriz obtenerDiagonalidad(List<List<double>> coeficientes)
        {
            return DiagonalidadMatriz.NoDominante;
        }
    }
}
