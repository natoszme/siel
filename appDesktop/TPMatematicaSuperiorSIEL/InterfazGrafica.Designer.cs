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
            this.button1 = new System.Windows.Forms.Button();
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(526, 429);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 35);
            this.button1.TabIndex = 4;
            this.button1.Text = "Resolver";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // InterfazGrafica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 520);
            this.Controls.Add(this.button1);
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
        private System.Windows.Forms.Button button1;
    }
}

