﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPMatematicaSuperiorSIEL.SielSolver
{
    public abstract class SielSolver
    {
        public List<CriterioDeParo.CriterioDeParo> criteriosDeParo = new List<CriterioDeParo.CriterioDeParo>();
        public List<PasoDeResolucion> pasos = new List<PasoDeResolucion>();

        protected int cantDecimales;
        public SielSolver(double epsilon,int cantDecimales)
        {
            criteriosDeParo.Add(new CriterioDeParo.CriterioAbsoluto(epsilon));
            criteriosDeParo.Add(new CriterioDeParo.CriterioRelativo(epsilon));
            this.cantDecimales = cantDecimales;
        }


        public void resolver(List<double> vectorInicial,List<List<double>> matrizCoeficientes, int cantidadEcuaciones, List<double> terminosIndependientes)
        {
            
            PasoDeResolucion paso = new PasoDeResolucion();
            paso.setearValoresDeIncognitas(vectorInicial);
           
             List<double> vectorCalculado = resolverSegunEstrategia(matrizCoeficientes,cantidadEcuaciones,terminosIndependientes,vectorInicial);
             
            //Cargo al paso de resolucion el resultado del criterio de paro para esa iteracion
            criteriosDeParo.ForEach(criterio=> paso.cargarCriterio(criterio.hayQueSeguir(vectorInicial,vectorCalculado)));
            pasos.Add(paso);
            if (pasos.Count >= 200)
            {
                Resultados formResultados = new Resultados(pasos);
                formResultados.ShowDialog();
                return;
            }
            if (criteriosDeParo.Any(criterio => criterio.hayQueSeguir(vectorInicial, vectorCalculado)))
            {
                resolver(vectorCalculado, matrizCoeficientes, cantidadEcuaciones, terminosIndependientes);
            }
            else
            {
                /*PasoDeResolucion pasoFinal = new PasoDeResolucion();
                pasoFinal.setearValoresDeIncognitas(vectorCalculado);
                criteriosDeParo.ForEach(criterio => pasoFinal.cargarCriterioFinal());

                pasos.Add(pasoFinal); */
                
                Resultados formResultados = new Resultados(pasos);
                formResultados.ShowDialog();
            }
        }

        protected abstract List<double> resolverSegunEstrategia(List<List<double>> matrizCoeficientes, int tamanioMatrizCoeficientes, List<double> terminosIndependientes, List<double> incognitas);
    }
}
