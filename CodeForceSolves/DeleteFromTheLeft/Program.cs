string str1 = Console.ReadLine();

string str2 = Console.ReadLine();

int count = 0;
if (str1.Length <= str2.Length)
{
    for (int m = str1.Length-1,s=str2.Length-1; m >=0; m--,s--)
    {
        if (str1[str1.Length-1] != str2[str2.Length-1])
        {
            Console.WriteLine(str1.Length + str2.Length);
            break;
        }
        else if (str1[m] == str2[s])
        {
            count++;
        }
        else
        { break; }

    }
}
else
{
    for (int m = str2.Length - 1,s=str1.Length-1; m >= 0; m--,s--)
    {
        if (str1[str1.Length - 1] != str2[str2.Length - 1])
        {
            Console.WriteLine(str1.Length + str2.Length);
            break;
        }
        else if (str1[s] == str2[m])
        {
            count++;
        }
        else
        { break;}

    }
}
if(count>0)
{
    Console.WriteLine((str1.Length-count)+(str2.Length-count));
}
