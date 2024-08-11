using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_ADV_4.Youtube
{
    internal class Channel
    {

        public string name { get; set; }
        public List<Video> videos { get; set; } = new List<Video>();

        public void addVideo(Video video)
        {

            videos.Add(video);

            // notify the subscriber
            videadded?.Invoke(video, this);

        }


        public event Action<Video,Channel>? videadded;


        public override string ToString()
        {
            return $"chanel name : {name}";
        }
    }
}
