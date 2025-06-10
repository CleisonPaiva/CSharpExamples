using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Inheritance.Models
{
    public class Pessoa
    {
        public string Name { get; set; } = string.Empty;
        public int Age { get; set; }

        public string Email { get; set; } = string.Empty;

        public string Apresentar() => $"Olá, meu nome é {Name} e eu tenho {Age} anos.";
    }
}