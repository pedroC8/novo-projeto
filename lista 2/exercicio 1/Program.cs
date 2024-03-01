using System;

class Program
{
     public static void Main (string[] args)
      {
         Console.WriteLine(" digite seu usuario: " );
         string admin = Console.ReadLine();

         Console.WriteLine("digite sua senha ");
         string Senhasalva = Console.ReadLine();

     
         if (Senhasalva == "123senha")
        {
          
             Console.WriteLine("senha esta correta ");
        } 
         else
         {

           Console.WriteLine("credenciais incorretas ");
         }


    


     }
}

   
    
