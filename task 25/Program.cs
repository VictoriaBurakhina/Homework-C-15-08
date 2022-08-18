// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

//3, 5 -> 243 (3⁵)

//2, 4 -> 16

Console.WriteLine ("Введите 1 число");
double Firstnumber = int.Parse(Console.ReadLine());
Console.WriteLine ("Введите второе число");
double Secondnumber = int.Parse(Console.ReadLine());
Math.Pow(Firstnumber,Secondnumber);
Console.WriteLine ($"результат ="+ Math.Pow(Firstnumber,Secondnumber));

