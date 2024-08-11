using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_ADV_4.FiFa
{
    internal class Player
    {
        public string name { get; set; }
        public string teamName { get; set; }

        // callback function
        public void run(Ball ball)
        {
            Console.WriteLine($"Player: {name} is running... , ball:{ball }");

        }
    }
}
