using System;

class Program
{ 
  public static void Main(string[] args)
  {
     Console.WriteLine("Digite suas notas: ");
     double nota1 = double.Parse(Console.ReadLine());
     Console.WriteLine("Digite suas notas: ");
     double nota2 = double.Parse(Console.ReadLine());
     Console.WriteLine("Digite suas notas: ");
     double nota3 = double.Parse(Console.ReadLine());
     Console.WriteLine("Digite suas notas: ");
     double nota4 = double.Parse(Console.ReadLine());

     double media = (nota1 + nota2 + nota3 + nota4)/4.0;
     Console.WriteLine("Sua media é: " + media);
  }

}
