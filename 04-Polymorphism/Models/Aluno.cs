using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Polymorphism.Models
{
    public class Aluno : Pessoa
    {
        public double Nota { get; set; }

        public override void Apresentar() {
            Console.WriteLine($"Ola, meu nome é {Name} e eu tenho {Age} anos e eu tenho a nota {Nota}.");
        }
    }
}