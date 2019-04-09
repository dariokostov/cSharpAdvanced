using System;
namespace Exercise01.Classes
{
    public class Medium
    {
        public delegate void NewsHandler(object obj, News breakingNews);
        public event NewsHandler BreakingNewsHandler;

        public void SendBreakingNews(string headline, string content, DateTime dateTimeNow)
        {
            News News = new News(headline, content, dateTimeNow);
            if(BreakingNewsHandler == null)
            {
                Console.WriteLine("0 subs! :(");
                return;
            }
            BreakingNewsHandler(this, News);
        }
    }
}
