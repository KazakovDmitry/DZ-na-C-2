/*Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/
//Функция показывает третью цифру числа abc
int TrtyaCifraChisla(int number)
{
    int a = number % 10;
    return a;
}

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if(number < 100)
    Console.WriteLine("Третьей цифры нет");
else
{
    while (number > 1000)
    {
       number = number / 10; 
    }
    int b = TrtyaCifraChisla(number);
    Console.WriteLine(b);
}