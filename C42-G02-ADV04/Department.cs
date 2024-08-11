using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C42_G02_ADV04
{
    internal class Department
    {
        public int DeptID { get; set; }
        public string DeptName { get; set; }

        public List<Employee> Staff = new List<Employee>();

        public void AddStaff(Employee employee)
        {
            Staff.Add(employee);
            employee.EmployeeLayOff += RemoveStaff;
        }


        public void RemoveStaff(object sender, EmployeeLayOffEventArgs e)
        {
            var employee = (Employee) sender ;
            if (employee != null && (e.cause == LayOffCause.vacationLess0 || e.cause == LayOffCause.ageGeater60))
            {
                Staff.Remove(employee);
                Console.WriteLine($"Employee {employee.EmployeeID} removed from department {DeptName}");
                Console.WriteLine("\n");
            }
        }

    }
}
