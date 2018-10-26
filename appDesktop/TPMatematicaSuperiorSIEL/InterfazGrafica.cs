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
        enum tiposMatrizCoeficientes { dominante = 0, estrictamenteDominante = 1, noDominante = 2 };

        public InterfazGrafica(int cantidadEcuaciones)
        {
            tamañoMatriz = cantidadEcuaciones;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            generarInputs(tamañoMatriz);
        }

        void generarInputs(int largo)
        {
            int posicionBaseX = 30;
            int posicionBaseY = 30;
            int distanciaEntreTextBoxX = 20;
            int distanciaEntreTextBoxY = 20;
            int tamanioTxtX = 20;
            int tamanioTxtY = 20;

            for (int i = 0; i < largo*largo; i++)
            {
                Label lblX = new Label();
                lblX.Text = "X" + i % largo + 1;
                int posXlbl = posicionBaseX + (i % largo) * (distanciaEntreTextBoxX + tamanioTxtX) + tamanioTxtX;
                int posYlbl = posicionBaseY + (i / largo) * (distanciaEntreTextBoxY + tamanioTxtY);
                lblX.SetBounds(posXlbl, posYlbl, tamanioTxtX, tamanioTxtY);
                this.Controls.Add(lblX);

                TextBox txt = new TextBox();
                txt.Name = "coeficiente" + i.ToString();
                int posX = posicionBaseX + (i % largo) * (distanciaEntreTextBoxX+tamanioTxtX);
                int posY = posicionBaseY + (i/largo) * (distanciaEntreTextBoxY+ tamanioTxtY);
                txt.SetBounds(posX, posY, tamanioTxtX, tamanioTxtY);
                this.Controls.Add(txt);
            }

            int offsetTerminosIndependientes = 40;
            for (int i = 0; i < largo; i++)
            {
                Label lblX = new Label();
                lblX.Text = "=" ;
                int posXlbl = posicionBaseX + largo * (distanciaEntreTextBoxX + tamanioTxtX) + offsetTerminosIndependientes/2;
                int posYlbl = posicionBaseY + i * (distanciaEntreTextBoxY + tamanioTxtY);
                lblX.SetBounds(posXlbl, posYlbl, tamanioTxtX, tamanioTxtY);
                this.Controls.Add(lblX);

                TextBox txt = new TextBox();
                txt.Name = "independiente" + i.ToString();
                int posX = posicionBaseX + largo * (distanciaEntreTextBoxX + tamanioTxtX) + offsetTerminosIndependientes;
                int posY = posicionBaseY + i * (distanciaEntreTextBoxY + tamanioTxtY);
                txt.SetBounds(posX, posY, tamanioTxtX, tamanioTxtY);
                this.Controls.Add(txt);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<List<double>> matrizCoeficientes = cargarMatrizCoeficientes();
            validarCoeficientes(matrizCoeficientes);            

            List<double> terminosIndependientes = cargarVectorTerminosIndependientes();
            validarTerminosIndependientes(terminosIndependientes);

            List<double> incognitas;
            if (rdbJacobi.Enabled == true)
            {

            }
            else
            {

            }
            
        }

        private void validarCoeficientes(List<List<double>> matrizCoeficientes)
        {
            if (matrizCoeficientes == null)
            {
                MessageBox.Show("La matriz de coeficientes debe contener sólo números", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void validarTerminosIndependientes(List<double> terminosIndependientes)
        {
            if (terminosIndependientes == null)
            {
                MessageBox.Show("La matriz de términos independientes debe contener sólo números", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
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

        tiposMatrizCoeficientes analizarMatrizCoeficientes(List<List<double>> matrizCoeficientes, int tamaño)
        {

            return tiposMatrizCoeficientes.dominante;
        }       

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }    

    }
}
