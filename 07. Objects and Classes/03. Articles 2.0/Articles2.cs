using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Articles_2._0
{
    class Article2
    {
        // class fields
        string title = null;
        string content = null;
        string author = null;

        // Constructors
        public Article2()
        {
        }

        // Properties
        public string Title
        {
            get { return title; }
            set { title = value; }
        }
        public string Content
        {
            get { return content; }
            set { content = value; }
        }
        public string Author
        {
            get { return author; }
            set { author = value; }
        }

        // Methods
        public static void PrintArticleInfo(Article2 article)
        {
            Console.WriteLine("{0} -{1}:{2}", article.title, article.content, article.author);
        }
    }

    class Article
    {
        static void Main()
        {
            int numOfArticles = int.Parse(Console.ReadLine());
            List<Article2> listOfArticles = new List<Article2>();
            for (int i = 0; i < numOfArticles; i++)
            {
                listOfArticles.Add(new Article2());
            }

            for (int i = 0; i < numOfArticles; i++)
            {
                string input = Console.ReadLine();
                char[] separators = new char[] { ',' };
                string[] commandsArray = input.Split(separators, StringSplitOptions.RemoveEmptyEntries);

                listOfArticles[i].Title = commandsArray[0];
                listOfArticles[i].Content = commandsArray[1];
                listOfArticles[i].Author = commandsArray[2];
            }

            string sortCommand = Console.ReadLine();

            switch (sortCommand)
            {
                case "title": listOfArticles.Sort((p, q) => p.Title.CompareTo(q.Title)); break;
                case "content": listOfArticles.Sort((p, q) => p.Content.CompareTo(q.Content)); break;
                case "author": listOfArticles.Sort((p, q) => p.Author.CompareTo(q.Author)); break;
            }

            foreach (var article in listOfArticles)
            {
                Article2.PrintArticleInfo(article);
            }
        }
    }
}
