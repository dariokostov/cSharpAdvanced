using System;
namespace Library.Classes
{
    public class User
    {
        private static int _count = 1;
        public int ID { get; set; }
        public string UserName { get; set; }

        public User(string userName)
        {
            this.ID = _count++;
            this.UserName = userName;
        }

    }
}
