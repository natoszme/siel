using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPMatematicaSuperiorSIEL.CriterioDeParo
{
    public interface CriterioDeParo
    {
        bool hayQueSeguir(List<double> vectorAnterior, List<double> vectorActual);
    }
}
