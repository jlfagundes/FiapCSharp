﻿/*
internal class program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Main");
    }
}
*/

using TasksDotNetCSharp.Models;

IList<Employees> list1= new List<Employees>();
IList<EmployeesOld> list2= new List<EmployeesOld>();

EmployeesOld newEmployee = new EmployeesOld();
newEmployee.name = "jose";

list1.Add(newEmployee);
list2.Add(newEmployee);

foreach (var item in list1)
{
    Console.WriteLine(item.name);

}

foreach (var item in list2)
{
    Console.WriteLine(item.name);

}


Console.Read();

/*
using System;
using TasksDotNetCSharp.Models;

// Task 2 - 24-11-22 até 28-11-22
Console.WriteLine("\nCONTROLE DE REAJUSTE SALARIAL");
Console.WriteLine("----------------------------- \n");

// Variavel para cadastrar ou não um novo funcionário
string addEmployee;


// Criando listas de funcionários elegiveis e não elegiveis
IList<Employees> listEmployees = new List<Employees>();
IList<EmployeesOld> listEmployeesOld = new List<EmployeesOld>();
IList<EmployeesOld> listEmployeesOldLimited = new List<EmployeesOld>();


do
{
    // Cadastrar funcionários
    Console.Write("\nDeseja cadastrar um funcionário? (s/n): ");
    addEmployee = Console.ReadLine();
    if (addEmployee == "s")
    {
        Console.Write("Digite o nome do novo funcionário: ");
        string nameEmployee = Console.ReadLine();

        Console.Write("Digite o cargo: ");
        string vaccationEmployee = Console.ReadLine();
        
        Console.Write("Digite o salário: ");
        double payment = double.Parse(Console.ReadLine());
        
        Console.Write("Digite o ano de admissão do funcionário: ");
        string yearAdmission = Console.ReadLine();

        Employees novoFuncionario = new Employees(nameEmployee, vaccationEmployee, payment, yearAdmission);
        listEmployees.Add(novoFuncionario);

        Console.Write("\n");
        Console.Write(nameEmployee);
        Console.Write(" foi cadastrado com sucesso\n");
    }
    else
    {
        
        // Separando os funcionários elegiveis e não elegíveis ao reajuste salarial
        Console.WriteLine("\n--------------------------------");
        Console.WriteLine("Relação dos funcionários novos: ");
        foreach (var item in listEmployees)
        {
            if (item.yearAdmission == "2022")
            {
                Console.WriteLine(item.name);

            }
            else
            {
                listEmployeesOld.Add(item);
            }
        }

        Console.WriteLine("\n-----------------------------------------------------");
        Console.WriteLine("Relação dos funcionários elegíveis ao reajuste de 10%");
        foreach (var item in listEmployeesOld)
        {
            if (item.payment > 7000)
            {
                Console.WriteLine(item.name);
            }
            else
            {
                listEmployeesOldLimited.Add(item);
            }
        }

        Console.WriteLine("\n------------------------------------------------------------------");
        Console.WriteLine("Relação dos funcionários elegíveis ao reajuste que será definido: ");
        foreach (var item in listEmployeesOldLimited)
        {
            Console.WriteLine(item.name);
        }

        // Aplicando reajuste de 10%
        Console.WriteLine("\n#################################################");
        Console.Write("Deseja aplicar o reajuste salarial de 10%? (s/n) ");
        string increaseDefined = Console.ReadLine();
        if (increaseDefined == "s")
        {
            foreach (var item in listEmployeesOld)
            {
                if (item.payment > 7000)
                {
                    item.payment = item.payment * 1.1;
                    Console.Write("\n");
                    Console.Write(item.name);
                    Console.Write(" - novo salário - ");
                    Console.Write(item.payment);
                }
            }
            Console.WriteLine("\n\nReajuste de 10% aplicado aos funcionarios elegiveis");
        }

        // Aplicando reajuste a ser definido
        Console.WriteLine("\n#######################################################################");
        Console.Write("Deseja aplicar o reajuste salarial dos outros funcionarios elegíveis? (s/n) ");
        string increase = Console.ReadLine();
        if (increase == "s")
        {
            Console.Write("Qual valor em % deseja reajustar? ");
            double increaseValue = double.Parse(Console.ReadLine());
            foreach (var item in listEmployeesOldLimited)
            {
                Console.Write("\n");
                item.payment = item.payment * (1+(increaseValue/100));
                Console.Write(item.name);
                Console.Write(" - novo salário - ");
                Console.Write(item.payment);
            }
            Console.Write("\n\nReajuste aplicado aos funcionarios elegiveis de ");
            Console.Write(increaseValue);
            Console.Write("%\n\n");
        }


        Console.WriteLine("\n\nPressione qualquer tecla para finalizar...");
    }
    
} while (addEmployee == "s");

Console.Read();
*/