using System.Collections;
using System.Collections.Generic;
using System.Text;

int test = Convert.ToInt32(Console.ReadLine());
while (test > 0)
{
    int size = Convert.ToInt32(Console.ReadLine());
        string[] str = Console.ReadLine().Split(' ');
    int[] arr= new int[str.Length];
    int max = int.MinValue, min = int.MaxValue;
    for(int i=0; i < str.Length; i++)
    {
        arr[i]= int.Parse(str[i]);
        if (Convert.ToInt32(str[i])>max)
        {
            max = Convert.ToInt32(str[i]);
        }
        if (Convert.ToInt32(str[i]) < min)
        {
            min = Convert.ToInt32(str[i]);
        }
    }
    int coun1 = 0,coun2=0;
    if (arr[0]==max && arr[size-1]==min)
    {
        Console.WriteLine(max - min);
        test--;
        continue;
    }
    bool flag = false;
    for (int i = 0; i < str.Length-1; i++)
    {
        if (arr[i]==max && arr[i+1]==min)
        {
            Console.WriteLine(max - min);
          
            flag = true;
            break;

        }
    }
    if(size==1)
    {
        Console.WriteLine(0);
        test--;
        continue;
    }
    if (arr[0]==min  && flag==false)
    {
        Array.Sort(arr, 1, size - 1);
        Console.WriteLine(arr[size-1] - arr[0]);
        flag = true;

    }
    if (arr[size-1] == max && flag == false)
    {
        
        Console.WriteLine(arr[size-1] - min);
        flag = true;

    }

    if (flag == false )
    {
        int max1 = 0, max2 = 0;
        int[] arr2 = arr;
        Array.Sort(arr, 1, size - 1);
        Array.Sort(arr2,  0, size - 2);
        max1 = arr[size - 1] - arr[0];
        max2 = arr2[size - 1] - arr2[0];
        Console.WriteLine(Math.Max(max1, max2));

        flag = true;
    }

    test--;

}
