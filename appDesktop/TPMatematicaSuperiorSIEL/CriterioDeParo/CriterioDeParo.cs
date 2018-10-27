﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPMatematicaSuperiorSIEL.CriterioDeParo
{
    public abstract class CriterioDeParo
    {
        public double epsilon;

        public CriterioDeParo(double epsilon)
        {
            this.epsilon = epsilon;
        }

        public bool hayQueSeguir(List<double> vectorAnterior, List<double> vectorActual) {
            double normaInfinita = this.valorDeReferencia(vectorAnterior, vectorActual);
            return normaInfinita >= epsilon;
        }

        protected double valorDeReferencia(List<double> vectorAnterior, List<double> vectorActual)
        {
            List<Double> vectorResultado = vectorActual.Zip(vectorAnterior, (actual, anterior) => actual - anterior).ToList();
            return AnalizadorMatriz.normaInfinita(vectorResultado);
        }
    }
}
