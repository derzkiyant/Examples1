Task2();
// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

void Task2()
{
    Console.WriteLine("\nЗадача 2: ");

    Console.Write("Введите первое число: ");
    int number1 = Convert.ToInt32(Console.ReadLine());

    Console.Write("Введите второе число: ");
    int number2 = Convert.ToInt32(Console.ReadLine());

    if (number1 == number2) Console.WriteLine("Первое число равно второму");
    else if (number1 > number2) Console.WriteLine("Первое число больше, чем второе");
    else Console.WriteLine("Второе число больше, чем первое");
}

Task4();
// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

void Task4()
{
    Console.WriteLine("\nЗадача 4: ");

    Console.Write("Введите первое число: ");
    int number1 = Convert.ToInt32(Console.ReadLine());

    Console.Write("Введите второе число: ");
    int number2 = Convert.ToInt32(Console.ReadLine());

    Console.Write("Введите третье число: ");
    int number3 = Convert.ToInt32(Console.ReadLine());

    int maxNumber = number1;
    if (number2 > maxNumber) maxNumber = number2;
    if (number3 > maxNumber) maxNumber = number3;

    Console.WriteLine("Максимальное число: " + maxNumber);
}

Task6();
// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

void Task6()
{
    Console.WriteLine("\nЗадача 6: ");

    Console.Write("Введите число: ");
    int number = Convert.ToInt32(Console.ReadLine());

    if (number % 2 == 0) Console.WriteLine($"Число {number} является четным");
    else Console.WriteLine($"Число {number} не является четным");
}


Task8();
// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

void Task8()
{
    Console.WriteLine("\nЗадача 8: ");

    Console.Write("Введите целое число больше 1: ");
    int number = Convert.ToInt32(Console.ReadLine());

    if (number > 1)
    {
        for (int i = 2; i <= number; i += 2)
        {
            Console.Write(i + "  ");
        }
        Console.WriteLine("");
    }

    else Console.WriteLine("Введено неверное число");
}
