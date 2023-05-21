using System;
using System.Linq;
using System.Text;

int test = Convert.ToInt32(Console.ReadLine());

while (test > 0)
{
    bool flag = false;
    long num=Convert.ToInt64(Console.ReadLine());
    for(long i = 3;i <=num;i++)
      {
        if(num%i==0)
        {
            flag = true;
            break;
        }
        i++;
    }
    if(flag==true)
    { Console.WriteLine("YES"); }
    else
    { Console.WriteLine("NO"); }

    test--;
}
