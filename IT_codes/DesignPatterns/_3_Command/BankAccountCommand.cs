﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Command
{
    public class BankAccountCommand : ICommand
    {
        private BankAccount account;
        private bool succeeded;
        public enum Action
        {
            Deposit, Withdraw
        }
        private Action action;
        private int amount;
        public BankAccountCommand(BankAccount account, Action action, int amount)
        {
            this.account = account;
            this.action = action;
            this.amount = amount;
        }
        public void Call()
        {
            switch (action)
            {
                case Action.Deposit:
                    account.Deposit(amount);
                    succeeded = true;
                    break;
                case Action.Withdraw:
                    succeeded = account.Withdraw(amount);
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        public void Undo()
        {
            if (!succeeded) return;
            switch (action)
            {
                case Action.Deposit:
                    account.Deposit(-amount); // خودم منفی گذاشتم !!!
                    succeeded = true;
                    break;
                case Action.Withdraw:
                    succeeded = account.Withdraw(-amount); // خودم منفی گذاشتم !!!
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

    }
}