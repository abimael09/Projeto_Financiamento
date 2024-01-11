using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjetoFinanciamento
{
    abstract class Financiamento
    {
        public Cliente titular;
        private double valor;
        public int quantParcelas;
        private double total;

        // métodos sets e gets
        public void SetValor(double valor)
        {
            this.valor = valor;
        }
        public double GetValor()
        {
            return valor;
        }
        public void SetTotal(double total)
        {
            this.total = total;
        }
        public double GetTotal()
        {
            return total;
        }
        // construtores
        public Financiamento() { }
        public Financiamento(Cliente titular, double valor, int quantParcelas)
        {
            this.titular = titular;
            this.valor = valor;
            this.quantParcelas = quantParcelas;
        }

        // outros métodos
        public abstract double CalculaTotal();
    }
}
