// Задача 8: Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number == 1)
{
    System.Console.WriteLine("Четные числа в заданном диапазоне не найдены.");
}
else if (number > 1)
{
    for (int i = 1; i <= number; i++)
    {
        if (i % 2 == 0)
        {
            System.Console.WriteLine(i);
        }
    }
}
else
{
    System.Console.WriteLine("Введите число больше 0.");
}