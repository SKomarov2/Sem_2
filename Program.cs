// Напишите программу, которая принимает на вход
// трёхзначное число и удаляет вторую цифру этого
// числа.
// Примеры
// a = 256 => 26
// a = 891 => 81

// // "&&" - "И": яблоки И апельсины (и то, и другое нужно купить)
// // "||" - "ИЛИ": яблоки ИЛИ апельсины(что-то одно, либо все вместе)

// Console.Write("Введите трехзначное число ");
// int number = Convert.ToInt32(Console.ReadLine());
// if (number >= 100 && number <= 999)
// {
//     int firstDigit = number / 100;
//     int thiridDigit = number % 10;
//     int result = firstDigit * 10 + thiridDigit;
//     Console.WriteLine ($"Нужное число {number} => {result}");
// }
// else
// {
//     Console.WriteLine ("Число НЕ трехзначное");
// }

 //Напишите программу, которая принимает на вход трёхзначное
// число и возводит вторую цифру этого числа в степень, равную
// третьей цифре.
// Примеры
// 487 => 8^7 = 2 097 152
// 254 => 5^4 = 625
// 617 => 1^7 = 7
// 

// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// if (number >= 100 && number <= 999)
// {
//     int firstnumber = number / 10 % 10;
//     int result = firstnumber;
//     int thiridDigit = number % 100 % 10;
//     int index = 1;
//     while (index < thiridDigit)
//         {
//         index = index + 1;
//         result = result * firstnumber;
//         } 
    
//         {
//          Console.WriteLine ($"Нужное число {number} => {result}");
//         }
// }
// else
// {
//     Console.WriteLine ("Число НЕ трехзначное");
// }
// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// if (number >= 100 && number <= 999)
// {
//     int firstnumber = number / 10 % 10;
//     int thiridDigit = number % 10;
//     int result = (int)Math.Pow(firstnumber,thiridDigit);
//    Console.WriteLine ($"Нужное число {number}: {firstnumber}^{thiridDigit} => {result}");
// }
// else
// {
//     Console.WriteLine ("Число НЕ трехзначное");
// }

// Получите 3 цифру введенного числа слева (с начала)
// 1234567 => 3
// 7891 => 9
// 32 => 3 цифры нет

// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int copyNumber = number;
// if (number < 100) // Число не трехзначное
// {
//     Console.WriteLine("Третьей цифры нет :)");
// }
// else // Число трехзначное
// {
//     while (number > 999) // Если в числе минимум 4 цифры, я делю :)
//     {
//         number /= 10; 
//     }
//     Console.WriteLine($"Третья цифра от числа  {copyNumber} = {number % 10}");
// }

// Получи третью цифру справа:
// 456 => 4
// 7812 => 8
// 91 => Третьей цифры нет

// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int copyNumber = number;
// if (number < 100) // Число не трехзначное
// {
//     Console.WriteLine("Третьей цифры нет :)");
// }
// else // Число минимум трехзначное 
// {
//     int digitCount = 0; // Количество цифр, которое нужно убрать 
//     int digit = 0; // Третья цифра справа
//     while (digitCount < 2) // Отбрасываем 2 последние цифры
//     {
//         number /= 10;
//         digitCount++; // digitCount = digitCount + 1
//     }
//     Console.WriteLine($"Третья цифра справа от числа {copyNumber} = {number % 10}");
// }

// Console.WriteLine(1132146464564564845 / 100 % 10);
