using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjetoFinanciamento
{
    class Habitacional : Financiamento
    {
        private double itiv;
        // métodos sets e gets
        public void SetItiv(double itiv)
        {
            this.itiv = itiv;
        }
        public double GetItiv()
        {
            return itiv;
        }
        // construtores
        public Habitacional() { }
        public Habitacional(Cliente titular, double valor, int quantParcelas)
            : base (titular, valor, quantParcelas)
        {
            itiv = GetValor() * 4 / 100;
        }
        // outros métodos
        public override double CalculaTotal()
        {
            itiv = GetValor() * 4 / 100;
            double calculaTotal = GetValor() + itiv;
            SetTotal(calculaTotal);
            return calculaTotal;
        } 
    }
}
