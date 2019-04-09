using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercise01.Classes;

namespace BreakingNews
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Mediums
            Medium cnn = new Medium();
            Medium a1 = new Medium();
            #endregion


            #region Followers
            Follower john = new Follower("John");
            Follower zvonko = new Follower("Zvonko");
            Follower zivko = new Follower("Zivko");
            #endregion

            #region Subscriptions
            john.Subscribe(cnn);
            john.Subscribe(a1);
            zivko.Subscribe(cnn);
            zvonko.Subscribe(a1);
            #endregion

            #region SendingNews
            cnn.SendBreakingNews("Man died eating", "lorem ipsum...", DateTime.Now);
            a1.SendBreakingNews("Cat bitten by a spider, looks like a ballon", "lorem ipsum...", DateTime.Now);
            #endregion

            Console.ReadLine();
        }
    }

    //Task 02

    //class GenericClass<T>
    //{
    //    public GenericClass(T parametar)
    //    {

    //    }
    //    private T Array { get; set; }
    //    public int Count { get; set; }

    //    public void Add(T element)
    //    {

    //    }

    //    public T Remove(int index)
    //    {

    //    }
    //    public T GetElementByIndex(int index)
    //    {

    //    }

    //}
}
