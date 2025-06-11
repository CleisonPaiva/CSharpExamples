using _09_Interfaces.Interfaces;
using _09_Interfaces.Models;

ICalculadora calculadora = new Calculadora();
Console.WriteLine($"A Soma é: {calculadora.Somar(10, 20)}");
Console.WriteLine($"A Subtracao é: {calculadora.Subtrair(10, 20)}");
Console.WriteLine($"A Divisao é: {calculadora.Dividir(10, 20)}");
Console.WriteLine($"A Multiplicacao é: {calculadora.Multiplicar(10, 20)}");