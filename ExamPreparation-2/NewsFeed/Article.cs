using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsFeed
{
    public class Article
    {
        public Article(string title, string author, int wordCount)
        {
            Title = title;
            Author = author;
            WordCount = wordCount;
        }

        public string Title { get; set; }
        public string Author { get; set; }
        public int WordCount { get; set; }

        public override string ToString()
        {
            return $"Article: '{Title}' by {Author} - {WordCount} words";
        }
    }
}
