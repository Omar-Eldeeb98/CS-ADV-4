using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C42_G02_ADV04
{
    internal class SalesPerson : Employee
    {

        public int AchievedTarget { get; set; }

        public bool CheckTarget(int quota)
        {
            return AchievedTarget >= quota;
        }

        public new void EndOfYearOperation()
        {
            if (!CheckTarget(100))
            {
                OnEmployeeLayOff(new EmployeeLayOffEventArgs { cause = LayOffCause.failedtarget });
            }
        }

    }
}
