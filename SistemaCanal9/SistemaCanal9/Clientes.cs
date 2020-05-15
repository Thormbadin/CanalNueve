using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaCanal9
{
    public partial class Clientes : Form
    {
        Validacion V = new Validacion();
        public Clientes()
        {
            InitializeComponent();
        }

        private void txtNombresyApellidosClientes_KeyPress(object sender, KeyPressEventArgs e)
        {
            V.sololetras(e);
        }

        private void txtCedulaCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            V.solonumeros(e);
        }

        private void txtTelefonoClientes_KeyPress(object sender, KeyPressEventArgs e)
        {
            V.solonumeros(e);
        }

        private void txtTelefonoAlternativoClientes_KeyPress(object sender, KeyPressEventArgs e)
        {
            V.solonumeros(e);
        }
    }
}
