using Polymorphism.Models;
namespace Polymorphism.Models
{
    public class Professor : Pessoa
    {
        public decimal Salario { get; set; }

        public override void Apresentar() {
            Console.WriteLine($"Ola, meu nome é {Name} e eu tenho {Age} anos e ganho {Salario} reais.");
        }
    }
}