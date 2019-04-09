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

    public abstract class GenericClass<T>
    {
        protected GenericClass(T parametar)
        {

        }

        public List<T> Array { get; set; }
        public int Count { get; set; }

        public abstract void Add(T e);

        public abstract T Remove(int index);

        public abstract T GetElementByIndex(int index);

    }

    //public class StringGenericClass : GenericClass<string>
    //{
    //    public StringGenericClass(string parametar) : base (parametar)
    //    {

    //    }

    //    public override void Add(string e)
    //    {
    //        Array.Add(e);
    //    }

    //    public override string Remove(int index)
    //    {
    //        Array.RemoveAt(index);

    //        foreach (var item in Array)
    //        {
    //        }
    //        return $"Remove: {Array}";
    //    }


    //    public override string GetElementByIndex(int index)
    //    {
    //        return "";
    //    }
    //}

}
