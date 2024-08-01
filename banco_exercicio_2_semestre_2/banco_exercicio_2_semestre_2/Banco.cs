using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace banco_exercicio_2_semestre_2
{
    public class Banco
    {
        public int numeroConta { get; set; }
        public string nome {  get; set; }
        public double limite { get; set; }
        public double saldo { get; set; }

        public void Sacar(double valor) 
        {
            Console.WriteLine($"Sacando Valor de R$ {valor} da sua Conta.\n");
            saldo -= valor;
        }
        public void Depositar(double valor) 
        {
            Console.WriteLine($"Depositando Valor de R$ {valor} da sua Conta.\n");
            saldo += valor;
        }

        public void Consultar() 
        {
            Console.WriteLine("Dados da Conta Bancária");
            Console.WriteLine($"Número Conta: {numeroConta}");
            Console.WriteLine($"Nome: {nome}");
            Console.WriteLine($"Limite da Conta: R$ {limite}");
            Console.WriteLine($"Saldo Atual: R$ {saldo}");
        }
    }
}
