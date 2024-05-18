
using _3_Command;
using Bridge;
using Mediator;
using System;
using System.Linq;

//Mediator
var room = new ChatRoom();
var john = new Person("John");
var jane = new Person("Jane");
room.Join(john);
room.Join(jane);
john.Say("hi room");
jane.Say("oh, hey john");
var simon = new Person("Simon");
room.Join(simon);
simon.Say("hi everyone!");
jane.PrivateMessage("Simon", "glad you could join us!");
Console.WriteLine('\n');

//Bridge
//var raster = new RasterRenderer();
var vector = new VectorRenderer();
var circle = new Circle(vector, 5);
circle.Draw(); // Drawing a circle of radius 5
circle.Resize(2);
circle.Draw(); // Drawing a circle of radius 10
Console.WriteLine('\n');


//Command
var ba = new BankAccount();
var cmdDeposit = new BankAccountCommand(ba,
 BankAccountCommand.Action.Deposit, 100);
var cmdWithdraw = new BankAccountCommand(ba,
 BankAccountCommand.Action.Withdraw, 1000);
cmdDeposit.Call();
cmdWithdraw.Call();
Console.WriteLine(ba); // balance: 100
cmdWithdraw.Undo();
cmdDeposit.Undo();
Console.WriteLine(ba); // balance: 0

var from = new BankAccount();
from.Deposit(100);
var to = new BankAccount();
var mtc = new MoneyTransferCommand(from, to, 1000);
mtc.Call();
Console.WriteLine(from); // balance: 100
Console.WriteLine(to); // balance: 0

var ba2 = new BankAccount();
var commands = new List<Action>();
commands.Add(() => Deposit(ba2, 100));
commands.Add(() => Withdraw(ba2, 100));
commands.ForEach(c => c());

 void Deposit(BankAccount account, int amount)
{
    account.Balance += amount;
}
 void Withdraw(BankAccount account, int amount)
{
    if (account.Balance >= amount)
        account.Balance -= amount;
}


Console.WriteLine("Hello, World!");

