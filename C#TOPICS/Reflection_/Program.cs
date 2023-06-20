// See https://aka.ms/new-console-template for more information
using Reflection_;

Console.WriteLine("Hello, World!");

Class1 class1 = new Class1();

class1.name = "Test";
class1.age = 1;
class1.college = "binan";

Ref ref1= new Ref ();

Class2 class2=ref1.Copy<Class2>(class1);


Console.WriteLine(class2.name);
Console.WriteLine(class2.college);
Console.WriteLine(class2.age);


