using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace TasksDotNetCSharp.Models
{
    public class EmployeesOld : Employees
    {
        public EmployeesOld() : base()
        {
        }
        public EmployeesOld(string name, string role, double payment, int yearAdmission, bool isEmployeeOld) : base()
        {
            this.isEmployeeOld = isEmployeeOld;
            this.name = name;
            this.role = role;
            this.yearAdmission = yearAdmission;
            this.payment = payment;
        }

    }
}
