// See https://aka.ms/new-console-template for more information
using Entity_FWork;
using Microsoft.EntityFrameworkCore;
using System.Runtime.CompilerServices;

Console.WriteLine("Hello, World!");

Student st1 = new Student();


st1.Name = "Moni";

st1.address = "Chittagong";

st1.DateOfReg = DateTime.Now;

st1.roll = 1000;
/*Student st2 = new Student();

st1.Name = "yellow3";

st1.address = "chittagong";

st1.DateOfReg = DateTime.Now;

st1.roll = 2;
*/

TrainingDbContext con1 = new TrainingDbContext();
/*con1.Main2Students.Add(st1);
con1.SaveChanges();*/

Student exist5 = con1.Main2Students.Where(x => x.id == 7).FirstOrDefault();
/*
exist5.Courses = new List<CourseStudent>
{
    new CourseStudent{ course=new Course
    { Name="math",
     Fee="10000",
     ClassStartTime=DateTime.Now,
     Topics=new List<Topic>
     {
         new Topic
         {
             Name="boolean"
         },
         new Topic
         {
             Name="Arithmatic"
         }
     }
    },
    CourseEnrollTime=DateTime.Now.AddHours(10)}
};
con1.SaveChanges();
*/
CourseStudent cs1= new CourseStudent();
cs1.course=con1.Courses.Where(x=>x.Id==4).FirstOrDefault();
cs1.CourseEnrollTime = DateTime.Now;
exist5.Courses = new List<CourseStudent>();
exist5.Courses.Add(cs1);
con1.SaveChanges();

/*List<Student> students = con1.Main2Students.Where(x=>x.roll<10).ToList();

foreach(Student X in students)
{
    Console.WriteLine($"Name = {X.Name} ,Roll = = {X.roll} ,Address = {X.address}");
}
*/

/*
st1 = con1.Main2Students.Where(x => x.id == 2).FirstOrDefault();
if(st1 != null)
{
    con1.Main2Students.Remove(st1);
    con1.SaveChanges();
}
*/


/*Course course1 = new Course
{
    Name = "Chem",
    Fee="100",
    ClassStartTime= DateTime.Now,
    Topics=new List<Topic>
    {
        new Topic{ Name="Molar"},
        new Topic { Name ="Atom"}
    }


};

Student existstdnt2 = con1.Main2Students.Where(x => x.id == 1).FirstOrDefault();

Course existingcourse = con1.Courses.Where(x => x.Id == 1).FirstOrDefault();

existingcourse.Students = new List<CourseStudent>
{
    new CourseStudent{ student=existstdnt2,CourseEnrollTime=DateTime.Now},

    new CourseStudent{ student=new Student{
        Name="raf",
        roll=1000,
        DateOfReg=DateTime.Now,
        address="mirpur"

    } ,
    CourseEnrollTime=DateTime.Now}

};

con1.SaveChanges();*/

/*con1.Courses.Add(course1);
con1.SaveChanges();*/



/*Course c = new Course();

c=con1.Courses.Where(x=>x.Id==2).FirstOrDefault();
con1.Courses.Remove(c);
con1.SaveChanges();*/
/*
Course existingcourse = con1.Courses.Where(x => x.Id == 1).Include(y => y.Topics).FirstOrDefault();

Console.WriteLine(existingcourse.Name);*/