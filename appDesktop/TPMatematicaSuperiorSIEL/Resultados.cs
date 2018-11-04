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
    public partial class Resultados : Form
    {

        public List<List<Double>> resultados = new List<List<double>>();

        public Resultados(List<List<Double>> resultados)
        {
            this.resultados = resultados;
            InitializeComponent();
        }

        private void Resultados_Load(object sender, EventArgs e)
        {
            mostrarResultadosEnTabla();
        }

        void mostrarResultadosEnTabla()
        {
            dgvResultados.ColumnCount = resultados[0].Count;
            for (int r = 0; r < resultados.Count; r++)
            {
                dgvResultados.Columns[r].HeaderText = "X" + r;
            }
            for (int r = 0; r < resultados.Count; r++)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dgvResultados);

                for (int c = 0; c < resultados[0].Count; c++)
                {
                    row.Cells[c].Value = resultados[r][c];
                }

                dgvResultados.Rows.Add(row);
            }
        }
    }
}
