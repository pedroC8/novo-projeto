using System;

class Program
{
  public static void Main(string[] args)
  {
    int tentativa = 3;
    int i = 0;

    string usuario ="";

    string senha ="";

    while((usuario != "admin" && senha != "123senha") && i < tentativa )
    {
       Console.WriteLine("digite o usuario ");
       usario = Console.ReadLine();

       Console.WriteLine("digite a senha");
       senha = Console.ReadLine();
    if (usuario == "admin" && senha == "123senha")
    {
        Console.WriteLine("login realizado com sucesso");
    }

    i++;
    {
     if (usuario == "Admin" && senha == "123senha")
     {
        Console.WriteLine("login realizado com sucesso");
     }
     else
     {
        Console.WriteLine("sua conta foi bloqueada");
     }
    }
  }

  }








}
