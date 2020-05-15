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
    public partial class Form1 : Form
    {
        Validacion V = new Validacion();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSalirInicioSesion_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Adios");//Mensaje de adios
            Application.Exit();
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            if(cmbUsuarioInicioSesion.SelectedItem.ToString()== "Administrador" && txtContrasenia.Text == "12345")
            {
                Opciones form2 = new Opciones();
                form2.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Contraseña o usuario incorrectos");
            }
        }
    }
}
