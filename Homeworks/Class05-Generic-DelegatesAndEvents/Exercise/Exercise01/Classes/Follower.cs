using System;
namespace Exercise01.Classes
{
    public class Follower
    {
        public string Name;

        public Follower(string name)
        {
            this.Name = name;
        }

        public void Subscribe(Medium medium)
        {
            medium.BreakingNewsHandler += new Medium.NewsHandler(Print);
        }

        public void Print(object obj, News breakingNews)
        {
            Console.WriteLine($"{breakingNews.Headline}\n{breakingNews.Content}\n{breakingNews.DateTimeNow}\n\n");
        }
    }
}
