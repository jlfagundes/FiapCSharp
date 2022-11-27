using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TasksDotNetCSharp.Interfaces;

namespace TasksDotNetCSharp.Models
{
    public class Employees : IEmployee
    {
        public string name { get; set; }
        public string role { get; set; }
        public double payment { get; set; }
        public int yearAdmission { get; set; }
        public bool isEmployeeOld { get; set; }

        public Employees() { }
        public Employees(string name, string role, double payment, int yearAdmission, bool isEmployeeOld)
        {
            this.name = name;
            this.role = role;
            this.payment = payment;
            this.yearAdmission = yearAdmission;
            this.isEmployeeOld = isEmployeeOld;
        }

        static public Employees AddEmployee(string name, string role, double payment, int yearAdmission, bool isEmployeeOld)
        {
            Employees newEmployee = new Employees(name, role, payment, yearAdmission, isEmployeeOld);
            return newEmployee;
        }
    }
}
