/*Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3*/

Console.WriteLine("Hello, write the first number:");
int num1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Write the second number:");
int num2 = int.Parse(Console.ReadLine()!);

if(num1 > num2){
    int max = num1;
    Console.WriteLine($"a = {num1}; b = {num2} -> max = {max}");
    }
    else if(num1 < num2){
        int max = num2;
        Console.WriteLine($"a = {num1}; b = {num2} -> max = {max}");
        }
        else
        {
            Console.WriteLine($"a = {num1}; b = {num2} -> a = b");
            }