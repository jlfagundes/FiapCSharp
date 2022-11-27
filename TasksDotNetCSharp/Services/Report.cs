using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TasksDotNetCSharp.Interfaces;
using TasksDotNetCSharp.Models;

namespace TasksDotNetCSharp.Services
{
    internal class Report
    {
        static public void ReportEmployees(List<Employees> arrayList)
        {
            // Separando os funcionários elegiveis e não elegíveis ao reajuste salarial
            // Variaveis de negócio
            Console.Clear();
            Console.WriteLine("\nRELATÓRIO DE FUNCIONÁRIOS");
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Nome" + " - " + "Salário" + " - " + "Ano de admissão" + " - " + "Antigo");
            foreach (var item in arrayList)
            {
                Console.WriteLine(item.name + " - " + item.payment + " - " + item.yearAdmission + " - " + item.isEmployeeOld);
            }
            Console.WriteLine("\nPressione qualquer tecla para continuar...");
        }

    }
}
