using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace LabQuestion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList staffList = new ArrayList();

            staffList.Add(new Staff("Ahmet", "Department-A", 1000));
            staffList.Add(new Staff("Mehet", "Department-B", 500));
            staffList.Add(new Staff("Cahit", "Department-C", 10));
            staffList.Add(new Staff("Gökhan", "Department-D", 5000));
            staffList.Add(new Staff("Melek", "Department-F1", 100));

            try
            {
                int result = sumSalary(staffList);

                Console.WriteLine("Result : " + result);
            }catch(Exception exc)
            {
                Console.WriteLine(exc.Message);
            }


            Console.ReadLine();
        }

        public static int sumSalary(ArrayList staffList)
        {
            int result = 0;
            foreach(Staff staff in staffList)
            {
                if (staff.salary < 0)
                    throw new SalaryException("Salary can not be negative");
                else
                    result += staff.salary;
            }



            return result;
        }
       
    }
}
