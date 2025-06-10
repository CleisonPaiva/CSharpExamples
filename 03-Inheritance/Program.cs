using Inheritance.Models;

Aluno a1 = new Aluno();

a1.Name = "Ana";
a1.Age = 16;
Console.WriteLine(a1.Apresentar());

Professor p1 = new Professor();

p1.Name = "José";
p1.Age = 30;
Console.WriteLine(p1.Apresentar());
