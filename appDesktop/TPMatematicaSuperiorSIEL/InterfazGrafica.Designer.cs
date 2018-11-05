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
            this.normas = new System.Windows.Forms.ComboBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnResolver
            // 
            this.btnResolver.Location = new System.Drawing.Point(376, 437);
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
            this.rdbGaussSeidel.Location = new System.Drawing.Point(26, 465);
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
            this.rdbJacobi.Location = new System.Drawing.Point(26, 431);
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
            this.volver.Location = new System.Drawing.Point(528, 424);
            this.volver.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.volver.Name = "volver";
            this.volver.Size = new System.Drawing.Size(112, 60);
            this.volver.TabIndex = 4;
            this.volver.Text = "Volver al comienzo";
            this.volver.UseVisualStyleBackColor = true;
            this.volver.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // normas
            // 
            this.normas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.normas.FormattingEnabled = true;
            this.normas.Items.AddRange(new object[] {
            "1",
            "2",
            "Infinita"});
            this.normas.Location = new System.Drawing.Point(101, 384);
            this.normas.Name = "normas";
            this.normas.Size = new System.Drawing.Size(121, 28);
            this.normas.TabIndex = 8;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(250, 380);
            this.btnCalcular.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(112, 35);
            this.btnCalcular.TabIndex = 9;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 387);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Norma";
            // 
            // InterfazGrafica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 520);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.normas);
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
        private System.Windows.Forms.ComboBox normas;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label label1;
    }
}

