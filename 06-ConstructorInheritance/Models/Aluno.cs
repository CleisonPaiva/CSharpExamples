using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _06_ConstructorInheritance.Models
{
    public class Aluno : Pessoa
    {
        public Aluno(string name) : base(name)
        {
            //Contrutor para passa parametro poe herança
        }

        public Aluno(): base()
        {
            //
        }

        public double Nota { get; set; }

        public override void Apresentar()
        {
            Console.WriteLine($"Olá, eu sou o {Name} e tenho {Idade} anos e minha nota é {Nota}");
        }
    }
}