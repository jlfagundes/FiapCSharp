using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace CSharpNetCore3.Models
{
    internal class Derivada : ClasseBase
    {
        public Derivada(): base()
        {
            Console.WriteLine(Metodo());
        }

        public override string Metodo()
        {
            return "Método da ClasseBase alterado na classe Derivada";
        }
    }
}
