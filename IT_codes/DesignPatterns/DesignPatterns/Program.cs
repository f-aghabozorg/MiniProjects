using _3_Command;
using _4_Strategy;
using Bridge;
using Mediator;
using System;
using System.Linq;

//https://refactoring.guru/design-patterns/csharp

//Mediator
/*
 * Intent:
 * Mediator is a behavioral design pattern that lets you reduce chaotic dependencies between objects.
 * The pattern restricts direct communications between the objects and forces them to collaborate only via a mediator object.
 * 
 * الگوی میانجی نشان می دهد که باید تمام ارتباط مستقیم بین اجزایی را که می خواهید مستقل از یکدیگر کنید، متوقف کنید. 
 * در عوض، این مؤلفه‌ها باید به‌طور غیرمستقیم، با فراخوانی یک شی واسطه ویژه که تماس‌ها را به مؤلفه‌های مناسب هدایت می‌کند، همکاری کنند.
 * در نتیجه، مؤلفه‌ها به جای جفت شدن با ده‌ها نفر از همکارانشان، تنها به یک کلاس واسطه وابسته هستند
 * [picture]
 */
ChatRoom room = new ChatRoom();
Person john = new Person("John");
Person jane = new Person("Jane");
room.Join(john);
room.Join(jane);
john.Say("hi room");
jane.Say("oh, hey john");
Person simon = new Person("Simon");
room.Join(simon);
simon.Say("hi everyone!");
jane.PrivateMessage("Simon", "glad you could join us!");
Console.WriteLine('\n');

//Bridge
/*
 * Intent:
 * Bridge is a structural design pattern that lets you split a large class or a set of closely related classes 
 * into two separate hierarchies—abstraction and implementation—which can be developed independently of each other.
 * 
 * [picture]
 */
VectorRenderer vector = new VectorRenderer();
Circle circle = new Circle(vector, 5);
circle.Draw(); // Drawing a circle of radius 5
circle.Resize(2);
circle.Draw(); // Drawing a circle of radius 10
Console.WriteLine('\n');


//Command
/*
 *  Intent:
 *  Command is a behavioral design pattern that turns a request into a stand-alone object that contains all information about the request. 
 *  This transformation lets you pass requests as a method arguments, delay or queue a request’s execution, and support undoable operations.
 * 
 *  A command is nothing more than a data class with its members describing what to do and how to do it
 * [picture]
 */

BankAccount ba = new BankAccount();
BankAccountCommand cmdDeposit = new BankAccountCommand(ba, BankAccountCommand.Action.Deposit, 100);        //سپرده
BankAccountCommand cmdWithdraw = new BankAccountCommand(ba, BankAccountCommand.Action.Withdraw, 100);     //برداشت
cmdDeposit.Call();
cmdWithdraw.Call();
Console.WriteLine(ba); // balance: 100
cmdWithdraw.Undo();
cmdDeposit.Undo();
Console.WriteLine(ba); // balance: 0
Console.WriteLine('\n');


//strategy
/*
 * Strategy is a behavioral design pattern that lets you define a family of algorithms,
 * put each of them into a separate class, and make their objects interchangeable.
 * 
 * استراتژی یک الگوی طراحی رفتاری است که
 * مجموعه‌ای از رفتارها را به اشیا تبدیل می‌کند و آن‌ها را در داخل شی متن اصلی قابل تعویض می‌کند
 */
TextProcessor tp = new TextProcessor();
tp.SetOutputFormat(OutputFormat.Markdown);
tp.AppendList(new[] { "foo", "bar", "baz" });
Console.WriteLine(tp);
// Output:
// * foo
// * bar
// * baz

tp.Clear(); // erases underlying buffer

tp.SetOutputFormat(OutputFormat.Html);
tp.AppendList(new[] { "foo", "bar", "baz" });
Console.WriteLine(tp);
//Output:
// < ul >
// < li > foo </ li >
// < li > bar </ li >
// < li > baz </ li >
// </ ul >


Console.WriteLine("Hello, World!");

