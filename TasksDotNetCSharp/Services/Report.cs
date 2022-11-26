using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TasksDotNetCSharp.Models;

namespace TasksDotNetCSharp.Services
{
    internal class Report
    {
        static public void ReportEmployees(List<EmployeesOld> arrayList)
        {
            // Separando os funcionários elegiveis e não elegíveis ao reajuste salarial
            Console.Clear();
            Console.WriteLine("\n--------------------------------");
            Console.WriteLine("Relação dos funcionários novos: ");
            foreach (var item in arrayList)
            {
                if (item.isEmployeeOld == false)
                Console.WriteLine(item.name);
            }

            Console.WriteLine("\n-----------------------------------------------------");
            Console.WriteLine("Relação dos funcionários elegíveis ao reajuste de 10%");
            foreach (var item in arrayList)
            {
                if (item.payment >= 7000 && item.isEmployeeOld == false)
                {
                    Console.WriteLine(item.name);
                }
            }

            Console.WriteLine("\n------------------------------------------------------------------");
            Console.WriteLine("Relação dos funcionários elegíveis ao reajuste que será definido: ");
            foreach (var item in arrayList)
            {
                if (item.payment < 7000 && item.isEmployeeOld == false)
                {
                    Console.WriteLine(item.name);
                }
            }
        }

    }
}
