using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Inheritance.Models;
namespace Inheritance.Models
{
    public class Professor: Pessoa
    {
        public decimal Salario { get; set; }
    }
}