using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_ADV_4.Youtube
{
    internal class Subscriber
    {
        public string name { get; set; }

        public void notify(Video video , Channel channel)
        {

            Console.WriteLine($"hi {name}, \nnew Video added ");
            Console.WriteLine($"added by: {channel.name} channel");
            Console.WriteLine($"video title : {video.title} , video desc: {video.description}");
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine("\n");
        }


        public override string ToString()
        {
            return $"subscriber name: {name}";
        }
    }
}
 