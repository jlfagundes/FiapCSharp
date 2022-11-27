using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TasksDotNetCSharp.Menu
{
    internal class Menu
    {
        public Menu() { }
        static public void HomePage()
        {
            Console.Clear();
            Console.WriteLine("\nCONTROLE DE REAJUSTE SALARIAL");
            Console.WriteLine("----------------------------- \n");
            Console.WriteLine("Pressione ESC para sair");
            Console.WriteLine("Pressione F9 para Cadastrar um Funcionário");
            Console.WriteLine("Pressione F10 para Relatórios");
            Console.WriteLine("Pressione F7 para Aplicar Reajuste Salarial\n");
            DateTime dataAgora = DateTime.Now;
            Console.WriteLine("Data: " + dataAgora);
        }
    }
}
