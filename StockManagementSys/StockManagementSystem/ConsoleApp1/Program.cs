// See https://aka.ms/new-console-template for more information
using System.Text;

Console.WriteLine("Hello, World!");

string str = Console.ReadLine();

int a0 = 0, b1= 0;
for(int i=0;i<str.Length;i++)
{
    if (str[i] == '0')
    {
        a0++;
    }
    else

        b1++;
}
StringBuilder str2 = new StringBuilder();
for (int i = 0; i < str.Length-1; i++)
{
   if(b1>0 && b1!=1)
    {
        str2.Append('1');
        b1--;
    }
   else { str2.Append("0");}
}
str2.Append('1');
Console.WriteLine(str2);