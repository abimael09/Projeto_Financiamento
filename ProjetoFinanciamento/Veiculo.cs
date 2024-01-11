using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjetoFinanciamento
{
    class Veiculo : Financiamento
    {
        private double ipi;

        // metodos sets e gets
        public void SetIpi(double ipi)
        {
            this.ipi = ipi;
        }
        public double GetIpi()
        {
            return ipi;
        }
        // construtores
        public Veiculo() { }
        public Veiculo(Cliente titular, double valor, int quantParcelas) : 
            base(titular,valor,quantParcelas)
        {
            this.ipi = GetValor() * 2 / 100;
        }
        // outros métodos
        public override double CalculaTotal()
        {
            this.ipi = GetValor() * 2 / 100;
            double calculoTotal = GetValor() + ipi;
            SetTotal(calculoTotal);
            return calculoTotal;
        }
    }
}
