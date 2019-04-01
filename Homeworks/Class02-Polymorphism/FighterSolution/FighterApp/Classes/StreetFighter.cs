using System;
using FighterApp.Interfaces;

namespace FighterApp.Classes
{
    public class StreetFighter : Fighter, IStreet
    {
        public double StreetCredit { get; set; }
        public StreetFighter(double health, double powerPunch, double speed, double streetCredit) : base(health, powerPunch, speed)
        {
            this.StreetCredit = streetCredit;
        }

        public void DoStreet(Fighter opponent)
        {
            double dmg = StreetCredit + Speed + PowerPunch;
            FighterMethod(opponent, dmg);
        }

        protected override void Finisher(Fighter opponent)
        {
            Console.WriteLine("You hit him with mayageri, expected recovery 2 weeks");
        }
    }
}
