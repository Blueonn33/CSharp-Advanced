using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Reflection.Metadata.Ecma335;
using System.Security.AccessControl;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace NewsFeed
{
    public class NewsFeed
    {
        public NewsFeed(string name, int capacity)
        {
            Name = name;
            Capacity = capacity;
            Articles = new List<Article>();
        }

        public string Name
        {
            get; set;
        }
        public int Capacity
        {
            get; set;
        }
        public List<Article> Articles
        {
            get; set;
        }

        public void AddArticle(Article article)
        {
            if (!Articles.Any(a => a.Title == article.Title) && Capacity > Articles.Count)
            {
                Articles.Add(article);
            }
        }

        public bool DeleteArticle(string title)
        {
            Article article = Articles.FirstOrDefault(a => a.Title == title);

            return Articles.Remove(article);
        }

        public Article GetShortestArticle()
        {
            Article article = Articles.OrderBy(a => a.WordCount).FirstOrDefault();

            return article;
        }

        public string GetArticleDetails(string title)
        {
            Article article = Articles.FirstOrDefault(a => a.Title == title);

            if (article == null)
            {
                return $"Article with title '{title}' not found.";
            }

            return article.ToString();
        }

        public int GetArticlesCount()
        {
            return Articles.Count;
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            List<Article> sortedArticles = Articles.OrderBy(a => a.WordCount).ToList();

            sb.AppendLine($"{Name} newsfeed content:");

            foreach (var article in sortedArticles)
            {
                sb.AppendLine($"{article.Author}: {article.Title}");
            }

            return sb.ToString().TrimEnd();
        }
    }
}
