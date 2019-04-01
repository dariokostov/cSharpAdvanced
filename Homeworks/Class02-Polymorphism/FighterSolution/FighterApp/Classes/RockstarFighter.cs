using System;
using FighterApp.Interfaces;

namespace FighterApp.Classes
{
    public class RockstarFighter : Fighter, IStreet, IBox, IMuayThai
    {
        public double Reputation { get; set; }

        public RockstarFighter(double health, double powerPunch, double speed, double reputation) : base(health, powerPunch, speed)
        {
            this.Reputation = reputation;
        }

        public void DoStreet(Fighter opponent)
        {
            double dmg = Reputation + Speed + PowerPunch;
            opponent.TakeDamage(dmg);
        }

        public void DoBoxing(Fighter opponent)
        {
            double dmg = Reputation + Speed + PowerPunch;
            opponent.TakeDamage(dmg);
        }

        public void DoMuayThai(Fighter opponent)
        {
            double dmg = Reputation + Speed + PowerPunch;
            FighterMethod(opponent, dmg);
        }

        protected override void Finisher(Fighter opponent)
        {
            Console.WriteLine("You hit him with ciganski samar, NO RECOVERY!!!");
        }
    }
}
