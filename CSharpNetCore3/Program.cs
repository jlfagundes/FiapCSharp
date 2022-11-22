using System;
using System.Dynamic;

namespace CSharpNetCore3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int valor = 10;

            valor += 1;

            if ( valor == 10 )
            {
                Console.WriteLine("O valor é igual a 10");
            } else
            {
                Console.WriteLine("O valor é diferente de 10");
            }

            Console.WriteLine(valor);

            /*
            double valorDouble = 10.5;
            bool valorBool = true;
            string valorString = "José";
            */



            Console.Read();
        }
    }
}
