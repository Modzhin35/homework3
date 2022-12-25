Console.Write("Введите 5-значное число: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num < 0) { num = -num; }
if (num < 10000 || num > 99999) { Console.Write("Введенное число не 5-значное!"); }
else
{
    int firstPartNum = num / 1000;
    firstPartNum = ((firstPartNum % 10) * 10) + firstPartNum / 10;
    int secondPartNum = num % 100;
    if (firstPartNum == secondPartNum) { Console.Write($"{num} является палиндромом"); }
    else { Console.Write($"{num} не является палиндромом"); }
    ;
}