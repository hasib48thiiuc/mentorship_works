using System.Text;

int test = Convert.ToInt32(Console.ReadLine());

while (test > 0)
{

    string[] str2 = Console.ReadLine().Split(" ");
    int n = int.Parse(str2[0]);

    int m = int.Parse(str2[1]);

    int s = int.Parse(str2[2]);
    bool flag = false;
    StringBuilder str1 = new StringBuilder();
    string str = "abcdefghijklmnopqrstuvwxyz";
    for (int i = 0; i < n; i++)
    {
        str1.Append(str[i]);
    }
    char x=' ';
    int coun = 0;
    for (int i = 0; i < n-m+ 1; i++)
    {
        flag = false;
        coun = 0;
        for (int j = 0; j < m - 1; j++)
        {
            if (str1[j] != str[j + 1] && coun < s)
            {
                if (j == 0)
                    coun = coun + 2;
                else coun++;
            }
            else if (str1[j] == str1[j + 1])
            {

            }
            else
            {
                if (flag == false)
                {
                    x = str1[j + 1];
                    flag = true;
                }
                str1[j]= x;
            }

        }
    }
    Console.WriteLine(str1.ToString());


    test--;
}