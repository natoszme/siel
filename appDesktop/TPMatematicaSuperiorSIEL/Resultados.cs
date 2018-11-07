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
    public partial class Resultados : Form
    {

        public List<PasoDeResolucion> resultados = new List<PasoDeResolucion>();

        public Resultados(List<PasoDeResolucion> resultados)
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
            dgvResultados.ColumnCount = resultados[0].valoresDeIncognitas.Count + resultados[0].cumpleCriterioDeParo.Count;
            for (int r = 0; r < resultados[0].valoresDeIncognitas.Count; r++)
            {
                dgvResultados.Columns[r].HeaderText = "X" + r;
            }
            for (int r = 0; r < resultados[0].cumpleCriterioDeParo.Count; r++)
            {
                switch(r){
                    case 0:{
                        dgvResultados.Columns[r + resultados[0].valoresDeIncognitas.Count].HeaderText = "Criterio Absoluto";
                    }break;
                    case 1:
                    {
                        dgvResultados.Columns[r + resultados[0].valoresDeIncognitas.Count].HeaderText = "Criterio Relativo";
                    } break;
                }
                
            }
            for (int r = 0; r < resultados.Count; r++)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dgvResultados);

                for (int c = 0; c < resultados[0].valoresDeIncognitas.Count; c++)
                {
                    row.Cells[c].Value = resultados[r].valoresDeIncognitas[c];
                }
                for (int cCriterio = 0; cCriterio < resultados[0].cumpleCriterioDeParo.Count; cCriterio++)
                {
                    row.Cells[resultados[0].valoresDeIncognitas.Count + cCriterio].Value = resultados[r].cumpleCriterioDeParo[cCriterio];
         
                }

                dgvResultados.Rows.Add(row);
            }
        }
    }
}
