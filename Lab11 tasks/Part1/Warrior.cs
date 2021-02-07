using System;
using System.Collections.Generic;
using System.Text;

namespace Part1
{
    class Warrior
    {
        public int HP { get; private set; }
        public int AttackDamageInfo { get; }
        public double ExpPointsInfo { get; set; }

        public Warrior(int healthLevel)
        {
            HP = healthLevel;
        }

        public void GetDamage(int dam)
        {
            HP -= dam;
        }

        public void GetExper(double addExp)
        {
            ExpPointsInfo += addExp;
        }


    }
}
