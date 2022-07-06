// Напишите программу которая выводит случайное число из отрезка [10, 99] и показывает найбольшую
// цифру числа.

Random rnd = new Random();
int sum = rnd.Next(10, 99);
Console.WriteLine(sum);
if (sum % 10 > sum / 10)
{
    Console.WriteLine(sum % 10);
}
else
{
    Console.WriteLine(sum / 10);
}