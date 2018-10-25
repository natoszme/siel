using System.Collections.Generic;
namespace TPMatematicaSuperiorSIEL
{
    partial class Form1
    {
        int tamañoMatriz = 5;
        bool metodoJacobi = true;
        enum metodoDeResolucion{jacobi,gaussSeidel};
        enum tiposMatrizCoeficientes{dominante = "Dominante diagonalmente",estrictamenteDominante = "Estrictamente dominante diagonalmente",noDominante = "No dominante diagonalmente"};

        List<List<double>> matrizCoeficientes = new List<List<double>>();
        List<double> incognitas;
        List<double> terminosIndependientes;
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
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


        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(171, 212);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Resolver";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Resolucion";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
    }
}

