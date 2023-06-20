// See https://aka.ms/new-console-template for more information
using ICollectionInterface;

Console.WriteLine("Hello, World!");

WaterBottlecs b1 = new WaterBottlecs(500, "blue", 400);

b1.AddAmount(1);
WaterBottlecs b2 = (WaterBottlecs)b1.Clone();


