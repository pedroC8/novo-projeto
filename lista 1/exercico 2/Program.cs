using System;

class Program
{ 
  public static void Main(string[] args)
  {
    Console.WriteLine("Digite a base do triangulo: ");
    double baseTriangulo = double.Parse(Console.ReadLine()); 

    Console.WriteLine("Digite a base do triangulo: ");
    double altura = double.Parse(Console.ReadLine()); 
    double area = (baseTriangulo * altura)/2;

    Console.WriteLine("a area triangulo eh maior que 20 ?" + (area > 20));
  }

}