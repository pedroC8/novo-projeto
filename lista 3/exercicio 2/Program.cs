using System;

class Program 
{
    public static void Main(string[] args)
    {

        Console.WriteLine("digite o numero de itens ");
        int itens = Convert.Toint32(Console.ReadLine());
        int i = 0;
        decimal compra = 0;
        while (i < itens )
        {
            Console.WriteLine("digite o valor de itens ");
            compra += Convert.ToDecimal(Console.ReadLine());
            i++;
        }
        if (compra > 150)
        {
            Console.WriteLine("Parabens ! voce ganhou frete gratis em sua compra de valor " + compra);
        }
        else 
        {
            Console.WriteLine("a compra nao possui frete gratis");
        }
    }
}
