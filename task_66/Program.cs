// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write("Введите начало диапазона натуральных чисел M:");
int a = DataInput();

Console.Write("Введите конец диапазона натуральных чисел N:");
int b = DataInput();

int result = NaturalsNumbersSumm(a, b);

Console.WriteLine($"сумма натуральных элементов в промежутке от M до N = {result}");

// Рекурсивный метод подсчета суммы натуральных элементов 
int NaturalsNumbersSumm(int a, int b, int summ = 0)
{
    if (b < a) { return summ; }
    summ += b;
    b--;

    return NaturalsNumbersSumm(a, b, summ);

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