using System;

class Program 
{
    public static void Main(string[] args)

 {
    int filho = 0;
    decimal salario = 0;
    decimal mediasalario = 0; 
    for (int i = 0; i < 3;i ++)
    {
        System.Console.WriteLine("digite o salario: ");
        salario = convert.todecimal(Console.ReadLine());

         mediasalario += salario;
         if(salario > maiorsalario);
         {
            maiorsalario = salario;
         }
         System.Console.WriteLine("digite o numero de filhos: ");
         filho += Convert.toint32(Console.ReadLine());
    }
    mediasalario = mediasalario/20;
    filho = filho/20;
    System.Console.WriteLine("media salarial " + mediasalario);
    System.Console.WriteLine("media filho" + filho);
    System.Console.WriteLine("maior salario" + maiorsalario);
 }
    
}