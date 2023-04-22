Console.WriteLine("Введите 1-е число: ");
int number_1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 2-е число: ");
int number_2 = Convert.ToInt32(Console.ReadLine());

if (number_1 > number_2)
{
    Console.WriteLine($"Первое число ({number_1}) больше, чем второе ({number_2})");
}

else if (number_1 < number_2)
{
    Console.WriteLine($"Второе число ({number_2}) больше, чем первое ({number_1})");
}

else
{
    Console.WriteLine("Числа равны");
}


