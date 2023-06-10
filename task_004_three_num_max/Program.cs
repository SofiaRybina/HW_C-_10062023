/*Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22*/

Console.WriteLine("Write the first number:");
int num1 = int.Parse(Console.ReadLine())!;
Console.WriteLine("Write the second number:");
int num2 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Write the third number:");
int num3 = int.Parse(Console.ReadLine()!);
int max = num1;

if(num2 > max && num2 > num3){
    max = num2;
    Console.WriteLine("Result:");
    Console.WriteLine($"{num1},{num2},{num3} -> {max}");
    }
    else if(num3 > max && num3 > num2){
        max = num3;
        Console.WriteLine("Result:");
        Console.WriteLine($"{num1},{num2},{num3} -> {max}");}
        else{
            Console.WriteLine("Result:");
            Console.WriteLine($"{num1},{num2},{num3} -> {max}");
            }