namespace Entity_FWork
{
    public class Student
    {
        public int id { get; set; }
        public String Name { get; set; }

        public int roll { get; set; }

        public DateTime DateOfReg { get; set; }
        public String address { get; set; }

        public List<CourseStudent> Courses { get; set; }

    }
}
