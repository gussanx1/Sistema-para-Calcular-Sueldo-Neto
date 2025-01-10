using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controlador;

namespace Vista
{
    public partial class PagoTrabajador : Form
    {
        public PagoTrabajador()
        {
            InitializeComponent();
        }

        private void PagoTrabajador_Load(object sender, EventArgs e)
        {

        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
           ContexoEstrategia obj = new ContexoEstrategia();

            if (cbCategoria.SelectedIndex == 0)
                obj.DefinirEstrategia(1);
            if (cbCategoria.SelectedIndex == 1)
                obj.DefinirEstrategia(2);
            if (cbCategoria.SelectedIndex == 2)
                obj.DefinirEstrategia(3);

            txtafp.Text = obj.Getdesafp().ToString();
            txtcate.Text = obj.Getdescat().ToString();
            txtprodu.Text = obj.Getbopro().ToString();
            txtneto.Text = obj.Getneto().ToString();

        }
    }
}
