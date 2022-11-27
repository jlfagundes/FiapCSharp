using System;
using TasksDotNetCSharp.Menu;
using TasksDotNetCSharp.Models;
using TasksDotNetCSharp.Services;

// Task 2 - 24-11-22 até 28-11-22

// Lista de funcionários
List<Employees> listEmployees = new List<Employees>();

// Casos de uso do sistema
do
{
    Menu.HomePage();
    switch (Console.ReadKey().Key)
    {
        case ConsoleKey.F9:
            do
            {
                Register.RegisterEmployee(listEmployees);
                Console.WriteLine(">>>>>>  Funcionário cadastrado com sucesso <<<<<<");
                Console.WriteLine("\nDeseja cadastrar um novo funcionário? (s/n): ");

            } while (Console.ReadKey().Key == ConsoleKey.S);
            break;
        case ConsoleKey.F10:
            Report.ReportEmployees(listEmployees);
            break;
        case ConsoleKey.F7:
            IncreasePayment.AddIncreasePayment(listEmployees, 7000);
            break;
        default:
            break;
    }
} while (Console.ReadKey().Key != ConsoleKey.Escape);
