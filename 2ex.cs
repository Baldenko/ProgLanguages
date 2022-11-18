// EX 2 Напишите программу, которая на вход принимает два числа и выдаёт, какое число 
Console.WriteLine ("Напишите первое число");

string FirstNumber = Console.ReadLine() ?? "";

int number1 = int.Parse(FirstNumber);

Console.WriteLine ("Напишите второе число");

string SecondNumber = Console.ReadLine() ?? "";

int number2 = int.Parse(SecondNumber);

if(number1 > number2)
{
    Console.WriteLine($"Число {number1} больше числа {number2}");
}
else
{
    Console.WriteLine($"Число {number2} больше числа {number1}");
}