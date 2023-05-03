int m = Convert.ToInt32(Console.ReadLine());

string[] str = Console.ReadLine().Split(' ');

long[] ar = new long [str.Length];

for (int i = 0; i < ar.Length; i++)
{
    ar[i]= Convert.ToInt64(str[i]);
}


long[] ar2= new long[ar.Length];

ar2[0] = ar[0];
long sum = 0;
sum += ar[0];
for (int i = 1; i < ar.Length; i++)
{
    
    ar2[i] = ar[i] + sum;
   
    if (ar[i] <= 0)
    {
        sum = sum;
    }
    
    else 
    {
        sum += ar[i];
    }


}

foreach(long x in ar2)
{
    Console.Write($"{x} ");
}
Console.WriteLine();