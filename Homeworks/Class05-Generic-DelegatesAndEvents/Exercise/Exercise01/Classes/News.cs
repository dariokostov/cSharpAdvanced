using System;
namespace Exercise01.Classes
{
    public class News
    {
        public string Headline { get; set; }
        public string Content { get; set; }
        public DateTime DateTimeNow { get; set; }

        public News(string headline, string content, DateTime dateTimeNow)
        {
            this.Headline = headline;
            this.Content = content;
            this.DateTimeNow = dateTimeNow;
        }
    }
}
