using System;
using System.Collections.Generic;
using System.Text;

namespace Part2
{
    class Account
    {
        private string _name;
        private double _amount;
        public string Personal => $"Name is {_name}, Amount is {_amount}";

        public Account(string name, double amount)
        {
            _name = name;
            _amount = amount;
        }

        public void Deposit(double amount)
        {
            _amount += amount;
        }

        public void WithDraw(double amount)
        {
            if (_amount >= amount)
                _amount -= amount;
            else
                throw new Exception("You want to withdraw more than available");
        }
    }
}
