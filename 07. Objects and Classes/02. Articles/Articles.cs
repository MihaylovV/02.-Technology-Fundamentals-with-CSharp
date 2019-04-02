using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Articles
{
    class Article
    {
        string Title;
        string Content;
        string Author;

        public Article()
        {
        }

        public Article(string title, string content, string author)
        {
            this.Title = title;
            this.Content = content;
            this.Author = author;
        }

        public string Edit(string content)
        {
            return this.Content = content;
        }

        public string ChangeAuthor(string newAuthor)
        {
            return this.Author = newAuthor;
        }

        public string Rename(string newTitle)
        {
            return this.Title = newTitle;
        }

        public void PrintArticle()
        {
            Console.WriteLine("{0} -{1}:{2}", this.Title, this.Content, this.Author);
        }
    }

    class Articles
    {
        static void Main()
        {
            List<string> article = GetArticleInfoFromUser();
            Article currentArticle = new Article(article[0], article[1], article[2]);

            int numOfCommands = int.Parse(Console.ReadLine());

            for (int i = 0; i < numOfCommands; i++)
            {
                string[] commandsArray = GetCommandsArray();

                switch (commandsArray[0])
                {
                    case "Edit": currentArticle.Edit(commandsArray[1]); break;
                    case "ChangeAuthor": currentArticle.ChangeAuthor(commandsArray[1]); break;
                    case "Rename": currentArticle.Rename(commandsArray[1]); break;
                }
            }

            currentArticle.PrintArticle();
        }

        public static List<string> GetArticleInfoFromUser()
        {
            string input = Console.ReadLine();
            char[] separators = new char[] { ',' };
            string[] inputArray = input.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            List<string> articleInfo = new List<string>();
            for (int i = 0; i < inputArray.Length; i++)
            {
                articleInfo.Add(inputArray[i]);
            }
            return articleInfo;
        }

        public static string[] GetCommandsArray()
        {
            string input = Console.ReadLine();
            char[] separators = new char[] { ':' };
            string[] commandsArray = input.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            return commandsArray;
        }
    }
}
