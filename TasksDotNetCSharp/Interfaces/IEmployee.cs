using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TasksDotNetCSharp.Models;

namespace TasksDotNetCSharp.Interfaces
{
    public interface IEmployee
    {
        public string name { get; set; }
        public string role { get; set; }
        public double payment { get; set; }
        int yearAdmission { get; set; }
        public bool isEmployeeOld { get; set; }

        static public void AddEmployee(
            string name,
            string role,
            double payment,
            int yearAdmission,
            bool isEmployeeOld) { }

    }
}
