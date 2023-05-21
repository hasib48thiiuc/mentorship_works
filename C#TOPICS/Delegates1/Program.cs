

using Delegates1;

/*
int sum(int a,int b)
{
    return a + b;
}
int multi(int a, int b)
{
    return a * b;
}

MyMethod y = sum;
MyMethod b = multi;
Console.WriteLine(y(500000, 50000000));
Console.WriteLine("result of multi ==" + b(500000, 50000000));*/

int Compare(int a,int b)
{
    if (a > b)
    else if (a < b)
        return 1;
        return -1;
    else 
        return 0;

}



int[] arr = new int[] { 5435, 323, 2323, 211, 224, 123, 24324, 111, 11, 33, 44, };

BubbleSort<int>.Sort(arr, Compare);
foreach (int i in arr)
{


    Console.WriteLine(i);

}

    