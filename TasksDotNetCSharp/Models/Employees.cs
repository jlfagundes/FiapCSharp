using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TasksDotNetCSharp.Interfaces;

namespace TasksDotNetCSharp.Models
{
    internal class Employees : IEmployee
    {
        public string name { get; set; }
        public string roll { get; set; }
        public double payment { get; set; }
        public string yearAdmission { get; set; }

        public Employees() { }
        public Employees(string name, string roll, double payment, string yearAdmission)
        {
            this.name = name;
            this.roll = roll;
            this.payment = payment;
            this.yearAdmission = yearAdmission;
        }

        static public Employees addEmployee(string name, string roll, double payment, string yearAdmission)
        {
            Employees newEmployee = new Employees(name, roll, payment, yearAdmission);
            return newEmployee;
        }
    }
}
