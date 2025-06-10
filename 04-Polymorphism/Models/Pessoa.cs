using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Polymorphism.Models
{
    public class Pessoa
    {
        public string Name { get; set; } = string.Empty;
        public int Age { get; set; }

        public string Email { get; set; } = string.Empty;

        public virtual void Apresentar() {
           Console.WriteLine($"Ola, meu nome é {Name} e eu tenho {Age} anos.");
        }
    }
}