using System;
using System.Collections.Generic;
using System.Text;

namespace StreamingInterfacek
{
    internal class movie : IContent
    {
        private Video video;

        public movie(string title, int length)
        {
            video = new Video(title, length);
        }

        public string getTitle()
        {
            return video.getTitle();
        }

        public int getLength()
        {
            return video.getLength();
        }
    }
}
