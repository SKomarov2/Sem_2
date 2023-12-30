// Напишите программу, которая принимает на вход
// трёхзначное число и удаляет вторую цифру этого
// числа.
// Примеры
// a = 256 => 26
// a = 891 => 81

// // "&&" - "И": яблоки И апельсины (и то, и другое нужно купить)
// // "||" - "ИЛИ": яблоки ИЛИ апельсины(что-то одно, либо все вместе)

Console.Write("Введите трехзначное число ");
int number = Convert.ToInt32(Console.ReadLine());
if (number >= 100 && number <= 999)
{
    int firstDigit = number / 100;
    int thiridDigit = number % 10;
    int result = firstDigit * 10 + thiridDigit;
    Console.WriteLine ($"Нужное число {number} => {result}");
}
else
{
    Console.WriteLine ("Число НЕ трехзначное");
}