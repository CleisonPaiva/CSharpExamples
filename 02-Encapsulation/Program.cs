using Encapsulation.Models;


ContaCorrente c1= new ContaCorrente(123, 1000.00);
c1.ExibirSaldo();
c1.Depositar(500.00);
c1.ExibirSaldo();
c1.Sacar(1000.00);
c1.ExibirSaldo();
c1.Sacar(1000.00);