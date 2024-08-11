using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C42_G02_ADV04
{
    internal class BoardMember:Employee
    {

        public void Resign()
        {
            OnEmployeeLayOff(new EmployeeLayOffEventArgs { cause = LayOffCause.resigned });
        }

    }
}
