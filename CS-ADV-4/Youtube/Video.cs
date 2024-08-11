using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_ADV_4.Youtube
{
    internal class Video
    {

        public string title { get; set; }

        public string description { get; set; }


        public override string ToString()
        {
            return $"title: {title} , description: {description}";
        }
    }
}
