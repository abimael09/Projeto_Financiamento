using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjetoFinanciamento
{
    class Program
    {
        static void Main(string[] args)
        {
            // classe cliente - composição
            Cliente cli1 = new Cliente();
            cli1.nome = "Sandra";
            cli1.endereco = "Rua c";
            Veiculo v1 = new Veiculo(cli1,20000,40);
            v1.titular = cli1;
            v1.titular.cpf = "456";
            
            Cliente cli2 = new Cliente();
            cli2.nome = "João";
            cli2.endereco = "Rua D";
            Veiculo v2 = new Veiculo();
            v2.titular = cli2;
            v2.SetValor(30000);
            v2.quantParcelas = 40;

            Habitacional h1 = new Habitacional(cli2,170000,1000);
            h1.titular = cli2;

            double totalV1 = v1.CalculaTotal();
            double totalV2 = v2.CalculaTotal();
            double totalH1 = h1.CalculaTotal();
            Financiamento[] financas = new Financiamento[3];
            financas[0] = v1;
            financas[1] = v2;
            financas[2] = h1;
            for (int cont = 0; cont < financas.Length;cont++ )
            {
                Console.WriteLine("Proprietario = " + financas[cont].titular.nome);
                Console.WriteLine("Total a pagar = " + financas[cont].GetTotal());
            }
            Console.WriteLine("----- usando foreach ------");
            // usando o foreach
            foreach(Financiamento fin in financas)
            {
                Console.WriteLine("Proprietario = " + fin.titular.nome);
                Console.WriteLine("Total a pagar = " + fin.GetTotal());
            }
            Console.ReadKey();
        }
    }
}
