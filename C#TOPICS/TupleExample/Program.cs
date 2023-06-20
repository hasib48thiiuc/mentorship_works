// See https://aka.ms/new-console-template for more information
using TupleExample;

Console.WriteLine("Hello, World!");

Police[] polices = new Police[3];
Thief[] thief = new Thief[3];

Police police1 = new Police();
police1.Id = 1;
police1.name = "Test";
Police police2 = new Police();
police2.Id = 2;
police2.name = "hell";
polices[0] = police1;
polices[1] = police2;
Thief thief1 = new Thief();
thief1.thief_Id = 1;
thief1.Thief_name = "sala";
thief1.Police_Id = 2;
thief[0] = thief1;



(string name, string thiefname)[] data = new (string, string)[3];
int index = 0;
for (int i = 0; i < 1; i++)
{
    if (polices[i].Id == thief[i].Police_Id)
    {
        data[index] = (polices[i].name, thief[i].Thief_name);

    }

}


for (int m = 0; m < data.Length; m++)
{


    Console.WriteLine($"Police Name= {data[m].name},Thief Name={data[m].thiefname}");
}







