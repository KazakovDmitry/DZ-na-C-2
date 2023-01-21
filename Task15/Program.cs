/*Задача 15: Напишите программу, которая принимает на вход цифру, 
обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет
*/

void FindWeekend(int number)
{
    if (number == 6 || number == 7)
        Console.WriteLine("Да. Этот день выходной");
    else if (number > 7 || number < 1)
        Console.WriteLine("Такого дня недели нет");
    else Console.WriteLine("Нет. Этот день рабочий");
}

Console.WriteLine("Проверим является ли ваше число выходным днём");
Console.WriteLine("Введите число: ");
int chislo = Convert.ToInt32(Console.ReadLine());
FindWeekend(chislo);
