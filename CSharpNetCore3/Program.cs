using System;
using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using CSharpNetCore3.Exceptions;
using CSharpNetCore3.Models;

namespace CSharpNetCore3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // Aprendendo sobre dictionary
            IDictionary<string, string> dicionario = new Dictionary<string, string>();
            dicionario["um"] = "valor Um";
            dicionario["dois"] = "valor Dois";
            dicionario["tres"] = "valor Tres";

            Console.WriteLine(dicionario["tres"]);

            foreach (KeyValuePair<string, string> item in dicionario)
            {
                string chave = item.Key;
                string valor = dicionario[chave];
                Console.WriteLine(valor);
            }

            /* // Aprendendo sobre coleções (listas) = evolução dos arrays
            string[] colecao = { "a", "b", "c" };

            IList<string> lista = new List<string>();

            lista.Add("d");
            lista.Add("e");
            lista.Add("f");
            lista.Add("g");
            lista.Remove("f");
            lista.RemoveAt(1);
            lista.Insert(1, "z");

            foreach (var item in lista)
            {
                Console.WriteLine(item);

            }
            */
            
            // throw new PersonalizadaExeption("Nome do inválido");

            /* // Aprendendo polimorfismo no c#
            Derivada pooTest = new Derivada();

            Console.WriteLine(pooTest);
            /*

            /* // Percorrendo um array com foreach
            string[] lista = { "a", "b", "c" };

            foreach (var item in lista)
            {
                Console.WriteLine(item);
            }
            */
            
            /*
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
            */


            /*
            double valorDouble = 10.5;
            bool valorBool = true;
            string valorString = "José";
            */



            Console.Read();
        }
    }
}
