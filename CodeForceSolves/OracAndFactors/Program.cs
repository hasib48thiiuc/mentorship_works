int m = Convert.ToInt32(Console.ReadLine());

while (m != 0)
{

    string[] str = Console.ReadLine().Split(" ");
    long a = Convert.ToInt64(str[0]);
    long b = Convert.ToInt64(str[1]);
    long sum = 0;
    long old =b;
    while (b != 0)
    {
        if (a % 2 == 0)
        {
            sum += 2 * b;
            break;
        }
        else
        {
            if (a % 3 == 0 )
            {
                sum += a + 3;
                a = sum;
            }
            else if (a % 5 == 0)
            {
                sum += a + 5;
                a = sum;
            }
            else if (a % 7 == 0)
            {
                sum += a + 7;
                a = sum;
            }
            else
            {
                sum += a + a;
                a = sum;

            }
        }
        b--;
    }
    if (old == b)
    {  sum += a; }
    Console.WriteLine(sum);
    m--;

}