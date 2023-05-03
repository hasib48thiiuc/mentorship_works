
using InterfaceP2;

Box box = new Box();
box._items=new object[10];
box._items[0] = "hello";
box._items[1] = 2;
foreach(var x in box)
{
    Console.WriteLine(x);
     
}