using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Operario : Estrategia
    {
        private double Sueldo;

        public void SetSueldo(double sue)
        {
            this.Sueldo = sue;
        }

        public double CalcularBonoCargaSocial()
        {
            return this.Sueldo * 0.03;
        }

        public double CalcularBonoProductividad()
        {
            return this.Sueldo * 0.06;
        }

        public double CalcularDescuento5taCat()
        {
            return this.Sueldo * 0.08;
        }

        public double CalcularDescuentoAFP()
        {
            return this.Sueldo * 0.10;
        }

        public double CalcularNeto()
        {
            return this.Sueldo - CalcularDescuentoAFP() - CalcularDescuento5taCat() + CalcularBonoProductividad() + CalcularBonoCargaSocial();
        }

        public void DefinirEstrategia(int opc)
        {
        }
    }
}
