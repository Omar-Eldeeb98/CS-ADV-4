using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C42_G02_ADV04
{
    internal class Club
    {
        public int ClubID { get; set; }
        public string ClubName { get; set; }

        private List<Employee> Members = new List<Employee>();


        public void AddMember(Employee employee)
        {
            Members.Add(employee);
            employee.EmployeeLayOff += RemoveMember;
        }

        public void RemoveMember(object sender, EmployeeLayOffEventArgs e)
        {
            var employee = (Employee) sender ;
            if (employee != null && e.cause == LayOffCause.vacationLess0)
            {
                Members.Remove(employee);
                Console.WriteLine($"Employee {employee.EmployeeID} removed from club {ClubName}");
                Console.WriteLine("\n");

            }
        }

    }
}
