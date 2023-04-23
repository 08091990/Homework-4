// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

int EnterData(string text)
{
    Console.WriteLine(text);
    return (int.Parse(Console.ReadLine())); 
}
int a = EnterData("Введите число A ");
int result = 0;
int num = a;
int b = a;
while(num > 0)
{
    num = b % 10;
    result = result + num;
    b = b / 10;
} 
Console.WriteLine($"{a} -> {result}");
