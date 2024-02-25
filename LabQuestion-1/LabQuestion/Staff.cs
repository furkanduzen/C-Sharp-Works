using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabQuestion
{
    internal class Staff
    {
        public string name;
        public string department;
        public int salary;

        public Staff(string name, string department, int salary)
        {
            if(name.Length > 5)
            {
                throw new ArgumentException("name is too long");
            }
            this.name = name;
            this.department = department;
            this.salary = salary;
        }
    }
}
