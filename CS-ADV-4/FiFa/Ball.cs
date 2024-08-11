using CS_ADV_4.FiFa;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_ADV_4.FiFa
{
    internal class Ball
    {

        public int id { get; set; }


        private Location location;

       public Location Location
        { 
            get { return location; }
       
            // event
            set 
            { 
                if(!value.Equals(location))
                {
                    location = value;
                    // notify subscriber
                    BallLocationChanging?.Invoke(this);
                }


            }
        }

       
        public event Action<Ball>? BallLocationChanging;



        public override string ToString()
        {
            return $"id: {id} , location: {Location}";
        }

    }
}
