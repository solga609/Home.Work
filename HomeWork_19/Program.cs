// Задача номер 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

 Console.WriteLine("Введите пятизначное число: ");
int a = Convert.ToInt32(Console.ReadLine());
int firstDigit = a /10000;
int secondDigit = a / 1000 % 10;
int fourthDigit = a / 100 % 10;
int fifthDigit = a % 10;

if (firstDigit == fifthDigit && secondDigit == fourthDigit) {

 Console.WriteLine($"Число {a} является палиндромом  ");
}

else 
     Console.WriteLine($"Число {a} не является палиндромом"); 

