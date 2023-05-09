using System;
using System.Collections.Generic;

int test = Convert.ToInt32(Console.ReadLine());

while (test > 0)
{
    int m = Convert.ToInt32(Console.ReadLine());
    SortedDictionary<int, List<string>> dic = new SortedDictionary<int, List<string>>();

    for (int x = 0; x < m; x++)
    {
        string[] str = Console.ReadLine().Split(" ");
        int minutes = Convert.ToInt32(str[0]);
        string skills = str[1];
        if (dic.ContainsKey(minutes))
        {
            dic[minutes].Add(skills);
        }
        else
        {
            dic.Add(minutes, new List<string>() { skills });
        }
    }
    int sum = 0;
    bool flag1 = true, flag2 = true;

    foreach (var kvp in dic)
    {
        List<string> skillsList = kvp.Value;
        foreach (string str in skillsList)
        {
            if (str[0] == '1' && flag1 == true)
                flag1 = false;

            if (str[1] == '1' && flag2 == true)
                flag2 = false;
        }
        sum += kvp.Key * skillsList.Count;
        if (flag1 == false && flag2 == false)
        {
            break;
        }
    }

    if (flag1 == false && flag2 == false)
    {
        Console.WriteLine(sum);
    }
    else
    {
        Console.WriteLine("-1");
    }

    test--;
}
