//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

Console.WriteLine ("Введите число");
int num = int.Parse(Console.ReadLine());
int GetSumofNumbers(int Number)
{
    int result = 0;
    while (Number>0)
    {
        result = result+Number%10;
        Number=Number/10;
    }
    return result;
}
Console.WriteLine ($"Сумма чисел в числе: {GetSumofNumbers(num)}"); 