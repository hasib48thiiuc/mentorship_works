using System.ComponentModel;

int s = Convert.ToInt32(Console.ReadLine());

while(s>0)
{
    string[] str = Console.ReadLine().Split(" ");
    int a = Convert.ToInt32(str[0]);

    int b = Convert.ToInt32(str[1]);
    int max1=0,main1=0;
    if (b - a >= 100)
    {
        for (int i = a; i <= b; i++)
        {
            int max = 0, min = 0;
            max = i % 10;
            min = i % 10;
            int f = i;
            while (f > 0)
            {

                if (max <= f % 10)
                {
                    max = f % 10;
                }
                if (min >= f % 10)
                {
                    min = f % 10;
                }
                f = f / 10;

            }
            // d.Add(i, max - min);
            if (max - min == 9)
            {
                main1 = i;
                break;
            }
        }
    }
    else
    {
        //Dictionary<int,int> d = new Dictionary<int,int>();
        for (int i = a; i <= b; i++)
        {
            int max = 0, min = 0;
            max = i % 10;
            min = i % 10;
            int f = i;
            while (f > 0)
            {

                if (max <= f % 10)
                {
                    max = f % 10;
                }
                if (min >= f % 10)
                {
                    min = f % 10;
                }
                f = f / 10;

            }
            // d.Add(i, max - min);
            if (max1 <= max - min)
            {
                max1 = max - min;
                main1 = i;
            }
        }
    }

    Console.WriteLine(main1);
    s--;
}