using System;
using FighterApp.Interfaces;

namespace FighterApp.Classes
{
    public class ProFighter : Fighter, IStreet, IBox
    {
        public double Experience { get; set; }
        public ProFighter(double health, double powerPunch, double speed, double experience) : base(health, powerPunch, speed)
        {
            this.Experience = experience;
        }

        public void DoStreet(Fighter opponent)
        {
            double dmg = Experience + Speed + PowerPunch;
            FighterMethod(opponent, dmg);
        }

        public void DoBoxing(Fighter opponent)
        {
            double dmg = Experience + Speed + PowerPunch;
            opponent.TakeDamage(dmg);
        }

        protected override void Finisher(Fighter opponent)
        {
            Console.WriteLine("You hit him with karlicno,expected recovery 5 weeks");
        }
    }
}
