Console.Write("Введите любое число N, кроме нуля: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num == 0) { Console.Write("Ошибка. Введите любое число, кроме нуля."); }
else
{
    if (num < 0) { num = -num; }
    int i = 1;
    while (i <= num)
    {
        Console.Write($"{Math.Pow(i, 3)} ");
        i++;
    }
}