using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _07_SealedClassAndMethods.Models
{
    public sealed class Professor : Pessoa
    {

        public Professor() : base()
        {
            //
        }
        public Professor(string name) : base(name)
        {
            //
        }

        public double Salario { get; set; }

        public override void Apresentar()
        {
            Console.WriteLine($"Olá, eu sou o {Name} e tenho {Idade} anos e ganho {Salario} reais");
        }
    }
}