using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlador
{
    public class ContexoEstrategia : Estrategia
    {
        private double desafp;
        private double descat;
        private double bocaso;
        private double bopro;
        private double neto;
        private double basico;

        public double Getdesafp()
        {
            return this.desafp;
        }
        public double Getdescat()
        {
            return this.descat;
        }
        public double Getbocaso()
        {
            return this.bocaso;
        }
        public double Getbopro()
        {
            return this.bopro;
        }
        public double Getneto()
        {
            return this.neto;
        }

        public double CalcularDescuentoAFP()
        {
            return 0;
        }
        public double CalcularDescuento5taCat()
        {
            return 0;
        }
        public double CalcularBonoCargaSocial()
        {
            return 0;
        }
        public double CalcularBonoProductividad()
        {
            return 0;
        }
        public double CalcularNeto()
        {
            return 0;
        }
        public void DefinirEstrategia(int opc)
        {
            RepositorioEmpresa oEmpresa = new RepositorioEmpresa();
            oEmpresa.ConexionSQL("select * from Trabajador");

            if (opc == 1)
            {
                Administrativo adm = new Administrativo();
                adm.SetSueldo(5000);
                this.desafp = adm.CalcularDescuentoAFP();
                this.descat = adm.CalcularDescuento5taCat();
                this.bocaso = adm.CalcularBonoCargaSocial();
                this.bopro = adm.CalcularBonoProductividad();
                this.neto = adm.CalcularNeto();
                
            }
            if (opc == 2)
            {
                Operario ope = new Operario();
                ope.SetSueldo(3000);
                this.desafp = ope.CalcularDescuentoAFP();
                this.descat = ope.CalcularDescuento5taCat();
                this.bocaso = ope.CalcularBonoCargaSocial();
                this.bopro = ope.CalcularBonoProductividad();
                this.neto = ope.CalcularNeto();

            }
            if (opc == 3)
            {
                Obrero obr = new Obrero();
                obr.SetSueldo(2000);
                this.desafp = obr.CalcularDescuentoAFP();
                this.descat = obr.CalcularDescuento5taCat();
                this.bocaso = obr.CalcularBonoCargaSocial();
                this.bopro = obr.CalcularBonoProductividad();
                this.neto = obr.CalcularNeto();

            }
        }
    }
}
