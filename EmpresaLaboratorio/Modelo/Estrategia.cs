using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public interface Estrategia
    {
        double CalcularBonoCargaSocial();
        double CalcularBonoProductividad();
        double CalcularDescuento5taCat();
        double CalcularDescuentoAFP();
        double CalcularNeto();
        void DefinirEstrategia(int opc);
    }
}
