using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Encapsulation.Models
{
    public class ContaCorrente
    {
        public ContaCorrente(int numeroConta, double saldo)
        {
            NumeroConta = numeroConta;
            Saldo = saldo;
        }
        public int NumeroConta { get; set; }

        private double Saldo { get; set; }

        public void Sacar(double valor)
        {
            if (Saldo < valor)
            {
                Console.WriteLine("Saldo insuficiente");
                return;
            }
            else
            {
                Saldo -= valor;
                Console.WriteLine("Saque realizado com sucesso");
            }
        }

        public void Depositar(double valor)
        {
            Saldo += valor;
            Console.WriteLine("Deposito realizado com sucesso");
        }

        public void ExibirSaldo(){
            Console.WriteLine($"Seu saldo é {Saldo}");
        }
    }
}