// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

int EnterData(string text)
{
    Console.WriteLine(text);
    return (int.Parse(Console.ReadLine())); 
}
int a = EnterData("Введите число A: ");
int b = EnterData("Введите число B: ");
int i = 0;
i = Convert.ToInt32(Math.Pow(a,b));
Console.Write($"{a}, {b}, -> {i}"); 

