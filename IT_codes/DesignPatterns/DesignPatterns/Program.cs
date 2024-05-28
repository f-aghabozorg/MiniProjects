using System;
using _1_Mediator;
using _2_Bridge;
using _3_Command;
using _4_Strategy;
using _5_FactoryMethod;
using _5_AbstractFactory;
using _6_Observer;

using _1 = _1_Mediator;
using _5 = _5_FactoryMethod;
using _6 = _6_Observer;
using _7_TemplateMethod;



#region Mediator
//reduce chaotic dependencies between objects via a mediator object
Console.WriteLine("\n1-Mediator");
ChatRoom room = new ChatRoom();
_1.Person john = new _1.Person("John");
_1.Person jane = new _1.Person("Jane");
room.Join(john);
room.Join(jane);
john.Say("hi room");
jane.Say("oh, hey john");
_1.Person simon = new _1.Person("Simon");
room.Join(simon);
simon.Say("hi everyone!");
jane.PrivateMessage("Simon", "glad you could join us!");
Console.WriteLine('\n');
#endregion


#region Bridge
//decouple an abstraction from the implementation - cartesian product
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


#region FactoryMethod
// * >>> The Factory Method defines a method, which should be used for creating objects
//       instead of using a direct constructor call (new operator). 
Console.WriteLine("5-FactoryMethod");
var point = _5.Point.NewPolarPoint(5, Math.PI / 4);

new _5.Client().Main();
#endregion


#region AbstractFactory
//* >>> The AbstractFactory produce families of related objects without specifying their concrete classes.  
Console.WriteLine("\n5-AbstractFactory");
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
Console.WriteLine("\n6-observer");

static void CallDoctor(object sender, FallsIllEventArgs eventArgs)
{
    Console.WriteLine($"A doctor has been called to {eventArgs.Address}.");
}

//As soon as CatchACold() is called, the CallDoctor() method is triggered
var person = new _6.Person();
person.FallsIll += CallDoctor;
person.CatchACold();


//Example -2
var subject = new Subject();
var observerA = new ConcreteObserverA();
subject.Attach(observerA);

var observerB = new ConcreteObserverB();
subject.Attach(observerB);

subject.SomeBusinessLogic();
subject.SomeBusinessLogic();

subject.Detach(observerB);

subject.SomeBusinessLogic();
#endregion


#region template method
Console.WriteLine("\n7-TemplateMthod");
new Chess().Run();
#endregion


#region Adapter
Console.WriteLine("\n8-Adapter");


#endregion


#region Composite
Console.WriteLine("\n9-Composite");


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
Console.WriteLine("\n10-Facade");

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
Console.WriteLine("\n11-Proxy");
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
Console.WriteLine("\n12-ProtoType");

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
Console.WriteLine("\n13-Singlton");

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

