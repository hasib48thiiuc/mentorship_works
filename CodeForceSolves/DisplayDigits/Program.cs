using System.Text;

int n=Convert.ToInt32(Console.ReadLine());

while(n>0)
{
    int s=Convert.ToInt32(Console.ReadLine());

    StringBuilder str = new StringBuilder();
    if(s%2==0)
    {
        for(int i=0;i<s/2;i++)
        {
            str.Append(1);
        }

    }
    else
    {
        if (s > 3)
        {
            for (int i = 1; i <= (s - 3 )/ 2; i++)
            {
                str.Append(1);
            }
            str.Insert(0, 7);

            

        }
        else

            str.Append(7);
    }



    Console.WriteLine(str);

    n--;
}