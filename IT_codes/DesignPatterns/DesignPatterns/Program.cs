using _1_Mediator;
using _3_Command;
using _4_Strategy;
using _5 = _5_FactoryMethod;
using _5_AbstractFactory;

using renderers;
using shapes;
using System;
using System.Linq;
using System.Drawing;

//https://refactoring.guru/design-patterns/csharp

#region Mediator
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
 * 
 * Usage examples: The most popular usage of the Mediator pattern in C# code is facilitating communications between GUI components of an app.
 * The synonym of the Mediator is the Controller part of MVC pattern.
 */
Console.WriteLine("1-Mediator");
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
#endregion


#region Bridge
//Bridge
/*
 * Intent:
 * Bridge is a structural design pattern that lets you split a large class or a set of closely related classes 
 * into two separate hierarchies—abstraction and implementation—which can be developed independently of each other.
 * 
 * [picture]
 */
Console.WriteLine("2-Bridge");
VectorRenderer vector = new VectorRenderer();
Circle vector_circle = new Circle(vector, 5);
vector_circle.Draw(); // Drawing a circle of radius 5
vector_circle.Resize(2);
vector_circle.Draw(); // Drawing a circle of radius 10
//add shape ....

Triangle vector_triangle = new Triangle(vector, 5);
vector_triangle.Draw();
vector_triangle.Resize(2);
vector_triangle.Draw();

DotRenderer dot = new DotRenderer(); //نکته: هر رندرر باید توانایی ایجاد همه اشکال را داشته باشد

//solid principle check:
//SPR: single responsibilty: هر رندرر یک کار انجام میدهد و آن ترسیم شکل است
//OCP: open-closed: برای اکسپند کردن باز است و برای مودیفای کردن بسته است
//LSP: Liskov sustitution: کلاسهایی که از آنها ارث بری میشود مورد اضافه ای ندارند
//ISP: Interface segretion: ایترفیس ها متد اضافه ای ندارند
//DIP: Dependancy inversion: لایه های سطح بالا نباید به لایه های سطخ پایین وابسته باشند

Circle dot_circle = new Circle(dot, 5);
dot_circle.Draw();
dot_circle.Resize(2);
dot_circle.Draw();

Triangle dot_triangle = new Triangle(dot, 5);
dot_triangle.Draw();
dot_triangle.Resize(2);
dot_triangle.Draw();


Console.WriteLine('\n');
#endregion


#region Command
//Command
/*
 *  Intent:
 *  Command is a behavioral design pattern that turns a request into a stand-alone object that contains all information about the request. 
 *  This transformation lets you pass requests as a method arguments, delay or queue a request’s execution, and support undoable operations.
 * 
 *  A command is nothing more than a data class with its members describing what to do and how to do it
 * [picture]
 */
Console.WriteLine("3-Command");
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
#endregion


#region strategy
Console.WriteLine("4-strategy");
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
#endregion

//until 00:05:00
#region FactoryMethod
// * >>> The Factory Method defines a method, which should be used for creating objects
//       instead of using a direct constructor call (new operator). 
Console.WriteLine("5-FactoryMethod");
var point = _5.Point.NewPolarPoint(5, Math.PI / 4);

new _5.Client().Main();
#endregion


#region AbstractFactory
//* >>> The AbstractFactory produce families of related objects without specifying their concrete classes.  
Console.WriteLine("5-AbstractFactory");
static ShapeFactory GetFactory(bool rounded)
{
    if (rounded)
        return new RoundedShapeFactory();
    else
        return new BasicShapeFactory();
}

var basic = GetFactory(false);
var basicRectangle = basic.Create(_5_AbstractFactory.Shape.Rectangle);
basicRectangle.Draw(); // Basic rectangle
var roundedSquare = GetFactory(true).Create(_5_AbstractFactory.Shape.Square); 
roundedSquare.Draw();  // Rounded square
#endregion


#region observer
Console.WriteLine("6-observer");

#endregion


#region template method
// template method

/*
 *  Intent:
 *  Template Method is a behavioral design pattern that allows you to define a skeleton of an algorithm in a base class 
 *  and let subclasses override the steps without changing the overall algorithm’s structure.
 * 
 *  Identification: 
 *  Template Method can be recognized if you see a method in base class that calls 
 *  a bunch of other methods that are either abstract or empty.
 * 
 */
Console.WriteLine("7-TemplateMthod");

#endregion


#region Adapter
// Adapter

/*
 *  Intent:
 *  The Adapter acts as a wrapper between two objects.
 *  It catches calls for one object and transforms them to format and interface recognizable by the second object.
 * 
 *  Identification: 
 *  Adapter is recognizable by a constructor which takes an instance of a different abstract/interface type.
 *  When the adapter receives a call to any of its methods, 
 *  it translates parameters to the appropriate format and then directs the call to one or several methods of the wrapped object.
 * 
 */
Console.WriteLine("8-Adapter");

#endregion


#region Composite
// Composite

/*
 *  Intent:
 *  Composite is a structural design pattern that lets you compose objects into tree structures
 *  and then work with these structures as if they were individual objects.
 *  
 *  Composite became a pretty popular solution for the most problems that require building a tree structure. 
 *  Composite’s great feature is the ability to run methods recursively over the whole tree structure and sum up the results.
 * 
 *  Identification: 
 *  If you have an object tree, and each object of a tree is a part of the same class hierarchy, 
 *  this is most likely a composite. If methods of these classes delegate the work to child objects of the tree and do it via the base class/interface of the hierarchy,
 *  this is definitely a composite.
 * 
 */
Console.WriteLine("9-Composite");

#endregion

#region Facade
// Facade

/*
 *  Intent:
 *  Facade is a structural design pattern that provides a simplified (but limited) interface 
 *  to a complex system of classes, library or framework.
*   While Facade decreases the overall complexity of the application, it also helps to move unwanted dependencies to one place.
 * 
 *  Identification:
 *  Facade can be recognized in a class that has a simple interface, but delegates most of the work to other classes.
 *  Usually, facades manage the full life cycle of objects they use.
 * 
 */
Console.WriteLine("10-Facade");

#endregion


#region Proxy
// Proxy

/*
 *  Intent:
 *  Proxy is a structural design pattern that lets you provide a substitute or placeholder for another object.
 *  A proxy controls access to the original object, 
 *  allowing you to perform something either before or after the request gets through to the original object.
 *  
 * Proxy is a structural design pattern that provides an object that acts as a substitute for a real service object used by a client.
 * A proxy receives client requests, does some work (access control, caching, etc.) and then passes the request to a service object.
 * The proxy object has the same interface as a service, which makes it interchangeable with a real object when passed to a client.
 *  
 * Usage examples:
 * While the Proxy pattern isn’t a frequent guest in most C# applications, it’s still very handy in some special cases.
 * It’s irreplaceable when you want to add some additional behaviors to an object of some existing class without changing the client code.
 * 
 * Identification:
 * Proxies delegate all of the real work to some other object.
 * Each proxy method should, in the end, refer to a service object unless the proxy is a subclass of a service.
 * 
 */
Console.WriteLine("11-Proxy");
#endregion

#region ProtoType
// ProtoType

/*
 *  Intent:
 *  Prototype is a creational design pattern that lets you copy existing objects without making your code dependent on their classes.
 *  
 * Prototype is a creational design pattern that allows cloning objects, even complex ones, without coupling to their specific classes.
 * All prototype classes should have a common interface that makes it possible to copy objects even if their concrete classes are unknown. 
 * Prototype objects can produce full copies since objects of the same class can access each other’s private fields.
 *  
 * Usage examples: 
 * The Prototype pattern is available in C# out of the box with a ICloneable interface.
 * 
 * Identification: 
 * The prototype can be easily recognized by a clone or copy methods, etc.
 */
Console.WriteLine("12-ProtoType");

#endregion

#region Singlton
// Singlton

/*
 *  Intent:
 *  Singleton is a creational design pattern that lets you ensure that a class has only one instance,
 *  while providing a global access point to this instance.
 *  
 *  Singleton is a creational design pattern, 
 *  which ensures that only one object of its kind exists and provides a single point of access to it for any other code.
 *  Singleton has almost the same pros and cons as global variables.
 *  Although they’re super-handy, they break the modularity of your code.
 *  You can’t just use a class that depends on a Singleton in some other context, 
 *  without carrying over the Singleton to the other context.
 *  Most of the time, this limitation comes up during the creation of unit tests.
 * 
 *  Usage examples: A lot of developers consider the Singleton pattern an antipattern.
 *  That’s why its usage is on the decline in C# code.
 *  
 *  Identification:
 *  Singleton can be recognized by a static creation method, which returns the same cached object.
 * 
 */
Console.WriteLine("13-Singlton");

#endregion

#region 
//

/*
 *  Intent:
 *  
 * 
 *  
 * 
 */

#endregion


Console.WriteLine("Hello, World!");

