/*
 
File
FileInfo

 
 
 
 
 
 
*/
/*File.Create(@"C:\Users\DELL\Desktop\mentorship_works\C#TOPICS\FileOperation2\hello22.txt");*/
/*using StreamWriter writer= File.AppendText(@"C:\Users\DELL\Desktop\mentorship_works\C#TOPICS\FileOperation2\hello22.txt");

writer.WriteLine("helllo");
writer.Write("ewrewrewr");*/
/*
using FileStream filestream= File.Open(@"C:\Users\DELL\Desktop\mentorship_works\C#TOPICS\FileOperation2\hello22.txt",FileMode.Append);
string str = "hello jelly";
byte[] data = Encoding.UTF8.GetBytes(str);

filestream.Write(data,4,5);*/

/*File.Copy(@"C:\Users\DELL\Desktop\mentorship_works\C#TOPICS\FileOperation2\hello22.txt", @"C:\Users\DELL\Desktop\mentorship_works\C#TOPICS\Datatypes\hello22.txt");*/
/*
FileInfo file = new FileInfo(@"C:\Users\DELL\Desktop\mentorship_works\C#TOPICS\Datatypes\hello22.txt");

if(file.Exists)
{
    file.Delete(); 
}*/

/*Directory.CreateDirectory(@"C:\Users\DELL\Desktop\mentorship_works\C#TOPICS\FileOperation2\New Folder");  
Console.WriteLine(Directory.GetCurrentDirectory());*/

string crrntdrct = Directory.GetCurrentDirectory();

DirectoryInfo dinfo = new DirectoryInfo(crrntdrct);

FileInfo[] files = dinfo.Parent.Parent.Parent.GetFiles();

foreach (FileInfo file in files)
{
    Console.WriteLine(file.Name);
}

var folders = dinfo.Parent.Parent.Parent.GetDirectories();

foreach (var folder in folders)
{
    Console.WriteLine(folder.Name);
}