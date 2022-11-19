Console.WriteLine("input number");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("input b");
int b = Convert.ToInt32(Console.ReadLine());

// since int stores 32 bits, the longest number will be at most 32 characters
int[] remainder_of_the_division = new int[32];

    int i = 31;
    while (number > 0)
    {
        remainder_of_the_division[i] = number % b;
        number = number / b;
        i = i - 1;
    }
    Console.WriteLine();

for (int j = 0; j < remainder_of_the_division.Length; j++)
{
    Console.Write(" " + remainder_of_the_division[j]);
}