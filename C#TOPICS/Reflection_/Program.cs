// See https://aka.ms/new-console-template for more information
using Reflection_;
using System.Reflection;

Console.WriteLine("Hello, World!");

Class1 class1 = new Class1();

class1.name = "Test";
class1.age = 1;
class1.college = "binan";

Ref ref1 = new Ref();

Class2 class2 = ref1.Copy<Class2>(class1);



PrintObject(class2);

void PrintObject(object item)
{
    Type t = item.GetType();
    PropertyInfo[] propertyInfos = t.GetProperties();

    foreach (var p in propertyInfos)
    {
        Console.WriteLine($"{p.Name}: {p.GetValue(item)}");
    }

}