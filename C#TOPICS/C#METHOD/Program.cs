// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int[] ages = new int[] { 20, 40, 60, 20, 40, 90 };
int[] grades = new int[] { 4, 3, 2, 4, 5, 3, 4, 2 };

double average = CalculateAverage(ages);
Console.WriteLine(average);

double gradeAverage = CalculateAverage(grades);
Console.WriteLine(gradeAverage);


double CalculateAverage(int[] ages)
{
    int sum = 0;
    foreach (int age in ages)
    {
        sum = sum + age;
    }

    return sum / (double)ages.Length;
}