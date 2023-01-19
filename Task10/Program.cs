/*Напишите программу, которая принимает на вход трёхзначное число 
и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1
*/
//Функция получения трехзначного числа
int TrehznacnoeChislo ()
{
    Console.WriteLine("Введите трёхзначное число ");
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

//Функция показывает вторую цифру числа abc
int VtorayaCifraChisla(int number)
{
    int a = number / 100;
    int b = (number - a * 100) / 10;
    return b;
}

int a = TrehznacnoeChislo();
int b = VtorayaCifraChisla(a);
Console.WriteLine($"Вторая цифра числа {a} = {b}");