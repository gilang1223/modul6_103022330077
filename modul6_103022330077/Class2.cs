using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul6_103022330077
{
    class SayaTubeVideo
    {
        private int id;
        public String title;
        public int playCount;
    
    public SayaTubeVideo(String title)
        {
            this.playCount = 0;
            this.id = new Random().Next(1000);
            this.title = title;
        }
        public void IncreasePlayCount(int playCount)
        {
            this.playCount += playCount;
        }
        public void PrintVideoDetails()
        {
            Console.WriteLine("ID: " + this.id);
            Console.WriteLine("Title: " + this.title);
            Console.WriteLine("Play Count: " + this.playCount);
        }
    }
}
