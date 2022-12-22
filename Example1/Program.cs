// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет

// 12821 -> да

// 23432 -> да
System.Console.Write("Введите пятизначное число: ");
string num = Console.ReadLine()!;
if(num.Length == 5)
{
for(int i=0;i <= num.Length / 2;i++)
{
    if(num[i] == num[num.Length-1-i])
    {
        if(i == num.Length / 2) System.Console.Write($"{num} -> да");
    }
    else 
    {
        System.Console.WriteLine($"{num} -> нет");
        break;
    }
}
}
else
{
    System.Console.WriteLine("Введено не корректное число");
}

