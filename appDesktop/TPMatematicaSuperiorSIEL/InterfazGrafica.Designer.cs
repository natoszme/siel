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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InterfazGrafica));
            this.btnResolver = new System.Windows.Forms.Button();
            this.rdbGaussSeidel = new System.Windows.Forms.RadioButton();
            this.rdbJacobi = new System.Windows.Forms.RadioButton();
            this.lblTipoMatriz = new System.Windows.Forms.Label();
            this.volver = new System.Windows.Forms.Button();
            this.normas = new System.Windows.Forms.ComboBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.numUDEpsilon = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.cantidadDecimales = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numUDEpsilon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cantidadDecimales)).BeginInit();
            this.SuspendLayout();
            // 
            // btnResolver
            // 
            this.btnResolver.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnResolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResolver.Location = new System.Drawing.Point(489, 414);
            this.btnResolver.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnResolver.Name = "btnResolver";
            this.btnResolver.Size = new System.Drawing.Size(126, 82);
            this.btnResolver.TabIndex = 0;
            this.btnResolver.Text = "Resolver";
            this.btnResolver.UseVisualStyleBackColor = false;
            this.btnResolver.Click += new System.EventHandler(this.button1_Click);
            // 
            // rdbGaussSeidel
            // 
            this.rdbGaussSeidel.AutoSize = true;
            this.rdbGaussSeidel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbGaussSeidel.ForeColor = System.Drawing.SystemColors.Control;
            this.rdbGaussSeidel.Location = new System.Drawing.Point(52, 460);
            this.rdbGaussSeidel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdbGaussSeidel.Name = "rdbGaussSeidel";
            this.rdbGaussSeidel.Size = new System.Drawing.Size(156, 29);
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
            this.rdbJacobi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbJacobi.ForeColor = System.Drawing.SystemColors.Control;
            this.rdbJacobi.Location = new System.Drawing.Point(52, 426);
            this.rdbJacobi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdbJacobi.Name = "rdbJacobi";
            this.rdbJacobi.Size = new System.Drawing.Size(95, 29);
            this.rdbJacobi.TabIndex = 1;
            this.rdbJacobi.TabStop = true;
            this.rdbJacobi.Text = global::TPMatematicaSuperiorSIEL.Properties.Settings.Default.Jacobi;
            this.rdbJacobi.UseVisualStyleBackColor = true;
            this.rdbJacobi.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // lblTipoMatriz
            // 
            this.lblTipoMatriz.AutoSize = true;
            this.lblTipoMatriz.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoMatriz.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTipoMatriz.Location = new System.Drawing.Point(519, 31);
            this.lblTipoMatriz.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTipoMatriz.Name = "lblTipoMatriz";
            this.lblTipoMatriz.Size = new System.Drawing.Size(146, 25);
            this.lblTipoMatriz.TabIndex = 3;
            this.lblTipoMatriz.Text = "Tipo de matriz: ";
            // 
            // volver
            // 
            this.volver.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.volver.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.volver.Location = new System.Drawing.Point(652, 414);
            this.volver.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.volver.Name = "volver";
            this.volver.Size = new System.Drawing.Size(182, 82);
            this.volver.TabIndex = 4;
            this.volver.Text = "Volver al comienzo";
            this.volver.UseVisualStyleBackColor = false;
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
            this.normas.Location = new System.Drawing.Point(128, 378);
            this.normas.Name = "normas";
            this.normas.Size = new System.Drawing.Size(121, 28);
            this.normas.TabIndex = 8;
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(278, 375);
            this.btnCalcular.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(112, 46);
            this.btnCalcular.TabIndex = 9;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(50, 382);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "Norma";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(278, 443);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(112, 46);
            this.btnLimpiar.TabIndex = 11;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(484, 343);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 25);
            this.label2.TabIndex = 12;
            this.label2.Text = "Epsilon";
            // 
            // numUDEpsilon
            // 
            this.numUDEpsilon.DecimalPlaces = 8;
            this.numUDEpsilon.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.numUDEpsilon.Location = new System.Drawing.Point(489, 374);
            this.numUDEpsilon.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numUDEpsilon.Name = "numUDEpsilon";
            this.numUDEpsilon.Size = new System.Drawing.Size(126, 26);
            this.numUDEpsilon.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(647, 343);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(187, 25);
            this.label3.TabIndex = 14;
            this.label3.Text = "Cantidad Decimales";
            // 
            // cantidadDecimales
            // 
            this.cantidadDecimales.Location = new System.Drawing.Point(652, 373);
            this.cantidadDecimales.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cantidadDecimales.Name = "cantidadDecimales";
            this.cantidadDecimales.Size = new System.Drawing.Size(126, 26);
            this.cantidadDecimales.TabIndex = 15;
            // 
            // InterfazGrafica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(847, 529);
            this.Controls.Add(this.cantidadDecimales);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numUDEpsilon);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.normas);
            this.Controls.Add(this.volver);
            this.Controls.Add(this.lblTipoMatriz);
            this.Controls.Add(this.rdbGaussSeidel);
            this.Controls.Add(this.rdbJacobi);
            this.Controls.Add(this.btnResolver);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "InterfazGrafica";
            this.Text = "Sistemas de ecuaciones lineales";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numUDEpsilon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cantidadDecimales)).EndInit();
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
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numUDEpsilon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown cantidadDecimales;
    }
}

