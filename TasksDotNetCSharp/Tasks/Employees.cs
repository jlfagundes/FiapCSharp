using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TasksDotNetCSharp.Tasks
{
    public class Employees
    {
        public string name { get; set; }
        public string occupation { get; set; }
        public double payment { get; set; }
        public string yearAdmission { get; set; }

        public Employees(string name, string occupation, double payment, string yearAdmission)
        {
            this.name = name;
            this.occupation = occupation;
            this.payment = payment;
            this.yearAdmission = yearAdmission;
        }
    }
}
