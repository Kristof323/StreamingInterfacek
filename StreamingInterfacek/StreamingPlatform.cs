using System;
using System.Collections.Generic;
using System.Text;

namespace StreamingInterfacek
{
    internal class StreamingPlatform
    {
        private List<IContent> contents;

        public StreamingPlatform()
        {
            contents = new List<IContent>();
        }

        public void addContent(IContent content)
        {
            contents.Add(content);
        }

        public IContent GetLongest()
        {
            if (contents.Count == 0)
            {
                Console.WriteLine("nem erheto el tartalom");
            }
            
            IContent longest = contents[0];

            foreach (IContent content in contents)
            {
                if (content.getLength() > longest.getLength())
                {
                    longest = content;
                }
            }
            return longest;
        }

        public List<IContent> GetContents()
        {
            return contents;
        }
    }
}
