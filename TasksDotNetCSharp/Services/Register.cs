using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TasksDotNetCSharp.Models;

namespace TasksDotNetCSharp.Services
{
    internal class Register
    {
        static public Employees RegisterEmployee(List<Employees> arrayList)
        {
            Console.Clear();
            Console.WriteLine("\nCADASTRO DE FUNCIONÁRIOS");
            Console.WriteLine("--------------------------------");
            Console.Write("\nDigite o nome do novo funcionário: ");
            string nameEmployee = Console.ReadLine();

            Console.Write("Digite o cargo: ");
            string vaccationEmployee = Console.ReadLine();

            Console.Write("Digite o salário: ");
            double payment = double.Parse(Console.ReadLine());

            Console.Write("Digite o ano de admissão do funcionário: ");
            int yearAdmission = int.Parse(Console.ReadLine());

            Employees newEmployee;

            if (yearAdmission < 2022)
            {
                newEmployee = Employees.AddEmployee(
                nameEmployee,
                vaccationEmployee,
                payment,
                yearAdmission,
                true);
            } else
            {
                newEmployee = Employees.AddEmployee(
                nameEmployee,
                vaccationEmployee,
                payment,
                yearAdmission,
                false);
            }

            arrayList.Add(newEmployee);

            return newEmployee;
        }
    }
}
