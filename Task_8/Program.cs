Console.WriteLine("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());

if (N > 0){
    int count = 2;
    while (count <= N)
    {
        Console.WriteLine(count);
        count += 2;
    }
}
else
{
    int count = -2;
    while (count >= N)
    {
        Console.WriteLine(count);
        count -= 2;
    }
}

