using System.Collections;
using System.Collections.Generic;
using System.Text;

int test = Convert.ToInt32(Console.ReadLine());
while (test > 0)
{
    int n = Convert.ToInt32(Console.ReadLine());
    string[] str = Console.ReadLine().Split();
    long[] arr= new long[str.Length];
    for(int i = 0; i < str.Length;i++)
    {
        arr[i] = Convert.ToInt64(str[i]);
    }
    Array.Sort(arr);

    if (arr[0] * arr[1] >= arr[n - 1] * arr[n-2] )
    {
        Console.WriteLine(arr[0] * arr[1]);
    }
    else
    {
        Console.WriteLine(arr[n-1] * arr[n-2]);

    }
    test--;

}
