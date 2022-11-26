using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TasksDotNetCSharp.Interfaces
{
    internal interface IEmployee
    {
        public string name { get; set; }
        public string roll { get; set; }
        public double payment { get; set; }
        public int yearAdmission { get; set; }
    }
}
