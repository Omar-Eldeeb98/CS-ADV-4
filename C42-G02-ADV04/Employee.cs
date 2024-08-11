using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C42_G02_ADV04
{
    internal class Employee
    {

        public event EventHandler<EmployeeLayOffEventArgs> EmployeeLayOff;

        // propperties
        public int EmployeeID { get; set; }
        public DateTime BirthDate { get; set; }
        public int VacationStock { get; set; }

        public bool RequestVacation(DateTime from, DateTime to)
        {
           
            return true;
        }

        protected virtual void OnEmployeeLayOff(EmployeeLayOffEventArgs e)
        {
            EmployeeLayOff?.Invoke(this, e);
        }

        private int GetAge()
        {
            return DateTime.Now.Year -BirthDate.Year;
        }

        public void EndOfYearOperation()
        {
            if (VacationStock < 0)
            {
                OnEmployeeLayOff(new EmployeeLayOffEventArgs { cause = LayOffCause.vacationLess0 });
            }
            else if (GetAge() > 60)
            {
                OnEmployeeLayOff(new EmployeeLayOffEventArgs { cause = LayOffCause.ageGeater60 });
            }
        }




    }
}
