using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_ADV_4.FiFa
{
    internal class Refree
    {


        public string name { get; set; }


        // callback function
        public void look(Ball ball)
        {
            Console.WriteLine($"Refree: {name} is looking... , ball: {ball}");
        }

    }
}
