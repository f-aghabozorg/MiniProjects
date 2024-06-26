﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Command
{
    public class BankAccount
    {
        private int balance; //موجودی
        private int overdraftLimit = -500; //محدودیت اضافه برداشت
        public void Deposit(int amount)    //سپرده
        {
            balance += amount;
            Console.WriteLine($"Deposited ${amount}, balance is now {balance}");
        }
        public bool Withdraw(int amount)    //برداشت
        {
            if (balance - amount >= overdraftLimit)
            {
                balance -= amount;
                Console.WriteLine($"Withdrew ${amount}, balance is now {balance}");
                return true; // succeeded
            }
            return false; // failed
        }
        public override string ToString()
        {
            return $"{nameof(balance)}: {balance}";
        }
    }
   
}
