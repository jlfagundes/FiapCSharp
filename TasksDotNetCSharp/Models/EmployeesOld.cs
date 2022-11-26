using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace TasksDotNetCSharp.Models
{
    internal class EmployeesOld : Employees
    {
        public bool isEmployeeOld { get; set; }
        public EmployeesOld() : base()
        {
        }
        public EmployeesOld(string name, string roll, double payment, int yearAdmission, bool isEmployeeOld) : base()
        {
            this.isEmployeeOld = isEmployeeOld;
            this.name = name;
            this.roll = roll;
            this.payment = payment;
        }
    }
}
