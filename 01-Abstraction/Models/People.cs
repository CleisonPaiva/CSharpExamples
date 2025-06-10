using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abstraction.Models
{
    public class People
    {
        public string Name { get; set; } = string.Empty;
        public int Age { get; set; }

        public string Apresentar() => $"Olá, meu nome é {Name} e eu tenho {Age} anos.";
    }
}