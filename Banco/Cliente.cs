using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Banco
{
    internal class Cliente
    {
        public int NumeroConta { get; private set; }
        public string Nome { get; set; }
        public double Saldo { get; private set; }

        public Cliente(int numeroConta, string nome) 
        {
            NumeroConta = numeroConta;
            Nome = nome;
        }

        public Cliente(int numeroConta, string nome, double saldo) : this(numeroConta, nome)
        {
            Saldo = saldo;
        }
                      
        public void Deposito(double quantia)
        {
            Saldo += quantia;

        }
        public void Saque(double quantia)
        {
            Saldo -= quantia + 5.0;

        }
               
        public override string ToString()
        {
            return "Conta: " 
                + NumeroConta 
                + ", Titular: " 
                + Nome 
                + ", Saldo: R$" 
                + Saldo.ToString("F2",CultureInfo.InvariantCulture);
        }

    }
}
