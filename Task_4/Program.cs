Console.WriteLine("Введите 1-е число: ");
int number_1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 2-е число: ");
int number_2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 3-е число: ");
int number_3 = Convert.ToInt32(Console.ReadLine());

int max = number_1;

if (number_2 > max)
{
    max = number_2;
}

if (number_3 > max)
{
    max = number_3;
}

Console.WriteLine(max);
