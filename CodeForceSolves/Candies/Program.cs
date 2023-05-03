int m=Convert.ToInt32(Console.ReadLine());

while (m != 0)
{

    int n = Convert.ToInt32(Console.ReadLine());
    double ans = 0;
    int a = 2;
    double x = Math.Pow(2, 0) + Math.Pow(2, 1);
    while (n / x != 0 || n/x==0)
    {
        if(n%x==0)
        {
            ans = n / x; 
            break;
        }
        
        x += Math.Pow(2, a);
        a++;
    }
    if(ans==0)
    { ans = 1; }
    Console.WriteLine(ans);

    m--;

}