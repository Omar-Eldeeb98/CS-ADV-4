﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C42_G02_ADV04
{
    public class EmployeeLayOffEventArgs : EventArgs
    {
        public LayOffCause cause { get; set; }
    }
}
