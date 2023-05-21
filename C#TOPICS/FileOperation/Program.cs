
/*if (File.Exists(@"C:\Users\DELL\Desktop\mentorship_works\C#TOPICS\FileOperation\hellot.txt"))
{
    Console.WriteLine("yes");
}
else
    Console.WriteLine("Not available");


File.Delete(@" D:\Segment 2.pdf");

 */
/*
File.Create(@"C:\Users\DELL\Desktop\mentorship_works\C#TOPICS\FileOperation\hello22.txt");*/

StreamWriter writer = File.AppendText(@"C:\Users\DELL\Desktop\mentorship_works\C#TOPICS\FileOperation\hello22.txt");

writer.WriteLine("hellohello");




