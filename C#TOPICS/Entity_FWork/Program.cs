// See https://aka.ms/new-console-template for more information
using Entity_FWork;

Console.WriteLine("Hello, World!");

/*Student st1 = new Student();


st1.Name = "yellow10010";

st1.address = "rongpur";

st1.DateOfReg= DateTime.Now;

st1.roll = 8;*/
/*Student st2 = new Student();

st1.Name = "yellow3";

st1.address = "chittagong";

st1.DateOfReg = DateTime.Now;

st1.roll = 2;
*/

TrainingDbContext con1 = new TrainingDbContext();

List<Student> students = con1.Main2Students.Where(x=>x.roll<10).ToList();

foreach(Student X in students)
{
    Console.WriteLine($"Name = {X.Name} ,Roll = = {X.roll} ,Address = {X.address}");
}

/*

st1 = con1.Main2Students.Where(x => x.id == 2).FirstOrDefault();
if(st1 != null)
{
    con1.Main2Students.Remove(st1);
    con1.SaveChanges();
}

*/
