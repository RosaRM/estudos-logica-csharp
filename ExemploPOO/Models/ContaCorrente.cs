using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPOO.Models
{
    public class ContaCorrente
    {
        public ContaCorrente(int numeroConta, decimal saldoInicial)
        {
            NumeroConta = numeroConta;
            saldo =  saldoInicial;
        }
        public int NumeroConta { get; set; }
        private decimal saldo;

        public void Sacar(decimal valor)
        {
            if (saldo >= valor)
            {
            saldo -= valor;

            }
            else
            {
            Console.WriteLine($"Seu saldo é menor que o saque: {saldo}");
            }
        }

        public void MostrarSaldo()
        {
            Console.WriteLine($"Seu saldo disponivel é {saldo}");
        }
    }
}