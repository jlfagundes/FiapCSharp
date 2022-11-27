using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TasksDotNetCSharp.Models;

namespace TasksDotNetCSharp.Services
{
    internal class IncreasePayment
    {
        static public void AddIncreasePayment(List<Employees> arrayList, double limitIncrease)
        {
            Console.Clear();
            Console.WriteLine("\nAPLICAR REJUSTE SALARIAL");
            Console.WriteLine("--------------------------------");

            // Aplicando reajuste 10% 
            string addIncrease;
            do
            {
                Console.Write("\nDeseja aplicar o reajuste salarial de 10%? (s/n): ");
                addIncrease = Console.ReadLine();
                if (addIncrease.ToLower() == "s")
                {
                    Console.WriteLine("-----------------------------------------------------");
                    Console.WriteLine("Relação dos funcionários com reajuste de 10%:");
                    Console.WriteLine("\nNome" + " - " + "Salário" + " - " + "Ano de admissão" + " - " + "Novo Salário");
                    foreach (var item in arrayList)
                    {
                        if (item.payment > limitIncrease && item.isEmployeeOld)
                        {
                            Console.WriteLine(item.name + " - " + item.payment + " - " + item.yearAdmission + " - " + (item.payment * 1.1));
                            item.payment = item.payment * 1.1;
                        }
                    }
                    Console.WriteLine("\n\nReajuste de 10% aplicado aos funcionarios elegiveis");
                    break;
                }
           } while (addIncrease != "n");
            

            // Aplicando reajuste a ser definido
            Console.WriteLine("\n-----------------------------------------------------");
            string addIncrease2;
            do
            {
                Console.Write("Deseja aplicar o reajuste salarial a ser definido? (s/n): ");
                addIncrease2 = Console.ReadLine();
                if (addIncrease2.ToLower() == "s")
                {
                    Console.Write("Qual valor em % deseja reajustar? ");
                    double increaseValue = double.Parse(Console.ReadLine());
                    Console.WriteLine("-----------------------------------------------------");
                    Console.WriteLine("Relação dos funcionários com reajuste de " + increaseValue + ":");
                    Console.WriteLine("\nNome" + " - " + "Salário" + " - " + "Ano de admissão" + " - " + "Novo Salário");
                    foreach (var item in arrayList)
                    {
                        if (item.payment < limitIncrease && item.isEmployeeOld)
                        {
                            double newPayment = item.payment * (1 + (increaseValue / 100));
                            Console.WriteLine(item.name + " - " + item.payment + " - " + item.yearAdmission + " - " + newPayment);
                            item.payment = item.payment * (1 + (increaseValue / 100));
                        }
                    }
                    Console.Write("\n\nReajuste aplicado aos funcionarios elegiveis de ");
                    Console.Write(increaseValue);
                    Console.Write("%\n\n");
                    Console.WriteLine("\nPressione qualquer tecla para continuar...");
                    break;
                }
            } while (addIncrease2.ToLower() != "n");
            return;
        }
    }
}
