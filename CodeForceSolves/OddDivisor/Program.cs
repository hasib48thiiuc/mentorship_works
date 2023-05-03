int m = Convert.ToInt32(Console.ReadLine());

while(m>0)
{
    long x = Int64.Parse(Console.ReadLine());
    bool flag = false;
    for (int i = 1; i < x / 2; i = i + 2)
    {
        if(x % i == 0)
        {
            Console.WriteLine("YES");
            flag = true;
            break;
        }
    }
    if(flag==false)
    {
        Console.WriteLine("NO");
    }
    m--;
}