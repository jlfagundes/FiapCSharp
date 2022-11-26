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
        static public Employees RegisterEmployee()
        {
            Console.Clear();
            Console.Write("Digite o nome do novo funcionário: ");
            string nameEmployee = Console.ReadLine();

            Console.Write("Digite o cargo: ");
            string vaccationEmployee = Console.ReadLine();

            Console.Write("Digite o salário: ");
            double payment = double.Parse(Console.ReadLine());

            Console.Write("Digite o ano de admissão do funcionário: ");
            int yearAdmission = int.Parse(Console.ReadLine());

            Employees newEmployee = Employees.addEmployee(
                nameEmployee,
                vaccationEmployee,
                payment,
                yearAdmission);

            return newEmployee;
        }
    }
}
