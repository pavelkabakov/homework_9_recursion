// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.Write("Введите первое чмсло M:");
int m = DataInput();

Console.Write("Введите второе число N:");
int n = DataInput();

int result = AnkermanFunction(m, n);

Console.WriteLine($"Результат A(m,n) = {result}");

// Рекурсивный метод функция Анкермана
int AnkermanFunction(int m, int n)
{
    if ( m == 0)
    { return n+1; }
    else
    {
        if (n==0)
        {
            return AnkermanFunction(m - 1, 1);
        }
    }

    return AnkermanFunction(m - 1, AnkermanFunction(m, n-1));

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