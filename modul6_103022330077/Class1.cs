using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul6_103022330077
{
    class SayaTubeUser
    {
        private int id;
        private string username;
        List<SayaTubeVideo> uploadVideos = new List<SayaTubeVideo>();
        public SayaTubeUser(String username)
        {
        Random random = new Random();
        this.username = username;
        this.id = new Random().Next(1000);

        }
        public int GetTotalPlayCount()
        {
            int totalPlayCount = 0;
            foreach (SayaTubeVideo video in uploadVideos)
            {
                totalPlayCount += video.;
            }
            return totalPlayCount;
        }
        public void AddVideo(SayaTubeVideo video)
        {
            uploadVideos.Add(video);
        }
        public void PrintAllVideoPlaycount()
        {
           
            for (int i = 0; i < uploadVideos.Count && i < 8;i++)
            {
                Console.WriteLine("Video "+ (i+1) +" judul: "+ uploadVideos[i].title + " : " );
            }
        }
    }
}
