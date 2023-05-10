
int[] ages = new int[] { 20, 40, 60, 20, 40, 90 };

int sum = 0;
for (int i = 0; i < ages.Length; i++)
{
    sum = sum + ages[i];
}


int num = 100;
while (num > 0)
{
    num = num / 2;
    Console.WriteLine($"From While:{num}");
}

int num2 = 100;
do
{
    num2 = num2 / 2;
    Console.WriteLine($"From Do-While:{num2}");

} while (num2 > 0);

foreach (int ae in ages)
{
    Console.WriteLine(ae);
}

int[] age = new int[20];
age[0] = 32;
age[1] = 24;
age[2] = 44;

string[] fruits = new string[10];
fruits[0] = "Apple";
fruits[1] = "Banana";

int[,] block = new int[10, 20];
block[0, 0] = 10;
block[1, 0] = 20;
block[2, 2] = 30;
block[9, 9] = 40;

string[] cities = new string[] { "Dhaka", "Sylhet" };

int[,,,,] something = new int[10, 10, 10, 10, 10];


int[][] grades = new int[10][];
grades[0] = new int[10];
grades[1] = new int[5];
grades[2] = new int[7];

grades[0][0] = 40;
grades[0][1] = 50;