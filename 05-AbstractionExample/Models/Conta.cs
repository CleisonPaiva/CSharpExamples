using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _05_AbstractionExample.Models
{
    public abstract class Conta
    {
        protected decimal saldo { get; set; }

        public abstract void Creditar(decimal valor);

        public void ExibirSaldo() {

            Console.WriteLine($"Seu saldo é: {saldo}");
        }
    }
}