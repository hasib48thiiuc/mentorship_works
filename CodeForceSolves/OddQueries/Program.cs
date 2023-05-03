int m=Convert.ToInt32(Console.ReadLine());

while (m != 0)
{
    int size, query;
    string[] str1 = Console.ReadLine().Split(" ");

    size = Convert.ToInt32(str1[0]);
    query= Convert.ToInt32(str1[1]);
    string[] str = Console.ReadLine().Split(" ");

    long[] ar = new long[str.Length];
    int l, r, k;
    long sum = 0;

    for (int i = 0; i < str.Length; i++)
    {
        ar[i] = Convert.ToInt32(str[i]);
        sum += ar[i];
        if (i != 0)
        {   ar[i] = ar[i] + ar[i - 1];
    }
            
    }
    while (query > 0)
    {
       
        long sum3 = 0;
        string[] str2 = Console.ReadLine().Split(" ");

        l = Convert.ToInt32(str2[0]);
        r = Convert.ToInt32(str2[1]);
        k = Convert.ToInt32(str2[2]);
       if(l >1)
        sum3 = sum - (ar[r - 1] - ar[l-2]) + (k * (r - l + 1));
       else
            sum3 = sum - ar[r - 1]  + (k * (r - l + 1));
        if (sum3 % 2 == 0)
        {
            Console.WriteLine("NO");
        }
        else
            Console.WriteLine("YES");

        query--;

    }
    m--;
}
  
   