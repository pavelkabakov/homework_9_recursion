// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.WriteLine("Введите число:");
int number1 = DataInput();
Console.WriteLine($"Вы ввели число:{number1}, ряд натуральных чисел от {number1} до 1:");

PrintNaturalNumber(number1);

// Console.WriteLine(result);

// Рекурсивный метод вывода
void PrintNaturalNumber(int a, int b = 1)
{
    if (a < b) { return; }
    {
        Console.Write($"{a}, ");
        a--;

        PrintNaturalNumber(a);
    }
}

// Рекурсивный метод проверки правильности ввода значения в консоль
int DataInput()
{

    bool status = int.TryParse(Console.ReadLine(), out int a);
    if (status) { return a; }

    if (!status)
    {
        Console.WriteLine("Введено не число, повторите ввод");
    }

    return DataInput();

}