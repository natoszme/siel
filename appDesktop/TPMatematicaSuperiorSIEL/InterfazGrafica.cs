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
    public partial class InterfazGrafica : Form
    {
        int tamañoMatriz;

        public InterfazGrafica(int cantidadEcuaciones)
        {
            tamañoMatriz = cantidadEcuaciones;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            generarInputs();
        }

        void generarInputs()
        {
            int posicionBaseX = 30;
            int posicionBaseY = 30;
            int distanciaEntreTextBoxX = 20;
            int distanciaEntreTextBoxY = 20;
            int tamanioTxtX = 20;
            int tamanioTxtY = 20;

            for (int i = 0; i < tamañoMatriz * tamañoMatriz; i++)
            {
                Label lblX = new Label();
                lblX.Text = "X" + i % tamañoMatriz + 1;
                int posXlbl = posicionBaseX + (i % tamañoMatriz) * (distanciaEntreTextBoxX + tamanioTxtX) + tamanioTxtX;
                int posYlbl = posicionBaseY + (i / tamañoMatriz) * (distanciaEntreTextBoxY + tamanioTxtY);
                lblX.SetBounds(posXlbl, posYlbl, tamanioTxtX, tamanioTxtY);
                this.Controls.Add(lblX);

                TextBox txt = new TextBox();
                txt.Name = "coeficiente" + i.ToString();
                int posX = posicionBaseX + (i % tamañoMatriz) * (distanciaEntreTextBoxX + tamanioTxtX);
                int posY = posicionBaseY + (i / tamañoMatriz) * (distanciaEntreTextBoxY + tamanioTxtY);
                txt.SetBounds(posX, posY, tamanioTxtX, tamanioTxtY);
                this.Controls.Add(txt);
            }

            int offsetTerminosIndependientes = 40;
            for (int i = 0; i < tamañoMatriz; i++)
            {
                Label lblX = new Label();
                lblX.Text = "=" ;
                int posXlbl = posicionBaseX + tamañoMatriz * (distanciaEntreTextBoxX + tamanioTxtX) + offsetTerminosIndependientes / 2;
                int posYlbl = posicionBaseY + i * (distanciaEntreTextBoxY + tamanioTxtY);
                lblX.SetBounds(posXlbl, posYlbl, tamanioTxtX, tamanioTxtY);
                this.Controls.Add(lblX);

                TextBox txt = new TextBox();
                txt.Name = "independiente" + i.ToString();
                int posX = posicionBaseX + tamañoMatriz * (distanciaEntreTextBoxX + tamanioTxtX) + offsetTerminosIndependientes;
                int posY = posicionBaseY + i * (distanciaEntreTextBoxY + tamanioTxtY);
                txt.SetBounds(posX, posY, tamanioTxtX, tamanioTxtY);
                this.Controls.Add(txt);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<List<double>> matrizCoeficientes = cargarMatrizCoeficientes();

            if (matrizCoeficientes == null)
            {
                MessageBox.Show("La matriz de coeficientes debe contener sólo números", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            List<double> terminosIndependientes = cargarVectorTerminosIndependientes();

            if (terminosIndependientes == null)
            {
                MessageBox.Show("La matriz de términos independientes debe contener sólo números", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool seguir = seguirEnBaseADiagonalidad(matrizCoeficientes);
            if (!seguir)
            {
                return;
            }

            //TODO limpiar la tabla
            if (rdbJacobi.Checked == true)
            {
                //SielSolver.JacobiSielSolver.resolver();
            }
            else
            {
                //SielSolver.GaussSeidelSielSolver.resolver();
            }
            
        }

        private bool seguirEnBaseADiagonalidad(List<List<double>> coeficientes)
        {
            
            AnalizadorMatriz.DiagonalidadMatriz tipoDiagonalidad = AnalizadorMatriz.obtenerDiagonalidad(coeficientes, tamañoMatriz);
            lblTipoMatriz.Text = "Tipo de matriz: ";
            lblTipoMatriz.Text += AnalizadorMatriz.aString(tipoDiagonalidad);

            if (tipoDiagonalidad == AnalizadorMatriz.DiagonalidadMatriz.NoDominante)
            {
                DialogResult respuestaNoDiagonalidad = MessageBox.Show("La matriz de coeficientes ingresada no es diagonalmente dominante. ¿Desea modificarla?", "Información", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (respuestaNoDiagonalidad == System.Windows.Forms.DialogResult.Yes)
                {
                    return false;
                }
            }

            return true;
        }

        private List<List<double>> cargarMatrizCoeficientes()
        {
            List<List<double>> matrizCoeficientes = new List<List<double>>();
            List<double> listaAux = new List<double>(); 
           
            for (int i = 0; i < tamañoMatriz; i++)
            {
                listaAux = obtenerVectorDeInputs("coeficiente", i);

                if (listaAux == null)
                {
                    return null;
                }

                matrizCoeficientes.Add(listaAux);
            }

            return matrizCoeficientes;
        }

        private List<double> cargarVectorTerminosIndependientes()
        {
            return obtenerVectorDeInputs("independiente", 0);
        }

        private List<double> obtenerVectorDeInputs(String nombreInput, int fila)
        {
            List<double> listaAux = new List<double>(); 

            for (int i = 0; i < tamañoMatriz; i++)
            {
                double respuesta = intentarObtenerCoeficiente(nombreInput + (i + fila * tamañoMatriz).ToString());

                if (double.IsNaN(respuesta))
                {
                    return null;
                }
                else
                {
                    listaAux.Add(respuesta);
                }
            }

            return listaAux;
        }

        private double intentarObtenerCoeficiente(String nombreInput)
        {
            String valorInput = this.Controls[nombreInput.ToString()].Text.ToString();
            valorInput = valorInput.Replace('.', ',');
            double respuesta;
            try
            {
                respuesta = Convert.ToDouble(valorInput);
            }
            catch(Exception e)
            {
                return double.NaN;
            }
            return respuesta;
        }  

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }    

    }
}
