Console.WriteLine("Введите начальное число M:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите начальное число N:");
int n = Convert.ToInt32(Console.ReadLine());
SummNumbers(m, n, 0);

void SummNumbers(int m, int n, int sum)
{
    if (m > n)
    {
        Console.WriteLine($"Сумма натуральных элементов в промежутке от M до N: {sum}");
        return;
    }
    sum = sum + (m++);
    SummNumbers(m, n, sum);
}