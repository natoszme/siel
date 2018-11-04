using System.Collections.Generic;
namespace TPMatematicaSuperiorSIEL
{
    partial class InterfazGrafica
    {
        
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

       


        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnResolver = new System.Windows.Forms.Button();
            this.rdbGaussSeidel = new System.Windows.Forms.RadioButton();
            this.rdbJacobi = new System.Windows.Forms.RadioButton();
            this.lblTipoMatriz = new System.Windows.Forms.Label();
            this.volver = new System.Windows.Forms.Button();
            this.btnNorma1 = new System.Windows.Forms.Button();
            this.btnNorma2 = new System.Windows.Forms.Button();
            this.btnNormaInfinito = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnResolver
            // 
            this.btnResolver.Location = new System.Drawing.Point(360, 429);
            this.btnResolver.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnResolver.Name = "btnResolver";
            this.btnResolver.Size = new System.Drawing.Size(112, 35);
            this.btnResolver.TabIndex = 0;
            this.btnResolver.Text = "Resolver";
            this.btnResolver.UseVisualStyleBackColor = true;
            this.btnResolver.Click += new System.EventHandler(this.button1_Click);
            // 
            // rdbGaussSeidel
            // 
            this.rdbGaussSeidel.AutoSize = true;
            this.rdbGaussSeidel.Location = new System.Drawing.Point(84, 465);
            this.rdbGaussSeidel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdbGaussSeidel.Name = "rdbGaussSeidel";
            this.rdbGaussSeidel.Size = new System.Drawing.Size(130, 24);
            this.rdbGaussSeidel.TabIndex = 2;
            this.rdbGaussSeidel.TabStop = true;
            this.rdbGaussSeidel.Text = "Gauss-Seidel";
            this.rdbGaussSeidel.UseVisualStyleBackColor = true;
            // 
            // rdbJacobi
            // 
            this.rdbJacobi.AutoSize = true;
            this.rdbJacobi.Checked = true;
            this.rdbJacobi.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::TPMatematicaSuperiorSIEL.Properties.Settings.Default, "Jacobi", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.rdbJacobi.Location = new System.Drawing.Point(84, 429);
            this.rdbJacobi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdbJacobi.Name = "rdbJacobi";
            this.rdbJacobi.Size = new System.Drawing.Size(80, 24);
            this.rdbJacobi.TabIndex = 1;
            this.rdbJacobi.TabStop = true;
            this.rdbJacobi.Text = global::TPMatematicaSuperiorSIEL.Properties.Settings.Default.Jacobi;
            this.rdbJacobi.UseVisualStyleBackColor = true;
            this.rdbJacobi.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // lblTipoMatriz
            // 
            this.lblTipoMatriz.AutoSize = true;
            this.lblTipoMatriz.Location = new System.Drawing.Point(388, 37);
            this.lblTipoMatriz.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTipoMatriz.Name = "lblTipoMatriz";
            this.lblTipoMatriz.Size = new System.Drawing.Size(116, 20);
            this.lblTipoMatriz.TabIndex = 3;
            this.lblTipoMatriz.Text = "Tipo de matriz: ";
            // 
            // volver
            // 
            this.volver.Location = new System.Drawing.Point(528, 429);
            this.volver.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.volver.Name = "volver";
            this.volver.Size = new System.Drawing.Size(112, 35);
            this.volver.TabIndex = 4;
            this.volver.Text = "Volver";
            this.volver.UseVisualStyleBackColor = true;
            this.volver.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnNorma1
            // 
            this.btnNorma1.Location = new System.Drawing.Point(528, 228);
            this.btnNorma1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnNorma1.Name = "btnNorma1";
            this.btnNorma1.Size = new System.Drawing.Size(112, 35);
            this.btnNorma1.TabIndex = 5;
            this.btnNorma1.Text = "Norma 1";
            this.btnNorma1.UseVisualStyleBackColor = true;
            this.btnNorma1.Click += new System.EventHandler(this.btnNorma1_Click);
            // 
            // btnNorma2
            // 
            this.btnNorma2.Location = new System.Drawing.Point(528, 289);
            this.btnNorma2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnNorma2.Name = "btnNorma2";
            this.btnNorma2.Size = new System.Drawing.Size(112, 35);
            this.btnNorma2.TabIndex = 6;
            this.btnNorma2.Text = "Norma 2";
            this.btnNorma2.UseVisualStyleBackColor = true;
            this.btnNorma2.Click += new System.EventHandler(this.btnNorma2_Click);
            // 
            // btnNormaInfinito
            // 
            this.btnNormaInfinito.Location = new System.Drawing.Point(528, 352);
            this.btnNormaInfinito.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnNormaInfinito.Name = "btnNormaInfinito";
            this.btnNormaInfinito.Size = new System.Drawing.Size(112, 35);
            this.btnNormaInfinito.TabIndex = 7;
            this.btnNormaInfinito.Text = "Norma ∞";
            this.btnNormaInfinito.UseVisualStyleBackColor = true;
            this.btnNormaInfinito.Click += new System.EventHandler(this.btnNormaInfinito_Click);
            // 
            // InterfazGrafica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 520);
            this.Controls.Add(this.btnNormaInfinito);
            this.Controls.Add(this.btnNorma2);
            this.Controls.Add(this.btnNorma1);
            this.Controls.Add(this.volver);
            this.Controls.Add(this.lblTipoMatriz);
            this.Controls.Add(this.rdbGaussSeidel);
            this.Controls.Add(this.rdbJacobi);
            this.Controls.Add(this.btnResolver);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "InterfazGrafica";
            this.Text = "Interfaz Grafica";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnResolver;
        private System.Windows.Forms.RadioButton rdbJacobi;
        private System.Windows.Forms.RadioButton rdbGaussSeidel;
        private System.Windows.Forms.Label lblTipoMatriz;
        private System.Windows.Forms.Button volver;
        private System.Windows.Forms.Button btnNorma1;
        private System.Windows.Forms.Button btnNorma2;
        private System.Windows.Forms.Button btnNormaInfinito;
    }
}

