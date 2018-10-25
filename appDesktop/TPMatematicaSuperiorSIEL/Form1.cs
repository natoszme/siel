﻿using System;
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
    public partial class Form1 : Form
    {
        int tamañoMatriz = 5;
        bool metodoJacobi = true;
        enum metodoDeResolucion { jacobi, gaussSeidel };
        enum tiposMatrizCoeficientes { dominante = 0, estrictamenteDominante = 1, noDominante = 2 };

        List<List<double>> matrizCoeficientes = new List<List<double>>();
        List<double> incognitas;
        List<double> terminosIndependientes;

        public Form1()
        {
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

           /* Label lbl = new Label();
            lbl.Text = "Coeficientes";
            lbl.SetBounds(posicionBaseX, 10, 150, tamanioTxtY);
            this.Controls.Add(lbl);*/

            for (int i = 0; i < largo*largo; i++)
            {
                TextBox txt = new TextBox();
                txt.Name = i.ToString();
                int posX = posicionBaseX + (i % largo) * (distanciaEntreTextBoxX+tamanioTxtX);
                int posY = posicionBaseY + (i/largo) * (distanciaEntreTextBoxY+ tamanioTxtY);
                txt.SetBounds(posX, posY, tamanioTxtX, tamanioTxtY);
                this.Controls.Add(txt);

                Label lblX = new Label();
                lblX.Text = "X" + i%largo+1;
                int posXlbl = posicionBaseX + (i % largo) * (distanciaEntreTextBoxX + tamanioTxtX) + tamanioTxtX;
                int posYlbl = posicionBaseY + (i / largo) * (distanciaEntreTextBoxY + tamanioTxtY);
                lblX.SetBounds(posXlbl, posYlbl, tamanioTxtX, tamanioTxtY);
                this.Controls.Add(lblX);

            }

            int offsetTerminosIndependientes = 40;
            /*Label lblIndependientes = new Label();
            lblIndependientes.Text = "Terminos independientes";
            int posXlblInd = posicionBaseX + largo * (distanciaEntreTextBoxX + tamanioTxtX) + offsetTerminosIndependientes - 40;
            lblIndependientes.SetBounds(posXlblInd, 10, 300, tamanioTxtY);
            this.Controls.Add(lblIndependientes);
            */
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
            List<List<double>> matrizCoeficientes = new List<List<double>>();
            List<double> incognitas;
             List<double> terminosIndependientes;
            
        }

        tiposMatrizCoeficientes analizarMatrizCoeficientes(List<List<double>> matrizCoeficientes, int tamaño)
        {

            return tiposMatrizCoeficientes.dominante;
        }

        bool cumpleCriterioParo()
        {
            //Hay que codear el criterio de los errores para cortar y modificar la firma acordemente
            return false;
        }

        public void resolverSIELporJacobi(List<List<double>> matrizCoeficientes, int tamañoMatrizCoeficientes, List<double> terminosIndependientes, List<double> incognitas)
        {
            if (!cumpleCriterioParo())
            {
                List<double> proximasIncognitas = new List<double>();
                for (int i = 0; i < tamañoMatrizCoeficientes; i++)
                {
                    double proximoValor = terminosIndependientes[i];
                    for (int j = 0; j < tamañoMatrizCoeficientes; j++)
                    {
                        if (i != j)
                        {
                            proximoValor -= matrizCoeficientes[i][j] * incognitas[j];
                        }
                    }
                    proximoValor = proximoValor / matrizCoeficientes[i][i];
                    proximasIncognitas.Insert(i, proximoValor);
                }
                System.Threading.Thread.Sleep(3);
                resolverSIELporJacobi(matrizCoeficientes, tamañoMatrizCoeficientes, terminosIndependientes, proximasIncognitas);
            }


        }

      

    }
}
