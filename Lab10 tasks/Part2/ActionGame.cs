using System;
using System.Collections.Generic;
using System.Text;

namespace Part2
{
    interface IWarrior
    {
        public void Defend();
    }

    interface IMonster
    {
        public void Attack();
    }

    interface IObject
    {
        public void Take();
    }

    class ActionGame
    {
    }

    class Warrior : IWarrior
    {
        public void Defend()
        {
            Console.WriteLine("Defending");
        }

    }

    class Monster : IMonster
    {
        public void Attack()
        {
            Console.WriteLine("Attacking");
        }
    }

    class Object : IObject
    {
        public void Take()
        {
            Console.WriteLine("It is taken");
        }
    }
}
