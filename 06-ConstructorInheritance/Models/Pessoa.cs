using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _06_ConstructorInheritance.Models
{
    public class Pessoa
    {

        public Pessoa(string name)
        {
            Name= name;
        }

        public Pessoa()
        {
            //
        }

        public string Name { get; set; } = string.Empty;
        public int Idade { get; set; }

        public string Email { get; set; } = string.Empty;

        public virtual void Apresentar()
        {
            Console.WriteLine($"Olá, eu sou o {Name} e tenho {Idade} anos");
        }
    }
}