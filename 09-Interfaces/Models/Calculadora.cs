using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _09_Interfaces.Interfaces;

namespace _09_Interfaces.Models
{
    public class Calculadora : ICalculadora
    {
        /*
        Se o metodo for implementado na interface ele nao precisa ser implementado na classe
        mas pode ser implementado caso voce precise mudar alguma coisa no corpo
        public int Dividir(int numero1, int numero2)
           {
               return numero1 / numero2;
           }  */

        public int Multiplicar(int numero1, int numero2)
        {
            return numero1 * numero2;
        }

        public int Somar(int numero1, int numero2)
        {
            return numero1 + numero2;
        }

        public int Subtrair(int numero1, int numero2)
        {
            return numero1 - numero2;
        }
    }
}