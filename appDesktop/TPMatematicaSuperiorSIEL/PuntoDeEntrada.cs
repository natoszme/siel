using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPMatematicaSuperiorSIEL
{
    public partial class PuntoDeEntrada : Form
    {
        public PuntoDeEntrada()
        {
            InitializeComponent();
        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            try
            {
                int cantidadEcuaciones = int.Parse( txtCant.Text);
                InterfazGrafica formRoles = new InterfazGrafica(cantidadEcuaciones);
                this.Hide();
                formRoles.Show();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Debe ingresar un numero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
        }       
    }
}
