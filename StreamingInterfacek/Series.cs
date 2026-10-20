using System;
using System.Collections.Generic;
using System.Text;

namespace StreamingInterfacek
{
    internal class Series : IContent
    {
        private string title;
        private List<Video> videos;

        public Series(string title, Video firstvideo)
        {
            this.title = title;
            this.videos = new List<Video>();
            this.videos.Add(firstvideo);
        }

        public Series(string title, List<Video> videos)
        {
            this.title = title;
            this.videos = videos;
        }

        public string getTitle()
        {
            return title;
        }

        public int getLength()
        {
            int totalLength = 0;
            foreach (Video video in videos)
            {
                totalLength += video.getLength();
            }
            return totalLength;
        }
    }
}
