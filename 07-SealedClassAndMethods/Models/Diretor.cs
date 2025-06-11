using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _07_SealedClassAndMethods.Models
{
     /*
     Definindo a Classe Pai como Sealed
     Exemplo
     public sealed class Professor
     Isso impedirá que outras classes herdem da classe Professor, ou seja
     Professor não pode ter filhos


     O mesmo serve para metodos
     Exemplo public sealed override void Apresentar()

     Isso impedirá que outras classes sobreescrevam o metodo Apresentar, ou seja
     Apresentar nao pode ser sobreposto
     */
    //   public class Diretor : Professor
    public class Diretor
    {

    }
}